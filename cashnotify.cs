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
    public partial class cashnotify : UserControl
    {
        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Resturant internship Project\projectDB.mdf;Integrated Security=True;Connect Timeout=30");

        public cashnotify()
        {
            InitializeComponent();
        }

        private void cashnotify_Load(object sender, EventArgs e)
        {
            loadNotify();
        }

        private void loadNotify()
        {
            string query = "SELECT Id, table_id,  amount, timestamp " +
                           "FROM [dbo].[orders]" +
                           "WHERE status = 'Pending' " +
                           "ORDER BY timestamp ASC";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable ordersTable = new DataTable();
            adapter.Fill(ordersTable);

            flowLayoutPanel1.Controls.Clear();
            foreach (DataRow row in ordersTable.Rows)
            {
                cashitem cashitem = new cashitem();

                cashitem.orderId = (int)row["Id"];
                cashitem.tableNumber = row["table_id"].ToString();
                cashitem.amount = row["amount"].ToString();

                flowLayoutPanel1.Controls.Add(cashitem);
            }
        }
    }
}