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

//Ʃ�� ����
//�� ������ Ʃ�÷� ���ϴ� ������ ���� ���� �����ϴ� ���.