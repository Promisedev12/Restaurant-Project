namespace Restoran_Project
{
    partial class Food
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
            this.foodCard8 = new Restoran_Project.foodCard();
            this.SuspendLayout();
            // 
            // foodCard8
            // 
            this.foodCard8.BackColor = System.Drawing.Color.Transparent;
            this.foodCard8.Location = new System.Drawing.Point(0, 0);
            this.foodCard8.Name = "foodCard8";
            this.foodCard8.Size = new System.Drawing.Size(237, 296);
            this.foodCard8.TabIndex = 7;
            this.foodCard8.Load += new System.EventHandler(this.foodCard8_Load);
            // 
            // Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.foodCard8);
            this.Name = "Food";
            this.Size = new System.Drawing.Size(216, 296);
            this.Load += new System.EventHandler(this.Food_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private foodCard foodCard8;

    }
}
