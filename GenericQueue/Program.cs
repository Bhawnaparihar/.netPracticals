using System;
using System.Collections.Generic;

namespace GenericQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> first = new Queue<int>();
            first.Enqueue(7);
            first.Enqueue(11);
            first.Enqueue(45);
            first.Enqueue(50);

            Queue<int> second = new Queue<int>();
            second.Enqueue(12);
            second.Enqueue(32);
            second.Enqueue(65);
            second.Enqueue(67);

            ProcessInOrder(first, second);

            Console.WriteLine(
                "Press any key to continue...");
            Console.ReadKey();

        }

        static void ProcessInOrder(Queue<int> first,
            Queue<int> second)
        {
            while (first.Count > 0 || second.Count > 0)
            {
                if (first.Count == 0)
                {
                    Console.WriteLine(second.Dequeue());
                    continue;
                }

                if (second.Count == 0)
                {
                    Console.WriteLine(first.Dequeue());
                    continue;
                }

                if (first.Peek() >= second.Peek())
                {
                    Console.WriteLine(
                        second.Dequeue());
                }
                else
                {
                    Console.WriteLine(first.Dequeue());
                }
            }
        }
    }
}
