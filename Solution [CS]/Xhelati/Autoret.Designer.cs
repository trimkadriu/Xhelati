namespace Xhelati
{
    partial class Autoret
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autoret));
            this.pctXhelati = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNeRregull = new System.Windows.Forms.Button();
            this.txtPershkrimi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctXhelati)).BeginInit();
            this.SuspendLayout();
            // 
            // pctXhelati
            // 
            this.pctXhelati.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctXhelati.Dock = System.Windows.Forms.DockStyle.Left;
            this.pctXhelati.Image = global::Xhelati.Properties.Resources.Egzekutuesi;
            this.pctXhelati.Location = new System.Drawing.Point(0, 0);
            this.pctXhelati.Name = "pctXhelati";
            this.pctXhelati.Size = new System.Drawing.Size(159, 235);
            this.pctXhelati.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctXhelati.TabIndex = 0;
            this.pctXhelati.TabStop = false;
            this.pctXhelati.WaitOnLoad = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xhelati v1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Version 1.0.0.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Copyright © 2011. All Rights Reserved";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Trim Kadriu";
            // 
            // btnNeRregull
            // 
            this.btnNeRregull.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNeRregull.Location = new System.Drawing.Point(314, 204);
            this.btnNeRregull.Name = "btnNeRregull";
            this.btnNeRregull.Size = new System.Drawing.Size(75, 23);
            this.btnNeRregull.TabIndex = 5;
            this.btnNeRregull.Text = "Ne Rregull";
            this.btnNeRregull.UseVisualStyleBackColor = true;
            this.btnNeRregull.Click += new System.EventHandler(this.btnNeRregull_Click);
            // 
            // txtPershkrimi
            // 
            this.txtPershkrimi.Location = new System.Drawing.Point(175, 107);
            this.txtPershkrimi.Multiline = true;
            this.txtPershkrimi.Name = "txtPershkrimi";
            this.txtPershkrimi.ReadOnly = true;
            this.txtPershkrimi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPershkrimi.Size = new System.Drawing.Size(214, 89);
            this.txtPershkrimi.TabIndex = 6;
            this.txtPershkrimi.Text = resources.GetString("txtPershkrimi.Text");
            // 
            // Autoret
            // 
            this.AcceptButton = this.btnNeRregull;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnNeRregull;
            this.ClientSize = new System.Drawing.Size(401, 235);
            this.Controls.Add(this.txtPershkrimi);
            this.Controls.Add(this.btnNeRregull);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctXhelati);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Autoret";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autoret";
            ((System.ComponentModel.ISupportInitialize)(this.pctXhelati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctXhelati;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNeRregull;
        private System.Windows.Forms.TextBox txtPershkrimi;
    }
}