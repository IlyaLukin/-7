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
             if (n > 0 && m > 0)
            {
                if (n > m)
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
                else Console.WriteLine("N должно быть меньше M");
               
            }
            else  Console.WriteLine("Ошибка, неверный формат числа");
           
        }

        static void Main(string[] args)
        {
             int N = 0, M = 0;
            try{
                  Console.WriteLine("Введите число элементов в комбинации");
                   N = int.Parse(Console.ReadLine());
                  Console.WriteLine($"N={N}");
                }catch { Console.WriteLine("Неверный формат числа"); }
            
            try{
                  Console.WriteLine("Введите общее число элементов");
                   M = int.Parse(Console.ReadLine());
                   Console.WriteLine($"M={M}");
               }catch { Console.WriteLine("Неверный формат числа"); }
                
            foreach (int[] c in Combinations(N, M))
            {
                Console.WriteLine(string.Join(",", c));

            }
            Console.ReadKey();

        }
    }
}
