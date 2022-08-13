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

//����Ʈ�� ��ųʸ�, ť, ����

/*
****** ����Ʈ **
�迭���� ���̰�, ���� ����.
�迭�� ���� ū �������� �ڵ����� �ø���, ���������� ���� ���� �ִ�.

List<string> list = new List<string>
{"1", "2", "asdf", "hi"};

list[0] �̷� ������� ���� �����´�.

list.Add("he");
.Clear
.Find
.Insert
.Remove
.Count
.Sort

****** ��ųʸ� **
Ű�� ���� ���� �����´�.
key, value

Dictionary<string, string> dic = new Dcitionary<string,string>
{
    ["hi"] = "hello";
}
dic["hi"] �̷� ������� ���� �����´�.
dic["he"] = "wa" ; ���� ���� ���� �Ҵ��ϰų�, ������ �� �ִ�.
 
 
****** Stack **
 ���� ������Ű�� ���. LIFO (Last in First Out)

.Push�� ���� �ְ�
.Pop���� ���� ����(���� ���� ������)
 
 
****** Queue **
 ���� ������Ű�� ���. FIFO (First in First out)

.Enqueue�� ���� �ְ�
.Dequeue���� ���� ����(���� ���� ������)
 
 
 
 
 
 
 
 
 */