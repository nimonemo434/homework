using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;
using System.Media; //사운드 출력

//clear() 사용시 반짝거림.
//그렇다면 그냥 배경을 칠해서 지우자. 반짝거리지 않을것.
//배경을 칠하고 그위에 다시 그리고.

namespace 구슬_게임
{
    enum Color
    {
        red = 0, green, blue, darkYellow
    }
    
    public static class Form
    {
        public static int count = 0;
        static bool _isStart = false;

        //찍을 점의 갯수, 번째 줄(2의 배수로)
        public static void RedLine(int Num, int Line)
        {
            for (int i = 0; i < Num; i++)
            {
                SetCursorPosition(Line, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Write("▒");
                Console.ForegroundColor = ConsoleColor.White;
                WriteLine();
            }
        }

        public static void GreenLine(int Num, int Line)
        {
            for (int i = 0; i < Num; i++)
            {
                SetCursorPosition(Line, i);
                Console.ForegroundColor = ConsoleColor.Green;
                Write("▒");
                Console.ForegroundColor = ConsoleColor.White;
                WriteLine();
            }
        }

        public static void BlueLine(int Num, int Line)
        {
            for (int i = 0; i < Num; i++)
            {
                SetCursorPosition(Line, i);
                Console.ForegroundColor = ConsoleColor.Blue;
                Write("▒");
                Console.ForegroundColor = ConsoleColor.White;
                WriteLine();
            }
        }

        //줄을 움직이는 것처럼 보이게 하기 위해 Clear대신 줄을 지웁니다.(덮어 쓰기)
        public static void DeleteLine(int Num, int Line)
        {
            for (int i = 0; i < Num; i++)
            {
                SetCursorPosition(Line, i);
                Console.ForegroundColor = ConsoleColor.Blue;
                Write(" ");
                Console.ForegroundColor = ConsoleColor.White;
                WriteLine();
            }
        }



        public static void CoinDrawing(int X, int Y)
        {
            for(int k = 0; k < 2; k++)
            {
                for (int t = 0; t < 15; t++)
                {
                    SetCursorPosition(X + 4 + t, Y + (k * 4));
                    Console.BackgroundColor = ConsoleColor.Black;
                    Write(" ");
                }
            }
            for(int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        SetCursorPosition(X + k + (i * 19), Y + 1 + (j * 2));
                        Console.BackgroundColor = ConsoleColor.Black;
                        Write(" ");
                    }
                }
            }
            
            for (int t = 0; t < 15; t++)
            {
                SetCursorPosition(X + 4 + t, Y + 3);
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Write(" ");
            }

            for (int t = 0; t < 15; t++)
            {
                SetCursorPosition(X + 4 + t, Y + 1);
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Write(" ");
            }

            for (int i = 0; i < 23; i++)
            {
                SetCursorPosition(X + i, Y + 2);
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Write(" ");
            }

            for (int t = 0; t < 15; t++)
            {
                SetCursorPosition(X + 4 + t, Y + 3);
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Write(" ");
            }

            for (int i = 0; i < 3; i++)
            {
                SetCursorPosition(X - 1 + (i * 12), Y + 2);
                Console.BackgroundColor = ConsoleColor.Black;
                Write(" ");
            }
        }

        public static void GoldDrawing(int X, int Y)
        {
            //바탕 노란색
            Console.BackgroundColor = ConsoleColor.Yellow;
            for (int k = 0; k < 5; k++)
            {
                for (int i = 0; i < 5; i++)
                {
                    SetCursorPosition(X + 5 + (i + (5 * k)), Y - k);
                    Write("    ");
                    SetCursorPosition(X + 3 + (i + (5 * k)), Y - (k - 1));
                    Write("      ");
                }
            }
            
            for(int j = 0; j< 4; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        SetCursorPosition(X + (i + (4 * k)), Y + 5 + k - j);
                        Write(" ");
                    }
                }
            }
            for(int j = 0; j< 4; j++)
            {
                for (int k = 0; k < 5; k++)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        SetCursorPosition(X + 12 + (i + (5 * k)), Y - (k - 7 + j));
                        Write(" ");
                    }
                }
            }
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 5; k++)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        SetCursorPosition(X + 12 + (i + (5 * k)), Y - (k - 1 - j));
                        Write(" ");
                    }
                }
            }

            SetCursorPosition(X + 8, Y + 2);
            Write("    ");


            //덜 밝은 외각

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            for (int k = 0; k < 5; k++)
            {
                for (int i = 0; i < 5; i++)
                {
                    SetCursorPosition(X + 12 + (i + (5 * k)), Y - (k - 2));
                    Write(" ");
                }
            }

            for (int k = 0; k < 3; k++)
            {
                for (int i = 0; i < 4; i++)
                {
                    SetCursorPosition(X + (i + (4 * k)), Y + 1 + k);
                    Write(" ");
                }
            }
            for (int i = 0; i < 5; i++)
            {
                SetCursorPosition(X + 10, Y + 3 + i);
                Write("  ");
            }


            //외각 선

            Console.BackgroundColor = ConsoleColor.Black;
            //대각선
            for (int k = 0; k < 5; k++)
            {
                for (int i = 0; i < 5; i++)
                {
                    SetCursorPosition(X + (i + (5 * k)), Y - k);
                    Write(" ");
                }
            }

            for (int i = 0; i < 6; i++)
            {
                SetCursorPosition(X, Y + i);
                Write("  ");
            }

            for (int k = 0; k < 3; k++)
            {
                for (int i = 0; i <4; i++)
                {
                    SetCursorPosition(X + (i + (4 * k)), Y + 6 + k);
                    Write(" ");
                }
            }

            //아래 대각선
            for (int k = 0; k < 5; k++)
            {
                for (int i = 0; i < 5; i++)
                {
                    SetCursorPosition(X + 12 + (i + (5 * k)), Y - (k - 7));
                    Write(" ");
                }
            }

            for (int i = 0; i < 6; i++)
            {
                SetCursorPosition(X + 35, Y - 2+ i);
                Write("  ");
            }

            for (int k = 0; k < 3; k++)
            {
                for (int i = 0; i < 4; i++)
                {
                    SetCursorPosition(X + 25 + (i + (4 * k)), Y - 5 + k);
                    Write(" ");
                }
            }
        }

        static void Title()
        {
            for(int i = 0; i<6; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                SetCursorPosition(30 + (i * 2) , 5);
                Write("  ");
                SetCursorPosition(30 + (i * 2), 6);
                Write("  ");
            }

            for (int i = 0; i < 6; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                SetCursorPosition(42, 5 + i);
                Write("    ");
            }

            for (int i = 0; i < 14; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                SetCursorPosition(26 + (i * 2), 13);
                Write("  ");
                SetCursorPosition(26 + (i * 2), 14);
                Write("  ");
            }

            for (int i = 0; i < 6; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                SetCursorPosition(38, 14 + i);
                Write("    ");
            }

            Thread.Sleep(250);

            for (int i = 0; i < 6; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                SetCursorPosition(65 + (i * 2), 5);
                Write("  ");
                SetCursorPosition(65 + (i * 2), 6);
                Write("  ");
            }

            for (int i = 0; i < 6; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                SetCursorPosition(77, 5 + i);
                Write("    ");
            }

            for (int i = 0; i < 6; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                SetCursorPosition(65, 5 + i);
                Write("    ");
            }

            for (int i = 0; i < 14; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                SetCursorPosition(59 + (i * 2), 13);
                Write("  ");
                SetCursorPosition(59 + (i * 2), 14);
                Write("  ");
            }

            for (int i = 0; i < 7; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                SetCursorPosition(65 + (i * 2), 16);
                Write("  ");
            }

            for (int i = 0; i < 3; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                SetCursorPosition(79, 16 + i);
                Write("    ");
            }

            for (int i = 0; i < 9; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                SetCursorPosition(65 + (i * 2), 19);
                Write("  ");
            }

            for (int i = 0; i < 3; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                SetCursorPosition(65, 19 + i);
                Write("    ");
            }

            for (int i = 0; i < 7; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                SetCursorPosition(69 + (i * 2), 21);
                Write("  ");
            }

            Thread.Sleep(250);

            for (int i = 0; i < 6; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                SetCursorPosition(105 + (i * 2), 5);
                Write("  ");
                SetCursorPosition(105 + (i * 2), 6);
                Write("  ");
            }

            for (int i = 0; i < 10; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                SetCursorPosition(117, 5 + i);
                Write("    ");
            }

            for (int i = 0; i < 3; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                SetCursorPosition(125 + (i * 2), 10);
                Write("  ");
                SetCursorPosition(125 + (i * 2), 11);
                Write("  ");
            }

            for (int i = 0; i < 10; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                SetCursorPosition(131, 5 + i);
                Write("    ");
            }

            for (int i = 0; i < 12; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                SetCursorPosition(138, 5 + i);
                Write("    ");
            }

            Thread.Sleep(250);

            CoinDrawing(150, 5);

            for (int i = 0; i < 8; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                SetCursorPosition(180, 5 + i);
                Write("    ");
            }

            GoldDrawing(150, 18);
        }

        public static void Render()
        {
            for (int i = 0; i < 10; i++)
            {
                CoinDrawing(38, 42 - (i * 2));
                Thread.Sleep(30);
            }

            for (int i = 0; i < 8; i++)
            {
                CoinDrawing(150, 38 - (i * 2));
                Thread.Sleep(30);
            }

            for (int i = 0; i < 7; i++)
            {
                CoinDrawing(10, 40 - (i * 2));
                Thread.Sleep(30);
            }

            GoldDrawing(110, 36);
            Thread.Sleep(100);

            for (int i = 0; i < 5; i++)
            {
                CoinDrawing(105, 41 - (i * 2));
                Thread.Sleep(30);
            }

            for (int i = 0; i < 3; i++)
            {
                CoinDrawing(29, 42 - (i * 2));
                Thread.Sleep(30);
            }

            GoldDrawing(40, 41);
            Thread.Sleep(100);

            for (int i = 0; i < 6; i++)
            {
                CoinDrawing(145, 42 - (i * 2));
                Thread.Sleep(30);
            }

            //제목 등장
            Title();
            
            //press any key to start
            Thread someThing = new Thread(new ThreadStart(_PressAnykey));
            someThing.Start();

            //쓰레드 중 입력하면 글자 출력이됩니다. 
            //그래서 배경이랑 같은 색을 둬서 안나오는 것처럼 덮습니다.
            Console.ForegroundColor = ConsoleColor.DarkGray;

            //입력시 게임 시작.
            ReadKey();
            _isStart = true;
            someThing.Join();
            Clear();
        }

        static void _PressAnykey()
        {
            while (!_isStart)
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                SetCursorPosition(90, 30);
                Write("Press any Key to Start");
                Thread.Sleep(750);
                SetCursorPosition(90, 30);
                Write("                         ");
                Thread.Sleep(750);
            }
        }
        

    }

    public static class WaitMenu
    {
        public static bool _isSelected = false;
        public static bool _isContinue = false;
        public static int posY =  15;
        public static int posX =  10;

        public static void Initialize(ref bool _letsFinish)
        {
            //아무 키나 입력하면 게임 시작합니다.
            //Form.Render();

            //종료입력될때까지 진행
            do
            {
                //게임 승리 조건
                if(BankSystem._borrowMoney == 0 && Player.Money > BankSystem._bankMoney)
                {
                    Clear();
                    for (int i = 0; i < 10; i++)
                    {
                        Form.CoinDrawing(38, 42 - (i * 2));
                        Thread.Sleep(30);
                    }

                    for (int i = 0; i < 8; i++)
                    {
                        Form.CoinDrawing(150, 38 - (i * 2));
                        Thread.Sleep(30);
                    }

                    for (int i = 0; i < 7; i++)
                    {
                        Form.CoinDrawing(10, 40 - (i * 2));
                        Thread.Sleep(30);
                    }

                    Form.GoldDrawing(110, 36);
                    Thread.Sleep(100);

                    for (int i = 0; i < 5; i++)
                    {
                        Form.CoinDrawing(105, 41 - (i * 2));
                        Thread.Sleep(30);
                    }

                    for (int i = 0; i < 3; i++)
                    {
                        Form.CoinDrawing(29, 42 - (i * 2));
                        Thread.Sleep(30);
                    }

                    Form.GoldDrawing(40, 41);
                    Thread.Sleep(100);

                    for (int i = 0; i < 6; i++)
                    {
                        Form.CoinDrawing(145, 42 - (i * 2));
                        Thread.Sleep(30);
                    }

                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.White;
                    UtilSystem.OpenChat(100, 15, 40, 6, "승리 하셨습니다.", 0, 0);
                    _letsFinish = true; 
                    ReadKey();
                    
                }
                else
                //메뉴선택 화면
                _letsFinish = SelectMenu();

            } while (!_letsFinish);

        }

        static void PlayerState()
        {
            UtilSystem.MenuLine();

            //그림이 끝나면 다시 돌려놓습니다.
            Console.BackgroundColor = ConsoleColor.DarkGray;
            SetCursorPosition(50, 44);
            Write("5억 : 골드 바     1천 : 동전     1백 : 금가루");
            SetCursorPosition(140, 44);
            Write($"당신의 돈 : {string.Format("{0:N0}", Player.Money)}");

            //돈이 5억마다 골드바, 1천마다 동전입니다. 1백마다 점
            Random r = new Random();
            long Goldcount = Player.Money / 500000000;
            for (int i = 0; i < Goldcount; i++)
            {
                Form.GoldDrawing(r.Next(50, 150), r.Next(10, 30));
                Thread.Sleep(50);
            }
            long Coincount = (Player.Money - (Goldcount * 500000000)) / 10000000;
            for (int i = 0; i < Coincount; i++)
            {
                Form.CoinDrawing(r.Next(50, 150), r.Next(10, 40));
                Thread.Sleep(50);
            }
            long DotCount = (Player.Money - ((Goldcount * 500000000) + (Coincount * 10000000))) / 1000000;
            for (int i = 0; i < DotCount; i++)
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                SetCursorPosition(r.Next(50, 150), r.Next(10, 40));
                Write("  ");
                Thread.Sleep(10);
            }

            //그림이 끝나면 다시 돌려놓습니다.
            Console.BackgroundColor = ConsoleColor.DarkGray;

        }

        public static bool SelectMenu()
        {
            bool _isStop = false;
            do
            {

                Console.ForegroundColor = ConsoleColor.White;

                //좌표 이동
                SetWindowPosition(0, 0);

                SetCursorPosition(posX, posY);
                WriteLine("     은행");
                SetCursorPosition(posX, posY + 3);
                WriteLine("     게임시작");
                SetCursorPosition(posX, posY + 6);
                WriteLine("     설명");
                SetCursorPosition(posX, posY + 9);
                WriteLine("     종료");

                //플레이어 돈
                PlayerState();

                do
                {
                    //입력
                    UtilSystem.PlayerSelectPos(ref posY, ref posX, 24, 15, posX, posX, ref _isSelected, 3, 0, "▶");

                } while (!_isSelected);

                switch (posY)
                {
                    case 15: //은행
                        _isSelected = false;
                        do
                        {
                            Clear();
                            _isContinue = BankSystem.Render();
                        } while (!_isContinue);
                        break;
                    case 18: //게임 시작
                        _isSelected = false;
                        GameSystem.Render();
                        break;
                    case 21: //설명
                        _isSelected = false;
                        Explain.Render();
                        break;
                    case 24: //종료
                        _isSelected = false;
                        _isStop = true;
                        break;
                }

                posX = 10;
                posY = 15;

            } while (!_isStop);

            return false;
        }
    }

    public static class UtilSystem
    {
        //쓸 화면의 좌표 입니다.
        
        //플레이어가 선택하기위해 화살표 움직이는 함수

        //입력값 y,x ,Y의 최대값최솟값. X의 최대값최솟값. 선택되었을때 함수 탈출.입력됫을때 움직일 정도의 Y, X
        public static void PlayerSelectPos(ref int posY, ref int posX, int MaxY, int MinY, int MaxX, int MinX, ref bool _isSelected, int MoveY, int MoveX, string point)
        {
            SetCursorPosition(posX, posY);
            Write(point);

            if (MoveX == 0)
            {
                SetCursorPosition(posX, posY - MoveY);
                Write("  ");
                SetCursorPosition(posX, posY + MoveY);
                Write("  ");
            }

            else if(MoveY == 0)
            {
                SetCursorPosition(posX - MoveX, posY);
                Write("  ");
                SetCursorPosition(posX + MoveX, posY);
                Write("  ");
            }

            //선택을 입력 받습니다.
            ConsoleKeyInfo key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    posY -= MoveY;
                    if (posY < MinY)
                    {
                        posY = MinY;
                    }
                    break;

                case ConsoleKey.DownArrow:
                    posY += MoveY;
                    if (posY > MaxY)
                    {
                        posY = MaxY;
                    }
                    break;

                case ConsoleKey.LeftArrow:
                    posX -= MoveX;
                    if (posX < MinX)
                    {
                        posX = MinX;
                    }
                    break;

                case ConsoleKey.RightArrow:
                    posX += MoveX;
                    if (posX > MaxX)
                    {
                        posX = MaxX;
                    }
                    break;

                case ConsoleKey.Enter:
                    _isSelected = true;
                    break;

                case ConsoleKey.C:
                    //특정 조건(게임 진행중)에서만 가능한 범주 입니다.
                    if (Player._isCheckRule)
                    {
                        Clear();

                        MainTable.RuleBook();
                        ReadKey();

                        Clear();

                        //다시 게임을 불러옵니다.
                        GameSystem.OtherClassRender();
                    }
                    break;
            }
        }

        //부분 지우기(x,y부터 manyx 만큼, manyy 만큼)
        public static void PartClear(int X, int Y, int manyX, int manyY)
        {
            for(int j = 0; j<manyY; j++)
            {
                SetCursorPosition(X, Y + j);

                for (int i = 0; i < manyX; i++)
                {
                    Write(" ");
                }
            }
        }

        //채팅창 열기(x,y중심 manyx(짝수) 만큼, manyy(짝수) 만큼, left 만큼, right만큼 _chat 위치 이동)
        public static void OpenChat(int X, int Y, int manyX, int manyY,string _chat, int left, int right)
        {
            SetCursorPosition(X, Y);
            Write("●");
            Thread.Sleep(300);

            for(int i = 1; i <= manyY /2; i++)
            {
                SetCursorPosition(X - 1, Y - i);
                Write("┏┓");

                for(int t = 0; t < (i * 2) - 1; t++)
                {
                    SetCursorPosition(X - 1, Y - i + (t + 1));
                    Write("   ");
                }

                SetCursorPosition(X - 1, Y + i);
                Write("┗┛");
                Thread.Sleep(50);
            }

            for(int i = 1; i< manyX / 2; i++)
            {

                for(int k = 0; k < (i * 2); k++)
                {
                    for (int t = 0; t <= manyY; t++)
                    {
                        SetCursorPosition(X - i + (k), Y - (manyY / 2) + t);
                        Write("   ");
                    }
                }
                SetCursorPosition((X - 1) - i, Y - manyY / 2);
                Write("┏");
                SetCursorPosition((X + 1) + i, Y - manyY / 2);
                Write("┓");

                SetCursorPosition((X - 1) - i, Y + manyY / 2);
                Write("┗");
                SetCursorPosition((X + 1) + i, Y + manyY / 2);
                Write("┛");
                Thread.Sleep(10);
            }

            SetCursorPosition(X - _chat.Length - left, Y);
            Write(_chat);

        }

        //컴퓨터 모양
        public static void DrawCom(int X, int Y,int color)
        {
            //안쪽 색
            Console.BackgroundColor = ConsoleColor.White;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    SetCursorPosition(X + 2 + i, Y + 1 + j);
                    Write("  ");
                }
            }
            //손

            Console.BackgroundColor = ConsoleColor.Cyan;

            for(int i = 0; i< 5; i++)
            {
                SetCursorPosition(X + 17 + i, Y + 6);
                Write("  ");
            }
            for(int i = 0; i<2; i++)
            {
                SetCursorPosition(X + 21, Y + 5 - i);
                Write("  ");
            }
            for(int i = 0; i< 2; i++)
            {
                SetCursorPosition(X + 20 + (i * 2), Y + 3);
                Write("  ");
            }

            //태두리
            switch (color)
            {
                case (int)Color.red:
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case (int)Color.green:
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                case (int)Color.blue:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case (int)Color.darkYellow:
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    break;
            }
            for (int i = 0; i < 15; i++)
            {
                SetCursorPosition(X + i, Y);
                Write("  ");
                SetCursorPosition(X + i, Y + 7);
                Write("  ");
            }
            for (int i = 0; i < 8; i++)
            {
                SetCursorPosition(X, Y + i);
                Write("  ");

                SetCursorPosition(X + 15, Y + i);
                Write("  ");
            }

            //표정
            Console.BackgroundColor = ConsoleColor.Black;

            SetCursorPosition(X + 5, Y + 2);
            Write(" ");
            SetCursorPosition(X + 5, Y + 3);
            Write(" ");
            SetCursorPosition(X + 11, Y + 2);
            Write(" ");
            SetCursorPosition(X + 11, Y + 3);
            Write(" ");






            //색 원래대로 돌려놓기
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGray;
        }

        //있는 컴퓨터를 지우는(덮어씌우는 함수)
        public static void DeleteCom(int X, int Y)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            for(int i = 0; i < 30; i++)
            {
                for(int j = 0; j< 10; j++)
                {
                    SetCursorPosition(X + i, Y + j);
                    Write("  ");
                }
            }
        }

        //메뉴화면을 꾸미는 창
        public static void MenuLine()
        {
            for (int i = 0; i < 125; i++)
            {
                SetCursorPosition(50 + i, 5);
                Console.BackgroundColor = ConsoleColor.Cyan;
                Write(" ");

                SetCursorPosition(50 + i, 40);
                Console.BackgroundColor = ConsoleColor.Cyan;
                Write(" ");
            }
            Console.BackgroundColor = ConsoleColor.DarkGray;
        }

    }

    public static class GameSystem
    {
        public static bool _isSelected = false;
        public static bool _isContinue = false;
        public static bool _isSelected_Finish = false;
        public static int posY =  15; //위치
        public static int posX =  10;
        public static int GameRound = 1; //게임 라운드
        public static List<AIComputer> comList; //생성된 컴퓨터 수
        public static int ComNum; //컴퓨터 수
        public static float Level = 0; //컴퓨터 수에 따른 배수

        public static void Render()
        {
            Clear();

            //게임의 난이도(컴퓨터 수)를 정합니다.
            Option();
            Clear();

            //게임 시작에 필요한 정보를 세팅합니다.
            Initialize();

            //게임 시작합니다.
            MainGame();
        }

        public static void Option()
        {
            SetCursorPosition(posX, posY - 3);
            WriteLine("   원하시는 컴퓨터의 수를 고르세요");
            SetCursorPosition(posX, posY);
            WriteLine("     2대");
            SetCursorPosition(posX, posY + 3);
            WriteLine("     3대");
            SetCursorPosition(posX, posY + 6);
            WriteLine("     4대");
            
            UtilSystem.MenuLine();

            do
            {
                UtilSystem.DrawCom(55, 25, 2);
                UtilSystem.DrawCom(150, 25, 3);
                if (posY == 15) // 2개
                {
                    UtilSystem.DeleteCom(75, 8);
                    UtilSystem.DeleteCom(130, 8);
                    Level = 1;
                }
                else if(posY == 18) // 3개
                {
                    UtilSystem.DrawCom(75, 8, 4);
                    UtilSystem.DeleteCom(130, 8);
                    Level = 2;
                }

                else if(posY == 21) // 4개
                {
                    UtilSystem.DrawCom(75, 8, 4);
                    UtilSystem.DrawCom(130, 8, 0);
                    Level = 3;
                }

                //최소가 되면 반짝거립니다 -> 버그 수정 할것.
                UtilSystem.PlayerSelectPos(ref posY, ref posX, 21, 15, posX, posX, ref _isSelected, 3, 0, "▶");


            } while (!_isSelected);

            switch (posY)
            {
                case 15:
                    ComNum = 2;
                    break;
                case 18:
                    ComNum = 3;
                    break;
                case 21:
                    ComNum = 4;
                    break;
            }
        }

        public static void Initialize()
        {
            //복사형태의 r을 생성하고 그걸 넘깁니다.
            List<AIComputer> r = new List<AIComputer>();

            //클래스 배열의 4개의 공간을 생성합니다.
            AIComputer[] aIComputer = new AIComputer[4];

            //클래스 배열은 객체별로 생성을 해줘야 합니다.
            for(int i = 0;i<4; i++)
            {
                aIComputer[i] = new AIComputer();
            }
            comList = r;

            //생성은 4개 모두를 했지만, 개수만큼만 넘겨줍니다.
            for (int i = 0; i< ComNum; i++)
            {
                comList.Add(aIComputer[i]);
            }


            //생성된 객체들에게 값을 생성해줍니다.
            aIComputer[0].posX = 10;
            aIComputer[0].posY = 20;
            aIComputer[0].Color = 0;

            aIComputer[1].posX = 100;
            aIComputer[1].posY = 20;
            aIComputer[1].Color = 1;

            aIComputer[2].posX = 35;
            aIComputer[2].posY = 5;
            aIComputer[2].Color = 2;

            aIComputer[3].posX = 75;
            aIComputer[3].posY = 5;
            aIComputer[3].Color = 3;

        }
        
        public static void ShowInfo()
        {
            int hisPosX = 150;
            int hisPosY = 5;
            int herPosX = 150;
            int herPosY = 25;

            //배경(검은 바탕)
            Console.BackgroundColor = ConsoleColor.Black;
            for(int i = 0; i < 46; i++)
            {
                for(int j = 0; j< 7; j++)
                {
                    SetCursorPosition(hisPosX - 2 + i, hisPosY - 1 + j);
                    Write("  "); 
                }
            }

            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i < 46; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    SetCursorPosition(herPosX - 2 + i, herPosY - 1 + j);
                    Write("  ");
                }
            }

            Console.BackgroundColor = ConsoleColor.Gray;
            #region R
            for (int i = 0; i < 5; i++)
            {
                SetCursorPosition(hisPosX, hisPosY + i);
                Write("  ");
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    SetCursorPosition(hisPosX + 2 + (i * 2), hisPosY + (j * 2));
                    Write("  ");
                }
            }
            SetCursorPosition(hisPosX + 6, hisPosY + 1);
            Write("  ");
            SetCursorPosition(hisPosX + 4, hisPosY + 3);
            Write("  ");
            SetCursorPosition(hisPosX + 6, hisPosY + 4);
            Write("  ");
            #endregion
            #region O
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j<2; j++)
                {
                    SetCursorPosition(hisPosX + 11 + (i * 2), hisPosY + (j * 4));
                    Write("  ");
                }
            }
            for(int i = 0; i< 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    SetCursorPosition(hisPosX + 9 + (i * 6), hisPosY + 1 + j);
                    Write("  ");
                }
            }
            #endregion
            #region U
            for(int i = 0; i< 2; i++)
            {
                for(int j = 0; j<4; j++)
                {
                    SetCursorPosition(hisPosX + 18 + (i * 6), hisPosY + j);
                    Write("  ");
                }
            }
            for(int i = 0; i < 2; i++)
            {
                SetCursorPosition(hisPosX + 20 + (i * 2), hisPosY + 4);
                Write("  ");
            }
            #endregion
            #region N
            for(int i = 0; i< 2; i++)
            {
                for(int j = 0; j< 5; j++)
                {
                    SetCursorPosition(hisPosX + 27 + (i * 6), hisPosY + j);
                    Write("  ");
                }
            }
            for(int i = 0; i < 2; i++)
            {
                SetCursorPosition(hisPosX + 29 + (i * 2), hisPosY + 1 + i);
                Write("  ");
            }
            #endregion
            #region D
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    SetCursorPosition(hisPosX + 38 + (i * 2), hisPosY + (j * 4));
                    Write("  ");
                }
            }
            for(int i = 0; i<5; i++)
            {
                SetCursorPosition(hisPosX + 36, hisPosY + i);
                Write("  ");
            }
            for (int j = 0; j < 3; j++)
            {
                SetCursorPosition(hisPosX + 42, hisPosY + 1 + j);
                Write("  ");
            }
            #endregion

            Console.BackgroundColor = ConsoleColor.Gray;
            #region M
            for(int i = 0; i< 5; i++)
            {
                for(int j = 0; j<2; j++)
                {
                    SetCursorPosition(herPosX + (j * 6), herPosY + i);
                    Write("  ");
                }
            }
            for(int i = 0; i<2; i++)
            {
                SetCursorPosition(herPosX + 2 + (i * 3), herPosY + 1);
                Write(" ");
            }
            SetCursorPosition(herPosX + 3, herPosY + 2);
            Write("  ");
            #endregion
            #region O
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    SetCursorPosition(herPosX + 11 + (i * 2), herPosY + (j * 4));
                    Write("  ");
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    SetCursorPosition(herPosX + 9 + (i * 6), herPosY + 1 + j);
                    Write("  ");
                }
            }
            #endregion
            #region N
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    SetCursorPosition(herPosX + 18 + (i * 6), herPosY + j);
                    Write("  ");
                }
            }
            for (int i = 0; i < 2; i++)
            {
                SetCursorPosition(herPosX + 20 + (i * 2), herPosY + 1 + i);
                Write("  ");
            }
            #endregion
            #region E
            for(int i = 0; i< 5; i++)
            {
                SetCursorPosition(herPosX + 27, herPosY + i);
                Write("  ");
            }
            for(int i = 0;i<3; i++)
            {
                for(int j = 0; j<3; j++)
                {
                    SetCursorPosition(herPosX + 29 + (i * 2), herPosY + (j * 2));
                    Write("  ");
                }
            }
            #endregion
            #region Y
            for(int i = 0; i < 2; i++)
            {
                SetCursorPosition(herPosX + 36 + (i * 6), herPosY);
                Write("  ");
            }
            for(int i = 0; i < 2; i++)
            {
                SetCursorPosition(herPosX  + 38 + (i * 3), herPosY + 1);
                Write(" ");
            }
            for(int i = 0; i<3; i++)
            {
                SetCursorPosition(herPosX + 39, herPosY + 2 + i);
                Write("  ");
            }
            #endregion

            //라운드 -> 추후 변경
            SetCursorPosition(hisPosX + 20, hisPosY + 10);
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Write($"{GameRound}");

            //돈
            SetCursorPosition(herPosX + 15, herPosY + 10);
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Write($"{string.Format("{0:N0}", Player.Money)}");

            //다시 원상복귀.
            Console.BackgroundColor = ConsoleColor.DarkGray;
        }

        public static void OtherClassRender()
        {
            //중앙 테이블
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    SetCursorPosition(65 + i, 24 + j);
                    Write("  ");
                }
            }
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            SetCursorPosition(5, 38);
            Write("C를 누르면 족보가 나옵니다");

            //게임의 라운드와 플레이어의 돈을 보여줍니다
            ShowInfo();

            for (int i = 0; i < ComNum; i++)
            {
                //컴퓨터의 정보를 보여줍니다.(구슬 수, 플레이어 돈, 라운드)
                comList[i].showInfo();
            }

        }

        public static void MainGame()
        {
            //8라운드
            do
            {
                do
                {
                    //게임 시작 바탕을 미리 만들어봅니다.
                    OtherClassRender();

                    //플레이어의 구슬을 보여주고 선택, 환인, 취소, 족보보기를 하게합니다.
                    Player.Render(ref _isSelected_Finish);

                    //취소를 누른경우 처음부터 다시 해줘야합니다.
                    if (!_isSelected_Finish)
                        Clear();

                    //취소가 아닌 구슬선택후 확인을 누른경우 다음 단계로 넘어 갑니다.
                } while (!_isSelected_Finish);

                //루프나오면 다시 초기화.
                _isSelected_Finish = false;

                for (int i = 0; i < ComNum; i++)
                {
                    Random r = new Random();
                    comList[i].PutComMarble(r); 
                    
                    //컴퓨터가 빠르게 랜덤을 돌리면 같은 숫자를 반복해서 나오는 오류가 잇어서
                    //슬립으로 텀을 둬서 천천히 랜덤을 뽑게하면 됩니다.
                    Thread.Sleep(50);
                }

                //돈 베팅
                MainTable.BettingMoney();

                //구슬 선택
                MainTable.BettingMarble();

                //결과 계산 함수.
                MainTable.LetdoThis();

                //결과 창
                MainTable.Render();

                //돈 주기
                MainTable.TakeMoney();

                //라운드 증가
                GameRound++;

                //선택 구슬(3개) 초기화
                Player.count = 0;

                Clear();

                if (BankSystem._isDelayMoney)
                {
                    //이자를 받지않습니다.
                }

                else
                {
                    //4라운드 8라운드마다 빌린돈의 10퍼센트씩 돈이 없어집니다.(이자)
                    if (GameRound == 4 || GameRound == 8)
                    {
                        Player.Money -= BankSystem._borrowMoney % 10;
                    }
                }

                //한 게임이 끝났으니 다시 초기화 합니다.
                BankSystem._isDelayMoney = false;
                MainTable._resultMoney = 0;

                //구슬 초기화
                MainTable.M_RedMarble = 0;
                MainTable.M_BlueMarble = 0;
                MainTable.M_GreenMarble = 0;

                //돈이 0원이 된 경우 게임 종료
                if (Player.Money <= 0)
                {
                    Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.White;
                    UtilSystem.OpenChat(100, 15, 40, 6, "게임 오버.", 0, 0);
                    Thread.Sleep(1000);
                    UtilSystem.OpenChat(100, 35, 40, 6, "돈도 없으면 썩 꺼지세요.", 0, 0);
                    ReadKey();

                    //강제 종료
                    Environment.Exit(0);
                }

            } while (GameRound < 8);

        }

    }

    public static class BankSystem
    {
        public static long _bankMoney = 5000000000; //은행의 돈(50억)
        public static float _credit_rating = 50.0f; //은행 신용도(100%)
        public static long _borrowMoney = 0; //빌린 돈
        public static bool _isSelected = false;
        public static bool _isContinue = false;
        public static int posY = 15; //위치
        public static int posX = 10;
        static int count = 0;
        public static bool _isDelayMoney = false;
        static Random r = new Random();

        public static void _moneyCreditShow()
        {
            SetCursorPosition(140, 44);
            Write($"당신의 돈 : {string.Format("{0:N0}", Player.Money)}");

            SetCursorPosition(135, 8);
            Write($"은행의 돈 : {string.Format("{0:N0}", _bankMoney)}");

            SetCursorPosition(60, 8);
            Write($"당신의 신용도 : {_credit_rating}");

            SetCursorPosition(135, 10);
            Write($"당신이 빌린 돈 : {string.Format("{0:N0}", _borrowMoney)}");
        }

        public static void RowCreditEnding()
        {
            //돈이 0원이 된 경우 게임 종료
            if (_credit_rating <= 0.0f)
            {
                Clear();
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.White;
                UtilSystem.OpenChat(100, 15, 40, 6, "게임 오버.", 0, 0);
                Thread.Sleep(1000);
                UtilSystem.OpenChat(100, 35, 40, 6, "믿을 수 없는 놈은 썩 꺼지세요.", 0, 0);
                ReadKey();

                //강제 종료
                Environment.Exit(0);
            }
        }

        public static bool Render()
        {
            posY = 15;
            posX = 10;

            //만약 신용도가 0이 되면 게임에서 집니다.
            RowCreditEnding();

            UtilSystem.MenuLine();

            UtilSystem.DrawCom(100, 15, 3);
            UtilSystem.OpenChat(110, 25, 20, 4, "무엇을 도와드릴까요?", -2,0);

            _moneyCreditShow();

            SetCursorPosition(10, 15);
            Write("     돈 빌리기"); //대화 내용에서 이자 비율 정할수잇음
            SetCursorPosition(10, 18);
            Write("     돈 갚기");
            SetCursorPosition(10, 21);
            Write("     대화하기"); //이자를 미루기, 은행 털기, 뇌물주기.
            SetCursorPosition(10, 24);
            Write("     종료");


            do
            {
                UtilSystem.PlayerSelectPos(ref posY, ref posX, 24, 15, 10, 10, ref _isSelected, 3, 0, "▶");

            } while (!_isSelected);

            switch (posY)
            {
                case 15: //빌리기
                    Clear();
                    _isSelected = false;
                    MoneyBorrow();
                    break;
                case 18: //갚기
                    Clear();
                    _isSelected = false;
                    MoneyBack();
                    break;
                case 21: //대화하기
                    Clear();
                    _isSelected = false;
                    do
                    {
                        _isContinue = Communication();
                    } while (!_isContinue);
                    break;
                case 24: //종료
                    Clear();
                    _isSelected = false;
                    return true;

            }
            return false;
        }

        public static void MoneyBorrow()
        {
            UtilSystem.MenuLine();
            UtilSystem.DrawCom(100, 15, 3);
            UtilSystem.OpenChat(110, 25, 30, 4, "받고 싶은 금액을 적으세요", -2, 0);
            _moneyCreditShow();

            SetCursorPosition(100, 30);

            if (!long.TryParse(ReadLine(),out long WantMoney))
            {
                Clear();
                UtilSystem.MenuLine();
                UtilSystem.DrawCom(100, 15, 3);
                UtilSystem.OpenChat(110, 25, 50, 4, "은행에서 장난 치면 안됩니다(신용도 -5)", -4, 0);
                _moneyCreditShow();

                _credit_rating -= 5;
                Thread.Sleep(2000);
            }

            //신용도가 낮으면 진행 불가
            if (_credit_rating >= 10)
            {
                Player.Money += WantMoney;
                _bankMoney -= WantMoney;
                _borrowMoney += WantMoney;
            }

            //신용도가 10 이하인 경우
            else
            {
                UtilSystem.MenuLine();
                UtilSystem.DrawCom(100, 15, 3);
                UtilSystem.OpenChat(110, 25, 40, 4, "신용도가 낮아서 진행이 안됩니다.", -3, 0);
                _moneyCreditShow();
                Thread.Sleep(2000);
            }
        }

        public static void MoneyBack()
        {
            if(_borrowMoney <= 0) //빌린돈이 없는 경우
            {
                Clear();
                UtilSystem.MenuLine();
                UtilSystem.DrawCom(100, 15, 3);
                UtilSystem.OpenChat(110, 25, 40, 4, "반납하실 금액이 없습니다.", -3, 0);
                _moneyCreditShow();

                _credit_rating -= 5;
                Thread.Sleep(2000);
            }

            else
            {
                UtilSystem.MenuLine();

                UtilSystem.DrawCom(100, 15, 3);
                UtilSystem.OpenChat(110, 25, 30, 4, "반납 할 금액을 적으세요", -2, 0);

                _moneyCreditShow();

                SetCursorPosition(100, 30);

                if (!long.TryParse(ReadLine(), out long BackMoney))
                {
                    Clear();
                    UtilSystem.MenuLine();
                    UtilSystem.DrawCom(100, 15, 3);
                    UtilSystem.OpenChat(110, 25, 50, 4, "은행에서 장난 치면 안됩니다(신용도 -5)", -4, 0);
                    _moneyCreditShow();

                    _credit_rating -= 5;
                    Thread.Sleep(2000);
                }

                Player.Money -= BackMoney;
                _bankMoney += BackMoney;
                _borrowMoney -= BackMoney;
                count++;

                //거래를 많이 한 경우(3번) 신용 증가
                if (count > 3)
                {
                    _credit_rating += 3;
                    count = 0;
                }
            }

        }

        public static bool Communication()
        {
            posY = 18;
            posX = 10;

            UtilSystem.MenuLine();

            UtilSystem.DrawCom(100, 15, 1);
            UtilSystem.OpenChat(110, 25, 20, 4, "무엇을 원하시나요?", -2, 0);

            _moneyCreditShow();

            SetCursorPosition(10, 18);
            Write("     이자를 미루기");
            SetCursorPosition(10, 21);
            Write("     은행 털기");
            SetCursorPosition(10, 24);
            Write("     뇌물주기");
            SetCursorPosition(10, 27);
            Write("     종료");
            
            do
            {
                UtilSystem.PlayerSelectPos(ref posY, ref posX, 27, 18, 10, 10, ref _isSelected, 3, 0 ,"▶");

            } while (!_isSelected);

            switch (posY)
            {
                case 18: //이자를 미루기
                    Clear();
                    _isSelected = false;
                    DelayBackMoney();
                    break;
                case 21: //은행 털기
                    Clear();
                    _isSelected = false;
                    BankRobber();
                    break;
                case 24: //뇌물주기
                    Clear();
                    _isSelected = false;
                    bribe();
                    break;
                case 27: //종료
                    Clear();
                    _isSelected = false;
                    return true;

            }
            Clear();

            return false;
        }

        public static void DelayBackMoney()
        {

            UtilSystem.MenuLine();
            _moneyCreditShow();
            UtilSystem.DrawCom(100, 15, 1);

            UtilSystem.OpenChat(110, 40, 50, 4, "제가 어려서 부터 힘들구..집안이...어쩌구저쩌구", -4, 0);

            Thread.Sleep(1000);
            int k = r.Next(0, 2);
            Thread.Sleep(50);
            if(k == 0)
            {
                UtilSystem.OpenChat(110, 25, 50, 4, "...알겠습니다. 한 게임만 이자를 안받죠.", -4, 0);
                _isDelayMoney = true;
            }
            else if(k == 1)
            {
                UtilSystem.OpenChat(110, 25, 50, 4, "그렇게 말하면 안힘든 사람이 어디있어요!", -4, 0);
                _credit_rating -= 1;
            }

            Thread.Sleep(2000);
        }

        public static void BankRobber()
        {
            UtilSystem.MenuLine();
            _moneyCreditShow();
            UtilSystem.DrawCom(100, 15, 1);

            UtilSystem.OpenChat(110, 40, 40, 4, "으...다들 꼼짝마!!!!", -3, 0);

            Thread.Sleep(1000);
            int k = r.Next(0, 11);
            Thread.Sleep(50);
            if (k == 0 || k == 5)
            {
                UtilSystem.OpenChat(110, 25, 30, 4, "으으 제발 살려주세요", -2, 0);
                Player.Money += 300000000; //3억
                _bankMoney -= 300000000;
            }
            else
            {
                UtilSystem.OpenChat(110, 25, 30, 4, "뭐야?! 경찰 불러!!!", -2, 0);
                _credit_rating -= 30;
            }

            Thread.Sleep(2000);
        }

        public static void bribe()
        {
            UtilSystem.MenuLine();
            _moneyCreditShow();
            UtilSystem.DrawCom(100, 15, 1);

            UtilSystem.OpenChat(110, 40, 50, 4, "ㅎㅎ..이거 제가 드리는겁니다...(5백)", -4, 0);

            Player.Money -= 5000000;

            Thread.Sleep(1000);
            int k = r.Next(0, 6);
            Thread.Sleep(50);
            if (k == 0 || k == 3)
            {
                UtilSystem.OpenChat(110, 25, 40, 4, "어..이러면..안되는데...흐흐", -3, 0);
                Player.Money += 50000000; //5천
                _credit_rating = 100;
            }
            else
            {
                UtilSystem.OpenChat(110, 25, 30, 4, "뭡니까 이게?", -2, 0);
                _credit_rating -= 50;
            }
            Thread.Sleep(2000);
        }
    }

    public static class Explain
    {
        public static void Render()
        {
            Clear();
            WriteLine();
            WriteLine();
            WriteLine();
            WriteLine();
            WriteLine();
            WriteLine("  은행에서 돈을 대출합니다");
            WriteLine("  돈을 빌리면 그에 대한 이자를 내야합니다.");
            WriteLine("  4라운드 8 라운드에서 빌린돈의 10%를 냅니다");
            WriteLine("  신용도는 거를 3번할때마다 3씩 오릅니다");
            WriteLine();
            WriteLine("  돈이 0원이 되거나, 은행측의 신용도가 0이되면 게임 오버.");
            WriteLine("  은행의 돈은 한정적이며 은행의 돈보다 많을 경우 승리합니다.");
            WriteLine();
            WriteLine("  컴퓨터의 수를 정하고 게임을 시작합니다(2대 (1배) 3대 (2배) 4대 (3배))");
            WriteLine();
            WriteLine("  구슬 개수는 총 15개(파랑5, 노랑5, 초록5)");
            WriteLine("  컴퓨터 n대와 플레이어 1인이 게임을 진행합니다.");
            WriteLine("  플레이어가 먼저 구슬을 집어넣습니다");
            WriteLine("  컴퓨터 n대가 구슬을 집어넣습니다");
            WriteLine("  단, 여기서 구슬을 집어넣을때, 3개 이하로 넣어야 합니다");
            WriteLine("");
            WriteLine("  플레이어는 구슬의 갯수와 색의 갯수, 조합으로 돈을 배팅합니다.");
            WriteLine("  각각 조건에 따라 돈의 배팅에 관해 배로 벌기도 하고, 배로 잃기도 합니다.");
            WriteLine("");
            WriteLine("  돈을 벌고 은행에 돈을 반납, 또는 대출을 합니다.");
            WriteLine("  라운드 하나가 끝난경우 플레이어와 컴퓨터가 들고있는 남은 구슬을 보여줍니다.");
            WriteLine("  그리고 그상태로 다시 라운드를 진행합니다.");
            WriteLine("");
            WriteLine("  총 8라운드로 진행하며,");
            WriteLine("  만약 구슬을 더이상 넣을수 없다면 컴퓨터는 그냥 턴을 넘기지만,");
            WriteLine("  플레이어는 남은 라운드에 비례해서 돈을 잃는다.");
            WriteLine("");
            WriteLine("  게임 진행중 구슬 선택화면에서 C를 누르면 족보가 나옵니다.");
            WriteLine();
            WriteLine();
            WriteLine();
            WriteLine();
            WriteLine();
            WriteLine();
            WriteLine();
            WriteLine("                              아무키나 누르면 메뉴로 돌아갑니다.");
            
            Form.CoinDrawing(95, 25);
            Form.GoldDrawing(125, 20);

            Console.BackgroundColor = ConsoleColor.DarkGray;

            SetCursorPosition(0, 0);
            
            ReadKey();
            Clear();
        }
    }

    public class AIComputer
    {
        public int posX;
        public int posY;
        public int Color;
        public int RedMarble = 5; //구슬 //나중에 get set으로 바꾸고 init에 넣어서 관리할것.
        public int BlueMarble = 5; //구슬 //생성과 좌표도 같이.
        public int GreenMarble = 5; //구슬
        private bool _isChecked = false;

        public void dot()
        {
            SetCursorPosition(posX, posY);
            WriteLine("ㅁ");
        }

        public void showInfo()
        {
            //남은 구슬을 보여줍니다.
            showRGBMarble();

            //컴퓨터를 그려줍니다
            UtilSystem.DrawCom(posX, posY, Color);
        }

        public void showRGBMarble()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            SetCursorPosition(posX, posY + 9);
            WriteLine($"┏R┓ ");
            SetCursorPosition(posX, posY + 10);
            WriteLine($"┃{RedMarble}┃ ");
            SetCursorPosition(posX, posY + 11);
            WriteLine($"┗━┛ ");

            Console.ForegroundColor = ConsoleColor.Blue;
            SetCursorPosition(posX + 6, posY + 9);
            WriteLine($"┏B┓ ");
            SetCursorPosition(posX + 6, posY + 10);
            WriteLine($"┃{BlueMarble}┃ ");
            SetCursorPosition(posX + 6, posY + 11);
            WriteLine($"┗━┛ ");

            Console.ForegroundColor = ConsoleColor.Green;
            SetCursorPosition(posX + 12, posY + 9);
            WriteLine($"┏G┓ ");
            SetCursorPosition(posX + 12, posY + 10);
            WriteLine($"┃{GreenMarble}┃ ");
            SetCursorPosition(posX + 12, posY + 11);
            WriteLine($"┗━┛ ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void PutComMarble(Random r)
        {

            do
            {
                //최소 0부터 최대 3까지. 0은 없음. 1 = r, 2 = g, 3 = b
                int first = r.Next(1, 4);  //처음은 무조건 생성.

                //각 숫자에 맞게 진행합니다.
                MinusMarble(first);

            } while (!_isChecked);

            do
            {
                int second = r.Next(0, 4);
                MinusMarble(second);

                //2번째가 생성이 되었다면.(생성안되면 통과.)
                if (second != 0)
                {
                    do
                    {
                        int third = r.Next(0, 4);
                        MinusMarble(third);

                    } while (!_isChecked);
                    
                }
            } while (!_isChecked);



        }

        void MinusMarble(int Num)
        {
            switch (Num)
            {
                case 0: //없는 경우
                    break;
                case 1: //Red

                    //개수가 부족했는데 뽑힌경우
                    if (RedMarble == 0)
                    {
                        _isChecked = false;
                        break;
                    }

                    else
                    {
                        _isChecked = true;
                        MainTable.M_RedMarble++;
                        RedMarble--;
                    }
                    break;
                case 2: //Green

                    //개수가 부족했는데 뽑힌경우
                    if (GreenMarble == 0)
                    {
                        _isChecked = false;
                        break;
                    }

                    else
                    {
                        _isChecked = true;
                        MainTable.M_GreenMarble++;
                        GreenMarble--;
                    }
                    break;
                case 3: //Blue

                    //개수가 부족했는데 뽑힌경우
                    if (BlueMarble == 0)
                    {
                        _isChecked = false;
                        break;
                    }

                    else
                    {
                        _isChecked = true;
                        MainTable.M_BlueMarble++;
                        BlueMarble--;
                    }
                    break;
            }
        }
        
    }

    public static class Player
    {
        public static long Money = 595000000; //보유 돈(천)
        public static int RedMarble = 5; //구슬
        public static int BlueMarble = 5; //구슬
        public static int GreenMarble = 5; //구슬
        public static int count = 0; //선택 구슬 수
        public static int posY = 0;
        public static int posX = 0;
        public static bool _isSelected = false;
        public static bool _isDone = false; //확인
        public static bool _isCancle = false; //취소
        public static bool _isCheckRule = false;

        public static void PlayerForm()
        {
            int yourPosX = 20;

            for(int i = 0; i<RedMarble; i++)
            {
                SetCursorPosition(yourPosX + (i * 6), 40);
                Console.BackgroundColor = ConsoleColor.Red;
                WriteLine("  ");
                Console.BackgroundColor = ConsoleColor.DarkGray;
            }
            for (int i = 0; i < GreenMarble; i++)
            {
                SetCursorPosition(yourPosX + (RedMarble * 6) + (i * 6), 40);
                Console.BackgroundColor = ConsoleColor.Green;
                WriteLine("  ");
                Console.BackgroundColor = ConsoleColor.DarkGray;
            }
            for (int i = 0; i < BlueMarble; i++)
            {
                SetCursorPosition(yourPosX + ((RedMarble + GreenMarble) * 6) + (i * 6), 40);
                Console.BackgroundColor = ConsoleColor.Blue;
                WriteLine("  ");
                Console.BackgroundColor = ConsoleColor.DarkGray;
            }
        }

        public static void PlayForm()
        {
            Console.BackgroundColor = ConsoleColor.White;
            for (int i = 0; i < 140; i++)
            {
                SetCursorPosition(i,36);
                Write("  ");
            }
            Console.BackgroundColor = ConsoleColor.DarkGray;

            SetCursorPosition(115, 42);
            WriteLine("확 정");
            
            SetCursorPosition(115, 45);
            WriteLine("취 소");
        }

        public static void SelectMarble(ref bool _isSelected_Finish)
        {
            //확인
            if (_isDone)
            {
                _isSelected_Finish = true;
            }

            //취소
            if (_isCancle)
            {
                if(MainTable.M_RedMarble != 0)
                {
                    RedMarble += MainTable.M_RedMarble;
                }
                if (MainTable.M_GreenMarble != 0)
                {
                    GreenMarble += MainTable.M_GreenMarble;
                }
                if (MainTable.M_BlueMarble != 0)
                {
                    BlueMarble += MainTable.M_BlueMarble;
                }

                //초기화.
                count = 0;
            }

            else
            {
                //3개가 되면 더이상 선택 안됨.
                if (count < 3)
                {
                    if (posX < 20 + (RedMarble * 6)) //레드일 경우
                    {
                        RedMarble--;
                        MainTable.M_RedMarble++;
                        count++;
                    }
                    else if (posX < 20 + ((GreenMarble + RedMarble) * 6)) //그린일 경우
                    {
                        GreenMarble--;
                        MainTable.M_GreenMarble++;
                        count++;
                    }
                    else if (posX < 20 + ((BlueMarble + GreenMarble + RedMarble) * 6)) //블루일 경우
                    {
                        BlueMarble--;
                        MainTable.M_BlueMarble++;
                        count++;
                    }
                }
            }
            
        }

        public static void Render(ref bool _isSelected_Finish)
        {
            posX = 20;
            posY = 42;

            int OKposX = 125;
            int OKposY = 42;

            //확인 취소와 아닐때를 나눌 경계선입니다.
            bool _switch = false;
            
            //화살표로 움직여서 선택합니다.
            do
            {            
                //우선 틀부터 잡습니다.
                PlayForm();

                //플레이어가 가진 구슬을 보여줍니다.
                PlayerForm();

                if (!_switch)
                {
                    //컨트롤 중 c를 눌러도 족보가 뜨게 해주는 트래거
                    _isCheckRule = true;

                    //최대를 하나 더 올려놓음으로써 그 상태가 될때 ok위치로 넘어가게 설정합니다.
                    UtilSystem.PlayerSelectPos(ref posY, ref posX, 42, 42
                                                , 20 + ((RedMarble + GreenMarble + BlueMarble) * 6),  20, ref _isSelected, 0, 6, "▲");

                    //다시 닫습니다.
                    _isCheckRule = false;

                    //확인 취소로 넘어가는 함수
                    if (posX == 20 + ((RedMarble + GreenMarble + BlueMarble) * 6))
                    {
                        _switch = true;
                        OKposX = 125;

                        //최대로 넘어간 화살표 지우기
                        SetCursorPosition(20 + ((RedMarble + GreenMarble + BlueMarble - 1) * 6), 42);
                        Write("  ");
                    }
                }

                //확인 취소 좌표를 따로 설정합니다.
                else if (_switch)
                {
                    SetCursorPosition(125, 42);
                    Write("  ");
                    SetCursorPosition( 125, 45);
                    Write("  ");

                    UtilSystem.PlayerSelectPos(ref OKposY, ref OKposX, 45, 42
                        , 125, 124, ref _isSelected, 3, 1, "◀");


                    //사용자가 Y값을 움직였을때(윗키를 눌렀을때)다시 돌아가게 설정합니다.
                    if (OKposX != 125)
                    {
                        //다시 위로 돌아갈때 마지막을 가르키게 하기 위해 미리 좌표를 지정해줍니다
                        posX = 20 + ((RedMarble + GreenMarble + BlueMarble - 1) * 6);
                        posY = 42;
                        _switch = false;
                        SetCursorPosition(125, 42);
                        Write("  ");
                        SetCursorPosition(125, 45);
                        Write("  ");
                    }

                    //확인 & 취소가 선택된 경우
                    if (_isSelected)
                    {
                        if(OKposY ==  42)
                        {
                            _isDone = true; 
                        }
                        else if(OKposY ==  45)
                        {
                            _isCancle = true;
                        }
                    }
                }

            } while (!_isSelected);

            //선택한 구슬 & 확인, 취소
            SelectMarble(ref _isSelected_Finish);

            //루프 통과후 초기화.
            _isDone = false;
            _isCancle = false;
            _isSelected = false;


        }
    }

    public static class MainTable
    {
        public static int M_RedMarble = 0; //구슬
        public static int M_BlueMarble = 0; //구슬
        public static int M_GreenMarble = 0; //구슬
        public static long _BettingMoney = 0;
        public static bool _take = false; //받는지 잃는지 함수.
        public static string _getInput; 
        static Color _SelectColor;//0 r 1 g 2 b
        static bool _checked = false; //이 족보 공식에 맞을경우 스톱.
        static string WhatIs = "없음";
        static string specialType = "없음";
        static string Yourtake;
        public static long _resultMoney = 0;//결과

        static void Reset()
        {
            WhatIs = "없음";
            specialType = "없음";
        }

        public static void Render()
        {
            Clear();

            GameSystem.ShowInfo();

            Console.BackgroundColor = ConsoleColor.Black;
            for(int i = 0; i< 125; i++)
            {
                SetCursorPosition(10 + i,5);
                Write("  ");
            }

            for (int i = 0; i < 125; i++)
            {
                SetCursorPosition(10 + i, 45);
                Write("  ");
            }
            Console.BackgroundColor = ConsoleColor.DarkGray;

            Console.BackgroundColor = ConsoleColor.Red;
            SetCursorPosition(25, 10);
            Write("  ");
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Write("의 개수 :  ");
            Thread.Sleep(1000);
            Write(M_RedMarble);

            Thread.Sleep(750);
            Console.BackgroundColor = ConsoleColor.Green;
            SetCursorPosition(25, 15);
            Write("  ");
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Write($"의 개수 :  ");
            Thread.Sleep(1000);
            Write(M_GreenMarble);


            Thread.Sleep(750);
            Console.BackgroundColor = ConsoleColor.Blue;
            SetCursorPosition(25, 20);
            Write("  ");

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Write($"의 개수 :  ");
            Thread.Sleep(1000);
            Write(M_BlueMarble);

            Thread.Sleep(750);
            SetCursorPosition(65, 13);
            Write("당신이 베팅한 돈은   ");
            Thread.Sleep(1000);
            Write(string.Format("{0:N0}", _BettingMoney));

            Thread.Sleep(750);
            SetCursorPosition(65, 15);
            Write("당신이 선택한 구슬은   ");
            Thread.Sleep(1000);
            YourSelect();

            Thread.Sleep(750);
            SetCursorPosition(65, 20);
            Write("컴퓨터수 :   ");
            Thread.Sleep(1000);
            Write($"{GameSystem.ComNum} 대({GameSystem.Level} 배)");

            Thread.Sleep(750);
            SetCursorPosition(65, 22);
            Write("특별한 경우는   ");
            Thread.Sleep(1000);
            Write(specialType);

            Thread.Sleep(750);
            SetCursorPosition(65, 24);
            Write("당신의 결과는   ");
            Thread.Sleep(1000);
            Write(WhatIs);

            Thread.Sleep(2000);
            SetCursorPosition(65, 26);
            Write("당신은 돈을   ");
            //잃는경우
            if (!_take)
            {
                Write("잃습니다.");
                Yourtake = "-";
            }
            else
            {
                Write("얻습니다.");
                Yourtake = "+";
            }

            Thread.Sleep(2000);
            SetCursorPosition(65, 32);
            Write("총합 :  ");
            Write(Yourtake);
            Write($" {_resultMoney}");
            Thread.Sleep(2000);

            //초기화
            Reset();

            Clear();
        }

        static void YourSelect()
        {
            if(_SelectColor == Color.red)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Write("  ");
                Console.BackgroundColor = ConsoleColor.DarkGray;
            }
            else if (_SelectColor == Color.green)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Write("  ");
                Console.BackgroundColor = ConsoleColor.DarkGray;
            }
            else if (_SelectColor == Color.blue)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Write("  ");
                Console.BackgroundColor = ConsoleColor.DarkGray;
            }
        }
        
        public static void BettingMoney()
        {
            bool _isgood = false;
            do
            {
                UtilSystem.OpenChat(65, 25, 40, 6, "베팅할 금액 : ", 6, 0);
                string _yourBett = ReadLine();

                if (!long.TryParse(_yourBett, out _BettingMoney))
                {
                    UtilSystem.OpenChat(65, 25, 40, 6, "다시 입력하세요", 6, 0);
                    Thread.Sleep(2000);
                    _isgood = false;
                }
                else
                    _isgood = true;

                if(_BettingMoney > Player.Money)
                {
                    UtilSystem.OpenChat(65, 25, 40, 6, "돈이 부족합니다. 다시 입력하세요", -3, 0);
                    Thread.Sleep(2000);
                    _isgood = false;
                }

            } while (!_isgood);
        }
        
        public static void BettingMarble()
        {
            bool _isgood = false;
            do
            {
                UtilSystem.OpenChat(65, 25, 60, 6, "베팅할 색(RED, GREEN, BLUE) : ", 0, 0);
                string _getInput = ReadLine();

                if (_getInput == "RED")
                {
                    _SelectColor = Color.red;
                    _isgood = true;
                }
                else if (_getInput == "GREEN")
                {
                    _SelectColor = Color.green;
                    _isgood = true;
                }
                else if (_getInput == "BLUE")
                {
                    _SelectColor = Color.blue;
                    _isgood = true;
                }
                else
                {
                    UtilSystem.OpenChat(65, 25, 40, 6, "다시 입력하세요", 6, 0);
                    Thread.Sleep(2000);
                    _isgood = false;
                }
            } while (!_isgood);

        }

        //족보. 계산함수
        public static void LetdoThis()
        {
            //구슬 개수 최소 최대 체크
            Rule_3_1_ManyMarble();
            Rule_3_2_FewMarble();

            //1가지로 통일 된 경우
            Rule_0_All();

            //통일 되지 않은경우 다음 족보로 넘어간다.
            if (!_checked)
            {
                //3개 모두 동률인 경우
                Rule_2_Same();

                //동률이 아닌 경우
                if (!_checked)
                {
                    //2개가 동률인 경우
                    Rule_4_LessSame();

                    //동률이 아닌경우
                    if (!_checked)
                    {
                        //선택구슬 나머지 족보 확인.
                        Rule_1_Most();
                        Rule_1_Middle();
                        Rule_1_Few();
                        Rule_1_Less();
                    }
                }
            }

            //결과 돈 
            _resultMoney = (long)(_resultMoney * GameSystem.Level);
            _checked = false; //초기화

        }

        public static void RuleBook()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Clear();
            WriteLine();
            WriteLine();
            WriteLine();
            WriteLine();
            WriteLine();
            WriteLine("  구슬 3개 선택후 베팅할 돈과 베팅할 색을 고릅니다.");
            WriteLine();
            WriteLine("  플레이어와 컴퓨터가 낸 구슬을 모두 합하여 결과를 냅니다");
            WriteLine("");
            WriteLine("  모두 합한 구슬과 플레이어가 베팅한 색으로 베팅한 돈의 배를 얻거나 잃습니다.");
            WriteLine("  색을 맞춘경우 (베팅한 돈 x 배수)를 얻고, 못맞춘 경우 (베팅한 돈 x 배수)를 잃습니다.");
            WriteLine();
            WriteLine("  ");
            WriteLine();
            WriteLine("                          족보");
            WriteLine("  ");
            WriteLine("  ");
            WriteLine("  단 1개의 구슬색만 나온 경우 : 하나로 통일 된 경우 ( x 10 )");
            WriteLine("  ");
            WriteLine("  선택한 구슬이 다른 구슬보다 많은 경우 : 선택한 구슬의 수(제일 많은 경우 ( x 2 )");
            WriteLine("  선택한 구슬이 다른 구슬의 중간 수많큼 있는 경우 : 선택한 구슬의 수(중간 ( x 2 무조건 잃음)");
            WriteLine("  선택한 구슬이 다른 구슬보다 적은 경우 : 선택한 구슬의 수(제일 적은 경우 ( x 3 무조건 잃음)");
            WriteLine("  ");
            WriteLine("  선택한 구슬이 없는 경우 : 선택한 구슬의 수가 없는 경우 ( x 5 무조건 잃음)");
            WriteLine("");
            WriteLine("  3개의 구슬의 색이 모두 같은 경우 : 구슬의 수가 동률 ( x 3 무조건 얻음)");
            WriteLine("  2개의 구슬의 색이 같은 경우 : 2개 구슬 동률 ( 틀리면 잃는 x 4 ) or ( 맞추면 받는 x 1 )");
            WriteLine("  라운드 하나가 끝난경우 플레이어와 컴퓨터가 들고있는 남은 구슬을 보여줍니다.");
            WriteLine("  그리고 그상태로 다시 라운드를 진행합니다.");
            WriteLine("  ");
            WriteLine("  --- 특수한 경우 ---");
            WriteLine("  ");
            WriteLine("  ");
            WriteLine("  n대의 컴퓨터가 모두 3개를 내고, 플레이어도 3개를 낸 경우 : 구슬이 최대치!! ( 추가 x3 )");
            WriteLine("  ");
            WriteLine("  n대의 컴퓨터가 모두 1개를 내고, 플레이어도 1개를 낸 경우 : 구슬이 최소치!! ( 추가 x 5 )");
            WriteLine("  ");
            WriteLine();
            WriteLine();
            WriteLine();
            WriteLine();
            WriteLine();
            WriteLine();
            WriteLine();
            WriteLine("                              아무키나 누르면 메뉴로 돌아갑니다.");

            Form.CoinDrawing(95, 25);
            Form.GoldDrawing(125, 20);

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGray;

            SetCursorPosition(0, 0);
        }

        //족보
        public static void Rule_0_All()
        {
            //색이 하나로 통일된 경우
            
            //레드로 통일
            if(M_BlueMarble == 0 && M_GreenMarble == 0)
            {
                //맞춘경우
                if (_SelectColor == Color.red)
                {
                    _resultMoney = _BettingMoney *  10;
                    _take = true;
                    _checked = true;
                    WhatIs = "하나로 통일 된 경우 ( x 10 )";
                }

                else
                {
                    _resultMoney = _BettingMoney *  10;
                    _take = false;
                    _checked = true;
                    WhatIs = "하나로 통일 된 경우 ( x 10 )";
                }
            }

            //그린
            else if (M_BlueMarble == 0 && M_RedMarble == 0)
            {
                //맞춘경우
                if (_SelectColor == Color.green)
                {
                    _resultMoney = _BettingMoney *  10;
                    _take = true;
                    _checked = true;
                    WhatIs = "하나로 통일 된 경우 ( x 10 )";
                }

                else
                {
                    _resultMoney = _BettingMoney *  10;
                    _take = false;
                    _checked = true;
                    WhatIs = "하나로 통일 된 경우 ( x 10 )";
                }
            }

            //블루
            else if (M_RedMarble == 0 && M_GreenMarble == 0)
            {
                //맞춘경우
                if (_SelectColor == Color.blue)
                {
                    _resultMoney = _BettingMoney *  10;
                    _take = true;
                    _checked = true;
                    WhatIs = "하나로 통일 된 경우 ( x 10 )";
                }

                else
                {
                    _resultMoney = _BettingMoney *  10;
                    _take = false;
                    _checked = true;
                    WhatIs = "하나로 통일 된 경우 ( x 10 )";
                }
            }

        }
        
        public static void Rule_1_Most()
        {
            switch (_SelectColor)
            {
                case Color.red:
                    if(M_RedMarble > M_GreenMarble && M_RedMarble > M_BlueMarble)
                    {
                        _resultMoney = _BettingMoney *  2;
                        _take = true;
                        _checked = true;
                        WhatIs = "선택한 구슬의 수(제일 많은 경우 ( x 2 ))";
                    }
                    break;
                case Color.green:
                    if (M_GreenMarble > M_RedMarble && M_GreenMarble > M_BlueMarble)
                    {
                        _resultMoney = _BettingMoney *  2;
                        _take = true;
                        _checked = true;
                        WhatIs = "선택한 구슬의 수(제일 많은 경우 ( x 2 ))";
                    }
                    break;
                case Color.blue:
                    if (M_BlueMarble > M_GreenMarble && M_BlueMarble > M_RedMarble)
                    {
                        _resultMoney = _BettingMoney *  2;
                        _take = true;
                        _checked = true;
                        WhatIs = "선택한 구슬의 수(제일 많은 경우 ( x 2 ))";
                    }
                    break;
            }
        }

        public static void Rule_1_Middle()
        {
            switch (_SelectColor)
            {
                case Color.red:
                    if (M_RedMarble > M_GreenMarble && M_RedMarble < M_BlueMarble ||
                        M_RedMarble < M_GreenMarble && M_RedMarble > M_BlueMarble)
                    {
                        _resultMoney = _BettingMoney *  2;
                        _take = false;
                        _checked = true;
                        WhatIs = "선택한 구슬의 수(중간 ( x 2 )";
                    }
                    break;

                case Color.green:
                    if (M_GreenMarble > M_RedMarble && M_GreenMarble < M_BlueMarble ||
                        M_GreenMarble < M_RedMarble && M_GreenMarble > M_BlueMarble)
                    {
                        _resultMoney = _BettingMoney *  2;
                        _take = false;
                        _checked = true;
                        WhatIs = "선택한 구슬의 수(중간 ( x 2 )";
                    }
                    break;

                case Color.blue:
                    if (M_BlueMarble > M_GreenMarble && M_BlueMarble < M_RedMarble ||
                        M_BlueMarble < M_GreenMarble && M_BlueMarble > M_RedMarble)
                    {
                        _resultMoney = _BettingMoney *  2;
                        _take = false;
                        _checked = true;
                        WhatIs = "선택한 구슬의 수(중간 ( x 2 )";
                    }
                    break;
            }
        }

        public static void Rule_1_Few()
        {
            switch (_SelectColor)
            {
                case Color.red:
                    if (M_RedMarble < M_GreenMarble && M_RedMarble < M_BlueMarble)
                    {
                        _resultMoney = _BettingMoney *  3;
                        _take = false;
                        _checked = true;
                        WhatIs = "선택한 구슬의 수(제일 적은 경우 ( x 3 )";
                    }
                    break;
                case Color.green:
                    if (M_GreenMarble < M_RedMarble && M_GreenMarble < M_BlueMarble)
                    {
                        _resultMoney = _BettingMoney *  3;
                        _take = false;
                        _checked = true;
                        WhatIs = "선택한 구슬의 수(제일 적은 경우 ( x 3 )";
                    }
                    break;
                case Color.blue:
                    if (M_BlueMarble < M_GreenMarble && M_BlueMarble < M_RedMarble)
                    {
                        _resultMoney = _BettingMoney *  3;
                        _take = false;
                        _checked = true;
                        WhatIs = "선택한 구슬의 수(제일 적은 경우 ( x 3 )";
                    }
                    break;
            }
        }

        public static void Rule_1_Less()
        {
            switch (_SelectColor)
            {
                case Color.red:
                    if (M_RedMarble == 0)
                    {
                        _resultMoney = _BettingMoney *  5;
                        _take = false;
                        _checked = true;
                        WhatIs = "선택한 구슬의 수(없다 ( x 5 ))";
                    }
                    break;
                case Color.green:
                    if (M_GreenMarble == 0)
                    {
                        _resultMoney = _BettingMoney *  5;
                        _take = false;
                        _checked = true;
                        WhatIs = "선택한 구슬의 수(없다 ( x 5 ))";
                    }
                    break;
                case Color.blue:
                    if (M_BlueMarble == 0)
                    {
                        _resultMoney = _BettingMoney *  5;
                        _take = false;
                        _checked = true;
                        WhatIs = "선택한 구슬의 수(없다 ( x 5 ))";
                    }
                    break;
            }
        }

        public static void Rule_2_Same()
        {
            //3개가 다 같은경우
            if (M_RedMarble == M_GreenMarble && M_GreenMarble == M_BlueMarble)
            {
                _take = true;
                _resultMoney = _BettingMoney *  3;
                _checked = true;
                WhatIs = "구슬의 수가 동률 ( x 3 )";
            }

        }

        public static void Rule_3_1_ManyMarble()
        {
            //구슬 최대치 인 경우
            if(M_BlueMarble + M_GreenMarble + M_RedMarble == (GameSystem.ComNum * 3) + 3)
            {
                _resultMoney = _BettingMoney *  3;
                specialType = "구슬이 최대치!! ( 추가 x3 )";
            }
        }

        public static void Rule_3_2_FewMarble()
        {
            //구슬 최소치 인 경우
            if (M_BlueMarble + M_GreenMarble + M_RedMarble == (GameSystem.ComNum * 1) + 1)
            {
                _resultMoney = _BettingMoney *  5;
                specialType = "구슬이 최소치!! ( 추가 x 5 )";
            }
        }

        public static void Rule_4_LessSame()
        {
            //선택한 색 빼고 2개가 같은 경우

            //레드
            if (M_BlueMarble == M_GreenMarble)
            {
                //틀린경우
                if (_SelectColor == Color.red)
                {
                    _resultMoney = _BettingMoney *  4;
                    _take = false;
                    _checked = true;
                    WhatIs = "2개 구슬 동률 ( 틀리면 잃는 x 4 ) or ( 맞추면 받는 x 1 )";
                }

                //2가지 중 포함되는 경우
                else
                {
                    _resultMoney = _BettingMoney *  1;
                    _take = true;
                    _checked = true;
                    WhatIs = "2개 구슬 동률 ( 틀리면 잃는 x 4 ) or ( 맞추면 받는 x 1 )";
                }
            }

            //그린
            else if (M_BlueMarble == M_RedMarble)
            {
                //틀린경우
                if (_SelectColor == Color.green)
                {
                    _resultMoney = _BettingMoney *  4;
                    _take = false;
                    _checked = true;
                    WhatIs = "2개 구슬 동률 ( 틀리면 잃는 x 4 ) or ( 맞추면 받는 x 1 )";
                }
                //2가지 중 포함되는 경우
                else
                {
                    _resultMoney = _BettingMoney *  1;
                    _take = true;
                    _checked = true;
                    WhatIs = "2개 구슬 동률 ( 틀리면 잃는 x 4 ) or ( 맞추면 받는 x 1 )";

                }
            }

            //블루
            else if (M_RedMarble == M_GreenMarble)
            {
                //틀린경우
                if (_SelectColor == Color.blue)
                {
                    _resultMoney = _BettingMoney *  4;
                    _take = false;
                    _checked = true;
                    WhatIs = "2개 구슬 동률 ( 틀리면 잃는 x 4 ) or ( 맞추면 받는 x 1 )";
                }
                //2가지 중 포함되는 경우
                else
                {
                    _resultMoney = _BettingMoney *  1;
                    _take = true;
                    _checked = true;
                    WhatIs = "2개 구슬 동률 ( 틀리면 잃는 x 4 ) or ( 맞추면 받는 x 1 )";

                }
            }


        }

        //계산후 돈 주기
        public static void TakeMoney()
        {
            //돈을 받는 경우
            if (_take)
            {
                Player.Money += _resultMoney;
            }

            //돈을 잃는 경우
            else
                Player.Money -= _resultMoney;
        }
    }
    
    class Program
    {
        #region Thread
        /*
        public static void Run()
        {
            for(int i = 0; i <10; i++)
            {
                WriteLine("10");
                Thread.Sleep(100);

            }
        }

        public static void Ang()
        {
            for(int j = 0; j <5; j++)
            {
                WriteLine("ㅇㅇ");
            }
        }
         */
        #endregion

        #region 사운드
        /*
    static void Soundplay()
    {
        SoundPlayer player = new SoundPlayer(@"cw.wav"); //파일 경로.
        player.PlaySync();
    }*/
        #endregion

        #region 화면 잘라내기
            /**/
        //MoveBufferArea()

        #endregion

        static void Main(string[] args)
        {
            #region Thread
            /*
            new Thread(new ThreadStart(Run)).Start();
            //Thread thread_ang = new Thread(new ThreadStart(Ang));
            //thread_ang.Start();

            WriteLine("쓰레드 종료까지 대기");
            //thread_ang.Join();
            WriteLine("종료");
            */
            #endregion

            #region 사운드
            /*
            Thread Soundthread = new Thread(new ThreadStart(Soundplay));
            Soundthread.Start();*/
            #endregion
            
            CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Clear();
            Title = "구슬 게임";

            SetWindowSize(200,50);
            SetBufferSize(220, 60);
            bool _LetsFinish = false;

            #region 깜빡임 실험
            //bool _isfine = false;
            //do
            //{
            //    for(int t = 0; t< 4; t++)
            //    {
            //        SetCursorPosition(0, 10 + t);
            //        Console.BackgroundColor = ConsoleColor.White;
            //        Write("  ");
            //        SetCursorPosition(1, 10 + t);
            //        Console.BackgroundColor = ConsoleColor.White;
            //        Write("  ");
            //        SetCursorPosition(2, 10 + t);
            //        Console.BackgroundColor = ConsoleColor.White;
            //        Write("  ");
            //        SetCursorPosition(3, 10 + t);
            //        Console.BackgroundColor = ConsoleColor.White;
            //        Write("  ");
            //        SetCursorPosition(4, 10 + t);
            //        Console.BackgroundColor = ConsoleColor.White;
            //        Write("  ");
            //        SetCursorPosition(5, 10 + t);
            //        Console.BackgroundColor = ConsoleColor.White;
            //        Write("  ");

            //    }
            //    if (!_isfine)
            //    {
            //        SetCursorPosition(2, 12);
            //        Console.BackgroundColor = ConsoleColor.Blue;
            //        Write("  ");
            //        _isfine = true;
            //        Console.BackgroundColor = ConsoleColor.White;
            //    }
            //    else
            //    {
            //        SetCursorPosition(3, 12);
            //        Console.BackgroundColor = ConsoleColor.Blue;
            //        Write("  ");
            //        _isfine = false;
            //        Console.BackgroundColor = ConsoleColor.White;
            //    }
            //    Thread.Sleep(500);
            //} while (z < 4);
            #endregion

            WaitMenu.Initialize(ref _LetsFinish);

        }
    }
}