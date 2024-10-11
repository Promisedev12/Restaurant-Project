using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Restoran_Project
{
    public partial class Login : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Resturant internship Project\projectDB.mdf;Integrated Security=True;Connect Timeout=30");

        public Login()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            tableLogin1.Visible = false;
            gunaLinkLabel2.Visible = false;
        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            gunaLinkLabel2.Visible = true;
            tableLogin1.Visible = true;
            gunaLinkLabel1.Visible = false;
            tableLogin1.BringToFront();
        }

        private void gunaLinkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            gunaLinkLabel1.Visible = true;
            userLogin1.Visible = true;
            gunaLinkLabel2.Visible = false;
            userLogin1.BringToFront();
        }
    }
}