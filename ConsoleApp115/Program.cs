using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp115
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int count = 1; count <= 10; ++count)
            {
                if (count == 5)
                {
                    continue;
                }
                Console.Write($"{count}");
            }

            Console.WriteLine("\nUsed continue to skip displaying 5");
            Console.ReadLine();
        }
    }
}
