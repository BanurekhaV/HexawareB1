using System;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using AccountMain;

namespace Accounts.Test
{
    [TestFixture]
    public abstract class NewEmployee_Test
    {
        public virtual Employee CreateEmployee()
        {
            return new Employee(); 
        }

        [TestCase]
        public void When_NamecontainsJunk_Chars_expectJunk_Chars_Returns_True()
        {
            Employee employee = CreateEmployee();
            employee.Name = "Mih@er";

            var result = employee.ContainsJunkChars();

            ClassicAssert.IsTrue(result);
        }
    }

    public class ManagerTestClass : NewEmployee_Test
    {
        public override Employee CreateEmployee()
        {
            return new Manager();
        }
    }

    public class ProjectTestClass : NewEmployee_Test
    {
        public override Employee CreateEmployee()
        {
            return new ProjectManager();
        }
    }
}
