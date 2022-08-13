namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_23
{
    using System;

    public class ExceptionHandling
    {
        public static int Main(string[] args)
        {
            string firstName;
            string ageText;
            int age;
            int result = 0;

            Console.Write("Enter your first name: ");
            firstName = Console.ReadLine();

            Console.Write("Enter your age: ");
            ageText = Console.ReadLine();

            try
            {
                age = int.Parse(ageText);
                Console.WriteLine(
                    $"Hi { firstName }! You are { age * 12 } months old.");
            }
            catch(FormatException)
            {
                Console.WriteLine(
                    $"The age entered, { ageText }, is not valid."); 
                result = 1;
            }
            catch(Exception exception)
            {
                Console.WriteLine(
                    $"Unexpected error:  { exception.Message }");
                result = 1;
            }
            finally
            {
                Console.WriteLine($"Goodbye { firstName }");
            }

            return result;
        }
    }
}

//Try Catch 오류 잡기
//에러 발생시 catch로 들어온다.
//Finally는 에러 발생 여부 상관없이 try로 보호된 영역을 벗어난 후 실행.