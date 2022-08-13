namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_01
{
    using System;
    using System.IO;
    using System.Net;

    static public class Program
    {
        public const string DefaultUrl = "https://IntelliTect.com";

        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("ERROR: No findText argument specified.");
                return;
            }
            string findText = args[0];

            string url = DefaultUrl;
            if (args.Length > 1)
            {
                url = args[1];
                // Ignore additional parameters
            }
            Console.Write($"Searching for '{findText}' at URL '{url}'.");

            Console.Write("\nDownloading....");
            using WebClient webClient = new WebClient();
            byte[] downloadData =
                webClient.DownloadData(url);

            Console.Write("\nSearching....");
            int textOccurrenceCount = CountOccurrences(
                downloadData, findText);

            Console.WriteLine(
                @$"{Environment.NewLine}'{findText}' appears {
                    textOccurrenceCount} times at URL '{url}'.");
        }

        private static int CountOccurrences(byte[] downloadData, string findText)
        {
            int textOccurrenceCount = 0;

            using MemoryStream stream = new MemoryStream(downloadData);
            using StreamReader reader = new StreamReader(stream);

            int findIndex = 0;
            int length = 0;
            do
            {
                char[] data = new char[reader.BaseStream.Length];
                length = reader.Read(data);
                for (int i = 0; i < length; i++)
                {
                    if (findText[findIndex] == data[i])
                    {
                        findIndex++;
                        if (findIndex == findText.Length)
                        {
                            // Text was found
                            textOccurrenceCount++;
                            findIndex = 0;
                        }
                    }
                    else
                    {
                        findIndex = 0;
                    }
                }
            }
            while (length != 0);

            return textOccurrenceCount;
        }
    }
}


//비동기 await 과 async

/*
 
async Task<int> aaa() 

이라고 쓰며
Task뒤에 붙은 int가 반환될 변수형이다.

aaa() 라고 쓰면 aaa도 진행되고 메인 쓰레드도 진행된다.
await aaa()라고 쓰면 aaa가 끝날때 까지 대기한다.


async가 붙어야만 await을 쓸 수 있다.
만약, aaa()안에 await이 들어있다면 메인 쓰레드는 안기다리고 계속 진행할 것이다.

예)

async Task aaa() { 1, 2, await 3, 4}

main()
{

aaa()
bbb()
ccc()

}

aaa가 호출되고, 1, 2 과 진행됨과 동시에 bbb, ccc도 진행되고, aaa는 3이 끝날때 까지 대기한다.

 

전부 스킵

 
 */