using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_complexcode
{
    public class TempIsZeroException : Exception
    {
        public TempIsZeroException(string message) : base(message)
        {
        }
    }
    public class Temperature
    {
        double temperature = 0.0;
        double fahrenheit;
        public Temperature(double temp)
        {
            temperature = temp;
        }
        public void showTemp()
        {
            if (temperature == 0)
            {
                throw (new TempIsZeroException("Zero Temperature found"));
            }
            else
            {
                Console.WriteLine("Temperature in Farhrenheit: {0}", temperature);
            }
        }
        public void cal()
        {
            Console.WriteLine("Celsius: " + temperature);

            fahrenheit = (temperature * 9) / 5 + 32;
            showTemp();
        }
    }
}
