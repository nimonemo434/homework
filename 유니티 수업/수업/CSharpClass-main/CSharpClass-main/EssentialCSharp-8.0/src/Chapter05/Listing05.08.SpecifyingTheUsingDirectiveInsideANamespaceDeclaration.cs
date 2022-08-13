namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_08
{
    using System;

    public class HelloWorld
    {
        public static void Main()
        {
            // No need to qualify Console with System
            // because of the using directive above
            Console.WriteLine("Hello, my name is Inigo Montoya");
        }
    }
}
//using을 사용해서 지정한 네임스페이스의 모든 형식을 해당 전체 파일로 가져오기 한다.