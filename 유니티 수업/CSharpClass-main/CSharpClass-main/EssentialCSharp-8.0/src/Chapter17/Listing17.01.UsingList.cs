namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_01
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            List<string> list = new List<string>
            { "Sneezy", "Happy", "Dopey",  "Doc", "Sleepy", "Bashful",  "Grumpy"};

            list.Sort();

            Console.WriteLine(
                $"In alphabetical order { list[0] } is the "
                + $"first dwarf while { list[^1] } is the last.");

            list.Remove("Grumpy");

        }
    }
}

//리스트와 딕셔너리, 큐, 스택

/*
****** 리스트 **
배열보단 무겁고, 쓰기 쉽다.
배열과 가장 큰 차이점은 자동으로 늘리고, 임의적으로 줄일 수도 있다.

List<string> list = new List<string>
{"1", "2", "asdf", "hi"};

list[0] 이런 방식으로 값을 가져온다.

list.Add("he");
.Clear
.Find
.Insert
.Remove
.Count
.Sort

****** 딕셔너리 **
키를 통해 값을 가져온다.
key, value

Dictionary<string, string> dic = new Dcitionary<string,string>
{
    ["hi"] = "hello";
}
dic["hi"] 이런 방식으로 값을 가져온다.
dic["he"] = "wa" ; 같이 값은 새로 할당하거나, 수정할 수 있다.
 
 
****** Stack **
 값을 축적시키는 방식. LIFO (Last in First Out)

.Push로 값을 넣고
.Pop으로 값을 뺀다(빼면 값은 없어짐)
 
 
****** Queue **
 값을 축적시키는 방식. FIFO (First in First out)

.Enqueue로 값을 넣고
.Dequeue으로 값을 뺀다(빼면 값은 없어짐)
 
 
 
 
 
 
 
 
 */