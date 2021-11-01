using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asnedab kõik 'o' tähed lauses 'Don't Panic!' nulliga
            //programm asendab kõik 'a' täed lauses 4-ga

            string dontP = "Don't Panic!";

            dontP = dontP.Replace('o', '0');
            dontP = dontP.Replace('a', '4');
            Console.WriteLine(dontP);
        }
    }
}
