using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindMasterModels
{
    class Program
    {
        static Colors GetColors()
        {
            Console.WriteLine("Choose a color :\n1. White\n2. Yellow\n3. Black\n4. Blue\n5. Green\n6. Red" );
            int chc = int.Parse(Console.ReadLine());
            return (Colors)(chc-1);
        }
        static void Main(string[] args)
        {
            /*
            //check if the Series class works
            Series s = new Series(Colors.WHITE, Colors.GREEN, Colors.RED, Colors.BLACK);
            Series magicSeries = new Series();
            Console.WriteLine($"Secret Series: {magicSeries} ");
            Console.WriteLine($"Guess Series: {s}");
            Console.WriteLine($"Bools: {magicSeries.Bools(s)} \nKliya: {magicSeries.Kliya(s)}");
            */
            Game g = new Game();
            int times = 0;
            while (times < 30 && !g.Won())
                {
                Console.WriteLine("Get 4 Colors ->");
                Colors c1 = GetColors();
                Colors c2 = GetColors();
                Colors c3 = GetColors();
                Colors c4 = GetColors();
                g.AddGuess(c1, c2, c3, c4);
                g.ShowMoves();
            }
            Console.WriteLine($"Good For you. You won after {g.GetGuessCounts()} moves");

            Console.ReadKey();
        }
    }
}
