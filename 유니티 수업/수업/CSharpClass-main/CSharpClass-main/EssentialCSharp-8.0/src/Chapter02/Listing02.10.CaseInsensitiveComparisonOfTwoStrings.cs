namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_10
{
    public class Program
    {
        public static void Main()
        {
            string option = "help";

            int comparison = string.Compare(option, "/Help", true);

            System.Console.WriteLine($"{comparison}");
        }
    }
}

//스킵 (string 비교 - true false 로 반환)