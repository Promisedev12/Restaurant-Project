namespace Restoran_Project
{
    partial class bestFood
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bestFood));
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel25 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel26 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel27 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.BackColor = System.Drawing.Color.OldLace;
            this.gunaPanel3.Controls.Add(this.gunaLabel25);
            this.gunaPanel3.Controls.Add(this.gunaLabel26);
            this.gunaPanel3.Controls.Add(this.gunaLabel27);
            this.gunaPanel3.Controls.Add(this.gunaPictureBox2);
            this.gunaPanel3.Location = new System.Drawing.Point(3, 3);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(196, 321);
            this.gunaPanel3.TabIndex = 18;
            this.gunaPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel3_Paint);
            // 
            // gunaLabel25
            // 
            this.gunaLabel25.AutoSize = true;
            this.gunaLabel25.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel25.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel25.Location = new System.Drawing.Point(44, 258);
            this.gunaLabel25.MaximumSize = new System.Drawing.Size(150, 150);
            this.gunaLabel25.Name = "gunaLabel25";
            this.gunaLabel25.Size = new System.Drawing.Size(75, 25);
            this.gunaLabel25.TabIndex = 12;
            this.gunaLabel25.Text = "10% off";
            // 
            // gunaLabel26
            // 
            this.gunaLabel26.AutoSize = true;
            this.gunaLabel26.Font = new System.Drawing.Font("Cooper Black", 16F);
            this.gunaLabel26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel26.Location = new System.Drawing.Point(59, 222);
            this.gunaLabel26.Name = "gunaLabel26";
            this.gunaLabel26.Size = new System.Drawing.Size(72, 36);
            this.gunaLabel26.TabIndex = 13;
            this.gunaLabel26.Text = "$30";
            // 
            // gunaLabel27
            // 
            this.gunaLabel27.AutoSize = true;
            this.gunaLabel27.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel27.Location = new System.Drawing.Point(3, 180);
            this.gunaLabel27.Name = "gunaLabel27";
            this.gunaLabel27.Size = new System.Drawing.Size(186, 32);
            this.gunaLabel27.TabIndex = 12;
            this.gunaLabel27.Text = "Rosted chicken";
            this.gunaLabel27.Click += new System.EventHandler(this.gunaLabel27_Click);
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(0, 0);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Radius = 5;
            this.gunaPictureBox2.Size = new System.Drawing.Size(203, 174);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 12;
            this.gunaPictureBox2.TabStop = false;
            // 
            // bestFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gunaPanel3);
            this.Name = "bestFood";
            this.Size = new System.Drawing.Size(203, 327);
            this.gunaPanel3.ResumeLayout(false);
            this.gunaPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel25;
        private Guna.UI.WinForms.GunaLabel gunaLabel26;
        private Guna.UI.WinForms.GunaLabel gunaLabel27;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
    }
}
