namespace AccountMain
{
    public class Accounts
    {
        string Acno;
        float Balance;

        public Accounts(string accno)
        {
            Acno = accno;
        }

        public void Deposit(float amount) 
        {
            Balance += amount;
        }

        public float GetBalance() 
        { 
            return Balance;
        }
        public void Withdraw(float amount) 
        {
            if (Balance > amount)
                Balance -= amount;
            else
                throw new Exception("Not Enough Funds to withdraw..");
        }
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Gender { get; set; }

        public List<Employee> GetEmpData()
        {
            //populating employee details
            List<Employee> emplist = new List<Employee>()
            {
            new Employee { ID = 100, Name = "Nasiha", Salary = 50000, Gender = "Female" },
            new Employee { ID = 101, Name = "Paari", Salary = 50000, Gender = "Male" },
            new Employee { ID = 102, Name = "Keerthana", Salary = 50000, Gender = "Female" },
            new Employee { ID = 103, Name = "Sudarshan",Salary = 50000, Gender = "Male" }
            };
            return emplist;
        }

        public string Login(string userid, string password)
        {
            if (string.IsNullOrEmpty(userid) || string.IsNullOrEmpty(password))
            {
                return "User Id or Password cannot be empty";
            }
            else if (userid == "Admin" && password == "Admin@123")
            {
                return "Welcome Admin";
            }
            else
                return "Incorrect User Id or Password";
        }

        public int AddtwoNos(int x, int y)
        {
            return x + y;
        }
    }
}
