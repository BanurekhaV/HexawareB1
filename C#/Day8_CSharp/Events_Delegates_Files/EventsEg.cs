using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace Events_Delegates_Files
{
    public delegate string MyEventDelegate(string str);

    class PublisherClass
    {
        //declare an event and associate it with the delegate

        event MyEventDelegate ourEvent; //decl an event of a particular delegate type

        public PublisherClass()
        {
            this.ourEvent += new MyEventDelegate(this.WelcomeUser);
            this.ourEvent += new MyEventDelegate(this.SecondFunction);
        }

        public string WelcomeUser(string uname)
        {
            return "Welcome Users : " + " " + uname;
        }

        public string SecondFunction(string msg)
        {
            return msg + " " + " Hope you are understanding and enjoying the session";
        }

        static void Main()
        {
            PublisherClass pobj = new PublisherClass();
            string msgfromfunc = pobj.ourEvent("C# Batch 1");  //raising an event
            Console.WriteLine(msgfromfunc);
            Console.Read();
        }
    }

    //2nd example for events-delegates
    internal class EventsEg
    {
        int data = 5;
        public delegate void NumberManipulator(int x);

        public event NumberManipulator ChangeNumberEvent;

        public EventsEg(int n)
        {
            this.ChangeNumberEvent += new NumberManipulator(this.OnChangeNumber); //registering an event with a handler

            setValue(n);
        }

        public void OnChangeNumber(int x)   //event handler
        {
            Console.WriteLine($"Event Raised and the Value from {data} is being changed to {x}");
        }

        public void setValue(int n)  // responsible for raising an event
        {
            if(data != n)   //if the values of data and the input are different
            {
                ChangeNumberEvent(n);
            }
            else
            {
                Console.WriteLine("No Changes in the value and hence no event..");
            }
        }
    }

    class TestEventClass
    {
        static void Main()
        {
            EventsEg evntobj = new EventsEg(5); // no event
            evntobj.setValue(15); //event will be raised
            evntobj.setValue(25); // evnet will be raised
            evntobj.setValue(5); //no event 
            Console.Read();
        }
    }
}
