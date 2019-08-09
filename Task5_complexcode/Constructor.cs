using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_Complexcode
{
    class Construct
    {
        public string p1, p2;
        public int p3, p4;
        public Construct(string x, string y)
        {
            p1 = x;
            p2 = y;
        }
        public Construct(Construct gf)
        {
            p1 = gf.p1;
            p2 = gf.p2;
        }
        public Construct(int a, int b)
        {
            p3 = a;
            p4 = b;
        }
        public Construct(Construct a, Construct b)
        {
            p3 = a.p3;
            p4 = b.p4;
        }
        ~Construct()
        {
            Console.WriteLine("Destructor is called");
        }
    }
}
