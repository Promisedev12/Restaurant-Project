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
    public partial class userLogin : UserControl
    {
        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Resturant internship Project\projectDB.mdf;Integrated Security=True;Connect Timeout=30");

        public userLogin()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string query = "SELECT Id, user_roll FROM [dbo].[user] WHERE username = @username AND password = @password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", gunaTextBox1.Text);
                cmd.Parameters.AddWithValue("@password", gunaTextBox2.Text);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();

                if (dt.Rows.Count > 0)
                {
                    string userRole = dt.Rows[0]["user_roll"].ToString().Trim();
                    int userId = Convert.ToInt32(dt.Rows[0]["Id"]);

                    if (userRole == "chef")
                    {
                        chefdash dd = new chefdash();
                        dd.userId = userId;
                        dd.Show();
                        this.Parent.Parent.Hide();
                    }
                    else if (userRole == "admin")
                    {
                        AdminDashboard ll = new AdminDashboard();
                        ll.userID = userId;
                        ll.Show();
                        this.Parent.Parent.Hide();
                    }
                    else if (userRole == "waiter")
                    {
                        waiterDash ll = new waiterDash();
                        ll.userId = userId;
                        ll.Show();
                        this.Parent.Parent.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Parent.Parent.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}