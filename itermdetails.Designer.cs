namespace Restoran_Project
{
    partial class itermdetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(itermdetails));
            this.gunaCirclePictureBox3 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaGradient2Panel2 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox3)).BeginInit();
            this.gunaGradient2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaCirclePictureBox3
            // 
            this.gunaCirclePictureBox3.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox3.Image")));
            this.gunaCirclePictureBox3.Location = new System.Drawing.Point(24, 27);
            this.gunaCirclePictureBox3.Name = "gunaCirclePictureBox3";
            this.gunaCirclePictureBox3.Size = new System.Drawing.Size(47, 39);
            this.gunaCirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox3.TabIndex = 0;
            this.gunaCirclePictureBox3.TabStop = false;
            this.gunaCirclePictureBox3.UseTransfarantBackground = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "3 Fried Chicken";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel4.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gunaLabel4.Location = new System.Drawing.Point(445, 18);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(68, 27);
            this.gunaLabel4.TabIndex = 25;
            this.gunaLabel4.Text = "$200";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(458, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 34;
            this.label3.Text = "Each";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // gunaGradient2Panel2
            // 
            this.gunaGradient2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel2.Controls.Add(this.label1);
            this.gunaGradient2Panel2.Controls.Add(this.label3);
            this.gunaGradient2Panel2.Controls.Add(this.gunaLabel4);
            this.gunaGradient2Panel2.Controls.Add(this.label2);
            this.gunaGradient2Panel2.Controls.Add(this.gunaCirclePictureBox3);
            this.gunaGradient2Panel2.GradientColor1 = System.Drawing.Color.OldLace;
            this.gunaGradient2Panel2.GradientColor2 = System.Drawing.Color.White;
            this.gunaGradient2Panel2.Location = new System.Drawing.Point(0, 3);
            this.gunaGradient2Panel2.Name = "gunaGradient2Panel2";
            this.gunaGradient2Panel2.Radius = 20;
            this.gunaGradient2Panel2.Size = new System.Drawing.Size(645, 100);
            this.gunaGradient2Panel2.TabIndex = 31;
            this.gunaGradient2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaGradient2Panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 32);
            this.label1.TabIndex = 35;
            this.label1.Text = "3";
            // 
            // itermdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gunaGradient2Panel2);
            this.Name = "itermdetails";
            this.Size = new System.Drawing.Size(647, 108);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox3)).EndInit();
            this.gunaGradient2Panel2.ResumeLayout(false);
            this.gunaGradient2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox3;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel2;
        private System.Windows.Forms.Label label1;
    }
}
