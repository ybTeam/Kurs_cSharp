using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatoryRelacyjne
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba1 = 15, liczba2 = 30;
            
            if(liczba1 == liczba2)
            {
                Console.WriteLine("Liczba1 jest rowna Liczba2");
            }

            if(liczba1 != liczba2)
            {
                Console.WriteLine("Liczba1 jest rozna od Liczba2");
            }

            if(liczba1 > liczba2)
            {
                Console.WriteLine("Liczba1 jest wieksze od Liczba2");
            }

            if (liczba1 < liczba2)
            {
                Console.WriteLine("Liczba1 jest mniejsza od Liczba2");
            }

            if (liczba1 >= liczba2)
            {
                Console.WriteLine("Liczba1 jest wieksze badz rowne Liczba2");
            }

            if (liczba1 <= liczba2)
            {
                Console.WriteLine("Liczba1 jest mniejsze badz rowne Liczba2");
            }
        }
    }
}
