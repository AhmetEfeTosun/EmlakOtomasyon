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
    public class DistrictDAL
    {
        public void Add(District district)
        {
            Database.OpenConnection();

            SqlCommand cmd = new SqlCommand("INSERT INTO Districts(CityId,DistrictName) " +
                 "values(@CityId," +
                        "@DistrictName)", Database.connection);

            cmd.Parameters.AddWithValue("@CityId", district.CityId);
            cmd.Parameters.AddWithValue("@DistrictName", district.DistrictName);

            cmd.ExecuteNonQuery();

            Database.CloseConnection();
        }

        public void Delete(District district)
        {
            Database.OpenConnection();

            SqlCommand cmd = new SqlCommand("DELETE Districts WHERE Id = @Id ", Database.connection);

            cmd.Parameters.AddWithValue("@Id", district.Id);
            cmd.ExecuteNonQuery();

            Database.CloseConnection();
        }

        public List<District> GetAll()
        {
            List<District> districts = new List<District>();
            Database.OpenConnection();

            string strQuery = "SELECT * FROM Districts";
            SqlCommand cmd = new SqlCommand(strQuery, Database.connection);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    District district = new District()
                    {
                        Id = Convert.ToInt32(dr["Id"].ToString()),
                        CityId = Convert.ToInt32(dr["CityId"].ToString()),
                        DistrictName = dr["DistrictName"].ToString(),

                    };
                    districts.Add(district);
                }
            }

            Database.CloseConnection();
            return districts;
        }

        public void Update(District district)
        {
            Database.OpenConnection();

            SqlCommand cmd = new SqlCommand("UPDATE Districts SET " +
                "CityId = @CityId," +
                "DistrictName = @DistrictName)" +
                " WHERE Id = @Id ", Database.connection);

            cmd.Parameters.AddWithValue("@Id", district.Id);
            cmd.Parameters.AddWithValue("@CityId", district.CityId);
            cmd.Parameters.AddWithValue("@DistrictName", district.DistrictName);
            cmd.ExecuteNonQuery();

            Database.CloseConnection();
        }
    }
}
