using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problem_3B
{
   public class DemoExample
    {
     //Default Constructor
        public string name;
        public DemoExample()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            this.name = name;
        }
        public void Display()
        {
            Console.WriteLine("Hello " + this.name);
        }
   //Parameterized Constaructor
        public int a, b;
        public DemoExample(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void Addition()
        {
            Console.WriteLine("Addition of {0} and {1} is {2} ", a, b, (a + b));
        }

    }
}
