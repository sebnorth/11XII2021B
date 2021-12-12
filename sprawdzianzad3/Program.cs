using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprawdzianzad3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int liczba = 13;

            Console.WriteLine("Podaj wartość ile: ");
            int ile = Convert.ToInt32(Console.ReadLine());

            while (i<ile)
            {
                if (liczba%2==1)
                {
                    Console.Write("{0} ", liczba);
                    i++;
                }

                liczba += 13;
            }

            Console.ReadKey();
        }
    }
}
