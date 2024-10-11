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
    public partial class recentOrders : UserControl
    {
        public recentOrders()
        {
            InitializeComponent();
        }
        public Image FoodImage
        {
            get { return gunaCirclePictureBox5.Image; }
            set { gunaCirclePictureBox5.Image = value; }
        }

       
        public string FoodName
        {
            get { return gunaLabel5.Text; }
            set { gunaLabel5.Text = value; }
        }

        public string CustomerLocation
        {
            get { return gunaLabel7.Text; }
            set { gunaLabel7.Text = value; }
        }

        
        public string OrderAmount
        {
            get { return gunaLabel8.Text; }
            set { gunaLabel8.Text = value; }
        }

     
        public string OrderStatus
        {
            get { return gunaLabel9.Text; }
            set { gunaLabel9.Text = value; }
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLabel7_Click(object sender, EventArgs e)
        {

        }
    }
}
