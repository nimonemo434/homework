// Justification: Demonstrating the equivalent operators
#pragma warning disable IDE0054 // Use compound assignment
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_13
{
    public class Program
    {
        public static void Main()
        {
            int spaceCount = 0;

            spaceCount = spaceCount + 1;
            spaceCount += 1;
            spaceCount++;
        }
    }
}

//증가 연산자

/*
 
 ++value 와 value++의 차이
 
 전위 증가 연산자와 후위 증가 연산자

write(++value)
write(++value)
write(++value)

write(value++)
write(value++)
write(value++)

 */
