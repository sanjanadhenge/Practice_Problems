using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problem_3B
{
    public interface IDemo
    {
        public void checkEvenOdd(int a);
    }
   public class DemoExample : IDemo
    {
     public void checkEvenOdd(int a)
        {
            if(a % 2 == 0)
            {
                Console.WriteLine("{0} is Even ", a);
            }
            else
            {
                Console.WriteLine("{0} is Odd ", a);
            }
        }
    }
}
