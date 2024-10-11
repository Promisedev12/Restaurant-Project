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
    public partial class cathegoryadd : UserControl
    {
        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Resturant internship Project\projectDB.mdf;Integrated Security=True;Connect Timeout=30");

        public cathegoryadd()
        {
            InitializeComponent();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public static string txtImagePath = "";

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "image files (*.png)|*.png|(*.jpg)|(*.jpg|(*.gif)|*.gif|All files(*.*)|*.*";
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

                string folderPath = Path.Combine(appDirectory, "images/cathegories");

                string FileName = Path.GetFileName(txtImagePath);
                string savePath = Path.Combine(folderPath, FileName);

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                gunaCirclePictureBox1.Image.Save(savePath);

                if (!string.IsNullOrEmpty(gunaTextBox1.Text) && gunaComboBox1.SelectedValue != null && gunaCirclePictureBox1.Image != null)
                {
                    int selectedCategoryId = (int)gunaComboBox1.SelectedValue;

                    string cathegoryName = gunaTextBox1.Text;

                    string query = "INSERT INTO [dbo].[cathegory] (name, menu_id, image) VALUES (@name, @menu_id, @image)";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("name", cathegoryName);
                        command.Parameters.AddWithValue("@menu_id", selectedCategoryId);
                        command.Parameters.AddWithValue("@image", savePath);
                        con.Open();
                        command.ExecuteNonQuery();
                        con.Close();
                    }

                    MessageBox.Show("Item added successfully!");
                }
                else
                {
                    MessageBox.Show("Please enter an item name and select a category.");
                }
            }
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void gunaGradient2Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void cathegoryadd_Load(object sender, EventArgs e)
        {
            string query = "SELECT id , name FROM menue";
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                gunaComboBox1.DataSource = dataTable;
                gunaComboBox1.DisplayMember = "name";
                gunaComboBox1.ValueMember = "id";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void gunaComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }
    }
}