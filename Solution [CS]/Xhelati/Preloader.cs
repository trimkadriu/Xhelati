using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Xhelati
{
    public partial class Preloader : Form
    {
        public static System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThirrMeny));

        public static void ThirrMeny()
        {
            Application.Run(new Meny());
        }
        public Preloader()
        {
            InitializeComponent();
        }

        private void Preloader_Shown(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(2000);
            t.Start();
            this.Close();
        }

    }
}
