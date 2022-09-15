using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {

        static int countAmount(int amount)
        {
            int result = 0;

            for (int i = 0; i <= amount; i++)
            {
                result += i;
                Console.WriteLine(result);
            }
            return result;
        }
        static void Main(string[] args)
        {
            string greeting = "Hi there";
            string name = "John Doe";
            Console.WriteLine($"{greeting} {name}");

            Console.WriteLine("/___|");
            Console.WriteLine("   /|");
            Console.WriteLine("  / |");
            Console.WriteLine(" /  |");

            int amount = countAmount(10);

            Console.WriteLine(amount);
        }
    }
}