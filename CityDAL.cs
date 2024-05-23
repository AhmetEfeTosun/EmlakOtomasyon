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
    public class CityDAL
    {
        public void Add(City city)
        {
            Database.OpenConnection();

            SqlCommand cmd = new SqlCommand("INSERT INTO Cities(CityName) " +
                 "values(@CityName)", Database.connection);

            cmd.Parameters.AddWithValue("@CityName", city.CityName);
            cmd.ExecuteNonQuery();

            Database.CloseConnection();
        }

        public void Delete(City city)
        {
            Database.OpenConnection();

            SqlCommand cmd = new SqlCommand("DELETE Cities WHERE Id = @Id ", Database.connection);

            cmd.Parameters.AddWithValue("@Id", city.Id);
            cmd.ExecuteNonQuery();

            Database.CloseConnection();
        }

        public List<City> GetAll()
        {
            List<City> cities = new List<City>();
            Database.OpenConnection();

            string strQuery = "SELECT * FROM Cities";
            SqlCommand cmd = new SqlCommand(strQuery, Database.connection);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    City city = new City()
                    {
                        Id = Convert.ToInt32(dr["Id"].ToString()),
                        CityName = dr["CityName"].ToString(),

                    };
                    cities.Add(city);
                }
            }

            Database.CloseConnection();
            return cities;
        }

        public void Update(City city)
        {
            Database.OpenConnection();

            SqlCommand cmd = new SqlCommand("UPDATE Cities SET " +
                "CityName = @CityName)" +
                " WHERE Id = @Id ", Database.connection);

            cmd.Parameters.AddWithValue("@Id", city.Id);
            cmd.Parameters.AddWithValue("@CityName", city.CityName);
            cmd.ExecuteNonQuery();

            Database.CloseConnection();
        }
    }
}
