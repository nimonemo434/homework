namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_01
{
    public class LineCount
    {
        public static void Main()
        {
            int lineCount;
            string files;

            DisplayHelpText();
            files = GetFiles();
            lineCount = CountLines(files);  // files 같은 값은 인수
            DisplayLineCount(lineCount);
        }

        private static void DisplayLineCount(int lineCount) // lineCount는 매개변수
        {
            throw new System.NotImplementedException();
        }

        private static int CountLines(string files)
        {
            throw new System.NotImplementedException();
        }

        private static string GetFiles()
        {
            throw new System.NotImplementedException();
        }

        private static void DisplayHelpText()
        {
            throw new System.NotImplementedException();
        }

        // ...
    }
}
//메서드 소개

//매개변수에 제공되는 인수를 통해 데이터를 받는다. 

//네임스페이스 - 특정 기능 영역에 관련된 모든 형식을 그룹으로 만든 메커니즘이다. (여러 스크립트로 나눠서 표현하는 방식으로 큰 틀 방식)