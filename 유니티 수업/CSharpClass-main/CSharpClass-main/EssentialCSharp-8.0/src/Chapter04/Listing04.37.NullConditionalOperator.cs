namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_37
{
    public class Program
    {
        public static void Main(params string[] args)
        {

            string[]? segments = null;

            // Not shown in manuscript since args won't be null in a normal Main method.
            segments = args;

            string? uri = null;

            int? length = segments?.Length;
            if (length is { } && length != 0)
            {
                uri = string.Join('/', segments!);
            }

            // Null-conditional with array accessor
            // uri = segments?[0];
                

            if (uri is null || length is 0)
            {
                System.Console.WriteLine(
                    "There were no segments to combine.");
            }
            else
            {
                System.Console.WriteLine(
                    $"Uri: { uri }");
            }
        }
    }
}

// ?. 과 ?[]  <- 값이 null인지 체크하는 연산자 (null이면 null)
//null 조건 연산자

// int? kk = k3?.lenght 일때, kk의 값은 k3가 null일 경우 null이며, null이 아니면 k3.lenght 이다.