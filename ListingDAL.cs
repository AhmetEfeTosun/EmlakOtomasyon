using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;

namespace EmlakOtomasyon
{
    public class ListingDAL
    {
        public void Add(Listing listing)
        {
            Database.OpenConnection();

            SqlCommand cmd = new SqlCommand("INSERT INTO Listings(CityId,DistrictId,Title,Description,Price,Date,SquareMeter,Status) " +
                 "values(@CityId," +
                        "@DistrictId," +
                        "@Title," +
                        "@Description," +
                        "@Price," +
                        "@Date," +
                        "@SquareMeter," +
                        "@Status)", Database.connection);

            cmd.Parameters.AddWithValue("@CityId", listing.CityId);
            cmd.Parameters.AddWithValue("@DistrictId", listing.DistrictId);
            cmd.Parameters.AddWithValue("@Title", listing.Title);
            cmd.Parameters.AddWithValue("@Description", listing.Description);
            cmd.Parameters.AddWithValue("@Price", listing.Price);
            cmd.Parameters.AddWithValue("@Date", listing.Date);
            cmd.Parameters.AddWithValue("@SquareMeter", listing.SquareMeter);
            cmd.Parameters.AddWithValue("@Status", Convert.ToByte(listing.Status));
            cmd.ExecuteNonQuery();

            Database.CloseConnection();
        }

        public void Delete(Listing listing)
        {
            Database.OpenConnection();

            SqlCommand cmd = new SqlCommand("DELETE Listings WHERE ListingId = @ListingId ", Database.connection);

            cmd.Parameters.AddWithValue("@ListingId", listing.ListingId);
            cmd.ExecuteNonQuery();

            Database.CloseConnection();
        }

        public List<Listing> GetAll()
        {
            List<Listing> listings = new List<Listing>();
            Database.OpenConnection();

            string strQuery = "SELECT * FROM Listings";
            SqlCommand cmd = new SqlCommand(strQuery, Database.connection);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Listing listing = new Listing()
                    {
                        ListingId = Convert.ToInt32(dr["ListingId"].ToString()),
                        CityId = Convert.ToInt32(dr["CityId"].ToString()),
                        DistrictId = Convert.ToInt32(dr["DistrictId"].ToString()),
                        Title = dr["Title"].ToString(),
                        Description = dr["Description"].ToString(),
                        Price = Convert.ToDouble(dr["Price"].ToString()),
                        Date = Convert.ToDateTime(dr["Date"].ToString()),
                        SquareMeter = Convert.ToInt32(dr["SquareMeter"].ToString()),
                        Status = Convert.ToBoolean(dr["Status"].ToString()),
                    };
                    listings.Add(listing);
                }
            }

            Database.CloseConnection();
            return listings;
        }

        public List<Listing> GetAllWithCityAndDistrictName()
        {
            List<Listing> listings = new List<Listing>();
            Database.OpenConnection();

            string strQuery = "SELECT * FROM Listings listing " +
                "INNER JOIN Cities as city on listing.CityId = city.Id " +
                "INNER JOIN Districts as district on listing.DistrictId = district.Id";
            SqlCommand cmd = new SqlCommand(strQuery, Database.connection);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Listing listing = new Listing()
                    {
                        ListingId = Convert.ToInt32(dr["ListingId"].ToString()),
                        CityId = Convert.ToInt32(dr["CityId"].ToString()),
                        DistrictId = Convert.ToInt32(dr["DistrictId"].ToString()),
                        Title = dr["Title"].ToString(),
                        Description = dr["Description"].ToString(),
                        Price = Convert.ToDouble(dr["Price"].ToString()),
                        Date = Convert.ToDateTime(dr["Date"].ToString()),
                        SquareMeter = Convert.ToInt32(dr["SquareMeter"].ToString()),
                        Status = Convert.ToBoolean(dr["Status"].ToString()),
                        CityName = dr["CityName"].ToString(),
                        DistrictName = dr["DistrictName"].ToString(),
                    };
                    listings.Add(listing);
                }
            }

            Database.CloseConnection();
            return listings;
        }

        public List<Listing> GetAllWithFilter(Listing filter)
        {
            List<Listing> listings = new List<Listing>();
            Database.OpenConnection();

            string strQuery = "SELECT * FROM Listings listing " +
                "INNER JOIN Cities as city on listing.CityId = city.Id " +
                "INNER JOIN Districts as district on listing.DistrictId = district.Id WHERE 1=1 ";

            if (filter.CityId != 0)
                strQuery = strQuery + " AND city.Id = @cityId ";

            if (filter.DistrictId != 0)
                strQuery = strQuery + " AND district.Id = @districtId ";

            if (filter.MaxPrice != 0)                                   
                strQuery = strQuery + " AND listing.Price between @minPrice and @maxPrice ";

            if (filter.MaxSquareMeter != 0)
                strQuery = strQuery + " AND listing.SquareMeter between @minSquare and @maxSquare ";

            SqlCommand cmd = new SqlCommand(strQuery, Database.connection);
            cmd.Parameters.AddWithValue("@cityId", filter.CityId);
            cmd.Parameters.AddWithValue("@districtId", filter.DistrictId);
            cmd.Parameters.AddWithValue("@minPrice", filter.MinPrice);
            cmd.Parameters.AddWithValue("@maxPrice", filter.MaxPrice);
            cmd.Parameters.AddWithValue("@minSquare", filter.MinSquareMeter);
            cmd.Parameters.AddWithValue("@maxSquare", filter.MaxSquareMeter);

            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Listing listing = new Listing()
                    {
                        ListingId = Convert.ToInt32(dr["ListingId"].ToString()),
                        CityId = Convert.ToInt32(dr["CityId"].ToString()),
                        DistrictId = Convert.ToInt32(dr["DistrictId"].ToString()),
                        Title = dr["Title"].ToString(),
                        Description = dr["Description"].ToString(),
                        Price = Convert.ToDouble(dr["Price"].ToString()),
                        Date = Convert.ToDateTime(dr["Date"].ToString()),
                        SquareMeter = Convert.ToInt32(dr["SquareMeter"].ToString()),
                        Status = Convert.ToBoolean(dr["Status"].ToString()),
                        CityName = dr["CityName"].ToString(),
                        DistrictName = dr["DistrictName"].ToString(),
                    };
                    listings.Add(listing);
                }
            }

            Database.CloseConnection();
            return listings;
        }

        public void Update(Listing listing)
        {
            Database.OpenConnection();

            SqlCommand cmd = new SqlCommand("UPDATE Listings SET " +
                "CityId = @CityId," +
                "DistrictId = @DistrictId," +
                "Title = @Title," +
                "Description = @Description," +
                "Price = @Price," +
                "Date = @Date," +
                "SquareMeter = @SquareMeter," +
                "Status = @Status" +
                " WHERE ListingId = @ListingId ", Database.connection);

            cmd.Parameters.AddWithValue("@ListingId", listing.ListingId);
            cmd.Parameters.AddWithValue("@CityId", listing.CityId);
            cmd.Parameters.AddWithValue("@DistrictId", listing.DistrictId);
            cmd.Parameters.AddWithValue("@Title", listing.Title);
            cmd.Parameters.AddWithValue("@Description", listing.Description);
            cmd.Parameters.AddWithValue("@Price", listing.Price);
            cmd.Parameters.AddWithValue("@Date", listing.Date);
            cmd.Parameters.AddWithValue("@SquareMeter", listing.SquareMeter);
            cmd.Parameters.AddWithValue("@Status", Convert.ToByte(listing.Status));
            cmd.ExecuteNonQuery();

            Database.CloseConnection();
        }
    }
}
