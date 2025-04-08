using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountMain
{
    public class CustomerOrderService
    {
        public void CustomerDiscount(Customer customer, Order order)
        {
            if (customer.CustType == CustomerType.Premium)
            {
                order.Amount = order.Amount - ((order.Amount * 10 / 100));
            }
            else if (customer.CustType == CustomerType.Elite)
            {
                order.Amount = order.Amount - ((order.Amount * 20 / 100));
            }


        }
    }
}
