namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_03
{
    public class Division
    {
        public static void Main()
        {
            int numerator;
            int denominator;
            int quotient;
            int remainder;

            System.Console.Write("Enter the numerator: ");
            numerator = int.Parse(System.Console.ReadLine());

            System.Console.Write("Enter the denominator: ");
            denominator = int.Parse(System.Console.ReadLine());

            quotient = numerator / denominator;
            remainder = numerator % denominator;

            System.Console.WriteLine(
                $"{numerator} / {denominator} = {quotient} with remainder {remainder}");
        }
    }
}

/*
 산술 이항 연술자
 
 + - * / %

* 곱하기
/ 나누기 (결과 값 몫)
% 나누기 (결과 값 나머지)

컴퓨터 계산 방식 - 사칙연산의 순서를 갖는다.
 
 */