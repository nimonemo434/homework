using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace _2022._07._25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "";
            string s2 = "";
            string type = "";
            float f1 = 0;
            string answer = "";

            Write("input : ");
            s1 = ReadLine();

            while(true)
             {               
                Write("type : ");
                type = ReadLine();
                Write("input : ");
                s2 = ReadLine();

                switch(type)
                {
                    case "+":
                        f1 = float.Parse(s1) + float.Parse(s2);
                        break;
                    case "*":
                        f1 = float.Parse(s1) * float.Parse(s2);
                        break;
                    case "-":
                        f1 = float.Parse(s1) - float.Parse(s2);
                        break;
                    case "/":
                        f1 = float.Parse(s1) / float.Parse(s2);
                        break;

                        default:
                        Write("error");
                        break;
                }
                WriteLine("result : " + f1.ToString() + "\n\n");

                Write("continue?(y/n) : ");
                answer = ReadLine();

                WriteLine();
                WriteLine();

                if(answer == "y" || answer == "Y")
                {
                    s1 = f1.ToString();
                    continue;
                }
                else if(answer == "n" || answer == "N")
                {
                    break;
                }
                else
                {
                    Write("this is error");
                    return;
                }
             }
            Write("finish");

            ReadKey();
        }
    }
}
