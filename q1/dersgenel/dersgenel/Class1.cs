using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dersgenel
{
    public class BaseClass
    {
        public void Show()
        {
            Console.WriteLine("baseclass show");
        }

    }
    public class DerivedClass : BaseClass
    {
        public new void Show() { Console.WriteLine("merhaba"); }
    }
    public  class Ligit
    {
        public Ligit()
        {
            Console.WriteLine("this is rigit");
        }
        public virtual double area(double a, double b)
        {
            return a * b;

        }
        public void volume(double a,double b,double c)
        {

        }
    }
    public class triangle : Ligit
    {
        public override double Area(double a,double b)
        {
           return base.area(a,b) * 0.5;
        }

    }
}
