using System;
using Roulette.Game;


namespace Roulette
{
    class Program
    {
        static void Main()
        {
            Bets bets = new Bets();
            int bin = Game.Roulette.Spin();

            Console.WriteLine($"\n\nThe winning number is {bin}");
            Console.WriteLine($"\nEvens and odds: {bets.EvensOdds(bin)}");
            Console.WriteLine($"\nReds/Blacks: {bets.RedsOrBlacks(bin)}");
            Console.WriteLine($"\nLows/Highs: {bets.LowsAndHighs(bin)}");
            Console.WriteLine($"\nDozens: {bets.Dozens(bin)}");
            Console.WriteLine($"\nColumns: {bets.Columns(bin)}");
            Console.WriteLine($"\nStreets: {bets.Street(bin)}");
            Console.WriteLine($"\n6 Numbers: {bets.SixNumbers(bin)}");
            Console.WriteLine($"\nSplit: {bets.Split(bin)}");
            Console.WriteLine($"\nCorner: {bets.Corner(bin)}");
            Console.WriteLine("\n\nWould you like to spin again? Y/n");
            string input = Console.ReadLine();
            if (input.ToLower() == "y")
            {
                Main();
            }
            else
            {
                return;
            }
        }
    }
}
