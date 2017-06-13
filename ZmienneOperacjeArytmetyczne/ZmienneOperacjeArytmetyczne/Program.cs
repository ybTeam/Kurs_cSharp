using System;

namespace ZmienneOperacjeArytmetyczne
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Operacje arytmetyczne
             * + dodawnie
             * - odejmowanie
             * * mnożenie
             * / dzielenie
             * % modulo
             * = przypisanie
             * ++ inkrementacja
             * -- dekrementacja
             */

            int zmienna1 = 20, zmienna2 = 3;

            Console.WriteLine(zmienna1 + " + " + zmienna2 + " = " + (zmienna1 + zmienna2));
            Console.WriteLine(zmienna1 + " - " + zmienna2 + " = " + (zmienna1 - zmienna2));
            Console.WriteLine(zmienna1 + " / " + zmienna2 + " = " + (zmienna1 / zmienna2));
            Console.WriteLine(zmienna1 + " * " + zmienna2 + " = " + (zmienna1 * zmienna2));
            Console.WriteLine(zmienna1 + " % " + zmienna2 + " = " + (zmienna1 % zmienna2));

            // Post inkrementacja i dekrementacja
            Console.WriteLine(zmienna1++ + " Zmienna1 inkrementacja");
            Console.WriteLine(zmienna2-- + " Zmienna2 dekrementacja");

            // Restowanie do wartosci poczatkowych
            zmienna1 = 20;
            zmienna2 = 3;

            // Pre inkrementacja i dekrementacja
            Console.WriteLine(++zmienna1 + " Zmienna1 inkrementacja");
            Console.WriteLine(--zmienna2 + " Zmienna2 dekrementacja");

            // Operatory przpisania
            zmienna1 = 20;
            zmienna2 = 3;
            zmienna1 += zmienna2;
            Console.WriteLine(" += " + zmienna1);

            zmienna1 = 20;
            zmienna2 = 3;
            zmienna1 -= zmienna2;
            Console.WriteLine(" -= " + zmienna1);

            zmienna1 = 20;
            zmienna2 = 3;
            zmienna1 /= zmienna2;
            Console.WriteLine(" /= " + zmienna1);

            zmienna1 = 20;
            zmienna2 = 3;
            zmienna1 *= zmienna2;
            Console.WriteLine(" *= " + zmienna1);

            zmienna1 = 20;
            zmienna2 = 3;
            zmienna1 %= zmienna2;
            Console.WriteLine(" %= " + zmienna1);
            Console.ReadKey();
        }
    }
}
