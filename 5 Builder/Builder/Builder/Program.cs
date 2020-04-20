using System;

namespace Builder
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            EleganceCar eleganceCar = new EleganceCar();
            NormalCar normalCar = new NormalCar();

            Dealer carDealer = new Dealer(eleganceCar);

            Console.WriteLine("Client wants a Elegance Car");
            Console.WriteLine("Dealer build a Elegance Car ");
            carDealer.ProduceCar();
            Console.WriteLine("Dealer get the Elegance Car for to deliver to client");
            carDealer.GetCar();
        }
    }
}