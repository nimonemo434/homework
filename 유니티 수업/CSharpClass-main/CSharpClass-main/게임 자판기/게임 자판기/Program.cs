using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 게임_자판기
{
    public static class _StartMenu
    {

        public static int posY = 0;
        public static bool _letFinish = false;

        static bool _letOut = false;
        static int _yourMoney = 5000;

        public static void WaitMenu() {


            SetCursorPosition(5, 2);
            Console.ForegroundColor = ConsoleColor.Blue;
            WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            Console.ForegroundColor = ConsoleColor.White;
            SetCursorPosition(20, 3);
            WriteLine("게임 파티");
            SetCursorPosition(5, 4);
            Console.ForegroundColor = ConsoleColor.Blue;
            WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            Console.ForegroundColor = ConsoleColor.White;
            SetCursorPosition(25, 6);
            WriteLine($"당신의 코인 : {_yourMoney}");
            SetCursorPosition(15, 8);
            WriteLine("로또");
            SetCursorPosition(15, 9);
            WriteLine("숫자야구");
            SetCursorPosition(15, 10);
            WriteLine("가위바위보");
            SetCursorPosition(15, 11);
            WriteLine("종료");

            do
            {
                for (int k = 0; k < 4; k++)
                {
                    SetCursorPosition(10, k + 8);
                    Write("  ");
                }
                SetCursorPosition(10, posY + 8);
                Write("▶");

                ConsoleKeyInfo key = Console.ReadKey(true);


                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        posY--;
                        if (posY < 0)
                        {
                            posY = 3;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        posY++;
                        if (posY > 3)
                        {
                            posY = 0;
                        }
                        break;
                    case ConsoleKey.Enter:
                        _letOut = true;
                        break;
                }

            } while (!_letOut);

            //posY값에 따라 게임이 결정됩니다.
            Clear();
            itSelect();

            _letOut = false;

            //돈이 0이거나 0 이하일 경우
            if(_yourMoney <= 0)
            {
                Clear();
                SetCursorPosition(5, 2);
                Console.ForegroundColor = ConsoleColor.Blue;
                WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.ForegroundColor = ConsoleColor.White;
                SetCursorPosition(20, 3);
                WriteLine("게임 오버");
                SetCursorPosition(5, 4);
                Console.ForegroundColor = ConsoleColor.Blue;
                WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.ForegroundColor = ConsoleColor.White;

                ReadKey();
                _letFinish = true;
            }
            
        }

        private static void itSelect()
        {
            switch (posY)
            {
                case 0: //로또
                    Lotto.Initialize(ref _yourMoney);
                    break;
                case 1: //숫자야구
                    BaseBall.Initialize(ref _yourMoney);
                    break;
                case 2: //가위바위보
                    RSP.Initialize(ref _yourMoney);
                    break;
                default: //종료
                    _letFinish = false;
                    break;
            }
        }
    }

    public static class Lotto
    {
        public static void Initialize(ref int money)
        {

            Random r = new Random();

            WriteLine("      ");
            ForegroundColor = ConsoleColor.Blue;
            BackgroundColor = ConsoleColor.Yellow;
            Write("★☆");
            BackgroundColor = ConsoleColor.Black;
            ForegroundColor = ConsoleColor.White;
            Write("로또 로또 로또");
            ForegroundColor = ConsoleColor.Blue;
            BackgroundColor = ConsoleColor.Yellow;
            WriteLine("☆★");
            BackgroundColor = ConsoleColor.Black;
            ForegroundColor = ConsoleColor.White;
            WriteLine("");
            WriteLine("5개의 정수를 순서대로 입력해주세요!");
            WriteLine("");
            WriteLine("");

            int _firstNum, _secondNum, _thirdNum, _fourthNum, _fifthNum; //입력 받는 숫자
            int _Num1, _Num2, _Num3, _Num4, _Num5; //컴퓨터 랜덤 값

            string _getNum;
            int count = 0;

            //랜덤값 배정.
            _Num1 = r.Next(1, 10);
            _Num2 = r.Next(11, 20);
            _Num3 = r.Next(21, 30);
            _Num4 = r.Next(31, 40);
            _Num5 = r.Next(41, 45);


            WriteLine("");
            Write("첫번째 숫자!");
            BackgroundColor = ConsoleColor.Blue;
            Write("(1~10)");
            BackgroundColor = ConsoleColor.Black;
            Write(" : ");

            _getNum = ReadLine();

            //숫자 입력 시작.
            if (int.TryParse(_getNum, out _firstNum))
            {

                //값 범위 밖의 값일 경우 종료.
                if (_firstNum > 10 || _firstNum < 0)
                {
                    WriteLine("값을 잘못 입력하셨습니다. 종료합니다.");
                    ReadKey();
                    return;
                }
            }

            //치트키. 입력받으면 로또번호가 다 나온다.
            else if (_getNum == "치트키")
            {
                WriteLine($"로또번호는 {_Num1} , {_Num2} , {_Num3} , {_Num4} , {_Num5} 입니다");
                WriteLine("첫번째 번호는 맞춰놓습니다.");
                _firstNum = _Num1;
            }

            //정수가 아닌 다른 값을 입력하면 종료.
            else
            {
                WriteLine("값을 잘못 입력하셨습니다. 종료합니다.");
                ReadKey();
                return;
            }


            WriteLine("");
            Write("두번째 숫자!");
            BackgroundColor = ConsoleColor.Green;
            Write("(11~20)");
            BackgroundColor = ConsoleColor.Black;
            Write(" : ");
            _getNum = ReadLine();

            if (int.TryParse(_getNum, out _secondNum))
            {
                if (_secondNum > 20 || _secondNum < 11)
                {
                    WriteLine("값을 잘못 입력하셨습니다. 종료합니다.");
                    ReadKey();
                    return;
                }
            }
            else
            {
                WriteLine("값을 잘못 입력하셨습니다. 종료합니다.");
                ReadKey();
                return;
            }

            WriteLine("");
            Write("세번째 숫자!");
            BackgroundColor = ConsoleColor.Red;
            Write("(21~30)");
            BackgroundColor = ConsoleColor.Black;
            Write(" : ");
            _getNum = ReadLine();

            if (int.TryParse(_getNum, out _thirdNum))
            {
                if (_thirdNum > 30 || _thirdNum < 21)
                {
                    WriteLine("값을 잘못 입력하셨습니다. 종료합니다.");
                    ReadKey();
                    return;
                }
            }
            else
            {
                WriteLine("값을 잘못 입력하셨습니다. 종료합니다.");
                ReadKey();
                return;
            }

            WriteLine("");
            Write("네번째 숫자!");
            ForegroundColor = ConsoleColor.Black;
            BackgroundColor = ConsoleColor.White;
            Write("(31~40)");

            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            Write(" : ");
            _getNum = ReadLine();

            if (int.TryParse(_getNum, out _fourthNum))
            {
                if (_fourthNum > 40 || _fourthNum < 31)
                {
                    WriteLine("값을 잘못 입력하셨습니다. 종료합니다.");
                    ReadKey();
                    return;
                }
            }
            else
            {
                WriteLine("값을 잘못 입력하셨습니다. 종료합니다.");
                ReadKey();
                return;
            }

            WriteLine("");
            Write("다섯번째 숫자!");
            BackgroundColor = ConsoleColor.Gray;
            Write("(41~45)");
            BackgroundColor = ConsoleColor.Black;
            Write(" : ");
            _getNum = ReadLine();

            if (int.TryParse(_getNum, out _fifthNum))
            {
                if (_fifthNum > 45 || _fifthNum < 41)
                {
                    WriteLine("값을 잘못 입력하셨습니다. 종료합니다.");
                    ReadKey();
                    return;
                }
            }
            else
            {
                WriteLine("값을 잘못 입력하셨습니다. 종료합니다.");
                ReadKey();
                return;
            }

            Clear();

            WriteLine("");
            WriteLine("시작합니다!!!");

            Write("입력하신 숫자는 ");

            ForegroundColor = ConsoleColor.Blue;
            BackgroundColor = ConsoleColor.Yellow;
            Write($"{_firstNum} , {_secondNum} , {_thirdNum} , {_fourthNum} , {_fifthNum}");

            BackgroundColor = ConsoleColor.Black;
            ForegroundColor = ConsoleColor.White;
            WriteLine("이였습니다!");

            WriteLine("");
            WriteLine($"로또번호는 {_Num1} , {_Num2} , {_Num3} , {_Num4} , {_Num5} 이였습니다!");
            if (_firstNum == _Num1)
            {
                count++;
            }
            if (_secondNum == _Num2)
            {
                count++;
            }
            if (_thirdNum == _Num3)
            {
                count++;
            }
            if (_fourthNum == _Num4)
            {
                count++;
            }
            if (_fifthNum == _Num5)
            {
                count++;
            }

            WriteLine($"맞추신 숫자들은 총 {count}개 입니다~");
            if (count == 5)
            {
                ForegroundColor = ConsoleColor.Blue;
                BackgroundColor = ConsoleColor.Yellow;
                WriteLine("1등입니다!! 축하합니다~!!! (+5000)");
                money += 5000;

            }
            else if (count == 4)
            {
                ForegroundColor = ConsoleColor.Blue;
                BackgroundColor = ConsoleColor.Yellow;
                WriteLine("2등입니다! 축하해요~ (+2000)");
                money += 2000;
            }
            else if (count == 3)
            {
                ForegroundColor = ConsoleColor.Blue;
                BackgroundColor = ConsoleColor.Yellow;
                WriteLine("3등입니다 (+500)");
                money += 500;
            }
            else
            { //2 개, 1개, 0개인 경우
                ForegroundColor = ConsoleColor.Blue;
                BackgroundColor = ConsoleColor.Yellow;
                WriteLine("아 안타까워요. (-500)");
                money -= 500;
            }

            WriteLine("아무키나 누르면 메뉴로 돌아갑니다.");
            ReadKey();

            Clear();
        }
    }

    public static class BaseBall
    {
        public static void Initialize(ref int money)
        {
            //1장 게임 준비
            WriteLine("      ☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            WriteLine("      ☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            WriteLine("      ☆★☆★ 숫  자  야  구 ☆★☆★☆★");
            WriteLine("      ☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            WriteLine("      ☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            WriteLine("");
            WriteLine("룰 : 시작후 컴퓨터가 숫자 3개를 순서대로 가지고 있습니다.");
            WriteLine("     플레이어는 이 숫자를 순서대로 맞추면 이기는 게임 입니다!");
            WriteLine("     숫자는 1부터 9까지 입니다!");
            WriteLine("     9턴 안에 숫자를 맞추지 못하면 게임 오버입니다");
            WriteLine("1번성공 = +5000. 2~4번성공 = +2000. 4~7번성공 = +500. 그 외 = -500");
            WriteLine("");
            WriteLine("");

            WriteLine("   S = 숫자와 위치가 맞는 경우");
            WriteLine("   B = 숫자는 있지만 위치가 다른 경우");
            WriteLine("   Out = 제시한 숫자 3개가 모두 틀린 경우");
            WriteLine("");
            WriteLine("  (아무키나 누르면 게임을 시작합니다.)");

            ReadKey();
            Clear();

            //2장 게임

            Random r = new Random();

            int com1, com2, com3; //100의 자리, 10의 자리, 1의 자리.    
            int _GetYourNum = 0;
            int count = 0;
            int _hundNum = 0; //100의 자리 숫자.
            int _tenNum = 0; //10의 자리 숫자.
            int _oneNum = 0; //1의 자리 숫자.


            //컴퓨터 숫자 정의.
            com1 = r.Next(1, 10);
            do
            {
                com2 = r.Next(1, 10);
            } while (com1 == com2);
            do
            {
                com3 = r.Next(1, 10);
            } while (com1 == com3 || com2 == com3);


            WriteLine("");
            WriteLine("");
            WriteLine("     컴퓨터는 숫자를 정했습니다. 이제 이 숫자를 맞추시면 됩니다.");
            WriteLine("");
            
            while (count < 10)
            {

                int _StrikeCount = 0;
                int _BallCount = 0;

                ForegroundColor = ConsoleColor.White;

                count++;

                //만약 시도 9번을 모두 채운경우.
                if (count == 10)
                {
                    WriteLine("땡! 9번 모두 시도했습니다.");
                    WriteLine("실패 하셨습니다.");
                    break;
                }

                WriteLine("");
                WriteLine("      ☆★☆★☆★☆★☆★☆★☆★☆★☆★");
                WriteLine("");
                Write($"{count}번째 턴. 숫자 입력 : ");

                //숫자가 아닌 것으로 적은 경우.
                if (!int.TryParse(ReadLine(), out _GetYourNum))
                {
                    ForegroundColor = ConsoleColor.Cyan;
                    WriteLine("숫자가 아닌 다른 것을 입력하셨습니다. 턴을 넘깁니다.");
                    ForegroundColor = ConsoleColor.White;
                    continue;
                }

                //숫자를 4자리 이상 적을 경우
                else if (_GetYourNum > 999)
                {
                    ForegroundColor = ConsoleColor.Cyan;
                    WriteLine("3자리 숫자 이상을 입력하셨습니다. 턴을 넘깁니다.");
                    ForegroundColor = ConsoleColor.White;
                    continue;
                }

                //입력 받은 숫자 나누기.
                _hundNum = _GetYourNum / 100;
                _tenNum = _GetYourNum % 100 / 10;
                _oneNum = _GetYourNum % 10;

                //플레이어가 0을 낸 경우. 잘못되었음을 알려준다.
                if (_hundNum == 0 || _tenNum == 0 || _oneNum == 0)
                {
                    ForegroundColor = ConsoleColor.Cyan;
                    WriteLine("0은 사용하지 않습니다. 턴을 넘깁니다.");
                    ForegroundColor = ConsoleColor.White;
                    continue;
                }

                //플레이어가 같은 숫자를 낸경우
                if (_hundNum == _tenNum || _oneNum == _tenNum || _oneNum == _hundNum)
                {
                    ForegroundColor = ConsoleColor.Cyan;
                    WriteLine("같은 숫자는 사용하지 않습니다. 턴을 넘깁니다.");
                    ForegroundColor = ConsoleColor.White;
                    continue;
                }

                //입력받은 값에 컴퓨터 값안에 포함되는 경우
                if (com1 == _hundNum || com2 == _hundNum || com3 == _hundNum)
                {
                    //위치 까지 같은 경우.
                    if (com1 == _hundNum)
                    {
                        _StrikeCount++;
                    }

                    //위치는 다른 경우.
                    else
                        _BallCount++;
                }
                if (com1 == _tenNum || com2 == _tenNum || com3 == _tenNum)
                {
                    //위치 까지 같은 경우.
                    if (com1 == _hundNum)
                    {
                        _StrikeCount++;
                    }

                    //위치는 다른 경우.
                    else
                        _BallCount++;
                }
                if (com1 == _oneNum || com2 == _oneNum || com3 == _oneNum)
                {
                    //위치 까지 같은 경우.
                    if (com1 == _hundNum)
                    {
                        _StrikeCount++;
                    }

                    //위치는 다른 경우.
                    else
                        _BallCount++;
                }

                //정답을 맞춘 경우.
                if (_StrikeCount == 3)
                {
                    WriteLine("와 정답입니다!!!! 축하드립니다!!!!!");
                    WriteLine($"지금까지 총 {count}번 시도하셨습니다");
                }
                else
                {
                    Write($"입력하신 값에선 {_StrikeCount}");
                    ForegroundColor = ConsoleColor.Blue;
                    Write("S ");
                    ForegroundColor = ConsoleColor.White;
                    Write($"{_BallCount}");
                    ForegroundColor = ConsoleColor.Yellow;
                    Write("B ");
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("입니다.");
                    Write("남은 시도 수는 ");
                    ForegroundColor = ConsoleColor.Magenta;
                    Write(9 - count);
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("번 입니다.");
                }
            }
            if (count == 1)
                money += 5000;
            else if (count >= 2 && count <= 4)
                money += 2000;
            else if (count > 4 && count <= 7)
                money += 500;
            else
                money -= 500;


            WriteLine("아무키나 누르면 메뉴로 돌아갑니다.");
            ReadKey();
            Clear();
        }
    }

    enum RockScissorsPaper
    {
        Rock = 0,
        Scissors, Paper
    }

    public static class RSP
    {
        public static void Initialize(ref int money)
        {
            Random r = new Random();


            int _computerRandomValue = r.Next(0, 2 + 1);
            int _yourHand;
            int _WhatKind = 0; //승리의 종류를 나타낼 변수. 0 은 비김. 1은 이김. 2는 짐.

            //1장 룰 설명
            WriteLine("");
            WriteLine("                  가 위 바 위 보 게 임");

            WriteLine("");
            WriteLine("");
            WriteLine("룰 : 컴퓨터가 임의로 가위, 바위, 보 중 하나를 냅니다!");
            WriteLine("     당신은 그 컴퓨터를 상대로 이기시면 됩니다!");
            WriteLine("승 : +2000. 무 : -500. 패 : -1000");

            WriteLine("");
            WriteLine("");
            WriteLine("준비 되셨으면 시작합니다! (enter key를 누르면 시작합니다)");

            ReadKey();
            Clear();

            //2장 입력을 받는 부분            
            WriteLine("");
            WriteLine("");
            WriteLine("        이제 당신의 차례입니다! 가위 바위 보중 하나를 입력해주세요!");
            WriteLine("");
            Write("            당신의 차례(바위 = 0, 가위 = 1, 보 = 2) : ");

            if (!int.TryParse(ReadLine(), out _yourHand))
            {
                WriteLine("");
                WriteLine("          엥? 이거 아니예요! 종료합니다.");
                ReadKey();
                return;
            }

            if (_yourHand > 2 || _yourHand < 0)
            {
                WriteLine("");
                WriteLine("          엥? 이거 아니예요! 종료합니다.");
                ReadKey();
                return;
            }

            WriteLine("");
            WriteLine("");

            WriteLine("        좋습니다! 이제 결과를 확인합니다...!!!");
            WriteLine("        (enter key를 누르면 시작합니다)");

            ReadKey();
            Clear();

            //3장 결과 출력.(연산)

            //기본으로 바위(0)으로 설정합니다.
            RockScissorsPaper _comHand = RockScissorsPaper.Rock;

            //기본(0)에서 컴퓨터 랜덤값 을 더해줍니다.
            //더하면 바위(0)에서 _computerRandomValue만큼 이동하면서 컴퓨터의 손이 바뀝니다.
            _comHand += _computerRandomValue;

            switch (_comHand)
            {
                case RockScissorsPaper.Rock:

                    switch ((RockScissorsPaper)_yourHand)
                    {
                        case RockScissorsPaper.Scissors: //가위
                            _WhatKind = 2;
                            break;
                        case RockScissorsPaper.Rock: //바위
                            _WhatKind = 0;
                            break;
                        case RockScissorsPaper.Paper: //보
                            _WhatKind = 1;
                            break;
                    }
                    break;
                case RockScissorsPaper.Scissors:

                    switch ((RockScissorsPaper)_yourHand)
                    {
                        case RockScissorsPaper.Scissors: //가위
                            _WhatKind = 0;
                            break;
                        case RockScissorsPaper.Rock: //바위
                            _WhatKind = 1;
                            break;
                        case RockScissorsPaper.Paper: //보
                            _WhatKind = 2;
                            break;
                    }
                    break;
                case RockScissorsPaper.Paper:

                    switch ((RockScissorsPaper)_yourHand)
                    {
                        case RockScissorsPaper.Scissors: //가위
                            _WhatKind = 1;
                            break;
                        case RockScissorsPaper.Rock: //바위
                            _WhatKind = 2;
                            break;
                        case RockScissorsPaper.Paper: //보
                            _WhatKind = 0;
                            break;
                    }
                    break;
            }
            //결과 표출
            WriteLine("");
            switch (_comHand)
            {
                case RockScissorsPaper.Paper:

                    WriteLine("    ㅁ ㅁ ㅁ   ");
                    WriteLine("    ㅁ ㅁ ㅁ ㅁ");
                    WriteLine("    ㅁ ㅁ ㅁ ㅁ");
                    WriteLine("  ㅁ ㅁㅁㅁㅁㅁ");
                    WriteLine("  ㅁ ㅁㅁㅁㅁㅁ");
                    WriteLine("   ㅁㅁㅁㅁㅁㅁ");
                    WriteLine("     ㅁㅁㅁㅁ  ");
                    WriteLine("     ㅁㅁㅁㅁ  ");
                    break;

                case RockScissorsPaper.Scissors:
                    WriteLine("    ㅁ   ㅁ    ");
                    WriteLine("    ㅁ  ㅁ");
                    WriteLine("    ㅁ ㅁ");
                    WriteLine("    ㅁㅁㅁㅁㅁ");
                    WriteLine("    ㅁㅁㅁㅁㅁ");
                    WriteLine("    ㅁㅁㅁㅁㅁ");
                    WriteLine("     ㅁㅁㅁㅁ  ");
                    WriteLine("     ㅁㅁㅁㅁ  ");
                    break;
                case RockScissorsPaper.Rock:
                    WriteLine("");
                    WriteLine("");
                    WriteLine("");
                    WriteLine("   ㅁㅁㅁㅁㅁ");
                    WriteLine("   ㅁㅁㅁㅁㅁ");
                    WriteLine("   ㅁㅁㅁㅁㅁ");
                    WriteLine("     ㅁㅁㅁㅁ  ");
                    WriteLine("     ㅁㅁㅁㅁ  ");
                    break;
            }

            switch ((RockScissorsPaper)_yourHand)
            {
                case RockScissorsPaper.Paper:
                    SetCursorPosition(40, 1);
                    WriteLine("    ㅁ ㅁ ㅁ   ");

                    SetCursorPosition(40, 2);
                    WriteLine("    ㅁ ㅁ ㅁ ㅁ");

                    SetCursorPosition(40, 3);
                    WriteLine("    ㅁ ㅁ ㅁ ㅁ");

                    SetCursorPosition(40, 4);
                    WriteLine("  ㅁ ㅁㅁㅁㅁㅁ");

                    SetCursorPosition(40, 5);
                    WriteLine("  ㅁ ㅁㅁㅁㅁㅁ");

                    SetCursorPosition(40, 6);
                    WriteLine("   ㅁㅁㅁㅁㅁㅁ");

                    SetCursorPosition(40, 7);
                    WriteLine("     ㅁㅁㅁㅁ  ");

                    SetCursorPosition(40, 8);
                    WriteLine("     ㅁㅁㅁㅁ  ");
                    break;
                case RockScissorsPaper.Scissors:


                    SetCursorPosition(40, 1);
                    WriteLine("    ㅁ   ㅁ    ");
                    SetCursorPosition(40, 2);
                    WriteLine("    ㅁ  ㅁ");
                    SetCursorPosition(40, 3);
                    WriteLine("    ㅁ ㅁ");
                    SetCursorPosition(40, 4);
                    WriteLine("    ㅁㅁㅁㅁㅁ");
                    SetCursorPosition(40, 5);
                    WriteLine("    ㅁㅁㅁㅁㅁ");
                    SetCursorPosition(40, 6);
                    WriteLine("    ㅁㅁㅁㅁㅁ");
                    SetCursorPosition(40, 7);
                    WriteLine("     ㅁㅁㅁㅁ  ");
                    SetCursorPosition(40, 8);
                    WriteLine("     ㅁㅁㅁㅁ  ");
                    break;
                case RockScissorsPaper.Rock:
                    SetCursorPosition(40, 1);
                    WriteLine("");
                    SetCursorPosition(40, 2);
                    WriteLine("");
                    SetCursorPosition(40, 3);
                    WriteLine("");
                    SetCursorPosition(40, 4);
                    WriteLine("   ㅁㅁㅁㅁㅁ");
                    SetCursorPosition(40, 5);
                    WriteLine("   ㅁㅁㅁㅁㅁ");
                    SetCursorPosition(40, 6);
                    WriteLine("   ㅁㅁㅁㅁㅁ");
                    SetCursorPosition(40, 7);
                    WriteLine("     ㅁㅁㅁㅁ  ");
                    SetCursorPosition(40, 8);
                    WriteLine("     ㅁㅁㅁㅁ  ");
                    break;
            }

            WriteLine("");
            WriteLine("");
            WriteLine($"컴퓨터는 {_comHand}를 냈고,          당신은 {(RockScissorsPaper)_yourHand}를 냈습니다.");
            WriteLine("");
            WriteLine("");
            switch (_WhatKind)
            {
                case 0: // 비겼을 경우

                    WriteLine("                       당신은 비겼습니다!");
                    money -= 500;
                    break;
                case 1: // 이겼을 경우

                    WriteLine("                       당신은 이겼습니다!");
                    money += 2000;
                    break;
                case 2: // 졌을 경우

                    WriteLine("                       당신은 졌습니다!");
                    money -= 1000;
                    break;
            }
            WriteLine();
            WriteLine("아무키나 누르면 메뉴로 돌아갑니다.");
            ReadKey();
            Clear();
        }
    }
    
    class Program
    {

        static void Main(string[] args)
        {
            CursorVisible = false;
            
            //첫 화면 입니다.
            do
            {
                _StartMenu.WaitMenu();
            } while (!_StartMenu._letFinish);

        }
    }
}
