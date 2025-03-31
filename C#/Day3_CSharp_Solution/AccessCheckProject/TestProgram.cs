
using Day3_CSharp;

namespace AccessCheckProject
{
    internal class TestProgram : Products
    {
        static void Main(string[] args)
        {
            Products acessproduct = new Products();
            acessproduct.ProductName = "USBs";
            
            TestProgram tp= new TestProgram();
            tp.ProductName = "HandBags";
            tp.Price = 2500;
            tp.Description = "Gucci";
        }
    }
}
