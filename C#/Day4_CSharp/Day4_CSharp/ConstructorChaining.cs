using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_CSharp
{
    class Customer
    {
        public Customer()
        {
            Console.WriteLine(  "Customer Construction 1 ...");
        }

        public Customer(int a) : this()
        {
            Console.WriteLine("Customer Construction 2 .....");
        }

        public Customer(string s, int a ) : this(a)
        {
            Console.WriteLine("Customer Construction 3 ....");
        }
            
    }

    //understanding Composition
    class Engine
    {
        public void Start()
        {
            Console.WriteLine("Engine Started ...");
        }

        public void Stop()
        {
            Console.WriteLine("Engine Stopped ...");
        }
    }

    class Car
    {
        Engine engine;

        public Car()
        {
           engine = new Engine();  // composition
        }

        public void StartCar()
        {
            engine.Start();
            Console.WriteLine("Car is Running...");
        }

        public void StopCar()
        {
            engine.Stop();
            Console.WriteLine("Car stopped now..");
        }
    }
    internal class ConstructorChaining
    {
        public static void Main()
        {
           // Customer customer = new Customer("CSharp", 10);
           Car car = new Car();
            car.StartCar();
            car.StopCar();
            Console.Read();
        }
    }
}
