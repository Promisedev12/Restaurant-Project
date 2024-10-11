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
    public partial class bestFood : UserControl
    {
        public bestFood()
        {
            InitializeComponent();
        }
        public Image foodImage
        {
            get { return gunaPictureBox2.Image; }
            set { gunaPictureBox2.Image = value; }
        }
        public string foodName
        {
            get { return gunaLabel27.Text; }
            set { gunaLabel27.Text = value; }
        }
        public string foodPrice
        {
            get { return gunaLabel26.Text; }
            set { gunaLabel26.Text = value; }
        }
        public string foodDescription
        {
            get { return gunaLabel25.Text; }
            set { gunaLabel25.Text = value; }
        }

        private void gunaPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLabel27_Click(object sender, EventArgs e)
        {

        }
    }
}
