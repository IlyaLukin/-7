using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    class Program
    {
   
        public static IEnumerable<int[]> Combinations(int m, int n)
        {
            int[] result = new int[m];
            Stack<int> stack = new Stack<int>();
            stack.Push(0);

            while (stack.Count > 0)
            {
                int index = stack.Count - 1;
                int value = stack.Pop();

                while (value < n)
                {
                    result[index++] = ++value;
                    stack.Push(value);

                    if (index == m)
                    {
                        yield return result;
                        break;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
              Console.WriteLine("Введите количество комбинаций");
              int N = int.Parse(Console.ReadLine());
              Console.WriteLine($"N={N}");

              Console.WriteLine("Введите количество чисел");
              int M = int.Parse(Console.ReadLine());
              Console.WriteLine($"M={M}");
            foreach (int[] c in Combinations(N, M))
            {
                Console.WriteLine(string.Join(",", c));

            }
            Console.ReadKey();

        }
    }
}
