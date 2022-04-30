using System;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // C:\Internal\training-internal\Template.pptx

            string path = Console.ReadLine();

            int indexOfName = path.LastIndexOf("\\") + 1;
            int indexOfExtension = path.LastIndexOf(".") + 1;

            string name = path.Substring(indexOfName, (indexOfExtension - indexOfName - 1));
            string extension = path.Substring(indexOfExtension);

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
