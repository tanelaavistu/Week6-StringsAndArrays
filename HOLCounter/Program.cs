using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsooli, mitu 'h', 'o' ja 'l' tähte on lauses "Hello World!".

            string helloWorld = "Hello World!".ToLower();

            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for (int i = 0; i < helloWorld.Length; i++)
            {
                if (helloWorld[i] == 'h')
                {
                    hCounter++;
                }
                if (helloWorld[i] == 'o')
                {
                    oCounter++;
                }
                if (helloWorld[i] == 'l')
                {
                    lCounter++;
                }

            }

            Console.WriteLine($"Lauses 'Hello World!' on {hCounter} h täht, {oCounter} o tähte ja {lCounter} l tähte");
        }
    }
}
