using System;
using System.IO;

namespace TextAppend
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter w =
                File.AppendText("LogFile.txt"))
            {
                w.WriteLine(
                    String.Format("Logged on: {0}\n",
                    DateTime.Now));
            }
            using (StreamReader r
                = File.OpenText("LogFile.txt"))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }

    }
}
