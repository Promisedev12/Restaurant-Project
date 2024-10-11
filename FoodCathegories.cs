using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran_Project
{
    public partial class FoodCathegories : UserControl
    {
        public FoodCathegories()
        {
            InitializeComponent();
            gunaPictureBox1.Click += FoodCathegories_Click;
            label1.Click += FoodCathegories_Click;
            gunaGradient2Panel1.Click += FoodCathegories_Click;
        }
        public Image cathegoryImage
        {
            get { return gunaPictureBox1.Image; }
            set { gunaPictureBox1.Image = value; }
        }
        public string cathegoryName
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public int cathegoryId { get; set; }
        private void FoodCathegories_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
        private void gunaGradient2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
