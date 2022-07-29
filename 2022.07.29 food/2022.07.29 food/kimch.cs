using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022._07._29_food
{
    internal class kimch : side
    {
        public override int donteat(int Happy)
        {
            base.donteat(Happy);
            Console.WriteLine("김치를 안먹었다(행복 하다)");
            return Happy;
        }
        public override int eat(int calorie)
        {
            base.eat(calorie);
            Console.WriteLine("김치를 먹었다(칼로리가 변하지 않았다)");
            return 0;
        }
    }
}
