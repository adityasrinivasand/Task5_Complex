using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_complexcode
{
    class Shape
    {
        public virtual void Draw(int a)
        {
            Console.WriteLine($" Draw Function has been invoked with a parametric length: {a} ");
        }
    }
    class Square : Shape
    {
        public override void Draw(int a)
        {
            Console.WriteLine($"Square Drawn with a length: {a} ");
            Console.WriteLine($"Area of Square Drawn with a length: {a} is {a*a} ");
        }

    }
    class Circle : Shape
    {
        public override void Draw(int a)
        {
            Console.WriteLine($"Circle Drawn with a Radius: {a} ");
            Console.WriteLine($"Area of Circle Drawn with a radius: {a} is {3.14 * a * a} ");

        }

    }
}
