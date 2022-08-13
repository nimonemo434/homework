using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace homeworkalpha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int count = 1;
            int[] thecomputernumbers = returnintarray(random);
            string s1 = "";

            Write("몇개의 숫자를 가지고 시작하시겠습니까? : ");
            s1 = ReadLine();
            int si = int.Parse(s1);

            WriteLine("게임 시작");

            while (true)
            {
                WriteLine($"라운드 : {count}");
                Write($"확인하고 싶은 숫자 {si}개 : ");
                string player = ReadLine();

                if (compareinputdata(player, thecomputernumbers))
                {
                    break;
                }
                else
                {
                    count++;
                }
            }
            WriteLine();
            Write($"수고하셨습니다 총 {count}라운드 플레이");

            ReadKey();
        }
        static int[] returnintarray(Random _rand)
        {
            int[] intarray = new int[3];

            for(int num = 0; num < intarray.Length; num++)
            {
                intarray[num] = _rand.Next(0, 9);

                for (int num2 = 0; num2 < num; num2++)
                {
                    if (intarray[num] == intarray[num2])
                    {
                        num--;
                        break;
                    }
                }
            }
            return intarray;
        }
        static bool isnumbersame(string _s1, string _s2)
        {
            if (_s1 == _s2)
            {
                return true;
            }
            return false;
        }

    static bool compareinputdata(string _player, int[] _thecompuernumber)
        {
            int strikecount = 0;
            int ballcount = 0;

            for (int one = 0; one < 3; one++)
            {
                for (int two = 0; two < 3; two++)
                {
                    if (isnumbersame(_player[one].ToString(), _thecompuernumber[two].ToString()))
                    {
                        if (one == two)
                        {
                            strikecount++;
                        }
                        else
                        {
                            ballcount++;
                        }
                    }
                }
            }
            return thisroundresult(strikecount, ballcount);
        }
        static bool thisroundresult(int _strikecount, int _ballcount)
        {
            Write("result : ");
            if (_strikecount == 3)
            {
                WriteLine("정답");
                return true;
            }

            else if (_strikecount == 0 && _ballcount == 0)
            {
                WriteLine("아웃");
            }

            else
            {
                WriteLine($"s = {_strikecount}개 , b = {_ballcount}개");
            }
            WriteLine();

            return false;
        }
    }
}
