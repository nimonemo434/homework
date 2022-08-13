using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022._07._29_food
{
    internal class side : koreafood
    {
        public int calorie = 0;
        public int happy = 0;
        public virtual int donteat(int Happy)
        {
            return Happy;
        }

        public virtual int eat(int calorie)
        {
            return calorie;
        }
    }
}
