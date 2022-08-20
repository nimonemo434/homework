using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("게임을 시작합니다");

            for (int i = 0; i < 7; i++)
            {
                Random random = new Random();
                int randomNumber = random.Next(0, 5);
                WriteLine(randomNumber);

                string answer = "";
                Write("상대방을 공격 하시겠습니까?(Y/N) : ");
                answer = ReadLine();

                if (answer == "y" || answer == "Y")
                {
                    WriteLine("상대방을 공격했습니다!");
                    if (randomNumber == 1)
                    {
                        WriteLine();
                        WriteLine("탕!!!!!!!");
                        WriteLine("승리했습니다");
                        ReadKey();
                        return;
                    }
                    else
                    {
                        WriteLine();
                        WriteLine("아무일도 일어나지 않았습니다");
                        WriteLine("");
                        WriteLine("패배했습니다");
                        ReadKey();
                        return;
                    }
                }
                else if (answer == "n" || answer == "N")
                {
                    WriteLine("자신의 머리에 총구를 겨누고 격발합니다");
                    if (randomNumber == 1)
                    {
                        WriteLine();
                        WriteLine("탕!!!!!!!");
                        WriteLine("패배했습니다");
                        ReadKey();
                        return;
                    }
                    else if (randomNumber == 2)
                    {
                        WriteLine();
                        WriteLine("일단 살아았습니다");
                        WriteLine("상대방의 차례입니다");
                        WriteLine();
                        WriteLine("탕!!!!!!!");
                        WriteLine("총구에서 격발음과 함께 불꽃이 튀깁니다");
                        WriteLine("승리했습니다");
                        ReadKey();
                        return;
                    }
                    else
                    {
                        WriteLine();
                        WriteLine("일단 살아았습니다");
                        WriteLine("상대방의 차례입니다");
                        WriteLine();
                        WriteLine("아무일도 일어나지 않았습니다");
                        WriteLine("총알을 재장전하고 다시 시작합니다");
                        continue;
                    }
                }
                else
                {
                    WriteLine();
                    WriteLine("잘못입력했습니다");
                    WriteLine("다시 시작합니다");
                    continue;
                }
            }

            WriteLine("아무도 죽지 않았습니다");
            ReadKey();
        }
    }
}
