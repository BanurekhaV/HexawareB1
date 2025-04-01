using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_CSharp
{
    abstract class AbstractShape
    {
       public abstract int Area();  // only decl. of abstract methods

        public void displayShape()  //  on abstract method
        {
            Console.WriteLine("Constructing a Shape...");
        }
    }

    class Square : AbstractShape
    {
        int side = 0;
        public Square(int n)
        {
            side = n;
        }
        public override int Area()
        {
           // base.displayShape();
            return side * side;
        }
    }

    class Tester
    {
        public static void Main()
        {
            Square square = new Square(5);
            Console.WriteLine(square.Area());
            square.displayShape();
            AbstractShape abscls = new Square(6);
            Console.WriteLine(abscls.Area());
            abscls.displayShape();
            Console.Read();
        }
    }
}
