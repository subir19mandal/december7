using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3App
{
    class Program
    {
        static void Main(string[] args)
        { Console.WriteLine("Enter number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("Numbers are equal");
               
            }
            else if (num1 > num2)
                
            {
                Console.WriteLine("num1:" +num1);
                Console.WriteLine("num2:" + num2);
                Console.WriteLine("num1 is bigger than num2");
            }
            else
            {
                Console.WriteLine("num1:" + num1);
                Console.WriteLine("num2:" + num2); 
                Console.WriteLine("num2 is bigger than num1");
            
            }
            Console.ReadKey();
        }
        }
    }

