namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_03
{
    using System;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            const int repetitions = 10000;
            // Use Task.Factory.StartNew<string>() for
            // TPL prior to .NET 4.5
            Task task = Task.Run(() =>
                {
                    for(int count = 0; count < repetitions; count++)
                    {
                        Console.Write('-');
                    }
                });
            for(int count = 0; count < repetitions; count++)
            {
                Console.Write('+');
            }

            // Wait until the Task completes
            task.Wait();
        }
    }
}

//스레드 - 병렬 일처리

/*
Task <- 용어(하나의 일 처리)

Task.Run // 작동하기
태스크 변수.Wait() 해당 스레드가 끝날때 까지 기다리기
태스크 변수.isCompleted 끝났는지 bool로 반환

유니티용 스레드가 또 있음 

이후 전체 스킵
 */