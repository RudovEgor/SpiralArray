using System;
using System.Xml;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int num = 1;
            int[,] array = new int[n, n];
            for (int delta = 0; delta < n-2; delta++)
            {
                for (int i = 0 + delta; i < n - delta; i++)
                {
                    array[0 + delta, i] = num;
                    num++;
                }
                num--;
                for (int i = 0 + delta; i < n - delta; i++)
                {
                    array[i, 4 - delta] = num;
                    num++;
                }
                num--;
                for (int i = n - 1 - delta; i >= 0 + delta; i--)
                {
                    array[4 - delta, i] = num;
                    num++;
                }
                num--;
                for (int i = n - 1 - delta; i >= 1 + delta; i--)
                {
                    array[i, 0 + delta] = num;
                    num++;
                }
                num--;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j]+"\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
