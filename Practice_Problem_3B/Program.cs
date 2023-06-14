using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problem_3B
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DemoExample demo = new DemoExample();
            demo.Display();
            DemoExample demo1 = new DemoExample(5, 7);
            demo1.Addition();

        }
    }
     
}
