using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakOtomasyon
{
    public partial class Form2 : Form
    {
        List<Listing> listings = new List<Listing>();
        List<City> cities = new List<City>();
        List<District> districts = new List<District>();

        Listing filter = new Listing();
        Listing recordedListing = new Listing();

        ListingDAL listingDal = new ListingDAL();
        CityDAL cityDal = new CityDAL();
        DistrictDAL districtDal = new DistrictDAL();

        public Form2()
        {
            InitializeComponent();
        }

        public void ClearData()
        {
            cityCmb.SelectedItem = null;
            districtCmb.SelectedItem = null;
            titleTxtBox.Clear();
            descriptionTxtBox.Clear();
            priceTxtBox.Clear();
            squareMeterTxtBox.Clear();
        }

        public void DisplayData()
        {
            filter = new Listing();

            if(filterCityCmb.SelectedItem != null && !string.IsNullOrEmpty(filterCityCmb.SelectedItem.ToString()))          
                filter.CityId = cities.Find(item => item.CityName == filterCityCmb.SelectedItem.ToString()).Id;

            if (filterDistrictCmb.SelectedItem != null && !string.IsNullOrEmpty(filterDistrictCmb.SelectedItem.ToString()))
                filter.DistrictId = districts.Find(item => item.DistrictName == filterDistrictCmb.SelectedItem.ToString()).Id;

            filter.MinPrice = Convert.ToInt32(minPriceNumeric.Value.ToString());
            filter.MaxPrice = Convert.ToInt32(maxPriceNumeric.Value.ToString());

            filter.MinSquareMeter = Convert.ToInt32(minSquareNumeric.Value.ToString());
            filter.MaxSquareMeter = Convert.ToInt32(maxSquareNumeric.Value.ToString());

            listings.Clear();
            listings = listingDal.GetAllWithFilter(filter);
            listingGrid.DataSource = listings;

            listingGrid.Columns["ListingId"].Visible = false;
            listingGrid.Columns["CityId"].Visible = false;
            listingGrid.Columns["DistrictId"].Visible = false;
            listingGrid.Columns["MinPrice"].Visible = false;
            listingGrid.Columns["MaxPrice"].Visible = false;
            listingGrid.Columns["MinSquareMeter"].Visible = false;
            listingGrid.Columns["MaxSquareMeter"].Visible = false;


            ClearData();
        }

        public void FillComboBox()
        {
            cities = cityDal.GetAll();
            districts = districtDal.GetAll();

            foreach (City city in cities)            
                cityCmb.Items.Add(city.CityName);

            foreach (City city in cities)
                filterCityCmb.Items.Add(city.CityName);
        }

        private void listBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayData();
            }
            catch (Exception)
            {
                MessageBox.Show("Veriler yüklenirken hata oluştu !");
            }
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Listing listing = new Listing();

                string selectedCity = cityCmb.SelectedItem.ToString();
                string selectedDistrict = districtCmb.SelectedItem.ToString();


                listing.CityId = cities.Find(item => item.CityName == selectedCity).Id;
                listing.DistrictId = districts.Find(item => item.DistrictName == selectedDistrict).Id;
                listing.Title = titleTxtBox.Text;
                listing.Description = descriptionTxtBox.Text;
                listing.Price = Convert.ToDouble(priceTxtBox.Text);
                listing.SquareMeter = Convert.ToInt32(squareMeterTxtBox.Text);
                listing.Date = DateTime.Now;
                listing.Status = true;

                listingDal.Add(listing);
                DisplayData();

                MessageBox.Show("Yeni kayıt eklendi ! ");

            }
            catch (Exception)
            {
                MessageBox.Show("Yeni kayıt eklenirken hata oluştu !");
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            FillComboBox();
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            try
            {

                recordedListing.CityId = cities.Find(item => item.CityName == cityCmb.SelectedItem.ToString()).Id;
                recordedListing.DistrictId = districts.Find(item => item.DistrictName == districtCmb.SelectedItem.ToString()).Id;
                recordedListing.Title = titleTxtBox.Text;
                recordedListing.Description = descriptionTxtBox.Text;
                recordedListing.Price = Convert.ToDouble(priceTxtBox.Text);
                recordedListing.SquareMeter = Convert.ToInt32(squareMeterTxtBox.Text);
                recordedListing.Date = DateTime.Now;

                listingDal.Update(recordedListing);
                DisplayData();
                MessageBox.Show("Seçilen kayıt başarıyla güncellendi !");
            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme işlemi yapılırken hata oluştu! ");
            }

        }

        private void listingGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            recordedListing.ListingId = Convert.ToInt32(listingGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            recordedListing.CityId = Convert.ToInt32(listingGrid.Rows[e.RowIndex].Cells[1].Value.ToString());
            recordedListing.DistrictId = Convert.ToInt32(listingGrid.Rows[e.RowIndex].Cells[2].Value.ToString());
            recordedListing.Title = listingGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            recordedListing.Description = listingGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            recordedListing.Price = Convert.ToInt32(listingGrid.Rows[e.RowIndex].Cells[5].Value.ToString());
            recordedListing.Date = Convert.ToDateTime(listingGrid.Rows[e.RowIndex].Cells[6].Value.ToString());
            recordedListing.SquareMeter = Convert.ToInt32(listingGrid.Rows[e.RowIndex].Cells[7].Value.ToString());
            recordedListing.Status = Convert.ToBoolean(listingGrid.Rows[e.RowIndex].Cells[8].Value.ToString());

            cityCmb.SelectedItem = cities.Find(item => item.Id == recordedListing.CityId).CityName;
            districtCmb.SelectedItem = districts.Find(item => item.Id == recordedListing.DistrictId).DistrictName;
            titleTxtBox.Text = recordedListing.Title.ToString();
            descriptionTxtBox.Text = recordedListing.Description.ToString();
            priceTxtBox.Text = recordedListing.Price.ToString();
            squareMeterTxtBox.Text = recordedListing.SquareMeter.ToString();
        }

        private void SilBtn_Click(object sender, EventArgs e)
        {
            try
            {
                listingDal.Delete(recordedListing);
                DisplayData();
                MessageBox.Show("Seçilen kayıt başarıyla silindi ! ");
            }
            catch (Exception)
            {
                MessageBox.Show("Silme işleminde hata oluştu ! ");
            }
        }

        private void filterCityCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterCityCmb.SelectedItem != null)
            {
                int cityId = cities.Find(item => item.CityName == filterCityCmb.SelectedItem.ToString()).Id;
                List<District> filteredDistricts = districts.FindAll(item => item.CityId == cityId);

                filterDistrictCmb.Items.Clear();

                foreach (District district in filteredDistricts)
                    filterDistrictCmb.Items.Add(district.DistrictName);
            }
        }

        private void cityCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cityCmb.SelectedItem != null)
            {
                int cityId = cities.Find(item => item.CityName == cityCmb.SelectedItem.ToString()).Id;
                List<District> filteredDistricts = districts.FindAll(item => item.CityId == cityId);

                districtCmb.Items.Clear();

                foreach (District district in filteredDistricts)
                    districtCmb.Items.Add(district.DistrictName);
            }
        }

        private void listingGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            recordedListing.ListingId = Convert.ToInt32(listingGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            recordedListing.CityId = Convert.ToInt32(listingGrid.Rows[e.RowIndex].Cells[1].Value.ToString());
            recordedListing.DistrictId = Convert.ToInt32(listingGrid.Rows[e.RowIndex].Cells[2].Value.ToString());
            recordedListing.Title = listingGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            recordedListing.Description = listingGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            recordedListing.Price = Convert.ToInt32(listingGrid.Rows[e.RowIndex].Cells[5].Value.ToString());
            recordedListing.Date = Convert.ToDateTime(listingGrid.Rows[e.RowIndex].Cells[6].Value.ToString());
            recordedListing.SquareMeter = Convert.ToInt32(listingGrid.Rows[e.RowIndex].Cells[7].Value.ToString());
            recordedListing.Status = Convert.ToBoolean(listingGrid.Rows[e.RowIndex].Cells[8].Value.ToString());

            Form3 detailForm = new Form3(recordedListing);
            this.Hide();
            detailForm.ShowDialog();
            this.Close();
        }
    }
}
