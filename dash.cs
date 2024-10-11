using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;
using System.IO;

namespace Restoran_Project
{
    public partial class dash : UserControl
    {
        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Resturant internship Project\projectDB.mdf;Integrated Security=True;Connect Timeout=30");

        public dash()
        {
            InitializeComponent();
        }

        private void dash_Load(object sender, EventArgs e)
        {
            UpdateTotalOtters();

            gunaLabel3.Text = GetTotalMenus().ToString();
            gunaLabel4.Text = GetTotalIncome().ToString();
            //LoadRecentOrders();
            LoadFavoriteFoods();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void LoadFavoriteFoods()
        {
            string query = @"
        SELECT TOP 6 f.image AS FoodImage, f.name AS FoodName, f.price AS FoodPrice, f.description AS FoodDescription
        FROM [orderItem] oi
        JOIN [food] f ON oi.food_id = f.id
        GROUP BY f.image, f.name, f.price, f.description
        ORDER BY COUNT(oi.food_id) DESC";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable favoriteFoodsTable = new DataTable();
            adapter.Fill(favoriteFoodsTable);

            flowLayoutPanel2.Controls.Clear();

            foreach (DataRow row in favoriteFoodsTable.Rows)
            {
                bestFood foodControl = new bestFood
                {
                    foodImage = Image.FromFile(row["FoodImage"].ToString()),
                    foodName = row["FoodName"].ToString(),
                    foodPrice = row["FoodPrice"].ToString(),
                    foodDescription = row["FoodDescription"].ToString()
                };

                flowLayoutPanel2.Controls.Add(foodControl);
            }
        }

        private void LoadRecentOrders()
        {
            string query = "SELECT TOP 3 f.image AS FoodImage, f.name AS FoodName,  u.location AS UserLocation, o.amount AS OrderAmount,  o.status AS OrderStatus FROM [orders] o JOIN [orderItem] oi ON o.id = oi.order_id JOIN [food] f ON oi.food_id = f.id JOIN [user] u ON o.user_id = u.id";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable ordersTable = new DataTable();
            adapter.Fill(ordersTable);

            flowLayoutPanel1.Controls.Clear();
            foreach (DataRow row in ordersTable.Rows)
            {
                recentOrders orderControl = new recentOrders
                {
                    FoodImage = Image.FromFile(row["FoodImage"].ToString()),
                    FoodName = row["FoodName"].ToString(),
                    CustomerLocation = row["UserLocation"].ToString(),
                    OrderAmount = Convert.ToDecimal(row["OrderAmount"]).ToString("C"),
                    OrderStatus = row["OrderStatus"].ToString()
                };

                flowLayoutPanel1.Controls.Add(orderControl);
            }
        }

        private void UpdateTotalOtters()
        {
            string query = "SELECT COUNT(*) FROM [dbo].[orders]";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int totalOtters = (int)cmd.ExecuteScalar();
            con.Close();

            gunaLabel1.Text = totalOtters.ToString();
        }

        private string userroll = "customer  ";

        private int GetTotalCustomers()
        {
            int totalCustomers = 0;

            string query = "SELECT COUNT(*) FROM [dbo].[user] where user_roll = '" + userroll + "'";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                totalCustomers = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving customer count: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return totalCustomers;
        }

        private int GetTotalMenus()
        {
            int totalMenus = 0;

            string query = "SELECT COUNT(*) FROM [menue]";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                totalMenus = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving menu count: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return totalMenus;
        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {
        }

        private decimal GetTotalIncome()
        {
            decimal totalIncome = 0;

            string query = "SELECT SUM(amount) FROM [orders]";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                var result = cmd.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    totalIncome = Convert.ToDecimal(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving total income: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return totalIncome;
        }

        private void gunaGradient2Panel7_Paint(object sender, PaintEventArgs e)
        {
        }

        private void gunaGradient2Panel3_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}