using System;

namespace Ex6_Laborator4_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex 6 dificultate ridicata
            //Scrieti o functie recursiva care va afisa al n - lea element din sirul lui
            //Fibonacci, n fiind citit de la tastatura

            Console.WriteLine("Introduceti un numar:");
            int numar = int.Parse(Console.ReadLine());
            if (numar < 1)
            {
                Console.WriteLine("Introduceti un numar mai mare de 0!");
                return;
            }
            int start = 1; long calculFibonacci = 1; long numarPrecedent1 = 1;
            AfisareNElementFibonacci(start, numar, calculFibonacci, numarPrecedent1);
        }

        static long AfisareNElementFibonacci(int start, int numar, long calculFibonacci, long numarprecedent)
        {
            while (start > numar)
            {
                Console.WriteLine("Numarul " + numar + " din sirul lui Fibonacci este " + calculFibonacci);
                return calculFibonacci;
            }
            long precedent2 = numarprecedent;
            if (start > 1)
            {
                numarprecedent = calculFibonacci;
            }
            if (start > 2)
            {
                calculFibonacci = numarprecedent + precedent2;
            }
            AfisareNElementFibonacci(start + 1, numar, calculFibonacci, numarprecedent);
            return calculFibonacci;
        }
    }
}
