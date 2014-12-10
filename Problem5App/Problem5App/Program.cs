using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5App
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }

}