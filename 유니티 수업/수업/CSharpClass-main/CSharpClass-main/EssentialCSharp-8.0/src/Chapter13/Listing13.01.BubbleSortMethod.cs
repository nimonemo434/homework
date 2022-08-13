namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_01
{
    static class SimpleSort1
    {
        public static void BubbleSort(int[] items)
        {
            int i;
            int j;
            int temp;

            if(items == null)
            {
                return;
            }

            for(i = items.Length - 1; i >= 0; i--)
            {
                for(j = 1; j <= i; j++)
                {
                    if(items[j - 1] > items[j])
                    {
                        temp = items[j - 1];
                        items[j - 1] = items[j];
                        items[j] = temp;
                    }
                }
            }
        }
        // ...
    }
}
//대리자(Delegate) 와 람다

/*
 
 대리자 : 일을 대신 해준다. 메소드를 참조하고 있는 역역.

사용법 - delegate 반환형 명(변수..);

예1)

namespace
{
    //선언
    delegate int PDelegate(int a, int b);

    class Program
    {
        //함수 선언
        static int Plus(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            //같은 매개변수를 갖기때문에 델리게이트에 함수를 담을 수 있다.
            PDelegate pd1 = Plus;
        
            
            Console.WriteLine(pd1(5, 10));
        }
    }
}
 



 
예2)

namespace
{
    //선언
    delegate int PDelegate(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            //담으려는 함수를 바로 선언해서 정의 할 수 있다.
            PDelegate pd2 = delegate(int a, int b)
            {
                return a / b;
            };

            Console.WriteLine(pd2(10, 5));
        }
    }
}
 

예3)

델리게이트는 멀티참조가 가능하다.

PDelegate pd3 = delegate(int a, int b) { ~~~ }
pd3 += delegate(int a, int b) { ~~~2}
pd3 += delegate(int a, int b) { ~~~3}
 
 
 
 ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

람다 : 무명함수의 다른말 (함수인데 이름이 없는 형태)

식 람다 - 바로 식으로 표현함 ( => 를 사용해서 바로 식 표현함)

예)
delegate int Cal(int a, int b);

static void main()
{
    //람다를 참조시킨다 
    Cal cal = (int a, int b) => a + b;

    cal(10,20);
}
 

 
문 람다 - 중괄호를 사용함

예)
delegate int Cal(int a, int b);

static void main()
{
    //람다를 참조시킨다.
    Cal cal = (int a, int b) => {
                                    return a + b;
                                }

    cal(10, 20);

}
 
 
 */

//이후 전체 스킵