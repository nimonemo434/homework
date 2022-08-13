using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022._07._24
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intarray = { 1, 2, 3, 4, 5, 6, 7, 8, };

            foreach (int thenumber in intarray) 
            {
                Console.WriteLine(thenumber + 3);
            }

            string s1 = "";

            s1 = Console.ReadLine();

            switch(s1)
            {
                case "1":
                    Console.WriteLine("hello");
                    break;
                case "2":
                    Console.WriteLine("my");
                    break;
                case "3":
                    Console.WriteLine("world");
                    break;
                case "4":
                    Console.WriteLine("SBS");
                    break;
                case "5":
                    Console.WriteLine("arcademy");
                    break;

                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
