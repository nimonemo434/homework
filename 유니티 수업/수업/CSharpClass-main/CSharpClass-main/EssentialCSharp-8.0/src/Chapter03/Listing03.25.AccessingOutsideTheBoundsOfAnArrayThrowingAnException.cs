namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_25
{
    public class Program
    {
        public static void Main()
        {
            string[] languages = new string[9];
            // ...
            //에러 발생
            //9번까지 정의했으나 배열은 0에서 시작함.
            languages[4] = languages[9];
        }
    }
}
