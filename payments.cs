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

//using System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Restoran_Project
{
    public partial class payments : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Resturant internship Project\projectDB.mdf;Integrated Security=True;Connect Timeout=30");

        public payments()
        {
            InitializeComponent();
        }

        public int orderID { get; set; }

        public string total
        {
            get { return label5.Text; }
            set { label5.Text = value; }
        }

        private void payments_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            gunaButton3.Visible = false;
            string query = "SELECT f.image AS foodImage, f.price AS foodPrice, f.name AS foodName, oi.quantity FROM [dbo].[orderItem] oi JOIN [dbo].[food] f ON oi.food_id = f.Id  WHERE oi.order_id = '" + orderID + "'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            flowLayoutPanel1.Controls.Clear();

            foreach (DataRow row in dataTable.Rows)
            {
                itermdetails itermdetails = new itermdetails();

                itermdetails.FoodImage = LoadImage(row["FoodImage"].ToString());

                itermdetails.FoodName1 = row["foodName"].ToString();
                itermdetails.Price = row["foodPrice"].ToString();
                itermdetails.quantity = row["quantity"].ToString();

                flowLayoutPanel1.Controls.Add(itermdetails);
            }
        }

        private Image LoadImage(string imagePath)
        {
            try
            {
                return Image.FromFile(imagePath);
            }
            catch
            {
                return null; // Handle errors appropriately
            }
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gunaComboBox1.Text == "Momo" || gunaComboBox1.Text == "Omo")
            {
                label3.Visible = true;
                textBox1.Visible = true;
                label4.Visible = false;
                gunaButton1.Visible = true;
                gunaButton3.Visible = false;
            }
            else if (gunaComboBox1.Text == "Cash")
            {
                label4.Visible = true;
                label3.Visible = false;
                textBox1.Visible = false;
                gunaButton1.Visible = false;
                gunaButton3.Visible = true;
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            //Dashboard dd = new Dashboard();

            this.Hide();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string status = "true";
            con.Open();
            string query = "UPDATE [dbo].[orders] SET paid = '" + status + "', payment_method = '" + gunaComboBox1.Text + "' WHERE Id = '" + orderID + "'";
            SqlCommand updatStatus = new SqlCommand(query, con);
            updatStatus.ExecuteNonQuery();
            MessageBox.Show("Order Palced its on its way");
            con.Close();
            this.Hide();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE [dbo].[orders] SET  payment_method = '" + gunaComboBox1.Text + "' WHERE Id = '" + orderID + "'";
            SqlCommand updatStatus = new SqlCommand(query, con);
            updatStatus.ExecuteNonQuery();
            MessageBox.Show("A waiter is comming to collect your payments");
            con.Close();
            this.Hide();
        }
    }
}