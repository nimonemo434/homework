namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_45
{
    public class BinaryConverter
    {
        public static void Main()
        {
            const int size = 64;
            ulong value;
            char bit;

            System.Console.Write("Enter an integer: ");
            // Use long.Parse() to support negative numbers
            // Assumes unchecked assignment to ulong
            value = (ulong)long.Parse(System.Console.ReadLine());

            // Set initial mask to 100....
            ulong mask = 1UL << size - 1;
            for(int count = 0; count < size; count++)
            {
                bit = ((mask & value) > 0) ? '1' : '0';
                System.Console.Write(bit);
                // Shift mask one location over to the right
                mask >>= 1;
            }
        }
    }
}

//예시 바꿀것. for문 사용

/*
 
for(int i = 0 ; i < count ; i++)
{
}


for(초기 ; 조건 ; 루프)
 
 
 
 */