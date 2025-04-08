using NUnit.Framework;
using NUnit.Framework.Legacy;
using AccountMain;

namespace Accounts.Test
{
     [TestFixture]
    public class TestAccounts
    {
        AccountMain.Accounts acc;
        
        [SetUp]
        public void TestsetUp()
        {
            //arrange
            acc = new AccountMain.Accounts("12345");
        }

        [Test]
        public void TestAccountDeposit()
        {
            //Act
            acc.Deposit(1000);

            //assert
            ClassicAssert.AreNotEqual(1001,acc.GetBalance());
        }

       
        public void sampleTest()
        {

        }
    }
}
