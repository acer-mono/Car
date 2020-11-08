using System;

namespace Car
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var plant = new Plant();
            
            Console.WriteLine(plant.GetCarInfo());
        }
    }
}