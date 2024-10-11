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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        public int userID { get; set; }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            companyLogo1.Visible = true;
            dash1.Visible = false;
            addmenue1.Visible = false;
            addFood1.Visible = false;

            cathegoryadd1.Visible = false;
            manageUsers1.Visible = false;
        }

        private void gunaGradientButton6_Click(object sender, EventArgs e)
        {
        }

        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {
            dash1.Visible = false;

            addFood1.Visible = false;

            cathegoryadd1.Visible = false;
            manageUsers1.Visible = false;
            addmenue1.Visible = true;
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            dash1.Visible = true;
            companyLogo1.Visible = false;

            companyLogo1.Visible = false;
            addmenue1.Visible = false;
            addFood1.Visible = false;

            cathegoryadd1.Visible = false;
            manageUsers1.Visible = false;
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            dash1.Visible = false;

            addFood1.Visible = false;

            cathegoryadd1.Visible = false;
            manageUsers1.Visible = false;
            addmenue1.Visible = true;
        }

        private void gunaGradientButton5_Click(object sender, EventArgs e)
        {
            dash1.Visible = false;
            addmenue1.Visible = false;

            cathegoryadd1.Visible = false;
            manageUsers1.Visible = false;
            addFood1.Visible = true;
        }

        private void gunaGradientButton7_Click(object sender, EventArgs e)
        {
            dash1.Visible = false;
            addmenue1.Visible = false;
            addFood1.Visible = false;

            manageUsers1.Visible = false;
            cathegoryadd1.Visible = true;
        }

        private void gunaGradientButton8_Click(object sender, EventArgs e)
        {
            dash1.Visible = false;
            addmenue1.Visible = false;
            addFood1.Visible = false;

            cathegoryadd1.Visible = false;
           
            manageUsers1.Visible = true;
        }
    }
}