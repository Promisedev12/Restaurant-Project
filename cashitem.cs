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
    public partial class cashitem : UserControl
    {
        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Resturant internship Project\projectDB.mdf;Integrated Security=True;Connect Timeout=30");

        public cashitem()
        {
            InitializeComponent();
        }

        public int orderId { get; set; }

        public string tableNumber
        {
            get { return label15.Text; }
            set { label15.Text = value; }
        }

        public string amount
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void gunaGradient2Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            update("selected");
            gunaButton3.Visible = false;
            gunaButton1.Visible = true;
        }

        private void update(string input)
        {
            string query = "UPDATE orders SET paid = @input WHERE Id = @OrderId";

            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                adapter.UpdateCommand = new SqlCommand(query, con);
                adapter.UpdateCommand.Parameters.AddWithValue("@OrderId", orderId);
                adapter.UpdateCommand.Parameters.AddWithValue("@input", input);
                con.Open();
                adapter.UpdateCommand.ExecuteNonQuery();
                con.Close();
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            update("true");
            this.Parent.Controls.Remove(this);
        }

        private void cashitem_Load(object sender, EventArgs e)
        {
            gunaButton1.Visible = false;
        }
    }
}