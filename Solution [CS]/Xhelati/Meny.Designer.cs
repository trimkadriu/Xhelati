namespace Xhelati
{
    partial class Meny
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meny));
            this.pctLojeere = new System.Windows.Forms.PictureBox();
            this.pctUpdate = new System.Windows.Forms.PictureBox();
            this.pctDil = new System.Windows.Forms.PictureBox();
            this.pctAutoret = new System.Windows.Forms.PictureBox();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.ttMeny = new System.Windows.Forms.ToolTip(this.components);
            this.lblExit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctLojeere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAutoret)).BeginInit();
            this.SuspendLayout();
            // 
            // pctLojeere
            // 
            this.pctLojeere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctLojeere.Image = global::Xhelati.Properties.Resources.Lojeere;
            this.pctLojeere.ImageLocation = "";
            this.pctLojeere.Location = new System.Drawing.Point(0, 258);
            this.pctLojeere.Name = "pctLojeere";
            this.pctLojeere.Size = new System.Drawing.Size(174, 54);
            this.pctLojeere.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctLojeere.TabIndex = 0;
            this.pctLojeere.TabStop = false;
            this.ttMeny.SetToolTip(this.pctLojeere, "Luani nje loje te re...");
            this.pctLojeere.MouseLeave += new System.EventHandler(this.pctLojeere_MouseLeave);
            this.pctLojeere.Click += new System.EventHandler(this.pctLojeere_Click);
            this.pctLojeere.MouseEnter += new System.EventHandler(this.pctLojeere_MouseEnter);
            // 
            // pctUpdate
            // 
            this.pctUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctUpdate.Image = global::Xhelati.Properties.Resources.Update;
            this.pctUpdate.ImageLocation = "";
            this.pctUpdate.Location = new System.Drawing.Point(0, 327);
            this.pctUpdate.Name = "pctUpdate";
            this.pctUpdate.Size = new System.Drawing.Size(174, 54);
            this.pctUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctUpdate.TabIndex = 1;
            this.pctUpdate.TabStop = false;
            this.ttMeny.SetToolTip(this.pctUpdate, "Beni lojen Up-Date ne versionin me te fundit (ju duhet te keni internet).");
            this.pctUpdate.MouseLeave += new System.EventHandler(this.pctUpdate_MouseLeave);
            this.pctUpdate.Click += new System.EventHandler(this.pctUpdate_Click);
            this.pctUpdate.MouseEnter += new System.EventHandler(this.pctUpdate_MouseEnter);
            // 
            // pctDil
            // 
            this.pctDil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctDil.Image = global::Xhelati.Properties.Resources.Dil;
            this.pctDil.ImageLocation = "";
            this.pctDil.Location = new System.Drawing.Point(0, 387);
            this.pctDil.Name = "pctDil";
            this.pctDil.Size = new System.Drawing.Size(174, 54);
            this.pctDil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctDil.TabIndex = 2;
            this.pctDil.TabStop = false;
            this.ttMeny.SetToolTip(this.pctDil, "Dil nga loja Xhelati v1.0");
            this.pctDil.MouseLeave += new System.EventHandler(this.pctDil_MouseLeave);
            this.pctDil.Click += new System.EventHandler(this.pctDil_Click);
            this.pctDil.MouseEnter += new System.EventHandler(this.pctDil_MouseEnter);
            // 
            // pctAutoret
            // 
            this.pctAutoret.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctAutoret.Image = global::Xhelati.Properties.Resources.Autoret;
            this.pctAutoret.ImageLocation = "";
            this.pctAutoret.Location = new System.Drawing.Point(419, 387);
            this.pctAutoret.Name = "pctAutoret";
            this.pctAutoret.Size = new System.Drawing.Size(151, 72);
            this.pctAutoret.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctAutoret.TabIndex = 3;
            this.pctAutoret.TabStop = false;
            this.ttMeny.SetToolTip(this.pctAutoret, "Shikoni autoret e lojes Xhelati v1.0");
            this.pctAutoret.MouseLeave += new System.EventHandler(this.pctAutoret_MouseLeave);
            this.pctAutoret.Click += new System.EventHandler(this.pctAutoret_Click);
            this.pctAutoret.MouseEnter += new System.EventHandler(this.pctAutoret_MouseEnter);
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.BackColor = System.Drawing.Color.Transparent;
            this.lblMinimize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.Location = new System.Drawing.Point(610, 9);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(26, 18);
            this.lblMinimize.TabIndex = 4;
            this.lblMinimize.Text = "__";
            this.ttMeny.SetToolTip(this.lblMinimize, "Minimizo Lojen Xhelati v1.0");
            this.lblMinimize.MouseLeave += new System.EventHandler(this.lblMinimize_MouseLeave);
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            this.lblMinimize.MouseEnter += new System.EventHandler(this.lblMinimize_MouseEnter);
            // 
            // lblExit
            // 
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(642, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(26, 18);
            this.lblExit.TabIndex = 5;
            this.lblExit.Text = "X";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttMeny.SetToolTip(this.lblExit, "Dil nga loja Xhelati v1.0");
            this.lblExit.MouseLeave += new System.EventHandler(this.lblExit_MouseLeave);
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            this.lblExit.MouseEnter += new System.EventHandler(this.lblExit_MouseEnter);
            // 
            // Meny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Xhelati.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(680, 460);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblMinimize);
            this.Controls.Add(this.pctAutoret);
            this.Controls.Add(this.pctDil);
            this.Controls.Add(this.pctUpdate);
            this.Controls.Add(this.pctLojeere);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Meny";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xhelati v1.0";
            this.Load += new System.EventHandler(this.Meny_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Meny_MouseUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Meny_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Meny_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pctLojeere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAutoret)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctLojeere;
        private System.Windows.Forms.PictureBox pctUpdate;
        private System.Windows.Forms.PictureBox pctDil;
        private System.Windows.Forms.PictureBox pctAutoret;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.ToolTip ttMeny;
        private System.Windows.Forms.Label lblExit;
    }
}