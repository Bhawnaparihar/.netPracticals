using System;

namespace ToUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            int character = Console.Read();

            while (character != -1)
            {
                if (Char.IsLetter((char)character))
                    Console.Write(((char)character)
                        .ToString().ToUpper());
                else
                    Console.Write((char)character);

                character = Console.Read();
            }
        }

    }
}
