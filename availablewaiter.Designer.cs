namespace Restoran_Project
{
    partial class availablewaiter
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.orderWaiter1 = new Restoran_Project.orderWaiter();
            this.gunaLabel40 = new Guna.UI.WinForms.GunaLabel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.orderWaiter1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 60);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(891, 860);
            this.flowLayoutPanel1.TabIndex = 51;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // orderWaiter1
            // 
            this.orderWaiter1.BackColor = System.Drawing.Color.Transparent;
            this.orderWaiter1.Location = new System.Drawing.Point(3, 3);
            this.orderWaiter1.Name = "orderWaiter1";
            this.orderWaiter1.orderID = 0;
            this.orderWaiter1.Size = new System.Drawing.Size(881, 345);
            this.orderWaiter1.TabIndex = 0;
            this.orderWaiter1.TableNumber = "09";
            this.orderWaiter1.userId = 0;
            // 
            // gunaLabel40
            // 
            this.gunaLabel40.AutoSize = true;
            this.gunaLabel40.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel40.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gunaLabel40.Location = new System.Drawing.Point(41, 0);
            this.gunaLabel40.Name = "gunaLabel40";
            this.gunaLabel40.Size = new System.Drawing.Size(287, 36);
            this.gunaLabel40.TabIndex = 50;
            this.gunaLabel40.Text = "Available Orders";
            // 
            // availablewaiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.gunaLabel40);
            this.Name = "availablewaiter";
            this.Size = new System.Drawing.Size(902, 929);
            this.Load += new System.EventHandler(this.availablewaiter_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel40;
        private orderWaiter orderWaiter1;
    }
}
