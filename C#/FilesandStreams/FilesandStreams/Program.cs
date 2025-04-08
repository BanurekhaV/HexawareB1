using System.IO;
using static System.Console;

namespace FilesandStreams
{

    class ReadWriteBinary
    {
       public static void WriteBinary()
        {
            WriteLine("Hello and Welcome to Files on C#");
            using (BinaryWriter writer = new BinaryWriter(File.Open("C:\\Banu\\Hexaware B1\\OurBinaryFile.bin",FileMode.Create))) 
            {
                writer.Write("0x80243456df");
                writer.Write("Some data written");
                writer.Write(true);
            }
        }

        public static void ReadBinary() 
        {
            BinaryReader reader = new BinaryReader(File.Open(@"C:\Banu\Hexaware B1\OurBinaryFile.bin", FileMode.Open));
            WriteLine("Data 1 : " + reader.ReadString());
            WriteLine("Data 2 : " + reader.ToString());
            WriteLine($"Data 3 : {reader.ReadString()}");
        }
    }

    class ReadWriteStreams
    {
        public static void WriteStreamData()
        {
            FileStream fs = new FileStream("MyFile.txt",FileMode.Append, FileAccess.Write);

            StreamWriter writer = new StreamWriter(fs);

            //prompt the user for input
            WriteLine("Enter a String of Data : ");
            string str = ReadLine();

            writer.Write(str);

            writer.Flush();
            writer.Close();
            fs.Close();
        }

        public static void ReadStreamData()
        {
            FileStream fs = new FileStream("MyFile.txt", FileMode.Open, FileAccess.Read);

            StreamReader reader = new StreamReader(fs);

            //to position the file pointer at a particluar offset, we can use base stream

            reader.BaseStream.Seek(10, SeekOrigin.Begin);

            //read till the end of the file
            string str2 = reader.ReadLine();

            while (str2 != null) 
            {
                WriteLine("{0}", str2);
                str2 = reader.ReadLine();
            }

            reader.Close();
            fs.Close();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello, World!");
          //  ReadWriteBinary.WriteBinary();
          //  ReadWriteBinary.ReadBinary();
          // ReadWriteStreams.WriteStreamData();
          ReadWriteStreams.ReadStreamData();
            Read();
        }
    }
}
