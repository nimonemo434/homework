namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_06
{
    public class Program
    {
        public static void Main()
        {
            (string First, string Second, string Third) namedFruits = ("apple", "orange", "banana");

            var namedFruits2 = ("Apples", "oragne", "etc..");

            namedFruits.First = "Eat";
        }
    }
}

//튜플 형식
//값 형식을 튜플로 원하는 형식을 직접 다중 구현하는 방식.