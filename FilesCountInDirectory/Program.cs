using System;
using System.IO;

namespace Lesson12ToDo
{
    class Program
    {

        const string directory = @"C:\Users\22\Pictures\Camera Roll\TxtFiles";
        static void Main(string[] args)
        {
            Console.WriteLine(ReadFiles(directory));
        }
        public static  int i = 0;
        public static int ReadFiles(string directory1)
        {
            var Mydirectory  = new DirectoryInfo(directory1);
            var files = Mydirectory.GetFiles();
            var directories = Mydirectory.GetDirectories();
            foreach (var file in files)
            {
                if (file.Exists)
                {
                    i++;
                }
            }
            foreach (var directory in directories)
            {
                return ReadFiles(directory.ToString());
            }
            return i;
        }
    }
}
