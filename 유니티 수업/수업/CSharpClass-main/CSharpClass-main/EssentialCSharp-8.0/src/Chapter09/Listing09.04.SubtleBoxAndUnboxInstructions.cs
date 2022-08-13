namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_04
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int totalCount;

            // Intentionally using ArrayList to demonstrate boxing
            System.Collections.ArrayList list =
                new System.Collections.ArrayList();

            Console.Write("Enter a number between 2 and 1000: ");
            totalCount = int.Parse(Console.ReadLine());

            if (totalCount == 7)  // Magic number used for testing
            {
                // Triggers exception when retrieving  value as double.
                list.Add(0);  // Cast to double or 'D' suffix required.
                              // Whether cast or using 'D' suffix,
                              // CIL is identical.

            }
            else
            {
                list.Add((double)0);
            }

            list.Add((double)1);
            
            for(int count = 2; count < totalCount; count++)
            {
                list.Add(
                    (double)list[count - 1]! +
                    (double)list[count - 2]!);
            }

            // Using a foreach to clarify the box operation rather than
            // Console.WriteLine(string.Join(", ", list.ToArray()));
            foreach (double? count in list)
            {
                Console.Write("{0}, ", count);
            }
        }
    }
}


//박싱과 언박싱

//값형식의 데이터를 참조형식의 데이터로 변환하는 방식

//int i = 3;
//object j = i; //박싱
//int k = (int)j; //언박싱

//보통 var kk = 3; 같은 방식을 많이 사용하고,
//배열은 object[] kk = new object[3]; 과 같은 방식의 참조형 데이터를 많이 사용한다.

//근데 거의 안씀