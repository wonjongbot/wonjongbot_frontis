using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            Console.WriteLine("Lower Bound: ");
            int lwrbnd = Convert.ToInt32(Console.ReadLine());

            int n = lwrbnd;

            Console.WriteLine("Upper Bound: ");
            int uprbnd = Convert.ToInt32(Console.ReadLine());

            for (int i = lwrbnd; i <= uprbnd; i++)
            {
                total += n;
                n++;
            }
            Console.WriteLine(total);
        }
    }
}
