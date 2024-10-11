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
    public partial class manageUsers : UserControl
    {
        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Resturant internship Project\projectDB.mdf;Integrated Security=True;Connect Timeout=30");

        public manageUsers()
        {
            InitializeComponent();
        }

        private void gunaGradient2Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void loadUsers()
        {
            string query = "SELECT Id, name,  user_roll " +
                           "FROM [dbo].[user]";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable ordersTable = new DataTable();
            adapter.Fill(ordersTable);

            flowLayoutPanel1.Controls.Clear();
            foreach (DataRow row in ordersTable.Rows)
            {
                userDetails userDetails = new userDetails();

                userDetails.userId = (int)row["Id"];
                userDetails.userName = row["name"].ToString();
                userDetails.rol = row["user_roll"].ToString();
                userDetails.id = row["Id"].ToString();
                flowLayoutPanel1.Controls.Add(userDetails);
            }
        }

        private void manageUsers_Load(object sender, EventArgs e)
        {
            loadUsers();
        }
    }
}