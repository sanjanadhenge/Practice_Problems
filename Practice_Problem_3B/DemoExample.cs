using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problem_3B
{
    public class DemoExample //Internal =  accessed methods and variable within a Project only
    {
        private int id = 1; //Private = accessed within class only
        public string name = "Rutuja"; //Public = accessed outside project also
        protected string mail = "ABC@gmail.com"; //Protected = accessed by derived class only
        public void DisplayId()
        {
            Console.WriteLine("Name : "+name+"\n"+"id : "+id);
        }
    }
    public class Subclass : DemoExample
    {
        public void Displaymail()
        {
            Console.WriteLine("Name : " + name + "\n" + "Mail : " + mail);
        }
    }
}
