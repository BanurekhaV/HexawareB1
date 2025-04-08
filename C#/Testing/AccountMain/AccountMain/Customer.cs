using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountMain
{
    public enum CustomerType
    {
        Basic, Premium, Elite
    }
    public class Customer
    {
        public int CustId { get; set; }
        public string CustName { get; set; }
        public CustomerType CustType { get; set; }
    }
}
