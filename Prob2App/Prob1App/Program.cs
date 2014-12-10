using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            float num1 = Convert.ToInt32(Console.ReadLine());
            float num2 = Convert.ToInt32(Console.ReadLine());

            float Add = num1 + num2;
            float sub = num1 - num2;
            float Div = num1 / num2;
            float Mult = num1 * num2;

            Console.WriteLine("Addition:" + Add);
            Console.WriteLine("Division:" + Div);
            Console.WriteLine("Substraction:" + sub);
            Console.WriteLine("Multification:" + Mult);
            Console.ReadKey();

        }
    }
}
