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

namespace EmlakOtomasyon
{
    public partial class Form3 : Form
    {
        Listing _listing = new Listing();
        List<ListingImage> images = new List<ListingImage>();
        string selectedImage = string.Empty;
        int imageCounter = 0;

        public Form3(Listing listing)
        {
            InitializeComponent();
            _listing = listing;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Form2 listing = new Form2();
            this.Hide();
            listing.ShowDialog();
            this.Close();
        }

        public void DisplayImage()
        {
            selectedImage = images[imageCounter].ImagePath;
            imagePic.ImageLocation = @"img\" + selectedImage;
            imagePic.Show();
        }

        public void GetImages()
        {
            Database.OpenConnection();

            string strQuery = "SELECT * FROM ListingImages WHERE ListingId = @ListingId";
            SqlCommand cmd = new SqlCommand(strQuery, Database.connection);
            cmd.Parameters.AddWithValue("@ListingId", _listing.ListingId);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ListingImage image = new ListingImage()
                    {
                        ImagePath = dr["ImagePath"].ToString(),
                    };
                    images.Add(image);
                }
            }

            Database.CloseConnection();

            if (images.Any())
            {
                selectedImage = images[0].ImagePath;
                imageCounter = 0;
                DisplayImage();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            GetImages();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            imageCounter--;
            if (imageCounter < 0)
            {
                imageCounter = images.Count - 1;
            }
            DisplayImage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            imageCounter++;
            if (imageCounter == images.Count)
            {
                imageCounter = 0;
            }
            DisplayImage();
        }
    }
}
