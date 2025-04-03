
using System.Data;
using System.Data.SqlClient;
using System.Text;


namespace Day7_CSharp
{
    internal class Program
    {
        static SqlConnection con = null;
        static SqlCommand cmd;
        static SqlDataReader dr;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            SelectData();
            Console.Read();
        }

        public static SqlConnection getConnection()
        {
            con = new SqlConnection("data source = Laptop-Tjj7d977;initial catalog = HexaDb;integrated security = true;");
            con.Open();
            return con;
        }
        public static void SelectData()
        {
            //StringBuilder sbq = new StringBuilder();
            //sbq.Append("select * from emp ")
            //    .Append("where ");
            //sbq.Append("sal > 2000 ");
            con = getConnection();
            cmd = new SqlCommand("select * from emp1",con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine(dr[0] + " " + dr[1]);
                Console.WriteLine("Employee Number = " + dr["empno"]);
                Console.WriteLine("Employee Name = " + dr["ename"]);
                Console.WriteLine("Employee Job = " + dr[2]);
                Console.WriteLine("Manager ID = "+ dr["mgr_id"]);
                Console.WriteLine("Employee Saalry = " + dr[5]);

            }
        }
    }
}
