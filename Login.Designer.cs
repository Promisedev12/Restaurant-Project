namespace Restoran_Project
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLinkLabel1 = new Guna.UI.WinForms.GunaLinkLabel();
            this.gunaLinkLabel2 = new Guna.UI.WinForms.GunaLinkLabel();
            this.userLogin1 = new Restoran_Project.userLogin();
            this.tableLogin1 = new Restoran_Project.tableLogin();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.userLogin1);
            this.gunaElipsePanel1.Controls.Add(this.tableLogin1);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(599, 102);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 30;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(611, 446);
            this.gunaElipsePanel1.TabIndex = 0;
            this.gunaElipsePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaElipsePanel1_Paint);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(33, 39);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(507, 471);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 1;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaLinkLabel1
            // 
            this.gunaLinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gunaLinkLabel1.AutoSize = true;
            this.gunaLinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaLinkLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLinkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gunaLinkLabel1.Location = new System.Drawing.Point(490, 587);
            this.gunaLinkLabel1.Name = "gunaLinkLabel1";
            this.gunaLinkLabel1.Size = new System.Drawing.Size(223, 38);
            this.gunaLinkLabel1.TabIndex = 2;
            this.gunaLinkLabel1.TabStop = true;
            this.gunaLinkLabel1.Text = "Or Set On Table ";
            this.gunaLinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gunaLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gunaLinkLabel1_LinkClicked);
            // 
            // gunaLinkLabel2
            // 
            this.gunaLinkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gunaLinkLabel2.AutoSize = true;
            this.gunaLinkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaLinkLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLinkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gunaLinkLabel2.Location = new System.Drawing.Point(482, 587);
            this.gunaLinkLabel2.Name = "gunaLinkLabel2";
            this.gunaLinkLabel2.Size = new System.Drawing.Size(231, 38);
            this.gunaLinkLabel2.TabIndex = 3;
            this.gunaLinkLabel2.TabStop = true;
            this.gunaLinkLabel2.Text = "Or Login As User";
            this.gunaLinkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gunaLinkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gunaLinkLabel2_LinkClicked_1);
            // 
            // userLogin1
            // 
            this.userLogin1.BackColor = System.Drawing.Color.Transparent;
            this.userLogin1.Location = new System.Drawing.Point(0, 0);
            this.userLogin1.Name = "userLogin1";
            this.userLogin1.Size = new System.Drawing.Size(596, 452);
            this.userLogin1.TabIndex = 1;
            // 
            // tableLogin1
            // 
            this.tableLogin1.BackColor = System.Drawing.Color.Transparent;
            this.tableLogin1.Location = new System.Drawing.Point(0, 0);
            this.tableLogin1.Name = "tableLogin1";
            this.tableLogin1.Size = new System.Drawing.Size(594, 451);
            this.tableLogin1.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1271, 666);
            this.Controls.Add(this.gunaLinkLabel2);
            this.Controls.Add(this.gunaLinkLabel1);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.gunaElipsePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLinkLabel gunaLinkLabel1;
        private tableLogin tableLogin1;
        private userLogin userLogin1;
        private Guna.UI.WinForms.GunaLinkLabel gunaLinkLabel2;
    }
}