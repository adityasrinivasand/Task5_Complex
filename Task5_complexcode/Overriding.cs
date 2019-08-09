using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_Complexcode
{
    class Shape
    {
        public virtual void Draw(float a)
        {
            Console.WriteLine($" Draw Function has been invoked with a parametric length: {a} ");
        }
    }
    class Square : Shape
    {
        public override void Draw(float a)                                                         //Overriding and overloading
        {
            int i = (int)a;                                                                     //type conversion 
            Console.WriteLine($"The decimal is converted from {a} to {i}");
            Console.WriteLine($"Square Drawn with a length: {i} ");
            Console.WriteLine($"Area of Square Drawn with a length: {i} is {i*i} ");
        }

    }
    class Circle : Shape
    {
        public override void Draw(float a)
        {
            Console.WriteLine($"Circle Drawn with a Radius: {a} ");
            Console.WriteLine($"Area of Circle Drawn with a radius: {a} is {3.14 * a * a} ");

        }

    }
}
