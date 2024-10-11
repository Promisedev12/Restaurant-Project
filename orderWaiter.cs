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
    public partial class orderWaiter : UserControl
    {
        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Resturant internship Project\projectDB.mdf;Integrated Security=True;Connect Timeout=30");

        public orderWaiter()
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
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
        }

        private void UpdateOrderStatus(string status)
        {
            if (status == "funished")
            {
                AddWaiterfOrder();
                this.Parent.Controls.Remove(this);
                (this.Parent as availablewaiter)?.LoadPendingOrders();
            }
            string query = "UPDATE [dbo].[orders] SET status = @status WHERE Id = @orderId";

            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Achu Promise\Downloads\Resturant internship Project\resturantProject.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@orderId", orderID);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void AddWaiterfOrder()
        {
            string query = "INSERT INTO [dbo].[waiterOrder] (waiter_ID, order_id) VALUES (@chefId, @orderId)";

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

        public void LoadOrderItems(int orderId, orderWaiter orderControl)
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
                    FoodImage = Image.FromFile(row["image"].ToString()),
                    FoodName1 = row["name"].ToString(),
                    quantity = row["quantity"].ToString()
                };

                flowLayoutPanel1.Controls.Add(itemControl);
            }
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
        }

        private void gunaButton2_Click_1(object sender, EventArgs e)
        {
            UpdateOrderStatus("Holding");
            gunaButton2.Visible = false;
            gunaButton1.Visible = true;
        }

        private void gunaButton1_Click_2(object sender, EventArgs e)
        {
            UpdateOrderStatus("funished");
            gunaButton1.Visible = true;
            gunaButton2.Visible = false;
        }

        private void orderWaiter_Load(object sender, EventArgs e)
        {
            var parentControl = this.Parent as availablewaiter;
            if (parentControl != null)
            {
                this.userId = parentControl.userId;
            }
        }
    }
}