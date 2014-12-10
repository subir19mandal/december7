using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter lower limit:");
            int lowernumber = Convert.ToInt32(Console.ReadLine());
            int uppernumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Userdefined Forloop:");
            for (int i = lowernumber; i <= uppernumber; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
