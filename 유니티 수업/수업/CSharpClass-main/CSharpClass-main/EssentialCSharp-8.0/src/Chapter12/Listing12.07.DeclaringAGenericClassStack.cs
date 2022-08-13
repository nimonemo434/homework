namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_07
{
    //���׸��� ���ڴٴ� �޼���. <T>��� ������.
    public class Stack<T>
    {
        //�迭�̱� �迭�ε� T�� ǥ���� �迭
        private T[] InternalItems;

        public Stack(int maxSize)
        {
            InternalItems = new T[maxSize];
        }

        public void Push(T data)
        {
            //...
        }

        public T Pop()
        {
            //...
            return InternalItems[0]; //just for the example
        }
    }
}

/*
 
���׸� ��� ����� T �̴�.
� ��Ҷ� �� �޾Ƶ帱�� �ִ�.

Stack�̶� Last in First out
�� �ʿ����
 
Stack<T> where T : class

���� ������� T�� Class�θ� �޾Ƶ��̴� ���������� ������.

Stack�� ���� ���׸� ����� ����غ��� (�Ȱ��� �����) ���� ��ŵ
 */