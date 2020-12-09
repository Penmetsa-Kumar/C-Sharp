using System;
namespace myapp
{

    interface IFile
    {
        void ReadFile();
    }

    interface IBinaryFile
    {
        void OpenBinaryFile();
        void ReadFile();
    }

    class FileInfo : IFile, IBinaryFile
    {
        void IFile.ReadFile()
        {
            Console.WriteLine("Reading Text File");
        }

        void IBinaryFile.OpenBinaryFile()
        {
            Console.WriteLine("Opening Binary File");
        }

        void IBinaryFile.ReadFile()
        {
            Console.WriteLine("Reading Binary File");
        }

        public void Search(string text)
        {
            Console.WriteLine("Searching in File");
        }
    }

    public class Program
    {
        public static void Main()
        {
            IFile file1 = new FileInfo();
            IBinaryFile file2 = new FileInfo();
            FileInfo file3 = new FileInfo();

            file1.ReadFile();

            file2.OpenBinaryFile();
            file2.ReadFile();

            file3.Search("text to be searched");

        }
    }
}
