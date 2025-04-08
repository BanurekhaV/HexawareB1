using System;
using System.IO;

namespace FilesandStreams
{
    internal class File_n_DirectoryInfo
    {
        static void Main()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo("C:\\Banu\\Hexaware B1\\SampleDirectory");
            if (directoryInfo.Exists)
            {
                Console.WriteLine("Directory by the name already exists..");
            }

            else
            {
                directoryInfo.Create();
                Console.WriteLine("Directory Created...");
            }

            //2. Let us get the list of subdirectories from the given directory
            Console.WriteLine("---------Directory Listing--------");
            directoryInfo = new DirectoryInfo("C:\\Banu\\Hexaware B1\\C#");
            if (directoryInfo.Exists)
            {
                DirectoryInfo[] subdirectories = directoryInfo.GetDirectories();

                foreach (object subdir in subdirectories)
                {
                    Console.WriteLine(subdir);
                }
            }
            else
                Console.WriteLine("The given directory does not exists or there are no sub directories");

            Console.WriteLine("----------Files of a directory Listing----------");

            FileInfo[] files = directoryInfo.GetFiles();

            foreach (FileInfo file in files)
            {
                Console.WriteLine("File Name :{0} File Size : {1}  File Extension : {2}", file.Name,file.Length, file.Extension);
            }
            Console.Read();
        }
    }
}
