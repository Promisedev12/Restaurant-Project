using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Restoran_Project
{
    public partial class AddFood : UserControl
    {
        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Resturant internship Project\projectDB.mdf;Integrated Security=True;Connect Timeout=30");

        public AddFood()
        {
            InitializeComponent();
        }

        private void AddFood_Load(object sender, EventArgs e)
        {
            string query = "SELECT id, name FROM menue";
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                gunaComboBox1.DataSource = dataTable;
                gunaComboBox1.DisplayMember = "name";
                gunaComboBox1.ValueMember = "id";
            }
            if (gunaComboBox1.SelectedValue != null)
            {
                //int menuID = (int)gunaComboBox1.SelectedValue;
                var valu = gunaComboBox1.SelectedValue;
                if (!(valu is DataRowView))
                {
                    //MessageBox.Show("SelectedValue:'" + valu + "', Type: '" + valu.GetType() + "'");
                    int menuID = (int)gunaComboBox1.SelectedValue;
                    string query1 = "SELECT name , id  FROM [dbo].[cathegory] WHERE menu_id = @MenuID";
                    SqlDataAdapter da = new SqlDataAdapter(query1, con);
                    da.SelectCommand.Parameters.AddWithValue("@MenuID", menuID);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    gunaComboBox2.DisplayMember = "name";
                    gunaComboBox2.ValueMember = "id";
                    gunaComboBox2.DataSource = dt;
                }
            }
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gunaComboBox1.SelectedValue != null)
            {
                //int menuID = (int)gunaComboBox1.SelectedValue;
                var valu = gunaComboBox1.SelectedValue;
                if (!(valu is DataRowView))
                {
                    //MessageBox.Show("SelectedValue:'" + valu + "', Type: '" + valu.GetType() + "'");
                    int menuID = (int)gunaComboBox1.SelectedValue;
                    string query = "SELECT name , id  FROM [dbo].[cathegory] WHERE menu_id = @MenuID";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@MenuID", menuID);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    gunaComboBox2.DisplayMember = "name";
                    gunaComboBox2.ValueMember = "id";
                    gunaComboBox2.DataSource = dt;
                }
            }
        }

        private void gunaComboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        public static string txtImagePath = "";

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "image files (*.png)|*.png|(*.jpg)|*.jpg|(*.gif)|*.gif|All files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                gunaCirclePictureBox1.Image = new Bitmap(ofd.FileName);
                txtImagePath = ofd.FileName;
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (gunaCirclePictureBox1.Image != null && !string.IsNullOrEmpty(gunaTextBox1.Text))
            {
                string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

                string folderPath = Path.Combine(appDirectory, "images/foods");

                string FileName = Path.GetFileName(txtImagePath);
                string savePath = Path.Combine(folderPath, FileName);

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                gunaCirclePictureBox1.Image.Save(savePath);

                if (!string.IsNullOrEmpty(gunaTextBox1.Text) && gunaComboBox2.SelectedValue != null && gunaCirclePictureBox1.Image != null && !string.IsNullOrEmpty(gunaTextBox2.Text) && !string.IsNullOrEmpty(gunaTextBox3.Text))
                {
                    int selectedCategoryId = (int)gunaComboBox2.SelectedValue;

                    string name = gunaTextBox1.Text;

                    string description = gunaTextBox2.Text;
                    string price = gunaTextBox3.Text;

                    string query = "INSERT INTO [dbo].[food] (name, description, price, cathegory_id, image) VALUES (@name, @description, @price, @cathegory_id, @image)";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@description", description);
                        command.Parameters.AddWithValue("@price", price);
                        command.Parameters.AddWithValue("@cathegory_id", selectedCategoryId);
                        command.Parameters.AddWithValue("@image", savePath);
                        con.Open();
                        command.ExecuteNonQuery();
                        con.Close();
                    }

                    MessageBox.Show("Food added successfully!");
                }
                else
                {
                    MessageBox.Show("Please enter an item name and select a category.");
                }
            }
            else
            {
                MessageBox.Show("Make sure you fill in all fields");
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            gunaCirclePictureBox1.Image = null;
            gunaTextBox1.Text = "";
            gunaTextBox2.Text = "";
            gunaTextBox3.Text = "";
            gunaComboBox2.DataSource = null;
        }
    }
}