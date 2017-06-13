using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogikaBoola
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba1 = 13, liczba2 = 23, liczba3 = 28;

            // Sprawdzane do odnalezienia pierwszej wartosci FALSE
            if(liczba1 < liczba2 && liczba1 < liczba3)
            {
                Console.WriteLine("Liczba1 jest mniejsza od Liczba2 i 3");
            }

            // Sprawdzane do konca nawet jezeli trakcie bedzie FALSE
            if (liczba1 < liczba2 & liczba1 < liczba3)
            {
                Console.WriteLine("Liczba1 jest mniejsza od Liczba2 i 3");
            }

            // Sprawdzane do odnalezienia pierwszej wartosci TRUE
            if (liczba2 < liczba1 || liczba2 < liczba3)
            {
                Console.WriteLine("Liczba2 jest mniejsza od Liczba1 lub 3");
            }

            // Sprawdzane do konca nawet jezeli w trakcie bedzie TRUE
            if (liczba2 < liczba1 | liczba2 < liczba3)
            {
                Console.WriteLine("Liczba2 jest mniejsza od Liczba1 lub 3");
            }

            /*
             * Wyrażanie liczba1 < liczba2 jest prawdziwe ale przez 
             * zastosowanie negacji ! wartość jest odwracana i daje FALSE
             * wiec ta linijka nie zostanie wypisana
             */

            if (!(liczba1 < liczba2))
            {
                Console.WriteLine("Liczba1 jest mniejsza od Liczba2");
            }

            Console.ReadKey();
        }
    }
}
