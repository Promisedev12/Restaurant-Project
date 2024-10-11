using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using Guna.UI.WinForms;
using Restoran_Project;

namespace Restoran_Project
{
    public partial class Dashboard : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Resturant internship Project\projectDB.mdf;Integrated Security=True;Connect Timeout=30");

        public Dashboard()
        {
            InitializeComponent();
        }

        public int tableNumber { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadCathegories(1);
            loadFood(1);
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            foodCathegories1.Visible = false;
        }

        private void loadCathegories(int menuId)
        {
            string query = "SELECT id, name, image FROM [dbo].[cathegory] WHERE menu_id = @menuId";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@menuId", menuId);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable cathegoryTable = new DataTable();
            adapter.Fill(cathegoryTable);
            flowLayoutPanel2.Controls.Clear();

            foreach (DataRow row in cathegoryTable.Rows)
            {
                FoodCathegories foodCathegory = new FoodCathegories
                {
                    cathegoryName = row["name"].ToString(),
                    cathegoryImage = Image.FromFile(row["image"].ToString()),
                    cathegoryId = (int)row["id"]
                };
                foodCathegory.Click += FoodCathegories_Click;
                flowLayoutPanel2.Controls.Add(foodCathegory);
            }
        }

        private void FoodCathegories_Click(object sender, EventArgs e)
        {
            FoodCathegories clickedControl = sender as FoodCathegories;
            int cathegoryId = clickedControl.cathegoryId;
            loadFood(cathegoryId);
        }

        private void loadFood(int cathegoryId)
        {
            string query = "SELECT id, name, price, description, image FROM [dbo].[food] WHERE cathegory_id = @cathegory_id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@cathegory_id", cathegoryId);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable foodTable = new DataTable();
            adapter.Fill(foodTable);

            flowLayoutPanel1.Controls.Clear();

            foreach (DataRow row in foodTable.Rows)
            {
                foodCard foods = new foodCard
                {
                    foodName = row["name"].ToString(),
                    foodPrice = row["price"].ToString(),
                    foodDescription = row["description"].ToString(),
                    foodImage = Image.FromFile(row["image"].ToString())
                };

                foods.Tag = row["id"];

                foods.AddOrderRequested += AddOrderHandler;
                foods.RemoveOrderRequested += RemoveOrderHandler;

                flowLayoutPanel1.Controls.Add(foods);
            }
        }

        private void AddOrderHandler(object sender, EventArgs e)
        {
            foodCard selectedFoodCard = sender as foodCard;
            if (selectedFoodCard != null)
            {
                // Check if the food item is already in the order list
                foreach (Control control in flowLayoutPanel4.Controls)
                {
                    if (control is newOrder existingOrder && (int)existingOrder.Tag == (int)selectedFoodCard.Tag)
                    {
                        existingOrder.IncrementQuantity();
                        UpdateTotalCost();
                        return;
                    }
                }

                // If the item is not found, add it as a new instance
                newOrder orderControl = new newOrder
                {
                    FoodName = selectedFoodCard.foodName,
                    FoodPrice = selectedFoodCard.foodPrice,
                    FoodId = (int)selectedFoodCard.Tag
                };

                orderControl.Tag = selectedFoodCard.Tag;
                orderControl.QuantityChanged += OrderControl_QuantityChanged;
                orderControl.ItemRemoved += OrderControl_ItemRemoved;
                orderControl.IncrementQuantity();
                flowLayoutPanel4.Controls.Add(orderControl);
                UpdateTotalCost();
            }
        }

        private void RemoveOrderHandler(object sender, EventArgs e)
        {
            foodCard selectedFoodCard = sender as foodCard;

            if (selectedFoodCard != null)
            {
                foreach (Control control in flowLayoutPanel4.Controls)
                {
                    if (control is newOrder orderControl && (int)orderControl.Tag == (int)selectedFoodCard.Tag)
                    {
                        flowLayoutPanel4.Controls.Remove(orderControl);
                        UpdateTotalCost();
                        break;
                    }
                }
            }
        }

        // Event handler when quantity changes
        private void OrderControl_QuantityChanged(object sender, EventArgs e)
        {
            UpdateTotalCost();
        }

        // Event handler when an item is removed
        private void OrderControl_ItemRemoved(object sender, EventArgs e)
        {
            newOrder removedOrder = sender as newOrder;
            if (removedOrder != null)
            {
                flowLayoutPanel4.Controls.Remove(removedOrder);
                UpdateTotalCost();
            }
        }

        // Calculate and update the total cost
        private void UpdateTotalCost()
        {
            decimal totalCost = 0;

            foreach (Control control in flowLayoutPanel4.Controls)
            {
                if (control is newOrder orderControl)
                {
                    decimal foodPrice = decimal.Parse(orderControl.FoodPrice);
                    int quantity = orderControl.Quantity;
                    totalCost += foodPrice * quantity;
                }
            }

            gunaLabel32.Text = totalCost.ToString("C");
        }

        private void getFoodOrders()
        {
            gunaLabel32.Text = flowLayoutPanel4.Controls.Count > 0 ? "3000" : "0";
        }

        private void gunaGradientTileButton2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            loadCathegories(2);
        }

        private void gunaGradientTileButton4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            loadCathegories(3);
        }

        private void gunaGradientTileButton3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            loadCathegories(4);
        }

        private void gunaGradientTileButton5_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            loadCathegories(5);
        }

        private void gunaGradientTileButton1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            loadCathegories(1);
        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void gunaElipsePanel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Random random = new Random();
                int orderId = random.Next(100000, 999999);

                string currentDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                decimal totalAmount = decimal.Parse(gunaLabel32.Text, System.Globalization.NumberStyles.Currency);

                string status = "Pending";

                string insertOrderQuery = "INSERT INTO [dbo].[orders] (Id, table_id, date, status, amount) VALUES (@Id, @table_id, @date, @status, @amount)";
                SqlCommand insertOrderCmd = new SqlCommand(insertOrderQuery, con);
                insertOrderCmd.Parameters.AddWithValue("@Id", orderId);
                insertOrderCmd.Parameters.AddWithValue("@table_id", tableNumber);
                insertOrderCmd.Parameters.AddWithValue("@date", currentDate);
                insertOrderCmd.Parameters.AddWithValue("@status", status);
                insertOrderCmd.Parameters.AddWithValue("@amount", totalAmount);

                con.Open();
                insertOrderCmd.ExecuteNonQuery();

                foreach (Control control in flowLayoutPanel4.Controls)
                {
                    if (control is newOrder orderControl)
                    {
                        int foodId = orderControl.FoodId;
                        int quantity = orderControl.Quantity;

                        string insertOrderItemQuery = "INSERT INTO [dbo].[orderItem] (order_id, food_id,quantity) VALUES (@order_id, @food_id, @quantity)";
                        SqlCommand insertOrderItemCmd = new SqlCommand(insertOrderItemQuery, con);
                        insertOrderItemCmd.Parameters.AddWithValue("@order_id", orderId);
                        insertOrderItemCmd.Parameters.AddWithValue("@food_id", foodId);

                        insertOrderItemCmd.Parameters.AddWithValue("@quantity", quantity);
                        insertOrderItemCmd.ExecuteNonQuery();
                    }
                }

                payments payments = new payments();
                payments.orderID = orderId;
                payments.total = totalAmount.ToString("C");
                payments.Show();
                payments.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}