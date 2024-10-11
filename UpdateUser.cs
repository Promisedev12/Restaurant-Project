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
    public partial class UpdateUser : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Resturant internship Project\projectDB.mdf;Integrated Security=True;Connect Timeout=30");

        public UpdateUser()
        {
            InitializeComponent();
        }

        public string UserName { get; set; }
        public string userRol { get; set; }
        public int id { get; set; }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            gunaTextBox1.Text = UserName;
            gunaTextBox2.Text = userRol;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            string query = "UPDATE [dbo].[user] SET user_roll = '" + gunaTextBox2.Text + "', name = '" + gunaTextBox1.Text + "'WHERE Id = '" + id + "'";
            SqlCommand adapter = new SqlCommand(query, con);
            con.Open();
            adapter.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("User updated");

            this.Hide();
        }
    }
}