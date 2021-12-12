using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprawdzianzad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a<b)
            {
                Console.WriteLine(a);
            }

            if (b < a) {

                Console.WriteLine(b);
            }

            if (a==b)
            {
                Console.WriteLine("SĄ RÓWNE");
            }

            Console.ReadKey();

        }
    }
}
