namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_17
{
    public class Uppercase
    {
        public static void Main()
        {
            string text;

            System.Console.Write("Enter text: ");
            text = System.Console.ReadLine();

            // UNEXPECTED: Does not convert text to uppercase
            text.ToUpper();

            string s1 = "hello";
            string s2 = "world";

            string s3 = s1 + s2; // helloworld

            System.Console.WriteLine(text);
        }
    }
}

//문자열 소개 - string


//대문자로 표현하기
//string 문자열 클래스에 다양한 활용법
//.compare 비교
//.format 초기화
//.concat 합치기
//.ToLower, ToUppder , Trim, Replace 등등...