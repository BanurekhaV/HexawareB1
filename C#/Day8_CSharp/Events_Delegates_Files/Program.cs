namespace Events_Delegates_Files
{
    public delegate void EmpHandler(string str); // decl of a delegate
    class Employee
    {
        public static void AcceptEmp(string empname)
        {
            Console.WriteLine("Hello " + " " + empname);
        }

        public void DisplayEmp(string s)
        {
            Console.WriteLine(s);
        }

        public void Show()
        {
            Console.WriteLine("This is Show..");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Employee emp = new Employee();

            //create an instance of the delegate
            EmpHandler eh1 = new EmpHandler(Employee.AcceptEmp); // assigning a static method of the employee class

            //calling the delage and hence calling the function that it is pointing to
            eh1("Karthick"); // invoking the delegate
            eh1.Invoke("Kamalesh");

            EmpHandler eh2= new EmpHandler(emp.DisplayEmp);
            eh2("Rofina");
            Console.Read();
        }
    }
}
