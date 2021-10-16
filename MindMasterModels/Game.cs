using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindMasterModels
{
    class Game
    {
        private Series magicSeries;
        private Series[] guesses;
        private int counter;
        public Game ()
        {
            magicSeries = new Series();
            guesses = new Series[30];
        }
        public void AddGuess(Colors c1, Colors c2, Colors c3, Colors c4)
        {
            guesses[counter++] = new Series(c1, c2, c3, c4);
        }
        public int LastGuessBools ()
        {
            return guesses[counter - 1].Bools(magicSeries);
        }
        public int LastKliya() => guesses[counter - 1].Kliya(magicSeries);
        private string DisplayGuess (int i)
        {
            string s = guesses[i].ToString();
            s += $"| Bool -> {guesses[i].Bools(magicSeries)}   Kliya {guesses[i].Kliya(magicSeries)}";
            return s;
        }
 
        public void ShowMoves ()
        {
            for (int i = 0; i < counter; i++)
                Console.WriteLine( DisplayGuess(i));
        }
        public bool Won ()
        {
            if (counter == 0) return false;
            return guesses[counter - 1].Bools(magicSeries) == 4;
        }
        public int GetGuessCounts() => counter;
    }
}
