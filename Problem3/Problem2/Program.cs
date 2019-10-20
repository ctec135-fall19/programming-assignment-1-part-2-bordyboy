using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 6; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            int j = 1;
            while (j<6)
            {
                Console.Write("{0} ", j);
                j++;
            }
            Console.WriteLine();

            int k = 1;
            do
            {
                Console.Write("{0} ", k);
                k++;
            } while (k < 6);
            Console.WriteLine();

        }

    }
}
