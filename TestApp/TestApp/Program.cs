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

            Console.WriteLine("Here's some code for Feature 2");

            for (var i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine("This is code of Feature 3");

            var fClass = new Feature3Class
            {
                Id = 1,
                Text = "Some Text"
            };
            
            Console.WriteLine($"{fClass.Id} :: {fClass.Text}");
                Console.WriteLine(i);
            }
            
            Console.WriteLine("This is code of Feature 3");

            var fClass = new Feature3Class
            {
                Id = 1,
                Text = "Some Text"
            };
            
            Console.WriteLine($"{fClass.Id} :: {fClass.Text}");

            Console.ReadLine();
        }
    }
}
