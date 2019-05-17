using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    class Program
    {
        static public bool NextSet(int []a, int N,int M)
        {
            int k = M;
            for(int i= k-1; i>=0; --i)
            if (a[i] < N-k+i+1)
            {
                    ++a[i];
                    for (int j = i + 1; j < k; ++j)
                        a[j] = a[j - 1] + 1;
                    return true;
            }
            return false;
        }

        static void Print(int []a,int N,ref int num)
        {
            num += 1;
            Console.Write($"Результат{num}: ");
            for (int i=0;i<N;i++)
            {
                
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();
            
        }

        static void Main(string[] args)
        {
            int[] a = null;

            Console.WriteLine("Введите количество элементов");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine($"N={N}");

            Console.WriteLine("Введите количество чисел");
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine($"M={M}");

            a = new int[N];
            int num = 0;
            for (int i=0;i<N;i++)
            {
                a[i] = i + 1;
                Print(a, M, ref num);
            }

            if(N>=M)
            {
                while (NextSet(a, N, M))
                    Print(a, M, ref num);
                
            }
            Console.ReadKey();
            
        }
    }
}
