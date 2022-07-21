using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework0721
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a;

            Console.Write("문자를 입력해주세요: ");
            a = Console.ReadLine();

            int b = int.Parse(a);
            Console.WriteLine("입력하신 문자의 정수형 값은: " + b);

            float c = (float)b;
            Console.WriteLine("입력하신 문자의 실수형 값은: " + c);

            string d = c.ToString();
            Console.WriteLine("입력하신 문자는 " + d + "입니다.");

            Console.ReadKey();
        }
        }
    }
