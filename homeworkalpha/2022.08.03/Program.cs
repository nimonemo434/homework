using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace _2022._08._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random _rand = new Random();

            int[] lotto = new int[5];

            for (int num = 0; num < lotto.Length; num++)
            {
                lotto[num] = _rand.Next(1, 49);

                for(int num2 = 0; num2 < num; num2++)
                {
                    if (lotto[num] == lotto[num2])
                    {
                        num--;
                        break;
                    }
                }
            }

            int stringcount = 0;
            string[] userinput = new string[5];

            WriteLine("숫자 입력 : ");

            for(int i = 0; i < 5; i++)
            {
                Write($"{stringcount + 1}번째 숫자 : ");
                userinput[i] = ReadLine();
                stringcount++;
            }

            int wincount = 0;

            for (int one = 0; one < 5; one++)
            {
                for(int two = 0; two < 5; two++)
                {
                    if(lotto[one].ToString() == userinput[two])
                    {
                        wincount++;
                        break;
                    }
                }
            }
            switch(wincount)
            {
                case 0:
                    WriteLine("꼴등!");
                    break;
                case 1:
                    WriteLine("5등!");
                    break;
                case 2:
                    WriteLine("4등!");
                    break;
                case 3:
                    WriteLine("3등!");
                    break;
                case 4:
                    WriteLine("2등!");
                    break;
                case 5:
                    WriteLine("1등!");
                    break;
            }

            ReadKey();
        }
    }
}
