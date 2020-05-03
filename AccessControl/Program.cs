using System;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;

namespace AccessControl
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "TestFile.txt";
            using (StreamWriter writer =
                File.CreateText(fileName))
            {
                writer.WriteLine(
                "Lorem ipsum dolor sit amet...");
            }

            var stream = File.Open(
                   fileName, FileMode.Open);
            var fileSecurity =
                   stream.GetAccessControl();

            foreach (var item in
                fileSecurity.GetAccessRules(
                true, true, typeof(NTAccount)))
            {
                var rule = item as
                  FileSystemAccessRule;
                Console.WriteLine(
                  "Identity Reference : {0}",
                  rule.IdentityReference.Value);
                Console.WriteLine(
                  "Access Control Type: {0}",
                  rule.AccessControlType);
                Console.WriteLine(
                  "File System Rights : {0}\n",
                  rule.FileSystemRights);
            }
        }
    }
}
