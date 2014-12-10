using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probmel4App
{
    class Program
    {
        static void Main(string[] args)
        { Console.WriteLine("Enter User Name:");
            string name=Convert.ToString(Console.ReadLine());
         
           Console.WriteLine("Hi, " + name + " Good day");
            Console.ReadKey();
        }
    }
}
