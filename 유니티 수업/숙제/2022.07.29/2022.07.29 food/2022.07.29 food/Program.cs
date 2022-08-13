using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022._07._29_food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            potato Potato = new potato();
            sweetpotato Sweetpotato = new sweetpotato();
            meat Meat = new meat();
            kimch Kimch = new kimch();

            int happy;
            int calorie;
            int carboh;
            int empty;
            string name = "김동록";

            carboh = Potato.eat(10) + Sweetpotato.eat(10);          
            happy = Kimch.donteat(10) + Meat.donteat(10);
            calorie = Kimch.eat(10) + Meat.eat(10);
            empty = Potato.donteat(10) + Sweetpotato.donteat(10);

            Console.WriteLine($"{name}\n행복도 : {happy} 칼로리 : {calorie} 탄수화물 : {carboh} 공복 : {empty}");
            Console.ReadLine();
        }
    }
}
