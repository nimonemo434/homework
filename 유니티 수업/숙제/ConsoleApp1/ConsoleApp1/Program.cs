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
            Random random = new Random();
            int[] arr = new int[5];
            int count1 = 0;
            int count2 = 0;
            string[] input = new string[5];

            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = random.Next(1, 49);

                for (int j = 0; j < i; ++j)
                {
                    if (arr[i] == arr[j])
                    {
                        i--;
                        break;
                    }
                }
            }
            WriteLine("숫자 입력");

            for (int i = 0; i <5; ++i)
            {
                Write((count1 + 1) + "번째 숫자 : ");
                input[i] = ReadLine();
                count1++;
            }

            for (int i = 0; i < 5; ++i)
            {
                for (int j =0; j < 5; ++j)
                {
                    if (arr[i].ToString() == input[j])
                    {
                        count2++;
                        break;
                    }
                }
            }
            switch (count2)
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
