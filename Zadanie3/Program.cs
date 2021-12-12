using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] tab = { 1, 2, 3, 6 }; 
            
            Console.WriteLine(FirstLast6(new int[] { 6, 1, 3, 1, 0}));
            Console.WriteLine(FirstLast6(new int[] { -6, 1, 3, 1, 0 }));

            Console.ReadKey();
        }

        static bool FirstLast6(int[] tablica) {

            if (tablica[0] == 6 || tablica[tablica.Length - 1] == 6 )
            {
                return true;
            }

            return false;
        }

        
    }
}
