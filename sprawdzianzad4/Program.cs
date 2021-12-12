using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprawdzianzad4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wartość x: ");
            int x = Convert.ToInt32(Console.ReadLine()); // 2231

            int cyfra;
            
            int iloczyn = 1;

            for (; x>0; )
            {
                cyfra = x % 10;
                iloczyn *= cyfra;
                x -= cyfra;
                x /= 10;
            }

            Console.WriteLine("Iloczyn cyfr wynosi: {0}", iloczyn);
            Console.ReadKey();
        }
    }
}
