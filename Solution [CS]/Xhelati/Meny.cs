using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Xhelati
{
    public partial class Meny : Form
    {
        private bool duke_terheq;
        private Point pozita;
        public static bool TuLujt;
        System.Threading.Thread t;

        public Meny()
        {
            InitializeComponent();
        }

        private void pctDil_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pctDil_MouseEnter(object sender, EventArgs e)
        {
            pctDil.Image = Xhelati.Properties.Resources.DilHover;
        }

        private void pctDil_MouseLeave(object sender, EventArgs e)
        {
            pctDil.Image = Xhelati.Properties.Resources.Dil;
        }

        private void pctAutoret_Click(object sender, EventArgs e)
        {
            Form Autoret = new Autoret();
            Autoret.ShowDialog();
        }

        private void pctAutoret_MouseEnter(object sender, EventArgs e)
        {
            pctAutoret.Image = Xhelati.Properties.Resources.AutoretHover;
        }

        private void pctAutoret_MouseLeave(object sender, EventArgs e)
        {
            pctAutoret.Image = Xhelati.Properties.Resources.Autoret;
        }

        private void pctUpdate_MouseEnter(object sender, EventArgs e)
        {
            pctUpdate.Image = Xhelati.Properties.Resources.UpdateHover;
        }

        private void pctUpdate_MouseLeave(object sender, EventArgs e)
        {
            pctUpdate.Image = Xhelati.Properties.Resources.Update;
        }

        private void pctLojeere_MouseEnter(object sender, EventArgs e)
        {
            pctLojeere.Image = Xhelati.Properties.Resources.LojeereHover;
        }

        private void pctLojeere_MouseLeave(object sender, EventArgs e)
        {
            pctLojeere.Image = Xhelati.Properties.Resources.Lojeere;
        }

        private void Meny_MouseMove(object sender, MouseEventArgs e)
        {
            if (duke_terheq)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - pozita.X,currentScreenPos.Y - pozita.Y);
            }
        }

        private void Meny_MouseDown(object sender, MouseEventArgs e)
        {
            pozita.X = e.X;
            pozita.Y = e.Y;
            duke_terheq = true;
        }

        private void Meny_MouseUp(object sender, MouseEventArgs e)
        {
            duke_terheq = false;
        }

        private void pctLojeere_Click(object sender, EventArgs e)
        {
            Form ParaLoja = new ParaLoja();
            ParaLoja.ShowDialog();
            if (TuLujt == true)
                this.Close();
        }

        private void lblMinimize_MouseEnter(object sender, EventArgs e)
        {
            lblMinimize.BackColor = System.Drawing.Color.Gray;
        }

        private void lblMinimize_MouseLeave(object sender, EventArgs e)
        {
            lblMinimize.BackColor = System.Drawing.Color.Transparent;
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Meny_Load(object sender, EventArgs e)
        {
            this.Activate();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblExit_MouseEnter(object sender, EventArgs e)
        {
            lblExit.BackColor = System.Drawing.Color.Gray;
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            lblExit.BackColor = System.Drawing.Color.Transparent;
        }

        private void pctUpdate_Click(object sender, EventArgs e)
        {
            DaljaPrisni();
            KontrolloInternet objKontInt = new KontrolloInternet();
            objKontInt.Kontrollo();
            if (objKontInt.KtheAkainternet() == true)
            {
                System.Threading.Thread.Sleep(1500);
                t.Abort();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "http://www.xhelati.tk/update";
                Process processi = new Process();
                processi.StartInfo = startInfo;
                processi.Start();
            }
            else
            {
                System.Threading.Thread.Sleep(1500);
                t.Abort();
                MessageBox.Show(this, "Gabim ! Ju nuk keni lidhje ne Internet.", "Gabim !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DaljaPrisni()
        {
            t = new System.Threading.Thread(new System.Threading.ThreadStart(ThirrPrisni));
            t.Start();
        }

        public static void ThirrPrisni()
        {
            Application.Run(new Prisni());
        }
    }
}
