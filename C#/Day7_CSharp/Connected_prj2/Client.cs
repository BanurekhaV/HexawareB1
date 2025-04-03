using Connected_prj2.Business_Layer;
using System.Data.SqlClient;

namespace Connected_prj2
{
    internal class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            RegionClass rc = new RegionClass();
            SqlDataReader readerobj = null;
            readerobj = rc.DisplayRegion();
            while(readerobj.Read())
            {
                Console.WriteLine(readerobj["RegionId"] + " " + readerobj["RegionDescription"]);
            }

            Console.WriteLine("Getting Region By Region ID");
            Console.WriteLine("Enter Region Id :");
            int reg_id =Convert.ToInt32(Console.ReadLine());

            readerobj = rc.GetRegionByID(reg_id);
            while(readerobj.Read())
            {
                Console.WriteLine(readerobj[0] + " " + readerobj[1]);
            }


            Console.Read(); 
        }
    }
}
