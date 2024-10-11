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
    public partial class chefOrder : UserControl
    {
        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Resturant internship Project\projectDB.mdf;Integrated Security=True;Connect Timeout=30");

        public chefOrder()
        {
            InitializeComponent();
        }

        public string TableNumber
        {
            get { return label15.Text; }
            set { label15.Text = value; }
        }

        public int orderID { get; set; }
        public int userId { get; set; }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus("selected");
            gunaButton2.Visible = false;
            gunaButton1.Visible = true;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
        }

        private void UpdateOrderStatus(string status)
        {
            string query = "UPDATE [dbo].[orders] SET status = @status WHERE Id = @orderId";

            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Achu Promise\Downloads\Resturant internship Project\resturantProject.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@orderId", orderID);

                con.Open();
                cmd.ExecuteNonQuery();

                if (status == "done")
                {
                    AddChefOrder();
                    this.Parent.Controls.Remove(this);
                    (this.ParentForm as chefdash)?.LoadPendingOrders();
                }
            }
        }

        private void AddChefOrder()
        {
            string query = "INSERT INTO [dbo].[chefOrders] (chef_ID, order_id) VALUES (@chefId, @orderId)";

            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Achu Promise\Downloads\Resturant internship Project\resturantProject.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@chefId", userId);
                cmd.Parameters.AddWithValue("@orderId", orderID);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void gunaGradient2Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void chefOrder_Load(object sender, EventArgs e)
        {
            gunaButton1.Visible = false;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        public void LoadOrderItems(int orderId, chefOrder orderControl)
        {
            string query = "SELECT f.image, f.name, oi.quantity " +
                           "FROM [dbo].[orderItem] oi " +
                           "INNER JOIN [dbo].[food] f ON oi.food_id = f.Id " +
                           "WHERE oi.order_id = @orderId";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@orderId", orderId);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable orderItemsTable = new DataTable();
            adapter.Fill(orderItemsTable);

            flowLayoutPanel1.Controls.Clear();

            foreach (DataRow row in orderItemsTable.Rows)
            {
                orderitem itemControl = new orderitem
                {
                    FoodImage = Image.FromFile(row["image"].ToString()), // Assuming the image path is stored
                    FoodName1 = row["name"].ToString(),
                    quantity = row["quantity"].ToString()
                };

                flowLayoutPanel1.Controls.Add(itemControl);
            }
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            UpdateOrderStatus("done");
            gunaButton1.Visible = true;
            gunaButton2.Visible = false;
        }

        private void label15_Click(object sender, EventArgs e)
        {
        }

        private void label16_Click(object sender, EventArgs e)
        {
        }

        private void orderitem1_Load(object sender, EventArgs e)
        {
        }
    }
}