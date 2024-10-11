namespace Restoran_Project
{
    partial class waiterDash
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
            this.gunaLabel33 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel32 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel31 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.gunaGradient2Panel2 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.cashnotify1 = new Restoran_Project.cashnotify();
            this.availablewaiter1 = new Restoran_Project.availablewaiter();
            this.gunaGradient2Panel1.SuspendLayout();
            this.gunaGradient2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel33
            // 
            this.gunaLabel33.AutoSize = true;
            this.gunaLabel33.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel33.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel33.Location = new System.Drawing.Point(37, 46);
            this.gunaLabel33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel33.Name = "gunaLabel33";
            this.gunaLabel33.Size = new System.Drawing.Size(102, 28);
            this.gunaLabel33.TabIndex = 47;
            this.gunaLabel33.Text = "Shey Irene";
            // 
            // gunaLabel32
            // 
            this.gunaLabel32.AutoSize = true;
            this.gunaLabel32.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel32.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel32.Location = new System.Drawing.Point(180, 17);
            this.gunaLabel32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel32.Name = "gunaLabel32";
            this.gunaLabel32.Size = new System.Drawing.Size(65, 28);
            this.gunaLabel32.TabIndex = 46;
            this.gunaLabel32.Text = "waiter";
            // 
            // gunaLabel31
            // 
            this.gunaLabel31.AutoSize = true;
            this.gunaLabel31.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel31.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gunaLabel31.Location = new System.Drawing.Point(14, 9);
            this.gunaLabel31.Name = "gunaLabel31";
            this.gunaLabel31.Size = new System.Drawing.Size(160, 36);
            this.gunaLabel31.TabIndex = 45;
            this.gunaLabel31.Text = "Welcome";
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.availablewaiter1);
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.OldLace;
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.White;
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(12, 91);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Radius = 30;
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(956, 953);
            this.gunaGradient2Panel1.TabIndex = 48;
            // 
            // gunaGradient2Panel2
            // 
            this.gunaGradient2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel2.Controls.Add(this.cashnotify1);
            this.gunaGradient2Panel2.GradientColor1 = System.Drawing.Color.White;
            this.gunaGradient2Panel2.GradientColor2 = System.Drawing.Color.OldLace;
            this.gunaGradient2Panel2.Location = new System.Drawing.Point(994, 91);
            this.gunaGradient2Panel2.Name = "gunaGradient2Panel2";
            this.gunaGradient2Panel2.Radius = 30;
            this.gunaGradient2Panel2.Size = new System.Drawing.Size(560, 953);
            this.gunaGradient2Panel2.TabIndex = 49;
            // 
            // cashnotify1
            // 
            this.cashnotify1.BackColor = System.Drawing.Color.Transparent;
            this.cashnotify1.Location = new System.Drawing.Point(3, 3);
            this.cashnotify1.Name = "cashnotify1";
            this.cashnotify1.Size = new System.Drawing.Size(633, 778);
            this.cashnotify1.TabIndex = 0;
            // 
            // availablewaiter1
            // 
            this.availablewaiter1.Location = new System.Drawing.Point(0, 0);
            this.availablewaiter1.Name = "availablewaiter1";
            this.availablewaiter1.Size = new System.Drawing.Size(902, 929);
            this.availablewaiter1.TabIndex = 0;
            this.availablewaiter1.userId = 0;
            // 
            // waiterDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1566, 1050);
            this.Controls.Add(this.gunaGradient2Panel2);
            this.Controls.Add(this.gunaGradient2Panel1);
            this.Controls.Add(this.gunaLabel33);
            this.Controls.Add(this.gunaLabel32);
            this.Controls.Add(this.gunaLabel31);
            this.Name = "waiterDash";
            this.Text = "waiterDash";
            this.Load += new System.EventHandler(this.waiterDash_Load);
            this.gunaGradient2Panel1.ResumeLayout(false);
            this.gunaGradient2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel gunaLabel33;
        private Guna.UI.WinForms.GunaLabel gunaLabel32;
        private Guna.UI.WinForms.GunaLabel gunaLabel31;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private availablewaiter availablewaiter1;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel2;
        private cashnotify cashnotify1;
    }
}