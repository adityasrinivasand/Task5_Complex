using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_complexcode
{
    class Loops
    {
        public int m, n, p, q, i, j;
        public int[,] a = new int[5, 5];
        public int[,] b = new int[5, 5];
        public int[,] c = new int[5,5];
        public void calculate()
        {
            if (n != p)
            {
                Console.WriteLine("Matrix multiplication not possible");
            }
            else
            {
                 c = new int[m, q];
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < q; j++)
                    {
                        c[i, j] = 0;
                        for (int k = 0; k < n; k++)
                        {
                            c[i, j] += a[i, k] * b[k, j];
                        }
                    }
                }
            }
            Console.WriteLine("The product of the two matrices is :");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write( c[i, j] + "\t");
                }
                Console.WriteLine();
            }
        
        }
        public void getdata()
        {
            Console.WriteLine("Enter the First Matrix's Row");
            var getnum = Console.ReadLine();
            while (!int.TryParse(getnum, out m))
            {
                Console.WriteLine("This is not a number!");
                getnum = Console.ReadLine();
            }
            Console.WriteLine("Enter the First Matrix's Column");
            getnum = Console.ReadLine();
            while (!int.TryParse(getnum, out n))
            {
                Console.WriteLine("This is not a number!");
                getnum = Console.ReadLine();
            }
            Console.WriteLine("Enter the Second Matrix's Row");
            getnum = Console.ReadLine();
            while (!int.TryParse(getnum, out p))
            {
                Console.WriteLine("This is not a number!");
                getnum = Console.ReadLine();
            }
            Console.WriteLine("Enter the Second Matrix's Column");
            getnum = Console.ReadLine();
            while (!int.TryParse(getnum, out q))
            {
                Console.WriteLine("This is not a number!");
                getnum = Console.ReadLine();
            }

            Console.WriteLine("Enter the values of First Matrix");
            for(i=0;i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.WriteLine("Enter the values of Second Matrix");
            for (i = 0; i < p; i++)
            {
                for (j = 0; j < q; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    b[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            display();
        }
        void display()
        {
            Console.WriteLine("");
            Console.WriteLine("Matrix a:");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("");
            Console.WriteLine("Matrix b:");
            for (i = 0; i < p; i++)
            {
                for (j = 0; j < q; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("");
            calculate();
        }
    }
}
