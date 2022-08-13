using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homwork_07_24_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            food myfood = new food;
            myfood.HowMuchIsIt();

            Koreanfood myKoreanfood = new Koreanfood;
            myKoreanfood.guest();
            myKoreanfood.HowMuchIsIt();
        }
    }
    class food
    {
        public string name = "";
        protected float price = 0;
        private string camefrom = "seoul";

        public void HowMuchIsIt()
        {
            Console.WriteLine(camefrom);
            Console.WriteLine(price);

        }
        public void 
    }
}
