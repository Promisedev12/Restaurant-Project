namespace Restoran_Project
{
    partial class newOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newOrder));
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaLabel22 = new Guna.UI.WinForms.GunaLabel();
            this.gunaNumeric1 = new Guna.UI.WinForms.GunaNumeric();
            this.gunaPictureBox7 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel20 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel22);
            this.gunaElipsePanel1.Controls.Add(this.gunaNumeric1);
            this.gunaElipsePanel1.Controls.Add(this.gunaPictureBox7);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel20);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(3, 3);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(442, 89);
            this.gunaElipsePanel1.TabIndex = 1;
            this.gunaElipsePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaElipsePanel1_Paint);
            // 
            // gunaLabel22
            // 
            this.gunaLabel22.AutoSize = true;
            this.gunaLabel22.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel22.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel22.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel22.Location = new System.Drawing.Point(111, 64);
            this.gunaLabel22.Name = "gunaLabel22";
            this.gunaLabel22.Size = new System.Drawing.Size(37, 21);
            this.gunaLabel22.TabIndex = 16;
            this.gunaLabel22.Text = "$30";
            // 
            // gunaNumeric1
            // 
            this.gunaNumeric1.BaseColor = System.Drawing.Color.White;
            this.gunaNumeric1.BorderColor = System.Drawing.Color.Silver;
            this.gunaNumeric1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gunaNumeric1.ButtonForeColor = System.Drawing.Color.White;
            this.gunaNumeric1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaNumeric1.ForeColor = System.Drawing.Color.Black;
            this.gunaNumeric1.Location = new System.Drawing.Point(315, 27);
            this.gunaNumeric1.Maximum = ((long)(9999999));
            this.gunaNumeric1.Minimum = ((long)(0));
            this.gunaNumeric1.Name = "gunaNumeric1";
            this.gunaNumeric1.Size = new System.Drawing.Size(93, 30);
            this.gunaNumeric1.TabIndex = 15;
            this.gunaNumeric1.Text = "gunaNumeric1";
            this.gunaNumeric1.Value = ((long)(0));
            // 
            // gunaPictureBox7
            // 
            this.gunaPictureBox7.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox7.Image")));
            this.gunaPictureBox7.Location = new System.Drawing.Point(19, 29);
            this.gunaPictureBox7.Name = "gunaPictureBox7";
            this.gunaPictureBox7.Size = new System.Drawing.Size(48, 56);
            this.gunaPictureBox7.TabIndex = 14;
            this.gunaPictureBox7.TabStop = false;
            this.gunaPictureBox7.Click += new System.EventHandler(this.gunaPictureBox7_Click);
            // 
            // gunaLabel20
            // 
            this.gunaLabel20.AutoSize = true;
            this.gunaLabel20.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel20.Location = new System.Drawing.Point(110, 27);
            this.gunaLabel20.Name = "gunaLabel20";
            this.gunaLabel20.Size = new System.Drawing.Size(155, 28);
            this.gunaLabel20.TabIndex = 13;
            this.gunaLabel20.Text = "Rosted chicken";
            // 
            // newOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gunaElipsePanel1);
            this.Name = "newOrder";
            this.Size = new System.Drawing.Size(451, 101);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel22;
        private Guna.UI.WinForms.GunaNumeric gunaNumeric1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox7;
        private Guna.UI.WinForms.GunaLabel gunaLabel20;
    }
}
