using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022._07._29_food
{
    internal class rice : koreafood
    {
        public int carboh = 0;
        public int empty = 0;
        public virtual int donteat(int empty)
        {
            return empty;
        }

        public virtual int eat(int carboh)
        {
            return carboh;
        }
    }
}
