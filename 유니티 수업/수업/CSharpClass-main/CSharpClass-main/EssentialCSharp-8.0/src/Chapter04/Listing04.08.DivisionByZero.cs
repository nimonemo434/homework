namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_08
{
    public class Program
    {
        public static void Main()
        {
            float n = 0f;
            // Displays: NaN 
            System.Console.WriteLine(n / 0);
        }
    }
}

// 0으로 나눈다는 정의는 없음.