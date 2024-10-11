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
    public partial class userDetails : UserControl
    {
        public userDetails()
        {
            InitializeComponent();
        }

        public int userId { get; set; }

        public string userName
        {
            get { return gunaLabel4.Text; }
            set { gunaLabel4.Text = value; }
        }

        public string rol
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public string id
        {
            get { return label5.Text; }
            set { label5.Text = value; }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            deleteUser deleteUser = new deleteUser();
            deleteUser.userRol = rol;
            deleteUser.id = userId; deleteUser.UserName = userName;
            deleteUser.UserID = id;
            deleteUser.Show();
        }

        private void gunaGradient2Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            UpdateUser update = new UpdateUser();
            update.userRol = rol;
            update.id = userId;
            update.UserName = userName;
            update.Show();
        }
    }
}