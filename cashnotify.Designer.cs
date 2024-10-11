namespace Restoran_Project
{
    partial class cashnotify
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
            this.gunaLabel40 = new Guna.UI.WinForms.GunaLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cashitem1 = new Restoran_Project.cashitem();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel40
            // 
            this.gunaLabel40.AutoSize = true;
            this.gunaLabel40.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel40.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gunaLabel40.Location = new System.Drawing.Point(12, 24);
            this.gunaLabel40.Name = "gunaLabel40";
            this.gunaLabel40.Size = new System.Drawing.Size(233, 36);
            this.gunaLabel40.TabIndex = 51;
            this.gunaLabel40.Text = "Cash Request";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.cashitem1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(18, 98);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(474, 677);
            this.flowLayoutPanel1.TabIndex = 52;
            // 
            // cashitem1
            // 
            this.cashitem1.amount = "09";
            this.cashitem1.BackColor = System.Drawing.Color.Transparent;
            this.cashitem1.Location = new System.Drawing.Point(3, 3);
            this.cashitem1.Name = "cashitem1";
            this.cashitem1.orderId = 0;
            this.cashitem1.Size = new System.Drawing.Size(454, 125);
            this.cashitem1.TabIndex = 0;
            this.cashitem1.tableNumber = "09";
            // 
            // cashnotify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.gunaLabel40);
            this.Name = "cashnotify";
            this.Size = new System.Drawing.Size(503, 778);
            this.Load += new System.EventHandler(this.cashnotify_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel40;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private cashitem cashitem1;
    }
}
