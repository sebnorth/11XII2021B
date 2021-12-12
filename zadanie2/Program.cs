using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            // wczytanie prawidłowego rozmiaru tablicy 0 < n <=1000 

            int[] tab;
            int i, n, minimum, maksimum; 

            do
            {
                Console.WriteLine("podaj n: ");
                n = Convert.ToInt32(Console.ReadLine());

            } while (n<=0 && n >1000);
            tab = new int[n];

            for (i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Podaj wartość tab[{0}]: ", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var item in tab)
            {
                Console.Write("{0} ", item);
            }
          

            // sposób bez użycia Array.Sort
            Console.WriteLine("Szukamy wartości najmniejszej.");
            minimum = tab[0];
            maksimum = tab[0];
            for ( i = 1; i < tab.Length; i++)
            {
                if (tab[i]<minimum)
                {
                    minimum = tab[i];
                }

                if (tab[i] > maksimum)
                {
                    maksimum = tab[i];
                }

            }

            Console.WriteLine("Minimum: {0}, maksimum: {1}", minimum, maksimum);
            Console.ReadKey();
        }
    }
}
