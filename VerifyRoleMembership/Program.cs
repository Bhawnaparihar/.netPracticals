using System;
using System.Security.Principal;
using System.Threading;


namespace VerifyRoleMembership
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.SetPrincipalPolicy(
                PrincipalPolicy.WindowsPrincipal);
            WindowsPrincipal principal =
                (WindowsPrincipal)Thread.CurrentPrincipal;
            bool isAdmin = principal.IsInRole(
                WindowsBuiltInRole.Administrator);

            Console.WriteLine(
                "You are {0}in the Administrators role",
                isAdmin ? "" : "not ");
        }

    }
}
