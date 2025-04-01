using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_CSharp
{
    interface Iprinter
    {
       double printerCost{get;}  //just decl
       void Print();
    }

    interface InkJet : Iprinter
    {
        void TypeofInk();
    }

    interface INewInkjet : InkJet
    {
        void newInk();
    }

    class Customer : INewInkjet
    {
        public double printerCost { get; set; } // here auto property implementation takes place 
        public void Print() { }
        public void newInk() { }
        public void TypeofInk() { }

    }
    internal class InterfaceEg
    {
        public static void Main()
        {
            //with the implementing class object all implemented methods can be called
            Customer c = new Customer();
            c.Print();
            c.newInk();
            c.TypeofInk();
            c.printerCost = 12500;
            Console.WriteLine(c.printerCost);

            //with respective interface object we can call only those methods within the interface
            Iprinter printer = new Customer();
            printer.Print();

            INewInkjet inkjet = new Customer();
            inkjet.newInk();

            InkJet inkj = new Customer();
            inkj.TypeofInk();
        }
    }
}
