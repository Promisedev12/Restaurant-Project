using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class availablewaiter : UserControl
    {
        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Resturant internship Project\projectDB.mdf;Integrated Security=True;Connect Timeout=30");

        public availablewaiter()
        {
            InitializeComponent();
        }

        public int userId { get; set; }

        private void availablewaiter_Load(object sender, EventArgs e)
        {
            var parentform = this.ParentForm as waiterDash;
            if (parentform != null)
            {
                this.userId = parentform.userId;
            }
            LoadPendingOrders();
        }

        public void LoadPendingOrders()
        {
            string query = "SELECT o.Id, o.table_id, o.date, o.amount, o.timestamp " +
                           "FROM [dbo].[orders] o " +
                           "WHERE o.status = 'done' AND o.paid = 'true' " +
                           "ORDER BY o.timestamp ASC";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable ordersTable = new DataTable();
            adapter.Fill(ordersTable);

            flowLayoutPanel1.Controls.Clear();

            foreach (DataRow row in ordersTable.Rows)
            {
                orderWaiter orderControl = new orderWaiter
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}