using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace hero
{
    internal class Program
    {
        static void randommonster() // 6가지수의 랜덤한 상황 발생
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 5);

            hero Hero = new hero();
            Hero.Init();
            goblin Goblin = new goblin();
            Goblin.Init();
            orc Orc = new orc();
            Orc.Init();
            bear Bear = new bear();
            Bear.Init();
            wolf Wolf = new wolf();
            Wolf.Init();
            ogre Ogre = new ogre();
            Ogre.Init();

            if (randomNumber == 1)
            {
                do
                {
                    WriteLine("당신은 고블린과 마주쳤습니다");
                    WriteLine();
                    Random goblin = new Random();
                    int goblinNumber = goblin.Next(0, 5);
                    if (goblinNumber == 0)
                    {
                        WriteLine();
                        Goblin.Attack(Hero);
                        ReadKey();
                    }
                    else
                    {
                        WriteLine("당신이 공격할 차례입니다");
                        WriteLine("어디를 공격하시겠습니까?");
                        string pa = "";
                        Write("정면( 1 ) 우측 ( 2 ) 좌측 ( 3 ) : ");
                        pa = ReadLine();
                        if (int.Parse(pa) == 1)
                        {
                            Hero.Attack(Goblin);
                        }
                        else if(int.Parse(pa) == 2)
                        {
                            Random pagb = new Random();
                            int pagb2 = pagb.Next(0, 3);
                            if(pagb2 == 0)
                            {
                                WriteLine();
                                Hero.Attack(Goblin);
                                WriteLine();
                            }
                            else
                            {
                                WriteLine();
                                Hero.CriticalAttack(Goblin);
                                WriteLine();
                            }
                        }
                        else
                        {
                            Random pagb = new Random();
                            int pagb2 = pagb.Next(0, 3);
                            if (pagb2 == 0)
                            {
                                WriteLine();
                                Hero.Attack(Goblin);
                                WriteLine();
                            }
                            else
                            {
                                WriteLine();
                                Hero.CriticalAttack(Goblin);
                                WriteLine();
                            }
                        }                     
                    }
                } while (Hero.Hp > 0 && Goblin.Hp > 0);
                if (Goblin.Hp <= 0)
                {
                    WriteLine();
                    WriteLine("고블린이 쓰려졌습니다");
                    WriteLine();
                }
                else if(Hero.Hp <= 0)
                {
                    WriteLine();
                    WriteLine("당신의 패배입니다");
                    WriteLine();
                }
            }
            else if (randomNumber == 2)
            {
                do
                {
                    WriteLine("당신은 오크와 마주쳤습니다");
                    WriteLine();
                    Random goblin = new Random();
                    int goblinNumber = goblin.Next(0, 5);
                    if (goblinNumber == 0)
                    {
                        WriteLine();
                        Orc.Attack(Hero);
                        ReadKey();
                    }
                    else if (goblinNumber == 1)
                    {
                        WriteLine();
                        Orc.CriticalAttack(Hero);
                        ReadKey();
                    }
                    else
                    {
                        WriteLine("당신이 공격할 차례입니다");
                        WriteLine("어디를 공격하시겠습니까?");
                        string pa = "";
                        Write("정면( 1 ) 우측 ( 2 ) 좌측 ( 3 ) : ");
                        pa = ReadLine();
                        if (int.Parse(pa) == 1)
                        {
                            WriteLine();
                            Hero.Attack(Orc);
                            WriteLine();
                        }
                        else if (int.Parse(pa) == 2)
                        {
                            Random pagb = new Random();
                            int pagb2 = pagb.Next(0, 3);
                            if (pagb2 == 0)
                            {
                                WriteLine();
                                Hero.Attack(Orc);
                                WriteLine();
                            }
                            else
                            {
                                WriteLine();
                                Hero.CriticalAttack(Orc);
                                WriteLine();
                            }
                        }
                        else
                        {
                            Random pagb = new Random();
                            int pagb2 = pagb.Next(0, 5);
                            if (pagb2 == 0)
                            {
                                WriteLine();
                                Hero.Attack(Orc);
                                WriteLine();
                            }
                            else
                            {
                                WriteLine();
                                Hero.CriticalAttack(Orc);
                                WriteLine();
                            }
                        }
                    }
                } while (Hero.Hp > 0 && Orc.Hp > 0);
                if (Orc.Hp <= 0)
                {
                    WriteLine();
                    WriteLine("오크가 쓰려졌습니다");
                    WriteLine();
                }
                else if (Hero.Hp <= 0)
                {
                    WriteLine();
                    WriteLine("당신의 패배입니다");
                    WriteLine();
                }
            }
            else if (randomNumber == 3)
            {
                do
                {
                    WriteLine("당신은 오거와 마주쳤습니다");
                    WriteLine();
                    Random goblin = new Random();
                    int goblinNumber = goblin.Next(0, 5);
                    if (goblinNumber == 0)
                    {
                        WriteLine();
                        Ogre.Attack(Hero);
                        ReadKey();
                    }
                    else if (goblinNumber == 1)
                    {
                        WriteLine();
                        Ogre.CriticalAttack(Hero);
                        ReadKey();
                    }
                    else if (goblinNumber == 2)
                    {
                        WriteLine();
                        WriteLine("멍청한 오거가 실수로 자신을 공격합니다");
                        Ogre.Attack(Ogre);
                        ReadKey();
                    }
                    else
                    {
                        WriteLine("당신이 공격할 차례입니다");
                        WriteLine("어디를 공격하시겠습니까?");
                        string pa = "";
                        Write("정면( 1 ) 우측 ( 2 ) 좌측 ( 3 ) : ");
                        pa = ReadLine();
                        if (int.Parse(pa) == 1)
                        {
                            Hero.Attack(Ogre);
                        }
                        else if (int.Parse(pa) == 2)
                        {
                            Random pagb = new Random();
                            int pagb2 = pagb.Next(0, 3);
                            if (pagb2 == 0)
                            {
                                WriteLine();
                                Hero.Attack(Ogre);
                                WriteLine();
                            }
                            else
                            {
                                WriteLine();
                                Hero.CriticalAttack(Ogre);
                                WriteLine();
                            }
                        }
                        else
                        {
                            Random pagb = new Random();
                            int pagb2 = pagb.Next(0, 1);
                            if (pagb2 == 0)
                            {
                                WriteLine();
                                Hero.Attack(Ogre);
                                WriteLine();
                            }
                            else
                            {
                                WriteLine();
                                Hero.CriticalAttack(Ogre);
                                WriteLine();
                            }
                        }
                    }
                } while (Hero.Hp > 0 && Ogre.Hp > 0);
                if (Ogre.Hp <= 0)
                {
                    WriteLine();
                    WriteLine("오거가 쓰려졌습니다");
                    WriteLine();
                }
                else if (Hero.Hp <= 0)
                {
                    WriteLine();
                    WriteLine("당신의 패배입니다");
                    WriteLine();
                }
            }
            else if (randomNumber == 4)
            {
                do
                {
                    WriteLine("당신은 늑대와 마주쳤습니다");
                    WriteLine();
                    Random goblin = new Random();
                    int goblinNumber = goblin.Next(0, 2);
                    if (goblinNumber == 0)
                    {
                        WriteLine();
                        Wolf.Attack(Hero);
                        ReadKey();
                    }
                    else
                    {
                        WriteLine("당신이 공격할 차례입니다");
                        WriteLine("어디를 공격하시겠습니까?");
                        string pa = "";
                        Write("정면( 1 ) 우측 ( 2 ) 좌측 ( 3 ) : ");
                        pa = ReadLine();
                        if (int.Parse(pa) == 1)
                        {
                            Random pagb = new Random();
                            int pagb2 = pagb.Next(0, 5);
                            if (pagb2 == 0)
                            {
                                WriteLine();
                                Hero.Attack(Wolf);
                                WriteLine();
                            }
                            else
                            {
                                WriteLine();
                                Hero.CriticalAttack(Wolf);
                                WriteLine();
                            }
                        }
                        else if (int.Parse(pa) == 2)
                        {
                            Random pagb = new Random();
                            int pagb2 = pagb.Next(0, 1);
                            if (pagb2 == 0)
                            {
                                WriteLine();
                                Hero.Attack(Wolf);
                                WriteLine();
                            }
                            else
                            {
                                WriteLine();
                                Hero.CriticalAttack(Wolf);
                                WriteLine();
                            }
                        }
                        else
                        {
                            Random pagb = new Random();
                            int pagb2 = pagb.Next(0, 1);
                            if (pagb2 == 0)
                            {
                                WriteLine();
                                Hero.Attack(Wolf);
                                WriteLine();
                            }
                            else
                            {
                                WriteLine();
                                Hero.CriticalAttack(Wolf);
                                WriteLine();
                            }
                        }
                    }
                } while (Hero.Hp > 0 && Wolf.Hp > 0);
                if (Wolf.Hp <= 0)
                {
                    WriteLine();
                    WriteLine("늑대가 쓰려졌습니다");
                    WriteLine();
                }
                else if (Hero.Hp <= 0)
                {
                    WriteLine();
                    WriteLine("당신의 패배입니다");
                    WriteLine();
                }
            }
            else if (randomNumber == 5)
            {
                do
                {
                    WriteLine("당신은 곰과 마주쳤습니다");
                    WriteLine();
                    Random goblin = new Random();
                    int goblinNumber = goblin.Next(0, 4);
                    if (goblinNumber == 0)
                    {
                        WriteLine();
                        Bear.Attack(Hero);
                        ReadKey();
                    }
                    else
                    {
                        WriteLine("당신이 공격할 차례입니다");
                        WriteLine("어디를 공격하시겠습니까?");
                        string pa = "";
                        Write("정면( 1 ) 우측 ( 2 ) 좌측 ( 3 ) : ");
                        pa = ReadLine();
                        if (int.Parse(pa) == 1)
                        {
                            WriteLine();
                            Hero.Attack(Bear);
                            WriteLine();
                        }
                        else if (int.Parse(pa) == 2)
                        {
                            Random pagb = new Random();
                            int pagb2 = pagb.Next(0, 3);
                            if (pagb2 == 0)
                            {
                                WriteLine();
                                Hero.Attack(Bear);
                                WriteLine();
                            }
                            else
                            {
                                WriteLine();
                                Hero.CriticalAttack(Bear);
                                WriteLine();
                            }
                        }
                        else
                        {
                            Random pagb = new Random();
                            int pagb2 = pagb.Next(0, 3);
                            if (pagb2 == 0)
                            {
                                WriteLine();
                                Hero.Attack(Bear);
                                WriteLine();
                            }
                            else
                            {
                                WriteLine();
                                Hero.CriticalAttack(Bear);
                                WriteLine();
                            }
                        }
                    }
                } while (Hero.Hp > 0 && Bear.Hp > 0);
                if (Bear.Hp <= 0)
                {
                    WriteLine();
                    WriteLine("곰이 쓰려졌습니다");
                    WriteLine();
                }
                else if (Hero.Hp <= 0)
                {
                    WriteLine();
                    WriteLine("당신의 패배입니다");
                    WriteLine();
                }
            }
            else
            {
                WriteLine("당신은 운이 좋았습니다");
                WriteLine("아무것도 마주치지 않고 통과했습니다");
            }
            ReadKey();
        }
        static void start() // 메소드 start
        {
            for (int i = 0; i < 3; i++) // 아래 내용들을 3번 반복
            {
                string choice = "";
                WriteLine();
                WriteLine();
                WriteLine("당신은 갈림길에 서있습니다 방향을 선택하세요");
                Write("왼쪽 = 1, 가운데 = 2, 오른쪽 = 3 : ");
                choice = ReadLine();

                if (int.Parse(choice) == 1) // 3가지 경우 내용은 모두 똑같지만 randommonster 메소드 덕분에 다른 상황이 연출 될수있다 일종의 눈속임
                {
                    WriteLine("당신은 왼쪽길을 선택했습니다");
                    WriteLine();
                    randommonster();
                }
                else if (int.Parse(choice) == 2)
                {
                    WriteLine("당신은 가운데길을 선택했습니다");
                    WriteLine();
                    randommonster();
                }
                else if(int.Parse(choice) == 3)
                {
                    WriteLine("당신은 오른쪽길을 선택했습니다");
                    WriteLine();
                    randommonster();
                }
                else
                {
                    WriteLine("잘못 입력했습니다,");
                    continue;
                }
            }
            WriteLine("긴 여정 끝에 당신은 다음마을에 도착했습니다");
            ReadKey();
            Clear();
        }  //영웅의 체력을 저장하고 진행되는 동안 "0" 이 되면 게임이 끝났어야 했다
        static void WaitMenu(ref int posY) // 메인메뉴
        {
            bool _letOut = false; //키 입력시 탈출방지

            SetCursorPosition(15, 14); //모험 시작 위치
            WriteLine("모험 시작");
            SetCursorPosition(15, 15); //종료 위치
            WriteLine("종료");

            do
            {
                for (int k = 0; k < 2; k++)
                {
                    SetCursorPosition(10, k + 14); //빈칸
                    Write("  ");
                }
                SetCursorPosition(10, posY + 14); //커서 위치
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
            Console.ForegroundColor = ConsoleColor.Blue; //그림 색
            WriteLine();
            WriteLine("        @@@@@   @@@   @@@  @     @@@");
            WriteLine("                                      ");
            WriteLine("                      $              ");
            WriteLine("                     $$$           ");
            WriteLine("                     $$$           ");
            WriteLine("                     $$$           ");
            WriteLine("                     $$$           ");
            WriteLine("                   #######     ");
            WriteLine("                      @            ");
            WriteLine("                      @            ");
            WriteLine();
            WriteLine("        ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            WriteLine();
            Console.ForegroundColor = ConsoleColor.White; //글자 색
        }
        static void Main(string[] args)
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
                            start(); // 게임 연결
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
