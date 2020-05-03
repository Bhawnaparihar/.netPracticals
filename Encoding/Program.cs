using System;
using System.IO;
using System.Text;

namespace Encoding
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "fileList.txt";
            WriteTextFile(fileName);
            ReadTextFile(fileName);
        }

        static void WriteTextFile(string fileName)
        {
            DirectoryInfo dInfo = new DirectoryInfo(
                Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments));
            StringBuilder sb = new StringBuilder();

            foreach (FileInfo fileInfo in dInfo.GetFiles())
            {
                sb.AppendLine(fileInfo.Name);
            }

            using (StreamWriter sw =
                new StreamWriter(fileName, false,
                    new UnicodeEncoding()))
            {
                sw.Write(sb.ToString());
            }
        }

        static void ReadTextFile(string fileName)
        {
            try
            {
                using (StreamReader sr =
                  new StreamReader(fileName,
                      new UnicodeEncoding()))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
        }

    }
}
