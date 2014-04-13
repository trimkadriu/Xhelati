namespace Xhelati
{
    partial class ParaLoja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParaLoja));
            this.lblText = new System.Windows.Forms.Label();
            this.lblEmri = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFilloLojen = new System.Windows.Forms.Button();
            this.btnAnuloLojen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtEmri = new System.Windows.Forms.TextBox();
            this.cmbListaLojes = new System.Windows.Forms.ComboBox();
            this.radPo = new System.Windows.Forms.RadioButton();
            this.radJo = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblText.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(0, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(302, 37);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Ju lutem plotesoni formen e meposhtme:";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmri
            // 
            this.lblEmri.AutoSize = true;
            this.lblEmri.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmri.Location = new System.Drawing.Point(6, 52);
            this.lblEmri.Name = "lblEmri";
            this.lblEmri.Size = new System.Drawing.Size(40, 18);
            this.lblEmri.TabIndex = 1;
            this.lblEmri.Text = "Emri:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tema:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Muzika e lojes:";
            // 
            // btnFilloLojen
            // 
            this.btnFilloLojen.Enabled = false;
            this.btnFilloLojen.Location = new System.Drawing.Point(124, 149);
            this.btnFilloLojen.Name = "btnFilloLojen";
            this.btnFilloLojen.Size = new System.Drawing.Size(70, 23);
            this.btnFilloLojen.TabIndex = 4;
            this.btnFilloLojen.Text = "Fillo Lojen";
            this.btnFilloLojen.UseVisualStyleBackColor = true;
            this.btnFilloLojen.Click += new System.EventHandler(this.btnFilloLojen_Click);
            // 
            // btnAnuloLojen
            // 
            this.btnAnuloLojen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnuloLojen.Location = new System.Drawing.Point(43, 149);
            this.btnAnuloLojen.Name = "btnAnuloLojen";
            this.btnAnuloLojen.Size = new System.Drawing.Size(75, 23);
            this.btnAnuloLojen.TabIndex = 5;
            this.btnAnuloLojen.Text = "Anulo Lojen";
            this.btnAnuloLojen.UseVisualStyleBackColor = true;
            this.btnAnuloLojen.Click += new System.EventHandler(this.btnAnuloLojen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::Xhelati.Properties.Resources.Egzekutuesi;
            this.pictureBox1.Location = new System.Drawing.Point(205, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txtEmri
            // 
            this.txtEmri.Location = new System.Drawing.Point(52, 50);
            this.txtEmri.MaxLength = 10;
            this.txtEmri.Name = "txtEmri";
            this.txtEmri.Size = new System.Drawing.Size(100, 20);
            this.txtEmri.TabIndex = 7;
            this.txtEmri.TextChanged += new System.EventHandler(this.txtEmri_TextChanged);
            // 
            // cmbListaLojes
            // 
            this.cmbListaLojes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListaLojes.FormattingEnabled = true;
            this.cmbListaLojes.Location = new System.Drawing.Point(52, 83);
            this.cmbListaLojes.Name = "cmbListaLojes";
            this.cmbListaLojes.Size = new System.Drawing.Size(142, 21);
            this.cmbListaLojes.TabIndex = 8;
            // 
            // radPo
            // 
            this.radPo.AutoSize = true;
            this.radPo.Checked = true;
            this.radPo.Location = new System.Drawing.Point(110, 117);
            this.radPo.Name = "radPo";
            this.radPo.Size = new System.Drawing.Size(40, 17);
            this.radPo.TabIndex = 9;
            this.radPo.TabStop = true;
            this.radPo.Text = "PO";
            this.radPo.UseVisualStyleBackColor = true;
            // 
            // radJo
            // 
            this.radJo.AutoSize = true;
            this.radJo.Location = new System.Drawing.Point(156, 117);
            this.radJo.Name = "radJo";
            this.radJo.Size = new System.Drawing.Size(38, 17);
            this.radJo.TabIndex = 10;
            this.radJo.Text = "JO";
            this.radJo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "(max 10)";
            // 
            // ParaLoja
            // 
            this.AcceptButton = this.btnFilloLojen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnAnuloLojen;
            this.ClientSize = new System.Drawing.Size(302, 183);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radJo);
            this.Controls.Add(this.radPo);
            this.Controls.Add(this.cmbListaLojes);
            this.Controls.Add(this.txtEmri);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAnuloLojen);
            this.Controls.Add(this.btnFilloLojen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmri);
            this.Controls.Add(this.lblText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ParaLoja";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xhelati v1.0 - Loje e re...";
            this.Load += new System.EventHandler(this.ParaLoja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblEmri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFilloLojen;
        private System.Windows.Forms.Button btnAnuloLojen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEmri;
        private System.Windows.Forms.ComboBox cmbListaLojes;
        private System.Windows.Forms.RadioButton radPo;
        private System.Windows.Forms.RadioButton radJo;
        private System.Windows.Forms.Label label3;
    }
}