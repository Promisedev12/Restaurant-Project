using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran_Project
{
    public partial class deleteUser : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Resturant internship Project\projectDB.mdf;Integrated Security=True;Connect Timeout=30");
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string userRol { get; set; }
        public int id { get; set; }

        public deleteUser()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void deleteUser_Load(object sender, EventArgs e)
        {
            gunaLabel4.Text = UserName;
            label1.Text = userRol;
            label5.Text = UserID;
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            string query = "delete FROM [dbo].[user] where Id = '" + id + "'";

            SqlCommand adapter = new SqlCommand(query, con);
            con.Open();
            adapter.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("User deleted");

            this.Hide();
        }
    }
}