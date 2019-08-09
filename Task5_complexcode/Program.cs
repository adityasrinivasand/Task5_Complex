using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_complexcode
{
    class Program
    {
        static void Main(string[] args)
        {
                                        /* Overloading, Overiding, polymorphism , Inheritance */

            Console.WriteLine("\t\t\t C# Complex");
            Console.WriteLine("");
            Console.WriteLine("\t\t Overriding Complex O/P");
            Shape[] s = new Shape[2];
            s[0] = new Circle();
            s[1] = new Square();
            Console.WriteLine("Enter a number");
            var number = Console.ReadLine();
            int num;
            while (!int.TryParse(number, out num))
            {
                Console.WriteLine("This is not a number!");
                number = Console.ReadLine();
            }
            Console.WriteLine("");
            for (int i = 0; i < 2; i++)
            {
                s[i].Draw(num);
                Console.WriteLine("");
            }
            Console.ReadLine();
            
                                                       /* Operator Overloading */

            Console.WriteLine("\t\t Operator Overloading Complex O/P");
            int c1, c2, c3, c4;

            Console.WriteLine("Enter Real part for First number");
            var getnum = Console.ReadLine();
            while (!int.TryParse(getnum, out c1))
            {
                Console.WriteLine("This is not a number!");
                getnum = Console.ReadLine();
            }
            Console.WriteLine("Enter Complex part for First number");
            getnum = Console.ReadLine();
            while (!int.TryParse(getnum, out c2))
            {
                Console.WriteLine("This is not a number!");
                getnum = Console.ReadLine();
            }
            Console.WriteLine("Enter Real part for Second number");
            getnum = Console.ReadLine();
            while (!int.TryParse(getnum, out c3))
            {
                Console.WriteLine("This is not a number!");
                getnum = Console.ReadLine();
            }
            Console.WriteLine("Enter Complex part for Second number");
            getnum = Console.ReadLine();
            while (!int.TryParse(getnum, out c4))
            {
                Console.WriteLine("This is not a number!");
                getnum = Console.ReadLine();
            }

            ComplexNum cnum1 = new ComplexNum(c1, c2);
            ComplexNum cnum2 = new ComplexNum(c3, c3);

            ComplexNum addition = cnum1 + cnum2;
            Console.WriteLine("First complex number:  {0}", cnum1);
            Console.WriteLine("Second complex number: {0}", cnum2);
            Console.WriteLine("RESULT :The sum of the two numbers: {0}", addition);
            Console.ReadLine();

                                        /* Looping with conditional */
            Console.WriteLine("\t\t Looping Complex O/P");
            Loops lo = new Loops();
            lo.getdata();
            Console.ReadLine();
    
                                        /* Constructors */
            Console.WriteLine("\t\t Constructors Complex O/P");
            Construct con = new Construct("Aditya", "Srinivasan");
            Construct con1 = new Construct(con); // g to g1 

            Console.WriteLine(con1.p1 + " to " + con1.p2);
            Construct con2 = new Construct(10, 20);
            Construct con3 = new Construct(con2, con2); // G to G1
            Console.WriteLine("Overloaded values : {0} and {1}",con3.p3, con3.p4); ;
            Console.ReadLine();

                                        /* Exceptional Handling */
            Console.WriteLine("\t\t Exceptional Handling Complex O/P");
            Console.WriteLine("Enter the Temperature in Celsius");
            var temperature = Convert.ToDouble(Console.ReadLine());
            Temperature temp = new Temperature(temperature);
            try
            {       
                temp.cal();
            }
            catch (TempIsZeroException e)
            {
                Console.WriteLine("TempIsZeroException: {0}", e.Message);
            }
            Console.ReadLine();
        }
    }
}
