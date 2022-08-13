namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_05
{
    public class Program
    {
        public static void Main()
        {
            int n = '3' + '4';
            char c = (char)n;
            System.Console.WriteLine(c);  // Writes out g
        }
    }
}

//ppt 20 

/*
 '3' <- 51
 '4' <- 52

더하면 103
 
유니코드에서 103 은 g
 
 
 */