using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homwork_07_24_2_
{
    class Program
    {
        static void Main()
        {
            string s1 = "";
            string s2 = "";
            string type = "";

            Console.Write("input1 : ");
            s1 = Console.ReadLine();
            Console.Write("input2 : ");
            s2 = Console.ReadLine();
            Console.Write("type : ");
            type = Console.ReadLine();

            int resultnew = Calculator(int.Parse(s1), int.Parse(s2), type);

            Console.WriteLine(resultnew);
        }

        static int Calculator(int num1, int num2, string a)
        {
            int result = 0;

            switch (a)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
            }
            return result;
        }
    }
}
