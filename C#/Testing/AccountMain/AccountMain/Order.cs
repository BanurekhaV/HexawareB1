using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountMain
{
    public class Order
    {
        public int OrderId {  get; set; }
        public int ProductId { get; set; }
        public int Qty {  get; set; }
        public decimal Amount {  get; set; }

    }
}
