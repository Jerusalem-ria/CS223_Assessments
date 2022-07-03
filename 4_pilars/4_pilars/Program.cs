using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_pilars
{
    abstract class shape
    {
        abstract public double calcArea();
        abstract public double CalcPerimeter();

    }

    class circle : shape
    {
        public double radius { get; set; }
        static readonly double Pi = 3.14;

        public override double calcArea()
        {
            return Pi * radius * radius;
        }

        public override double CalcPerimeter()
        {
            return 2 * Pi * radius;
        }


    }
    class rectangle : shape
    {
        public double length { get; set; }
        public double width { get; set; }

        public override double calcArea()
        {
            return length * width;
        }

        public override double CalcPerimeter()
        {
            return 2 * (length + width);
        }

    }
     class Program
    {
        static void Main(string[] args)
        {
            rectangle rec = new rectangle { length = 2, width = 8 };
            Console.WriteLine("Rectangel area = " + rec.calcArea());
            Console.WriteLine("Rectangel permeter = " + rec.CalcPerimeter());



            circle c = new circle { radius = 4 };
            Console.WriteLine("Circle area = " + c.calcArea());
            Console.WriteLine("Circle permeter = " + c.CalcPerimeter());
        }
    }
}
