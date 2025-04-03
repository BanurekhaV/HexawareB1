using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Connected_prj2.DataAccessLayer;

namespace Connected_prj2.Business_Layer
{
    internal class RegionClass
    {
        ConnectionClass connectionClass = new ConnectionClass();
        SqlDataReader reader;
        public SqlDataReader DisplayRegion()
        {
            reader =  connectionClass.DisplayRegion();
            return reader;
        }

        public SqlDataReader GetRegionByID(int rid)
        {
            reader = connectionClass.GetRegionById(rid);
            return reader;
        }
    }
}
