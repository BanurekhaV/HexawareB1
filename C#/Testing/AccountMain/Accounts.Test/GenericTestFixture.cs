using System;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using AccountMain;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Serialization;

namespace Accounts.Test
{
    [TestFixture(CustomerType.Premium, 100.00, TypeArgs = new Type[] {typeof(CustomerType),typeof(double)})]
   public class GenericTestFixture<T1,T2>
   {
        private T1 custType;
        private T2 minOrder;

        public GenericTestFixture(T1 custType, T2 minOrder)
        {
            this.custType = custType;
            this.minOrder = minOrder;
        }

        [TestCase]
        public void TestMethod()
        {
            Assert.That(custType, Is.TypeOf<CustomerType>());
            Assert.That(minOrder, Is.TypeOf<double>());
        }
   }
}
