using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Bulls_and_Cows
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int playCount = 1;  //라운드 수
            int[] theComputerNumbers = ReturnIntArray(random);  //컴퓨터가 가지고 있을 3가지 숫자.


            /////시작!!//////
            ///
            WriteLine("게임을 시작합니다!");


            while (true)
            {
                WriteLine($"라운드 : {playCount}");
                Write("확인하고 싶은 숫자 3개를 써주세요(띄어쓰기 없음, 안적기 없음) : ");
                string playerInput = ReadLine();

                //데이터 비교
                if(CompareInputDate(playerInput, theComputerNumbers))
                {
                    //정답인 경우 while 탈출
                    break;
                }
                else
                {
                    //아닌경우 증가
                    playCount++;
                }

            }
            WriteLine();
            Write($"고생하셨습니다! 총 플레이 {playCount}라운드 하셨습니다");


            ReadKey();
        }

        //할당받는 메서드
        static int[] ReturnIntArray(Random _rand)
        {
            int[] intArray = new int[3];

            //3가지 숫자 할당 받기
            for (int num = 0; num < intArray.Length; num++)
            {
                intArray[num] = _rand.Next(0, 9);

                //중복된 숫자가 있는지 체크한다(예, 0 3 3    <- 이때 3이 하나 더 나와서 다시 받아야 함
                for (int num2 = 0; num2 < num; num2++)
                {
                    //중복된 경우 숫자를 다시 받는다.
                    if (intArray[num] == intArray[num2])
                    {
                        //for문을 다시 하기위해 18번째 줄 에서 증가중이던 num을 하나 줄이고 다시 for문을 돌림.
                        num--;
                        break;
                    }
                }
            }
            return intArray;
        }

        //비교하는 메서드
        static bool isNumberSame(string _s1, string _s2)
        {
            //숫자가 같으면 true
            if(_s1 == _s2)
            {
                return true;
            }
            //다르면 false
            return false;
        }

        //유저가 입력한 결과를 비교하는 메서드
        static bool CompareInputDate(string _playerInput, int[] _theComputerNumbers)
        {
            int strikeCount = 0;
            int ballCount = 0;

            //유저가 적은 숫자들
            for (int one = 0; one < 3; one++)
            {
                //컴퓨터가 가지고 있는 숫자들 순서
                for (int two = 0; two < 3; two++)
                {
                    //입력한 string의 일부분(char) 과 컴퓨터가 가지고 있는 숫자 일부분(int)를 비교한다
                    if (isNumberSame(_playerInput[one].ToString(), _theComputerNumbers[two].ToString()))
                    {
                        //위치까지 같으면 S를 반환
                        if (one == two)
                        {
                            strikeCount++;
                        }
                        //아니면 B를 반환
                        else
                        {
                            ballCount++;
                        }
                    }

                    //일치하지 않으면 넘김
                }
            }

            return ThisRoundResult(strikeCount, ballCount);
        }

        //결과를 확인하는 메서드
        static bool ThisRoundResult(int _strikeCount, int _ballCount)
        {
            Write("result : ");
            //스트라이크 3개는 정답!
            if (_strikeCount == 3)
            {
                WriteLine("정답입니다!");
                //정답! true 반환
                return true;
            }

            else if (_strikeCount == 0 && _ballCount == 0)
            {
                WriteLine("아웃입니다!");
            }

            else
            {
                WriteLine($"S = {_strikeCount}개 , B = {_ballCount}개");
            }
            WriteLine();

            //정답아님. false반환
            return false;
        }
    }
}
