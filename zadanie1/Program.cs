using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int licznik = 0;

            int[] tab = new int[n];
            for (int i = 0; i < n; i++)
            {
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(tab);
            Array.Reverse(tab);


            foreach (int item in tab)
            {
                Console.Write("{0} ", item);
                if (item < 0)
                {
                    licznik++;
                }
            }

            Console.WriteLine("Liczb ujemnych w tablicy jest: {0}", licznik);

            //Console.WriteLine(tab[0]); // wypisuję pierwszy element tablicy

            //bool[] tab2= new bool[100];
            //Console.WriteLine(tab2[99]); // wypisuję ostatni element tablicy

            Console.ReadKey();
        }
    }
}
