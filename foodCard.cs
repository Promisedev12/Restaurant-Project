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
    public partial class foodCard : UserControl
    {
        public event EventHandler AddOrderRequested;

        public event EventHandler RemoveOrderRequested;

        public foodCard()
        {
            InitializeComponent();
            gunaPictureBox1.Click += OnFoodCardClick;
            gunaLabel1.Click += OnFoodCardClick;
            gunaLabel2.Click += OnFoodCardClick;
            gunaLabel3.Click += OnFoodCardClick;
            this.Click += OnFoodCardClick;
        }

        private void OnFoodCardClick(object sender, EventArgs e)
        {
            gunaButton3.Visible = !gunaButton3.Visible;

            if (gunaButton3.Visible)
            {
                AddOrderRequested?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                RemoveOrderRequested?.Invoke(this, EventArgs.Empty);
            }
        }

        public Image foodImage
        {
            get { return gunaPictureBox1.Image; }
            set { gunaPictureBox1.Image = value; }
        }

        public bool isSelected
        {
            get { return gunaButton3.Visible; }
            set { gunaButton3.Visible = value; }
        }

        public string foodName
        {
            get { return gunaLabel1.Text; }
            set { gunaLabel1.Text = value; }
        }

        public string foodPrice
        {
            get { return gunaLabel2.Text; }
            set { gunaLabel2.Text = value; }
        }

        public string foodDescription
        {
            get { return gunaLabel3.Text; }
            set { gunaLabel3.Text = value; }
        }

        public bool checkedButton
        {
            get { return gunaButton3.Visible; }
            set { gunaButton3.Visible = value; }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
        }

        private void gunaButton3_Click_1(object sender, EventArgs e)
        {
            //if (gunaButton3.Visible == false)
            //{
            //    gunaButton3.Visible = true;
            //}
            //else
            //{
            //    gunaButton3.Visible = false;
            //}
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            //if (gunaButton3.Visible == false)
            //{
            //    gunaButton3.Visible = true;
            //}
            //else
            //{
            //    gunaButton3.Visible = false;
            //}
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            //if (gunaButton3.Visible == false)
            //{
            //    gunaButton3.Visible = true;
            //}
            //else
            //{
            //    gunaButton3.Visible = false;
            //}
        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {
            //if (gunaButton3.Visible == false)
            //{
            //    gunaButton3.Visible = true;
            //}
            //else
            //{
            //    gunaButton3.Visible = false;
            //}
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {
            //if (gunaButton3.Visible == false)
            //{
            //    gunaButton3.Visible = true;
            //}
            //else
            //{
            //    gunaButton3.Visible = false;
            //}
        }

        private void foodCard_Load(object sender, EventArgs e)
        {
            gunaButton3.BringToFront();
            gunaButton3.Visible = false;
        }

        private void gunaGradient2Panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}