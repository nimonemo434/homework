namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_14
{
    public class Program
    {
        public static void Main()
        {
            string[] groceryList;
            System.Console.Write("How many items on the list? ");
            int size = int.Parse(System.Console.ReadLine());
            groceryList = new string[size];
            // ...
        }
    }
}

//배열의 크기를 초기화하는 것은 뒤에 해도 가능하다.