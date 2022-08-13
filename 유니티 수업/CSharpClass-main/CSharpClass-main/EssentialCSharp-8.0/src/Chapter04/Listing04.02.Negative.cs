namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_02
{
    public class Program
    {
        public static void Main()
        {
            //decimal 고정소수점 -  연산 속도가 빠르고 수의 정확성이 높은데신 큰수를 저장할때 메모리를 많이 잡아먹게 된다 (16byte)
            decimal debt = -26457079712930.80M;

            System.Console.WriteLine(debt);
        }
    }
}