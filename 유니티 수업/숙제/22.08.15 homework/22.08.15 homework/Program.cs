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
        static void Start() // 게임 진행
        {
            SetCursorPosition(0, 10); // 커서 위치
            CursorVisible = true; //커서 깜빡임 켜기
            WriteLine("  게임을 시작합니다");

            for (int i = 0; i < 7; i++) //7번의 반복문
            {
                SetCursorPosition(0, 0);
                Console.ForegroundColor = ConsoleColor.Red; //그림 색
                WriteLine();
                WriteLine("        ###########################");
                WriteLine("        ****************************");
                WriteLine("                %%%%%%%%%%%%%%%%%%%%");
                WriteLine("                       @     @@@@@@@@");
                WriteLine("                        #     ########");
                WriteLine("                         ##############");
                WriteLine("                                ########");
                WriteLine("                                 ########");
                Console.ForegroundColor = ConsoleColor.White; //글자 색

                SetCursorPosition(0, 12); //커서 위치
                CursorVisible = true;

                Random random = new Random();
                int randomNumber = random.Next(0, 5); //6개의 랜덤 숫자 받기
                WriteLine(randomNumber);

                string answer = "";
                Write("  상대방을 공격 하시겠습니까?(Y/N) : "); //플레이어의 입력받기
                answer = ReadLine();

                if (answer == "y" || answer == "Y") //공격을 선택할 경우 조건문
                {
                    WriteLine("  상대방에게 총구를 겨누고 격발합니다!");
                    if (randomNumber == 1) //랜덤한 숫자가 1일경우
                    {
                        WriteLine();
                        WriteLine("  탕!!!!!!!");
                        WriteLine("  승리했습니다");
                        ReadKey();
                        CursorVisible = false;
                        Clear();
                        return;
                    }
                    else //그외 나머지
                    {
                        WriteLine();
                        WriteLine("  아무일도 일어나지 않았습니다");
                        WriteLine("");
                        WriteLine("  패배했습니다");
                        ReadKey();
                        CursorVisible = false;
                        Clear();
                        return;
                    }
                }
                else if (answer == "n" || answer == "N") //자결을 선택할 경우 조건문
                {
                    WriteLine("  자신의 머리에 총구를 겨누고 격발합니다");
                    if (randomNumber == 1) //랜덤한 숫자의 1일경우
                    {
                        WriteLine();
                        WriteLine("  탕!!!!!!!");
                        WriteLine("  패배했습니다");
                        ReadKey();
                        CursorVisible = false;
                        Clear();
                        return;
                    } //이 아래부터는 컴퓨터의 차례
                    else if (randomNumber == 2) //랜덤한 숫자가 2인 경우
                    {
                        WriteLine();
                        WriteLine("  일단 살아았습니다");
                        WriteLine("  상대방의 차례입니다");
                        WriteLine();
                        WriteLine("  탕!!!!!!!");
                        WriteLine("  총구에서 격발음과 함께 불꽃이 튀깁니다");
                        WriteLine("  승리했습니다");
                        ReadKey();
                        CursorVisible = false;
                        Clear();
                        return;
                    }
                    else
                    {
                        WriteLine();
                        WriteLine("  일단 살아았습니다");
                        WriteLine("  상대방의 차례입니다");
                        WriteLine();
                        WriteLine("  아무일도 일어나지 않았습니다");
                        WriteLine("  총알을 재장전하고 다시 시작합니다");
                        ReadKey();
                        CursorVisible = false;
                        Clear();
                        continue;
                    }
                }
                else
                {
                    WriteLine();
                    WriteLine("  잘못입력했습니다");
                    WriteLine("  다시 시작합니다");
                    ReadKey();
                    CursorVisible = false;
                    Clear();
                    continue;
                }
            }
            WriteLine("  아무도 죽지 않았습니다");
            ReadKey();
        }
        static void WaitMenu(ref int posY) // 메인메뉴
        {
            bool _letOut = false; //키 입력시 탈출방지

            SetCursorPosition(15, 9); //시작 위치
            WriteLine("시작");
            SetCursorPosition(15, 10); //종료 위치
            WriteLine("종료");

            do
            {
                for (int k = 0; k < 2; k++)
                {
                    SetCursorPosition(10, k + 9); //빈칸
                    Write("  ");
                }
                SetCursorPosition(10, posY + 9); //커서 위치
                Write("▶"); //커서 모양

                ConsoleKeyInfo key = Console.ReadKey(true); //키 입력 매커니즘

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow: //위 입력
                        posY--;
                        if (posY < 0)
                        {
                            posY = 1;
                        }
                        break;
                    case ConsoleKey.DownArrow: //아래 입력
                        posY++;
                        if (posY > 1)
                        {
                            posY = 0;
                        }
                        break;
                    case ConsoleKey.Enter: //엔터 입력
                        _letOut = true; //탈출
                        break;
                }

            } while (!_letOut);

            SetCursorPosition(0, 0);
        }
        static void StartJa() //메인메뉴 간판
        {
            Console.ForegroundColor = ConsoleColor.Red; //그림 색
            WriteLine();
            WriteLine("        ############################");
            WriteLine("        ■                        ■");
            WriteLine("        ■     너 죽고 나 살자    ■");
            WriteLine("        ■                        ■");
            WriteLine("        ############################");
            Console.ForegroundColor = ConsoleColor.White; //글자 색

        }
        static void Main(string[] args) //메인메뉴 와 게임 연결
        {
            int posY = 0;
            bool _isFinish = false;
            bool _isStart = false;
            CursorVisible = false;
            do
            {
                if (_isStart)
                {
                    switch (posY)
                    {
                        case 0: 
                            Start(); // 게임 연결
                            _isStart = false;
                            break;

                        case 1: //종료
                            _isFinish = true;
                            break;
                    }
                }
                else
                {
                    StartJa();
                    WaitMenu(ref posY); //메인메뉴 그래픽 불러오기
                    _isStart = true;
                    Clear();
                }

            } while (!_isFinish);
        }
    }
}
