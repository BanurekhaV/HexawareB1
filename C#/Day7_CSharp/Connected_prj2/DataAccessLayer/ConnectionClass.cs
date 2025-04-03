using Connected_prj2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connected_prj2.DataAccessLayer
{
    public class ConnectionClass
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataReader dr;


        public SqlConnection getConnection()
        {
            con = new SqlConnection("data source = Laptop-Tjj7d977;database = Northwind;trusted_connection = true;");
            con.Open();
            return con;
        }

        public SqlDataReader DisplayRegion()
        {
            con=getConnection();
            cmd = new SqlCommand("Select * from Region",con);
            dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader GetRegionById(int regionId)
        {
            con=getConnection();
            cmd = new SqlCommand("Select * from Region where RegionId = @regionId");
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@regionId",regionId);
            dr = cmd.ExecuteReader();
            return dr;
        }
                
    }
}
