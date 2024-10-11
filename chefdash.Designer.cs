namespace Restoran_Project
{
    partial class chefdash
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chefOrder1 = new Restoran_Project.chefOrder();
            this.gunaLabel40 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel33 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel32 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel31 = new Guna.UI.WinForms.GunaLabel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.chefOrder1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(172, 172);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(891, 860);
            this.flowLayoutPanel1.TabIndex = 44;
            // 
            // chefOrder1
            // 
            this.chefOrder1.BackColor = System.Drawing.Color.Transparent;
            this.chefOrder1.Location = new System.Drawing.Point(3, 3);
            this.chefOrder1.Name = "chefOrder1";
            this.chefOrder1.orderID = 0;
            this.chefOrder1.Size = new System.Drawing.Size(885, 368);
            this.chefOrder1.TabIndex = 45;
            this.chefOrder1.TableNumber = "09";
            this.chefOrder1.userId = 0;
            // 
            // gunaLabel40
            // 
            this.gunaLabel40.AutoSize = true;
            this.gunaLabel40.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel40.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gunaLabel40.Location = new System.Drawing.Point(206, 112);
            this.gunaLabel40.Name = "gunaLabel40";
            this.gunaLabel40.Size = new System.Drawing.Size(287, 36);
            this.gunaLabel40.TabIndex = 43;
            this.gunaLabel40.Text = "Available Orders";
            this.gunaLabel40.Click += new System.EventHandler(this.gunaLabel40_Click);
            // 
            // gunaLabel33
            // 
            this.gunaLabel33.AutoSize = true;
            this.gunaLabel33.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel33.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel33.Location = new System.Drawing.Point(67, 49);
            this.gunaLabel33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel33.Name = "gunaLabel33";
            this.gunaLabel33.Size = new System.Drawing.Size(102, 28);
            this.gunaLabel33.TabIndex = 42;
            this.gunaLabel33.Text = "Shey Irene";
            // 
            // gunaLabel32
            // 
            this.gunaLabel32.AutoSize = true;
            this.gunaLabel32.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel32.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel32.Location = new System.Drawing.Point(210, 20);
            this.gunaLabel32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel32.Name = "gunaLabel32";
            this.gunaLabel32.Size = new System.Drawing.Size(51, 28);
            this.gunaLabel32.TabIndex = 41;
            this.gunaLabel32.Text = "Chef";
            // 
            // gunaLabel31
            // 
            this.gunaLabel31.AutoSize = true;
            this.gunaLabel31.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel31.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gunaLabel31.Location = new System.Drawing.Point(44, 12);
            this.gunaLabel31.Name = "gunaLabel31";
            this.gunaLabel31.Size = new System.Drawing.Size(160, 36);
            this.gunaLabel31.TabIndex = 40;
            this.gunaLabel31.Text = "Welcome";
            // 
            // chefdash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1287, 1046);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.gunaLabel40);
            this.Controls.Add(this.gunaLabel33);
            this.Controls.Add(this.gunaLabel32);
            this.Controls.Add(this.gunaLabel31);
            this.Name = "chefdash";
            this.Text = "chefdash";
            this.Load += new System.EventHandler(this.chefdash_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel40;
        private Guna.UI.WinForms.GunaLabel gunaLabel33;
        private Guna.UI.WinForms.GunaLabel gunaLabel32;
        private Guna.UI.WinForms.GunaLabel gunaLabel31;
        private chefOrder chefOrder1;
    }
}