using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class Program
    {
        // Program porownujacy dlugosc wyrazow
        static void Main(string[] args)
        {
            // Deklaracja zmiennych
            string wyraz1, wyraz2, wyraz3;

            Console.WriteLine("Program do wyszukiwania najkrotszego wyrazu!");
            Console.WriteLine("Podaj pierwszy wyraz i nacisnij enter: ");
            wyraz1 = Console.ReadLine();
            Console.WriteLine("Podaj drugi wyraz i nacisnij enter: ");
            wyraz2 = Console.ReadLine();
            Console.WriteLine("Podaj trzeci wyraz i nacisnij enter: ");
            wyraz3 = Console.ReadLine();

            // operacja length na stringach zwraca ich dlugosc
            /* W Console.WriteLine mozemy definiowac miejsca w stringu na zmienne
             * poprzez nawiasy klarmowe { } i podaniu w srodku numeru zmiennej zaczynajac od 0
             * nastepnie za stringiem po przecinkach podejmy jakie zmienne chcemy tam podstawic
             * kolejnosc oczywiscie ma znaczenie 
             */
            
            // Sprawdzamy czy wraz 1 jest dluzszy od 2
            if(wyraz1.Length > wyraz2.Length)
            {
                Console.WriteLine("Wyraz1 {0} jest dluzszy od Wyraz2: {1}", wyraz1, wyraz2);

                // Jesli jest dluszy od 2 to sprawdzmy czy jest dluzszy od 3
                if(wyraz1.Length > wyraz3.Length)
                {
                    Console.WriteLine("Wyraz1 {0} jest dluzszy od Wyraz3: {1}", wyraz1, wyraz3);
                }
                // Jesli nie jest dluszy od 3 to 3 jest najdluzszy 
                else
                {
                    Console.WriteLine("Wyraz3 {0} jest dluzszy lub rowny Wyraz1: {1}", wyraz3, wyraz1);
                }
            }
            // Sprawdzamy czy wyraz 2 jest dluzszy jednoczesnie od 1 i 3 
            else if(wyraz2.Length > wyraz1.Length && wyraz2.Length > wyraz3.Length)
            {
                Console.WriteLine("Wyraz2: {0} jest dluzszy od Wyraz1: {1} i Wyraz3: {2}", wyraz2, wyraz1, wyraz3);
            }
            // Jesli wyrazy 1 i 2 nie beda najdluzsze to bedzie to 3
            else
            {
                Console.WriteLine("Wyraz3: {0} jest dluzszy lub rowny Wyraz1: {1} i Wyraz2: {2}", wyraz3, wyraz1, wyraz2);
            }

            Console.ReadKey();
        }
    }
}
