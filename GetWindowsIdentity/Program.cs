using System;
using System.Security.Principal;

namespace GetWindowsIdentity
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain
                .SetPrincipalPolicy(
                PrincipalPolicy.WindowsPrincipal);

            WindowsIdentity identity =
               WindowsIdentity.GetCurrent();
            Console.WriteLine(
               "Windows Principal: {0}",
               identity.Name);

            foreach (var item in identity.Groups)
            {
                Console.WriteLine(
                                     item.Translate(
                                     typeof(NTAccount)));
            }
        }
    }
}
