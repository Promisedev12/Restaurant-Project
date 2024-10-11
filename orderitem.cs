using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran_Project
{
    public partial class orderitem : UserControl
    {
        public orderitem()
        {
            InitializeComponent();
        }

        public Image FoodImage
        {
            get { return gunaCirclePictureBox1.Image; }
            set { gunaCirclePictureBox1.Image = value; }
        }

        public string FoodName1
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public string quantity
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }

        private void orderitem_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}