using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float f1, f2, plus, minus, remai, mult, divide; // float 값을 저장

            Console.Write("input float : "); // 입력받을 숫자
            f1 = float.Parse(Console.ReadLine()); //받은 숫자를 정수로 전환

            Console.Write("input float : "); // 입력받을 숫자
            f2 = float.Parse(Console.ReadLine()); //받은 숫자를 정수로 전환

            plus = f1 + f2;
            minus = f1 - f2;
            remai = f1 % f2;
            mult = f1 / f2;
            divide = f1 * f2;

            Console.WriteLine($"+ : {plus}");
            Console.WriteLine($"- : {minus}");
            Console.WriteLine($"% : {remai}");
            Console.WriteLine($"/ : {mult}");
            Console.WriteLine($"* : {divide}");

            Console.ReadKey();

        }
    }
}
