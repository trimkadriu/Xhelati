using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Xhelati
{
    public partial class ParaLoja : Form
    {
        public static string emri;
        public static string loja;
        public static bool muzika;

        public ParaLoja()
        {
            InitializeComponent();
        }

        private void btnAnuloLojen_Click(object sender, EventArgs e)
        {
            Meny.TuLujt = false;
            this.Close();
        }

        private void ParaLoja_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (String file in System.IO.Directory.GetFiles(@Application.StartupPath + "\\Listat"))
                {
                    cmbListaLojes.Items.Add(new System.IO.FileInfo(file).Name.Replace(".rad", ""));
                    cmbListaLojes.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,"Gabim ! Aplikacioni duhet te mbyllet.\nAplikacionit i mungojne fajlla te nevojshem, ju lutem re-instaloni.\n\n" + ex.Message, "Gabim!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnFilloLojen_Click(object sender, EventArgs e)
        {
            Meny.TuLujt = true;
            System.Threading.Thread t;
            emri = Convert.ToString(txtEmri.Text);
            loja = Convert.ToString(cmbListaLojes.SelectedItem);
            t = new System.Threading.Thread(new System.Threading.ThreadStart(ThirrLoja));
            if (radPo.Checked == true)
            {
                muzika = true;
            }
            else
            {
                muzika = false;
            }
            t.Start();
            this.Close();
        }

        public static void ThirrLoader()
        {
            Application.Run(new Prisni());
        }

        public static void ThirrLoja()
        {
            Application.Run(new Loja(emri, loja, muzika));
        }

        private void txtEmri_TextChanged(object sender, EventArgs e)
        {
            if (txtEmri.Text == "")
            {
                btnFilloLojen.Enabled = false;
                lblText.Text = "Ju lutem plotesoni formen e meposhtme:";
                lblText.BackColor = System.Drawing.Color.LightSteelBlue;
            }
            else
            {
                btnFilloLojen.Enabled = true;
                lblText.Text = "Loja mund te fillohet";
                lblText.BackColor = System.Drawing.Color.Bisque;
            }
        }

    }
}
