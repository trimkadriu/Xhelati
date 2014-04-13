using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Xhelati
{
    public partial class Loja : Form
    {
        private bool duke_terheq;
        private Point pozita;
        public bool muzika;
        public static bool ukry;
        public static bool ukrykrejt;
        public static bool humbje;
        public string emri;
        public string loja;
        public System.Threading.Thread t;
        public int rezX = System.Windows.Forms.Screen.PrimaryScreen.Bounds.X;
        public int rezY = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Y;
        public WMPLib.WindowsMediaPlayer lshusi = new WMPLib.WindowsMediaPlayer();
        public WMPLib.WindowsMediaPlayer lshusi_britma = new WMPLib.WindowsMediaPlayer();
        public WMPLib.WindowsMediaPlayer lshusi_varja = new WMPLib.WindowsMediaPlayer();
        clsLoja clsLoja;

        public Loja(string e, string l, bool m)
        {
            InitializeComponent();
            emri = e;
            loja = l;
            muzika = m;
        }

        private void Loja_MouseDown(object sender, MouseEventArgs e)
        {
            pozita.X = e.X;
            pozita.Y = e.Y;
            duke_terheq = true;
        }

        private void Loja_MouseMove(object sender, MouseEventArgs e)
        {
            if (duke_terheq)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - pozita.X, currentScreenPos.Y - pozita.Y);
            }
        }

        private void Loja_MouseUp(object sender, MouseEventArgs e)
        {
            duke_terheq = false;
        }

        private void Loja_Load(object sender, EventArgs e)
        {
            this.Location = new Point(rezX - 799, rezY - 599);
            DaljaPrisni();
            lblEmri.Text = emri;
            if (muzika == false)
            {
                pctMuzika.Image = Xhelati.Properties.Resources.MuzikaClicked;
            }
            else
            {
                pctMuzika.Image = Xhelati.Properties.Resources.MuzikaUnclicked;
            }
            clsLoja = new clsLoja(Application.StartupPath, loja);
            lblFjala.Text = clsLoja.KtheMasken();
            lshusi.URL = Application.StartupPath + "\\Muzika\\theme.mp3";
            lshusi.controls.stop();
            lshusi.settings.setMode("loop", true);
            lshusi_britma.URL = Application.StartupPath + "\\Muzika\\kuku.mp3";
            lshusi_britma.controls.stop();
            lshusi_varja.URL = Application.StartupPath + "\\Muzika\\vdiq.mp3";
            lshusi_varja.controls.stop();
        }

        public static void ThirrPrisni()
        {
            Application.Run(new Prisni());
        }

        private void pctDil_Click(object sender, EventArgs e)
        {
            DialogResult dlgres = MessageBox.Show(this, "A jeni i sigurt qe doni te dilni nga loja ?", "Pyetje !", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dlgres == DialogResult.Yes)
            {
                ukrykrejt = true;
                rifresko();
            }
        }

        public static void ThirrMeny()
        {
            Application.Run(new Meny());
        }

        private void pctDil_MouseEnter(object sender, EventArgs e)
        {
            pctDil.Image = Xhelati.Properties.Resources.LojaDilHover;
        }

        private void pctDil_MouseLeave(object sender, EventArgs e)
        {
            pctDil.Image = Xhelati.Properties.Resources.LojaDil;
        }

        private void pctMuzika_MouseEnter(object sender, EventArgs e)
        {
            if (muzika == false)
                pctMuzika.Image = Xhelati.Properties.Resources.MuzikaClickedHover;
            else
                pctMuzika.Image = Xhelati.Properties.Resources.MuzikaUnclickedHover;
        }

        private void pctMuzika_MouseLeave(object sender, EventArgs e)
        {
            if (muzika == false)
                pctMuzika.Image = Xhelati.Properties.Resources.MuzikaClicked;
            else
                pctMuzika.Image = Xhelati.Properties.Resources.MuzikaUnclicked;
        }

        private void pctMuzika_Click(object sender, EventArgs e)
        {
            if (muzika == false)
            {
                muzika = true;
                pctMuzika.Image = Xhelati.Properties.Resources.MuzikaUnclicked;
                lshusi.controls.play();
            }
            else
            {
                muzika = false;
                pctMuzika.Image = Xhelati.Properties.Resources.MuzikaClicked;
                lshusi.controls.pause();
            }
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblMinimize_MouseEnter(object sender, EventArgs e)
        {
            lblMinimize.BackColor = System.Drawing.Color.Gray;
        }

        private void lblMinimize_MouseLeave(object sender, EventArgs e)
        {
            lblMinimize.BackColor = System.Drawing.Color.Transparent;
        }

        private void pctMuzika_MouseHover(object sender, EventArgs e)
        {
            if (muzika == false)
                ttLoja.Show("Lesho Muziken.", this, pctMuzika.Location.X + pctMuzika.Size.Width, pctMuzika.Location.Y, 3000);
            else
                ttLoja.Show("Ndalo Muziken.", this, pctMuzika.Location.X + pctMuzika.Size.Width, pctMuzika.Location.Y, 3000);
        }

        private void Loja_Shown(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(2000);
            t.Abort();
            this.Activate();
            tmLoja.Enabled = true;
            MessageBox.Show("");
            this.Location = new Point(rezX + (rezX + this.Size.Width) / 2, rezY + (rezY + (this.Size.Height) / 2) - 100);
            if (muzika == true)
            {
                lshusi.controls.play();
            }
        }

        private void tmLoja_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
            tmLoja.Enabled = false;
        }

        public void DaljaMeny()
        {
            t = new System.Threading.Thread(new System.Threading.ThreadStart(ThirrMeny));
            t.Start();
            this.Close();
        }

        public void DaljaPrisni()
        {
            t = new System.Threading.Thread(new System.Threading.ThreadStart(ThirrPrisni));
            t.Start();
        }

        public void rifresko()
        {
            DialogResult dlgres = new DialogResult();
            clsLoja.AuKry(lblFjala.Text);
            if (ukrykrejt == true)
            {
                if (humbje == true)
                {
                    if (muzika == true)
                    {
                        lshusi_varja.controls.play();
                    }
                    pctBritma.Image = Xhelati.Properties.Resources.Varja;
                    pctBritma.Visible = true;
                    lblFjala.Text = clsLoja.KtheMasken();
                    MessageBox.Show(this, "Deshtuat ! Ju keni humbur lojen. Paci fat ne lojen tjeter.\n\nPiket Totale: " + clsLoja.KthePoenatTotale(), "Deshtuat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dlgres = MessageBox.Show(this, "Urime ! Ju perfunduat lojen me Sukses.\n\nEmri: " + emri + "\nPiket Totale: " + clsLoja.KthePoenatTotale() + "\n\nDeshironi qe te rankoheni ne listen online ne Internet ?", "Urime !", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dlgres == DialogResult.Yes)
                    {
                        DaljaPrisni();
                        this.Hide();
                        KontrolloInternet objKontInt = new KontrolloInternet();
                        objKontInt.Kontrollo();
                        if (objKontInt.KtheAkainternet() == true)
                        {
                            System.Threading.Thread.Sleep(1500);
                            t.Abort();
                            string temp = objKontInt.VendosPoenat(emri, Convert.ToInt32(clsLoja.KthePoenatTotale()));
                            if (temp == "SUKSES")
                            {
                                MessageBox.Show(this, "Ju u rankuat ne listen e lojtareve.\nwww.Xhelati.tk", "Sukses !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                MessageBox.Show(this, temp, "Gabim !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            System.Threading.Thread.Sleep(1500);
                            t.Abort();
                            MessageBox.Show(this, "Gabim ! Ju nuk keni lidhje ne Internet.", "Gabim !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                humbje = false;
                ukrykrejt = false;
                DaljaMeny();
            }
            else
            {
                if (ukry == true)
                {
                    dlgres = MessageBox.Show(this, "Urime ! Ju e gjetet fjalen me sukses.\n\nEmri: " + emri + "\nPiket Totale: " + clsLoja.KthePoenatTotale() + "\n\nDeshironi te vazhdoni lojen ?", "Urime !", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dlgres == DialogResult.Yes)
                    {
                        lblGabimet.Text = "0/10";
                        lblFjala.Text = clsLoja.KtheMasken();
                        KthejShkronjat();
                    }
                    else
                    {
                        MessageBox.Show(this, "Ju perfunduat lojen.\n\nEmri: " + emri + "\n\nPiket Totale: " + clsLoja.KthePoenatTotale(), "Perfundoi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DaljaMeny();
                    }
                    ukry = false;
                }
                else
                {
                    int temp = Convert.ToInt32(lblGabimet.Text.Remove(lblGabimet.Text.Length - 3));
                    lblGabimet.Text = clsLoja.KtheGabimet().ToString() + "/10";
                    if(temp < Convert.ToInt32(lblGabimet.Text.Remove(lblGabimet.Text.Length - 3)))
                    {
                        if (muzika == true)
                        {
                            lshusi_britma.controls.play();
                        }
                        pctBritma.Image = Xhelati.Properties.Resources.Britma;
                        pctBritma.Visible = true;
                    }
                }
            }
        }

        private void KthejShkronjat()
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnE.Enabled = true;
            btnF.Enabled = true;
            btnG.Enabled = true;
            btnH.Enabled = true;
            btnI.Enabled = true;
            btnJ.Enabled = true;
            btnK.Enabled = true;
            btnL.Enabled = true;
            btnM.Enabled = true;
            btnN.Enabled = true;
            btnO.Enabled = true;
            btnP.Enabled = true;
            btnQ.Enabled = true;
            btnR.Enabled = true;
            btnS.Enabled = true;
            btnT.Enabled = true;
            btnU.Enabled = true;
            btnV.Enabled = true;
            btnW.Enabled = true;
            btnX.Enabled = true;
            btnY.Enabled = true;
            btnZ.Enabled = true;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            lblFjala.Text = clsLoja.kontrollo(lblFjala.Text);
            rifresko();
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            btnK.Enabled = false;
            lblFjala.Text = clsLoja.kontrollo(lblFjala.Text);
            rifresko();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnD.Enabled = false;
            lblFjala.Text = clsLoja.kontrollo(lblFjala.Text);
            rifresko();
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            btnS.Enabled = false;
            lblFjala.Text = clsLoja.kontrollo(lblFjala.Text);
            rifresko();
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            btnT.Enabled = false;
            lblFjala.Text = clsLoja.kontrollo(lblFjala.Text);
            rifresko();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            btnR.Enabled = false;
            lblFjala.Text = clsLoja.kontrollo(lblFjala.Text);
            rifresko();
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            btnO.Enabled = false;
            lblFjala.Text = clsLoja.kontrollo(lblFjala.Text);
            rifresko();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnB.Enabled = false;
            lblFjala.Text = clsLoja.kontrollo(lblFjala.Text);
            rifresko();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnC.Enabled = false;
            lblFjala.Text = clsLoja.kontrollo(lblFjala.Text);
            rifresko();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            btnE.Enabled = false;
            lblFjala.Text = clsLoja.kontrollo(lblFjala.Text);
            rifresko();
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            btnF.Enabled = false;
            lblFjala.Text = clsLoja.kontrollo(lblFjala.Text);
            rifresko();
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            btnG.Enabled = false;
            lblFjala.Text = clsLoja.kontrollo(lblFjala.Text);
            rifresko();
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            btnH.Enabled = false;
            lblFjala.Text = clsLoja.kontrollo(lblFjala.Text);
            rifresko();
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            btnI.Enabled = false;
            lblFjala.Text = clsLoja.kontrollo(lblFjala.Text);
            rifresko();
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            btnJ.Enabled = false;
            lblFjala.Text = clsLoja.kontrollo(lblFjala.Text);
            rifresko();
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            btnL.Enabled = false;
            lblFjala.Text = clsLoja.kontrollo(lblFjala.Text);
            rifresko();
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            btnM.Enabled = false;
            lblFjala.Text = clsLoja.kontrollo(lblFjala.Text);
            rifresko();
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            btnN.Enabled = false;
            lblFjala.Text = clsLoja.kontrollo(lblFjala.Text);
            rifresko();
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            btnP.Enabled = false;
            lblFjala.Text = clsLoja.kontrollo(lblFjala.Text);
            rifresko();
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            btnQ.Enabled = false;
            lblFjala.Text = clsLoja.kontrollo(lblFjala.Text);
            rifresko();
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            btnU.Enabled = false;
            lblFjala.Text = clsLoja.kontrollo(lblFjala.Text);
            rifresko();
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            btnV.Enabled = false;
            lblFjala.Text = clsLoja.kontrollo(lblFjala.Text);
            rifresko();
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            btnW.Enabled = false;
            lblFjala.Text = clsLoja.kontrollo(lblFjala.Text);
            rifresko();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            btnX.Enabled = false;
            lblFjala.Text = clsLoja.kontrollo(lblFjala.Text);
            rifresko();
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            btnY.Enabled = false;
            lblFjala.Text = clsLoja.kontrollo(lblFjala.Text);
            rifresko();
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            btnZ.Enabled = false;
            lblFjala.Text = clsLoja.kontrollo(lblFjala.Text);
            rifresko();
        }

        private void Loja_FormClosing(object sender, FormClosingEventArgs e)
        {
            lshusi.controls.stop();
            lshusi.close();
        }
    }
}
