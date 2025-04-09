using System;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using AccountMain;

namespace Accounts.Test
{
    [TestFixture(CustomerType.Premium, 100.00)]
    [TestFixture(CustomerType.Basic)]
    
    internal class CustomerOrder_Tests
    {
        private CustomerType customerType;
        private double orderval;


        public CustomerOrder_Tests(CustomerType custType):this(custType,0)
        {
            customerType = custType;
        }

        public CustomerOrder_Tests(CustomerType custType, double minval)
        {
            customerType = custType;
            orderval = minval;
        }

        [TestCase]
        public void TestCustTypeMethod()
        {
            ClassicAssert.IsTrue((customerType==CustomerType.Basic && orderval == 0 || customerType==CustomerType.Premium &&
                orderval > 0 ));
        }

        [TestCase(new int[] {1,3,5,7,9})]
        public void When_Allnumbers_areOdd_expect_oddNumbers_tobetrue(int[] numbers)
        {
            NumberClass nc = new NumberClass();
            bool result = nc.Odd_Numbers(numbers);

            Assert.That(result, Is.True);
        }
    }
}
