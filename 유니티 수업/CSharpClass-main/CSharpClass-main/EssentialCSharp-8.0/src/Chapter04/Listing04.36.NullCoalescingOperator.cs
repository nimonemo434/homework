#pragma warning disable CS0168 // Variable is declared but never used
#pragma warning disable IDE0059 // Unnecessary assignment of a value

using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_36
{
    public class Program
    {
        public static void Main()
        {
            string? fullName = GetDefaultDirectory();
            // ...

            // Null-coalescing operator
            string fileName = GetFileName() ?? "config.json";
            string directory = GetConfigurationDirectory() ??
                GetApplicationDirectory() ??
                System.Environment.CurrentDirectory;

            // Null-coalescing assignment operator
            fullName ??= $"{ directory }/{ fileName }";

            // ...


        }

        private static string? GetDefaultDirectory()
        {
            throw new NotImplementedException();
        }

        private static string? GetApplicationDirectory()
        {
            throw new NotImplementedException();
        }

        private static string? GetConfigurationDirectory()
        {
            throw new NotImplementedException();
        }

        private static string? GetFileName()
        {
            throw new System.NotImplementedException();
        }
    }
}

//null 병합 연산자

//?? 는 해당 값이 null이면 다른 값을 사용한다는 표현
//식1 ?? 식2 일때 식1 이 null이면 식2 를 사용함.

//해당 내용을 줄이면 ??=