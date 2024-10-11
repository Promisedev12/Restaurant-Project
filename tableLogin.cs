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
    public partial class tableLogin : UserControl
    {
        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Resturant internship Project\projectDB.mdf;Integrated Security=True;Connect Timeout=30");

        public tableLogin()
        {
            InitializeComponent();
        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string query = "SELECT  tableNumber FROM [dbo].[Table] WHERE tableNumber = @tableNumber";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@tableNumber", gunaTextBox1.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();

                if (dt.Rows.Count > 0)
                {
                    int tableNumber = Convert.ToInt32(gunaTextBox1.Text);

                    Dashboard dd = new Dashboard();
                    dd.tableNumber = tableNumber;
                    dd.Show();
                    this.Parent.Parent.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Table number.", "Try again or Contact Admin to add table ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Parent.Parent.Hide();
        }
    }
}