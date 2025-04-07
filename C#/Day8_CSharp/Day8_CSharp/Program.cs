using System.Data;
using System.Data.SqlClient;

namespace Day8_CSharp
{
    internal class Program
    {
        static SqlConnection con;
        static SqlDataAdapter da;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            try
            {
                string connectstr = "Data Source=Laptop-Tjj7d977;Initial Catalog=Northwind;Integrated security=true";
                con = new SqlConnection(connectstr);
                da = new SqlDataAdapter("select * from region", con);
                con.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "NorthwindRegion");
                
                DataTable dt = ds.Tables["NorthwindRegion"];

                //to access the data in the datatable collection of the DataSet

                foreach (DataRow drow in dt.Rows)
                {
                    //to access the columns in the row
                    foreach (DataColumn dc in dt.Columns)
                    {
                        Console.Write(drow[dc] + " ");
                    }
                    Console.WriteLine();
                }

                //Console.WriteLine("---------Adding another DataTable to the DS ---------");
                //da=new SqlDataAdapter("Select * from shippers",con);
                //da.Fill(ds, "NorthwindShipper");

                //dt = ds.Tables["NorthwindShipper"];

                //foreach (DataRow drow in dt.Rows)
                //{
                //    //to access the columns in the row
                //    foreach (DataColumn dc in dt.Columns)
                //    {
                //        Console.Write(drow[dc] + " ");
                //    }
                //    Console.WriteLine();
                //}

                Console.WriteLine("------Adding a new row to the region-------");
                DataRow row = ds.Tables["NorthwindRegion"].NewRow();

                //let us give values to the new row
                row["RegionID"] = 10;
                row["RegionDescription"] = "Test Region";

                //adding the newly created datarow to the datatable collection

                ds.Tables["NorthwindRegion"].Rows.Add(row);

                SqlCommandBuilder scb = new SqlCommandBuilder(da);

               // da.UpdateCommand = scb.GetUpdateCommand();
               da.InsertCommand = scb.GetInsertCommand();   //does insertion of rows into the database

                da.Update(ds, "NorthwindRegion");
                Console.WriteLine("------After insertion of one row-------");
                da.Fill(ds);  // to refresh after insertion

                dt = ds.Tables["NorthwindRegion"]; // this point sto the start of the datatable in the Dataset

                foreach (DataRow drow in dt.Rows)
                {
                    //to access the columns in the row
                    foreach (DataColumn dc in dt.Columns)
                    {
                        Console.Write(drow[dc] + " ");
                    }
                    Console.WriteLine();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }
    }
}
