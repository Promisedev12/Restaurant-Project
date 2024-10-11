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
    public partial class chefdash : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Resturant internship Project\projectDB.mdf;Integrated Security=True;Connect Timeout=30");

        public chefdash()
        {
            InitializeComponent();
        }

        public int userId { get; set; }

        private void chefdash_Load(object sender, EventArgs e)
        {
            LoadPendingOrders();
        }

        public void LoadPendingOrders()
        {
            string query = "SELECT o.Id, o.table_id, o.date, o.amount, o.timestamp " +
                           "FROM [dbo].[orders] o " +
                           "WHERE o.status = 'pending' AND o.paid = 'true' " +
                           "ORDER BY o.timestamp ASC";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable ordersTable = new DataTable();
            adapter.Fill(ordersTable);

            flowLayoutPanel1.Controls.Clear();

            foreach (DataRow row in ordersTable.Rows)
            {
                chefOrder orderControl = new chefOrder
                {
                    TableNumber = row["table_id"].ToString(),
                    orderID = (int)row["Id"],
                    userId = userId
                };

                int orderId = (int)row["Id"];
                orderControl.LoadOrderItems(orderId, orderControl);

                flowLayoutPanel1.Controls.Add(orderControl);
            }
        }

        private void gunaLabel40_Click(object sender, EventArgs e)
        {
        }
    }
}