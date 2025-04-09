using NUnit.Framework;
using NUnit.Framework.Legacy;
using AccountMain;

namespace Accounts.Test
{
     [TestFixture]
    public class TestAccounts
    {
        AccountMain.Accounts acc = new AccountMain.Accounts("12345");

                
        [SetUp]
        public void TestsetUp()
        {
            //arrange
            //acc = new AccountMain.Accounts("12345");
        }

        [Test]
        //[Order(1)]
        public void TestAccountDeposit()
        {
            //Act
            acc.Deposit(1000);

            //assert
            ClassicAssert.AreEqual(1000,acc.GetBalance());

        }    
       
         public void TestWithdrawal()
         {
             acc.Withdraw(200);   

         }

        [Test]
        //[Order(3)]

        public void CheckingBalanceaftertransactiontogive_PostiveBalance()
        {
            ClassicAssert.AreEqual(800, acc.GetBalance());
        }

        [Test]
        //[Order(2)]
        public void TestWithdrawmorethanbalance_shouldthrow_exception()
        {
            ClassicAssert.Throws<Exception>(TestWithdrawal);
        }

        [TestCase(Author ="Hexaassociates")]
        
        public void TestLoginCredentials()
        {
            //arrange

            Employee employee = new Employee();

            //act
            string s1 = employee.Login("banurekha", "123");
            string s2 = employee.Login("", "");
            string s3 = employee.Login("Admin", "Admin@123");

            //assert
            ClassicAssert.AreEqual("User Id or Password cannot be empty", s1);
            ClassicAssert.AreEqual("Incorrect User Id or Password", s2);
            ClassicAssert.AreEqual("Welcome Admin", s3);
        }

        //Parameterized Test along with testcases
        [Test]
        [TestCase(15,35,60)]
        [TestCase(10,45,55)]
        [TestCase(20,50,70)]
        

        public void Testingaddition_with2nos(int n1, int n2, int expected)
        {
            Employee employee = new Employee(); 

            int result = employee.AddtwoNos(n1, n2);

            ClassicAssert.AreEqual(expected, result);
        }

        [Test]
        [Ignore("Code not Complete")]
        public void TestPopulatedEmployeedEtails_arenotnull()
        {
            Employee e = new Employee();

            List<Employee> elist = e.GetEmpData();

            foreach (var emp in elist)
            {
                ClassicAssert.IsNotNull(emp.ID);
                ClassicAssert.IsNotNull(emp.Name);
            }
        }

        [TestCase(Author ="Banurekha")]
        public void WhenPremium_Customer_expect_10percentDiscount()
        {
            //arrange
            Customer P_customer = new Customer
            {
                CustId = 1,
                CustName = "maria",
                CustType = CustomerType.Premium
            };

            Order order = new Order
            {
                OrderId = 1,
                ProductId = 1,
                Qty = 1,
                Amount = 150
            };
            CustomerOrderService service = new CustomerOrderService();

            //act
            service.CustomerDiscount(P_customer, order);

            //assert
            ClassicAssert.AreEqual(order.Amount, 130);
        }
    }
}
