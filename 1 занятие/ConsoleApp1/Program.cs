using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int N))
            {
                Console.WriteLine($"Нечетные числа от 1 до {N}:");
                for (int i = 1; i <= N; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(GetKubX(N));
        }
        static string GetOddNumbers(int n)
        {
            string input = "";

            for (int i = 1; i <= n; i += 2)
            {
                input += i.ToString() + " ";
            }
            return input;

        }
        static string GetKubX(int n)
        {
            string result = "";

            for (int i = 1; i <= n; i += 1)
            {
                for (int j = 1; j <= n; j += 1)
                {
                    result += "x ";
                }

                result += "\n";
            }

            return result;

        }
    }
}
