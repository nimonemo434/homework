using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022._07._29_food
{
    internal class meat : side
    {
        public override int donteat(int Happy)
        {
            base.donteat(Happy);
            Console.WriteLine("고기를 안먹었다(행복하지 않다)");
            return 0;
        }
        public override int eat(int calorie)
        {
            base.eat(calorie);
            Console.WriteLine("고기를 먹었다(칼로리가 조금 늘었다)");
            return calorie/2;
        }
    }
}
