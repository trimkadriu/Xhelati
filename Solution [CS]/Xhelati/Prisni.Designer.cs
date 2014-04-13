namespace Xhelati
{
    partial class Prisni
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
            this.lblPrisni = new System.Windows.Forms.Label();
            this.pctLoadingBar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctLoadingBar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrisni
            // 
            this.lblPrisni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrisni.AutoEllipsis = true;
            this.lblPrisni.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrisni.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblPrisni.Location = new System.Drawing.Point(34, 26);
            this.lblPrisni.Name = "lblPrisni";
            this.lblPrisni.Size = new System.Drawing.Size(226, 41);
            this.lblPrisni.TabIndex = 0;
            this.lblPrisni.Text = "Ju lutem prisni...";
            this.lblPrisni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pctLoadingBar
            // 
            this.pctLoadingBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctLoadingBar.Image = global::Xhelati.Properties.Resources.LoadingBar;
            this.pctLoadingBar.Location = new System.Drawing.Point(37, 65);
            this.pctLoadingBar.Name = "pctLoadingBar";
            this.pctLoadingBar.Size = new System.Drawing.Size(220, 19);
            this.pctLoadingBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctLoadingBar.TabIndex = 1;
            this.pctLoadingBar.TabStop = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 95);
            this.label1.TabIndex = 2;
            // 
            // Prisni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(295, 117);
            this.Controls.Add(this.pctLoadingBar);
            this.Controls.Add(this.lblPrisni);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Prisni";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ju lutem prisni...";
            ((System.ComponentModel.ISupportInitialize)(this.pctLoadingBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrisni;
        private System.Windows.Forms.PictureBox pctLoadingBar;
        private System.Windows.Forms.Label label1;
    }
}