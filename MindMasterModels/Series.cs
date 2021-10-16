using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindMasterModels
{
    class Series
    {
        private Colors[] colors;
        public Series (Colors c1, Colors c2, Colors c3, Colors c4)
        {
            colors = new Colors[] { c1, c2, c3, c4 };
        }
        public Series()
        {
            Colors[] temp = { Colors.BLACK, Colors.BLUE, Colors.GREEN, Colors.RED, Colors.WHITE, Colors.YELLOW };
            Random rnd = new Random();
            for (int i = 0; i < 50; i++)
            {
                int i1 = rnd.Next(6);
                int i2 = rnd.Next(6);
                if (i1!= i2)
                {
                    Colors c = temp[i1];
                    temp[i1] = temp[i2];
                    temp[i2] = c;
                }
            }
            colors = new Colors[4];
            for (int i = 0; i < 4; i++)
                colors[i] = temp[i];
        }
        public override string ToString()
        {
            string s = colors[0].ToString();
            for (int i = 1; i < 4; i++)
                s += ", " + colors[i].ToString();
            return s;
        }
        public bool Exists (Colors c1)
        {
            foreach (Colors c in colors)
                if (c == c1) return true;
            return false;
        }
        public Colors GetColor(int place) => colors[place];
        public int Bools (Series s)
        {
            int count = 0;
            for (int i = 0; i < 4; i++)
                if (colors[i] == s.colors[i])
                    count++;
            return count;
         }
        public int Kliya (Series s)
        {
            int count = 0;
            foreach (Colors c in colors)
                if (s.Exists(c))
                    count++;
            return count - Bools(s);
        }

    }
}
