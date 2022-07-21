using System;

namespace homework_kimdongrok
{
    public class HelloWorld
    {
        public static void Main()
        {
            // 1
            {
                Console.Write("Hello world");
                Console.ReadLine();
            }

            // 2
            {
                string s1;
                string s2;
                string s3;

                Console.Write("input s1 : ");
                s1 = Console.ReadLine();
                System.Console.Write("input s2 : ");
                s2 = Console.ReadLine();

                Console.WriteLine($"the string is \n{s1}, {s2}");
                Console.WriteLine("the string is \n{0}, {1}", s1, s2);
                Console.WriteLine("the string is \n{1}, {0}", s1, s2);
                Console.WriteLine("the string is" + "\n" + "{0}" + ", " + "{1}", s1, s2);
                Console.ReadKey();
            }
        }
    }
}
