using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisetada ees- ja perekonnanime
            //programm kontrollib andmete pikkust
            //programm kuvab kumb nendes on pikem, kas ees- või perekonnanimi

            Console.WriteLine("Palun sisesta oma eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Palun sisesta oma perekonnanimi:");
            string lastName = Console.ReadLine();

            if (firstName.Length < lastName.Length)
            {
                Console.WriteLine("Sinu perekonnanimi on eesnimest pikem!");
            }
            else
            {
                Console.WriteLine("Sinu eesnimi on perekonnanimest pikem!");
            }
        }
    }
}
