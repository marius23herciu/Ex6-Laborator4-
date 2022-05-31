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
            long numar = int.Parse(Console.ReadLine());
            if (numar < 1)
            {
                Console.WriteLine("Introduceti un numar mai mare de 0!");
                return;
            }
            long start = 1; long calculFibonacci = 1; long numarPrecedent1 = 1;
            long rezultat = AfisareNElementFibonacci(start, numar, numarPrecedent1, calculFibonacci);
            Console.WriteLine("Numarul " + numar + " din sirul lui Fibonacci este " + rezultat);
        }

        static long AfisareNElementFibonacci(long start, long numar, long numarPrecedent, long calculFibonacci)
        {
            if (start > numar)
            {
                return calculFibonacci;
            }
            long precedent2 = numarPrecedent;
            if (start > 1)
            {
                numarPrecedent = calculFibonacci;
            }
            if (start > 2)
            {
                calculFibonacci = numarPrecedent + precedent2;
            }
            return calculFibonacci = AfisareNElementFibonacci(start + 1, numar, numarPrecedent, calculFibonacci);
        }
    }
}
