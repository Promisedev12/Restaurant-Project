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
    public partial class waiterDash : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Resturant internship Project\projectDB.mdf;Integrated Security=True;Connect Timeout=30");

        public waiterDash()
        {
            InitializeComponent();
        }

        private void waiterDash_Load(object sender, EventArgs e)
        {
        }

        public int orderID { get; set; }
        public int userId { get; set; }
    }
}