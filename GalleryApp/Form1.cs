using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalleryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-VGJQ4HL;Initial Catalog=GalleryApp;Integrated Security=True");
            string query = "select * from images";
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, sqlcon);
            DataTable dataTable = new DataTable();
            sqlAdapter.Fill(dataTable);


            for (int i = 0;i<dataTable.Rows.Count;i++)
            {
                listBox1.Items.Add(dataTable.Rows[i][1]);
            }
            
        }

        private void imagesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.imagesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.galleryAppDataSet1);
            MessageBox.Show("Image Saved.");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'galleryAppDataSet1.Images' table. You can move, or remove it, as needed.
            this.imagesTableAdapter.Fill(this.galleryAppDataSet1.Images);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image only. | *.jpg; *.jpeg; *.png; *.gif;";

            
            DialogResult dialogResult = openFile.ShowDialog();
            imgPictureBox.Image = Image.FromFile(openFile.FileName);
            image_pathLabel1.Text = openFile.FileName;
            image_idLabel1.Text = bindingNavigatorPositionItem.Text;
        }

 

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-VGJQ4HL;Initial Catalog=GalleryApp;Integrated Security=True");
            string query = "select img from images";
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, sqlcon);
            DataTable dataTable = new DataTable();
            sqlAdapter.Fill(dataTable);

            if (listBox1.SelectedIndex >= 0)
            {
                byte[] data = (byte[])dataTable.Rows[listBox1.SelectedIndex][0];
                MemoryStream ms = new MemoryStream(data);
                MessageForm messageForm = new MessageForm(Image.FromStream(ms));
                messageForm.Show();

            }
        }
    }
}
