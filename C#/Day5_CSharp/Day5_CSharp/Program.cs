namespace Day5_CSharp
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
          //  MyStaticClass ms = new MyStaticClass();
          MySealedClass ms = new MySealedClass();
            ms.Sealed_Function();
        }
    }

    //static class 
    static class MyStaticClass
    {
        static int myvar;
        public static void Static_Function1()
        {
            Console.WriteLine(myvar++);
        }
    }

    //sealed class
    sealed class MySealedClass
    {
        public void Sealed_Function()
        {
            Console.WriteLine( "It is sealed..");
        }
              
    }

    partial class MyPartialClass
    {
        public void FunctionPartial() { }
    }

   
}
