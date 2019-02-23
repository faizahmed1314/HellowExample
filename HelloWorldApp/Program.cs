using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your name");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("Hello"+ name);
            Console.ReadKey();
            
        }
    }
}
