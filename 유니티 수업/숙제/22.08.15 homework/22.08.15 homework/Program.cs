using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _22._08._15_homework
{
    internal class Program
    {
        static void Start()
        {
            SetCursorPosition(0, 2);
            CursorVisible = true;
            WriteLine("게임을 시작합니다");

            for (int i = 0; i < 7; i++)
            {
                SetCursorPosition(0, 4);

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
                        Clear();
                        return;
                    }
                    else
                    {
                        WriteLine();
                        WriteLine("아무일도 일어나지 않았습니다");
                        WriteLine("");
                        WriteLine("패배했습니다");
                        ReadKey();
                        Clear();
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
                        Clear();
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
                        Clear();
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
                        ReadKey();
                        Clear();
                        continue;
                    }
                }
                else
                {
                    WriteLine();
                    WriteLine("잘못입력했습니다");
                    WriteLine("다시 시작합니다");
                    ReadKey();
                    Clear();
                    continue;
                }
            }
            WriteLine("아무도 죽지 않았습니다");
            ReadKey();
        }
        static void WaitMenu(ref int posY)
        {
            bool _letOut = false;

            SetCursorPosition(15, 9);
            WriteLine("시작");
            SetCursorPosition(15, 10);
            WriteLine("종료");

            do
            {
                for (int k = 0; k < 4; k++)
                {
                    SetCursorPosition(10, k + 9);
                    Write("  ");
                }
                SetCursorPosition(10, posY + 9);
                Write("▶");

                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        posY--;
                        if (posY < 0)
                        {
                            posY = 1;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        posY++;
                        if (posY > 1)
                        {
                            posY = 0;
                        }
                        break;
                    case ConsoleKey.Enter:
                        _letOut = true;
                        break;
                }

            } while (!_letOut);

            SetCursorPosition(0, 0);
        }
        static void Main(string[] args)
        {
            int posY = 0;
            bool _isFinish = false;
            bool _isStart = false;
            CursorVisible = false;
            do
            {
                if (_isStart) //시작(enter)키를 누른 경우
                {
                    switch (posY)
                    {
                        case 0: 
                            Start();
                            _isStart = false;
                            break;

                        case 1: 
                            _isFinish = true;
                            break;
                    }
                }
                else //대기화면인 경우
                {
                    WaitMenu(ref posY);
                    _isStart = true;
                    Clear();
                }

            } while (!_isFinish);
        }
    }
}
