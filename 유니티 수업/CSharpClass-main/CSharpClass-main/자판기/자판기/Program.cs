using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 자판기
{
    
    class Program
    {
        struct Drink
        {
            public string name;
            public int pay;
            public string design;
            public int count; //개수
            public Drink(string _name, int _pay, string _des, int _count)
            {
                this.name = _name;
                this.pay = _pay;
                this.design = _des;
                this.count = _count;
            }
            public void MinusDrinkCount()
            {
                this.count--;
            }
        }
        
        //음료 구매시 선택 틀 함수 입니다.
        static void SelectForm(int x, int y,int ox, int oy, bool _isMove)
        {
            SetCursorPosition(9 + (x * 15), 9 + (y * 7));
            Write("▲");
            if (!_isMove)
            {
                SetCursorPosition(9 + (ox * 15), 9 + (oy * 7));
                Write(" ");
            }

        }

        //선택 음료를 찾는 함수.
        static void WhatKindDrink(ref List<Drink> _list, ref List<Drink> _buy, int posX, int posY)
        {
            int sum = 0;
            int count = 0;
            do
            {
                sum += _list[count].count;
                count++;

            } while (sum < ((posX + 1) + (posY * 5)));
            //함수를 나올때의 count는 선택한 종류의 음료 입니다.

            _buy.Add(_list[count - 1]);

            string name = _list[count - 1].name;
            int pay = _list[count - 1].pay;
            string design = _list[count - 1].design;
            int _count = _list[count - 1].count - 1;


            _list.RemoveAt(count - 1);

            //개수가 0개 일때.
            if (_count == 0)
            {
                //제거
            }

            //개수를 줄인다.
            else
            {
                Drink _new = new Drink(name, pay, design, _count);
                _list.Insert(count - 1, _new);
            }
        }

        //첫 자판기 모양
        static void StartJa()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            WriteLine("           ■■■■■■■■■■■■■■");
            WriteLine("           ■                        ■");
            WriteLine("           ■  자        판       기 ■");
            WriteLine("           ■                        ■");
            WriteLine("           ■■■■■■■■■■■■■■");

            Console.ForegroundColor = ConsoleColor.White;
        }
        
        //첫 화면 입니다.
        static void WaitMenu(ref int posY)
        {
            bool _letOut = false;

            SetCursorPosition(15, 8);
            WriteLine("물품 구입");
            SetCursorPosition(15, 9);
            WriteLine("재고 현황");
            SetCursorPosition(15, 10);
            WriteLine("물품 종류 구입");
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

            SetCursorPosition(0, 0);
        }

        //물품 구매 장바구니
        static void JangBa(ref List<Drink> _buy)
        {
            int pay = 0;
            SetCursorPosition(90, 7);
            Write("ㅡㅡ장바구니 목록ㅡㅡ");

            for(int t = 0; t<_buy.Count(); t++)
            {
                SetCursorPosition(90, 9 + t);
                Write($"{_buy[t].name}");

                pay += _buy[t].pay;
            }

            SetCursorPosition(90, 11 + _buy.Count());
            Write($"총 개수 : {_buy.Count()}, 총 가격 : {pay}");

            SetCursorPosition(90, 10 + _buy.Count());
            Write("                                  ");

            SetCursorPosition(0, 0);
        }

        //물품 구입
        static void BuySomething(ref List<Drink> _drinkList)
        {
            int count = 0; // 줄바꿈에 필요한 변수입니다.
            int posX = 0, posY = 0;
            bool _isFinish = false;
            List<Drink> _buySome = new List<Drink>();

            WriteLine("  구매 목록 선택후 enter를 누르면 구매목록으로.");
            WriteLine("  esc를 누르면 종료됩니다.");

            //리스트 개수 만큼 진행
            for (int i = 0; i < _drinkList.Count(); i++) {

                //재품의 개수 만큼 반복
                for(int j = 0; j<_drinkList[i].count; j++)
                {
                    //5개가 나오면 줄바꿈.
                    if (count == 5)
                    {
                        posY++;
                        posX = 0;
                        count = 0;
                    }

                    SetCursorPosition(5 + (posX * 15), 4 + (posY * 7));
                    WriteLine($"  {_drinkList[i].design}{_drinkList[i].design}");
                    SetCursorPosition(5 + (posX * 15), 5 + (posY * 7));
                    WriteLine($"  {_drinkList[i].design}{_drinkList[i].design}");
                    SetCursorPosition(5 + (posX * 15), 7 + (posY * 7));
                    WriteLine($"이름 : {_drinkList[i].name}");
                    SetCursorPosition(5 + (posX * 15), 8 + (posY * 7));
                    WriteLine($"가격 : {_drinkList[i].pay}");

                    count++;
                    posX++;
                }
            }

            //다시 사용하기 위해 초기화.
            int Allcount = posY;
            posX = 0;
            posY = 0;
            count = 0;
            bool _isMove = false; //움직엿는지 확인하는 변수

            do
            {
                //구매 목록 장바구니
                JangBa(ref _buySome);

                int OldposX = posX + 1;
                int OldposY = posY + 1;
                bool _isSelected = false;

                do
                {
                    SelectForm(posX, posY, OldposX, OldposY,_isMove);


                    OldposX = posX;
                    OldposY = posY;
                    _isMove = false;    

                    //선택을 입력 받습니다.
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            posY--;
                            if (posY < 0)
                            {
                                posY = 0;
                                _isMove = true;
                            }
                            break;

                        case ConsoleKey.DownArrow:
                            posY++;
                            if (posY > Allcount)
                            {
                                posY = Allcount;
                                _isMove = true;
                            }
                            break;

                        case ConsoleKey.LeftArrow:
                            posX--;
                            if (posX < 0)
                            {
                                posX = 0;
                                _isMove = true;
                            }
                            break;

                        case ConsoleKey.RightArrow:
                            posX++;
                            if (posX > 4)
                            {
                                posX = 4;
                                _isMove = true;
                            }
                            break;

                        case ConsoleKey.Enter:
                            _isSelected = true;
                            //엔터누른 값을 찾는 함수.

                            Clear();

                            WhatKindDrink(ref _drinkList, ref _buySome, posX, posY);

                            count = 0; // 줄바꿈에 필요한 변수입니다.
                            int tposX = 0;
                            int tposY = 0;
                             _isFinish = false;

                            SetCursorPosition(0, 0);
                            WriteLine("  구매 목록 선택후 enter를 누르면 구매목록으로.");
                            WriteLine("  esc를 누르면 종료됩니다.");

                            //리스트 개수 만큼 진행
                            for (int i = 0; i < _drinkList.Count(); i++)
                            {

                                //재품의 개수 만큼 반복
                                for (int j = 0; j < _drinkList[i].count; j++)
                                {
                                    //5개가 나오면 줄바꿈.
                                    if (count == 5)
                                    {
                                        tposY++;
                                        tposX = 0;
                                        count = 0;
                                    }

                                    SetCursorPosition(5 + (tposX * 15), 4 + (tposY * 7));
                                    WriteLine($"  {_drinkList[i].design}{_drinkList[i].design}");
                                    SetCursorPosition(5 + (tposX * 15), 5 + (tposY * 7));
                                    WriteLine($"  {_drinkList[i].design}{_drinkList[i].design}");
                                    SetCursorPosition(5 + (tposX * 15), 7 + (tposY * 7));
                                    WriteLine($"이름 : {_drinkList[i].name}");
                                    SetCursorPosition(5 + (tposX * 15), 8 + (tposY * 7));
                                    WriteLine($"가격 : {_drinkList[i].pay}");

                                    count++;
                                    tposX++;
                                }
                            }
                            break;

                        case ConsoleKey.Escape:
                            _isSelected = true;
                            _isFinish = true;
                            Clear();
                            break;
                    }

                } while (!_isSelected);
                
            } while (!_isFinish);
            
        }

        //재고 현황
        static void WhatweGot(ref List<Drink> _drinkList)
        {
            WriteLine();
            WriteLine("                   현재 재고 현황입니다.");
            WriteLine("                   아무 키 입력시 메뉴화면");

            SetCursorPosition(0, 5);

            for (int i = 0; i < _drinkList.Count(); i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.ForegroundColor = ConsoleColor.White;
                WriteLine($"이름 : {_drinkList[i].name}, 가격 : {_drinkList[i].pay}, 모양 : {_drinkList[i].design}, 재고 : {_drinkList[i].count}개");
            }
            ReadKey();
            Clear();
        }

        //물품 종류 구입
        static void BuyAnotherKind(ref List<Drink> _drinkList)
        {
            string name;
            int pay;
            string design;
            int count; //개수
            bool _isRight = false;

            WriteLine();
            WriteLine("                   새로운 물품을 선정해주세요.");


            SetCursorPosition(0, 5);
            Console.ForegroundColor = ConsoleColor.Blue;
            WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            Console.ForegroundColor = ConsoleColor.White;
            Write("이름 입력 : ");
            name = ReadLine();

            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.ForegroundColor = ConsoleColor.White;
                Write("가격 입력 : ");
                if (!int.TryParse(ReadLine(), out pay))
                {
                    Write("다시 입력하세요");
                    _isRight = true;
                }
                _isRight = false;
            } while (_isRight);
            
            
            Console.ForegroundColor = ConsoleColor.Blue;
            WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            Console.ForegroundColor = ConsoleColor.White;
            Write("모양 입력 : ");
            design = ReadLine();

            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.ForegroundColor = ConsoleColor.White;
                Write("개수 입력 : ");
                if (!int.TryParse(ReadLine(), out count))
                {
                    Write("다시 입력하세요");
                    _isRight = true;
                }
                _isRight = false;
            } while (_isRight);
            WriteLine();
            Write("입력이 완료 되었습니다.");
            Write("아무 키나 누르면 메뉴로 돌아갑니다.");
            
            Drink _newThing = new Drink(name,pay,design,count);
            _drinkList.Add(_newThing);

            ReadKey();
            Clear();
        }

        static void Main(string[] args)
        {
            CursorVisible = false;

            List<Drink> _drinkList = new List<Drink>();

            Drink _a = new Drink("콜라", 900, "☎" , 4);
            Drink _b = new Drink("사이다", 800, "★" , 3);
            Drink _c = new Drink("환타", 1200, "♨" , 2);
            Drink _d = new Drink("주스", 2500, "♣" , 5);

            _drinkList.Add(_a);
            _drinkList.Add(_b);
            _drinkList.Add(_c);
            _drinkList.Add(_d);

            bool _isFinish = false;
            bool _isStart = false;
            int posY = 0;

            do
            {
                if (_isStart) //시작(enter)키를 누른 경우
                {
                    switch (posY)
                    {
                        case 0: //물품 구입

                            BuySomething(ref _drinkList);
                            //대기화면으로 전환
                            _isStart = false;
                            break;

                        case 1: //재고 현황

                            WhatweGot(ref _drinkList);
                            //대기화면으로 전환
                            _isStart = false; 
                            break;
                        case 2: //물품 종류 구입

                            BuyAnotherKind(ref _drinkList);
                            //대기화면으로 전환
                            _isStart = false;
                            break;
                        case 3: //종료
                            _isFinish = true;
                            break;
                    }
                }
                else //대기화면인 경우
                {
                    StartJa();
                    WaitMenu(ref posY);
                    _isStart = true;
                    Clear();
                }

            } while (!_isFinish);
            
        }
    }
}
