using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a test app");
            Console.WriteLine("This is a new line of code");
            Console.WriteLine("A third line of code added here");

            Console.WriteLine("Feature1");

            Feature1Class x = new Feature1Class();
            
            Console.ReadLine();
        }
    }
}
