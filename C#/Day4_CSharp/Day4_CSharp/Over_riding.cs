using System;


namespace Day4_CSharp
{

    class Shape
    {
        protected float R, L, B;

        public virtual float Area()
        {
            return 3.14f * R * R;    //area of a Circle
        }

        public virtual float Circumferenc()
        {
            return 2 * 3.14f * R;  //circumference of a circle
        }
    }

    class Rectangle : Shape
    {
        public void GetLB()
        {
            Console.Write("Enter Length : ");
            L=float.Parse(Console.ReadLine());

            Console.Write("Enter Breadth : ");
            B = float.Parse(Console.ReadLine());
        }

        public override float Area()   // 
        { 
            return L*B;
        }

        public override float Circumferenc()
        {
            //return base.Circumferenc();
            return 2* (L+B);
        }
    }

    class Circle : Shape
    {
        public void GetRadius()
        {
            Console.Write(" Enter Radius :");
            R = Convert.ToSingle(Console.ReadLine());
        }
    }
    internal class Over_riding
    {
        static void Main()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.GetLB();

           float rectarea = rectangle.Area();
            Console.WriteLine("Area of Rectangle is {0}", rectarea);
            Console.WriteLine("Circumference of Rectangle :{0}", rectangle.Circumferenc());

            Console.WriteLine("----------------");
            Circle circle = new Circle();
            circle.GetRadius();
            Console.WriteLine("Area of Circle {0}", circle.Area());
            Console.WriteLine("Circumference of Circle is {0}", circle.Circumferenc());
            Console.Read(); 
        }
    }
}
