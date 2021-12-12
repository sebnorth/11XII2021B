using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprawdzianzad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double wynik = (n+n*n) / 3.0;

            Console.WriteLine("Wynik dla n={0} wynosi: {1} ", n, wynik);
            Console.ReadKey();
        }
    }
}
