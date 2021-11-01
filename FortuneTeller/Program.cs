using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm ennustab, mis juhtub kasutajaga homme (kasutame Random klassi)

            string[] predictions = { "win a million dollars", "fall in love", "buy Youtube Premium", "join the dark side for cookies" };

            Random rnd = new Random();
            int userFortune = rnd.Next(0, predictions.Length);

            Console.WriteLine($"Tomorrow you will {predictions[userFortune]}.");






        }
    }
}
