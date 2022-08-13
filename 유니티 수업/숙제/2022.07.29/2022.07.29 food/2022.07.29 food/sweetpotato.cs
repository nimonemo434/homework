using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022._07._29_food
{
    internal class sweetpotato : rice
    {
        public override int donteat(int empty)
        {
            base.donteat(empty);
            Console.WriteLine("고구마밥을 안먹었다(조금 배고프다)");
            return empty/2;
        }
        public override int eat(int carboh)
        {
            base.eat(carboh);
            Console.WriteLine("고구마밥을 먹었다(탄수화물이 많이 늘었다)");
            return carboh*2;
        }
    }
}
