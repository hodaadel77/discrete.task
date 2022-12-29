using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project._._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, z = 0;
            Console.WriteLine("enter n1");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter n2");
            n2 = int.Parse(Console.ReadLine());
            for (int i = n1; i <= n2; i++)
            {
                for (int x = 1; x < i; x++)
                {
                    if (i % x == 0)
                    {
                        z += x;
                    }
                }
                if (z == i)
                {
                    Console.WriteLine(i);
                }
                z = 0;
            }
        }
    }
}
