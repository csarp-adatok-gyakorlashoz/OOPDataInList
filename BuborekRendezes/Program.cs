using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

namespace BuborekRendezes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            Random rnd = new Random();
            int db = rnd.Next(10, 15);
            for (int b = 0; b < db; b++)
            {
                a.Add(rnd.Next(-99999, 99999));
            }

            int n = a.Count;
            Console.WriteLine("Tömb elemeinek száma:" + n);

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = n - 1; i >= 1; i = i - 1)
            {
                for (int j = 0; j < i ; j = j + 1)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }

            stopwatch.Stop();
            Console.WriteLine("Eltelt idő: " + stopwatch.Elapsed);

            for (int i = 0; i <n; i = i + 1)
            {
                Console.Write(a[i] + ",");
            }
            Console.ReadKey();
        }
    }
}
