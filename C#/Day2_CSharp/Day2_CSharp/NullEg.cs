using System;


namespace Day2_CSharp
{
    internal class NullEg
    {
        public void NullableExample()
        {
            string ? str = null;  //nullable reference type
            int ? TicketsOnSale = 100;   //nullable value type
            int AvailableTickets;
            //if (TicketsOnSale == null)
            //{
            //    AvailableTickets = 0;
            //}
            //else
            //    AvailableTickets = TicketsOnSale.Value;
            //or
            //AvailableTickets = (int)TicketsOnSale;
          //  Console.WriteLine($"AvailableTickets are : {AvailableTickets}");

            //the above can be replaced with null coalescing operator ??

            AvailableTickets = TicketsOnSale ?? 0;
            Console.WriteLine($"AvailableTickets are : {AvailableTickets}");
        }
        

    }
}
