namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_07
{
    //제네릭을 쓰겠다는 메세지. <T>라고 적었다.
    public class Stack<T>
    {
        //배열이긴 배열인데 T로 표현한 배열
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
 
제네릭 사용 방식은 T 이다.
어떤 요소라도 다 받아드릴수 있다.

Stack이란 Last in First out
알 필요없음
 
Stack<T> where T : class

같은 방식으로 T를 Class로만 받아들이는 제약조건이 존재함.

Stack을 예로 제네릭 만들고 사용해보기 (똑같이 만들기) 이후 스킵
 */