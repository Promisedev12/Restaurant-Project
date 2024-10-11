using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran_Project
{
    public partial class itermdetails : UserControl
    {
        public itermdetails()
        {
            InitializeComponent();
        }

        public Image FoodImage
        {
            get { return gunaCirclePictureBox3.Image; }
            set { gunaCirclePictureBox3.Image = value; }
        }

        public string FoodName1
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }

        public string quantity
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public string Price
        {
            get { return gunaLabel4.Text; }
            set { gunaLabel4.Text = value; }
        }

        private void gunaGradient2Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}