using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_complexcode
{
    public class ComplexNum
    { 
        public int real;
        public int imaginary;
        public ComplexNum(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        public static ComplexNum operator + (ComplexNum n1, ComplexNum n2)
        {
            return new ComplexNum(n1.real + n2.real, n1.imaginary + n2.imaginary);
        }
        public override string ToString()
        {
            return (String.Format("{0} + {1}i", real, imaginary));
        }
    }
}
