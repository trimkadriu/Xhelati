using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Xhelati
{
    class clsLoja
    {
        private int gabimet;
        private int gabimetkomplet;
        private float poenat;
        private float poenatkomplet;
        private short CiliRresht;
        private List<string> ListaFjalt = new List<string>();
        private string RreshtiMomental;
        private string maska = string.Empty;
        private string[] subListaFjalt;
        private char shkronja;

        public clsLoja(string StartupPath, string CilaLoj)
        {
            try     //Provohet leximi i fajllav dhe fillimi i lojes
            {
                string fajlli = StartupPath + "\\Listat\\" + CilaLoj + ".rad";
                using (System.IO.StreamReader lexuesi = new System.IO.StreamReader(fajlli))
                {
                    string rreshti;
                    while ((rreshti = lexuesi.ReadLine()) != null)
                    {
                        ListaFjalt.Add(rreshti);
                    }
                }
                CiliRresht = 0;
                RreshtiMomental = ListaFjalt[CiliRresht];
                RreshtiMomental = RreshtiMomental.ToUpper();
                gabimet = 0;
                poenat = 0;
                KrijoMasken();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gabim ! Loja nuk mund ti gjej fajllat e nevojshem.\nJu lutem re-instaloni Lojen.\n\n" + ex.Message);
                Application.Exit();
            }
        }

        public string KrijoMasken()     //Krijohet maska ne fillim te lojes
        {
            subListaFjalt = Regex.Split(RreshtiMomental, @"\s+");
            foreach (string fjal in subListaFjalt)
            {
                for (int i = 0; i <= fjal.Length - 1; i++)
                {
                    maska = maska + "*";
                }
                maska = maska + " ";
            }
            return maska;
        }

        public string KtheMasken()
        {
            return maska;
        }

        public int KtheGabimet()
        {
            return gabimet;
        }

        public float KthePoenatTotale()
        {
            if (poenatkomplet == 0)
                mbledhgabimetpoenat();
            if (gabimetkomplet == 0)
                gabimetkomplet = 1;
            return poenatkomplet / gabimetkomplet;
        }

        public string kontrollo(string MaskaMomentale)      //Kontrollon masken a e ka qel naj shkronj tjeter
        {
            int ekaqellu = 0;
            maska = string.Empty;
            StackTrace frame = new StackTrace();
            shkronja = Convert.ToChar(frame.GetFrame(1).GetMethod().Name.Substring(3, 1));
            MaskaMomentale = MaskaMomentale.Trim();
            MaskaMomentale.ToCharArray();
            RreshtiMomental.ToCharArray();
            for (int i = 0; i <= MaskaMomentale.Length - 1; i++)
            {
                if (MaskaMomentale[i].ToString() != "*")
                    maska = maska + MaskaMomentale[i];
                else
                {
                    if (RreshtiMomental[i] == shkronja)
                    {
                        maska = maska + shkronja;
                        ekaqellu++;
                    }
                    else
                    {
                        maska = maska + "*";
                    }
                }
            }
            if (ekaqellu == 0)              //Llogariten piket edhe gabimet se loja nashta hala su kry
                gabimet++;
            else
                poenat = poenat + ((ekaqellu * 100) / (RreshtiMomental.Length -1));
            return maska;
        }

        public void AuKry(string MaskaMomentale)
        {
            if (gabimet == 10)  //Loja kryhet se ki hup
            {
                mbledhgabimetpoenat();
                Loja.humbje = true;
                Loja.ukrykrejt = true;
                maska = RreshtiMomental;
            }
            else
            {
                if (MaskaMomentale == RreshtiMomental)
                {
                    CiliRresht++;
                    mbledhgabimetpoenat();
                    if (CiliRresht > ListaFjalt.Count - 1)  //Loja u kry 
                    {
                        Loja.ukrykrejt = true;
                    }
                    else
                    {                               //Veq Rreshti u kry
                        pastro();
                    }
                }
            }
        }

        public void pastro()                //Pastrohet per rreshtin tjeter
        {
            Loja.ukry = true;
            RreshtiMomental = ListaFjalt[CiliRresht];
            RreshtiMomental = RreshtiMomental.ToUpper();
            maska = string.Empty;
            KrijoMasken();
            gabimet = 0;
            poenat = 0;
        }

        public void mbledhgabimetpoenat()         //Mledhen Gabimet komplet
        {
            gabimetkomplet = gabimetkomplet + gabimet;
            poenatkomplet = poenatkomplet + poenat;
        }

    }
}