using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Restoran_Project
{
    public partial class addmenue : UserControl
    {
        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Resturant internship Project\projectDB.mdf;Integrated Security=True;Connect Timeout=30");

        public addmenue()
        {
            InitializeComponent();
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

                string folderPath = Path.Combine(appDirectory, "images/menue");

                string FileName = Path.GetFileName(txtImagePath);
                string savePath = Path.Combine(folderPath, FileName);

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                gunaCirclePictureBox1.Image.Save(savePath);

                string query = "INSERT INTO dbo.[menue] (name, image) VALUES (@name, @image)";
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@name", gunaTextBox1.Text);
                    command.Parameters.AddWithValue("@image", savePath);

                    con.Open();
                    adapter.InsertCommand = command;
                    adapter.InsertCommand.ExecuteNonQuery();
                    con.Close();
                }

                MessageBox.Show("Menue added successfully!");
            }
            else
            {
                MessageBox.Show("Please select an image and enter the menue name.");
            }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            gunaCirclePictureBox1.Image = null;
            gunaTextBox1.Text = "";
        }

        private void addmenue_Load(object sender, EventArgs e)
        {
        }
    }
}