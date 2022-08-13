namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_01
{
    class Cooler
    {
        public Cooler(float temperature)
        {
            Temperature = temperature;
        }

        // Cooler is activated when ambient temperature is higher than this
        public float Temperature { get; set; }

        // Notifies that the temperature changed on this instance
        public void OnTemperatureChanged(float newTemperature)
        {
            if(newTemperature > Temperature)
            {
                System.Console.WriteLine("Cooler: On");
            }
            else
            {
                System.Console.WriteLine("Cooler: Off");
            }
        }
    }

    class Heater
    {
        public Heater(float temperature)
        {
            Temperature = temperature;
        }

        // Cooler is activated when ambient temperature is higher than this
        public float Temperature { get; set; }

        // Notifies that the temperature changed on this instance
        public void OnTemperatureChanged(float newTemperature)
        {
            if(newTemperature < Temperature)
            {
                System.Console.WriteLine("Heater: On");
            }
            else
            {
                System.Console.WriteLine("Heater: Off");
            }
        }
    }
}


/*
 
이벤트 사용법 <- 거의 안씀

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0일때_이벤트_발생
{
    //1. 이벤트를 발생시키기 위한 이벤트 핸들러 델리게이트 선언
    public delegate void MyEventHandler(string message);

    //게시자 클래스 선언
    public class Publisher
    {
        //2. 이벤트 선언 (참고로 이벤트 선언은 값을 전달하는 쪽에서 선언)
        public event MyEventHandler MyEvent;

        public void Do(int number)
        {
            //이벤트 게시자가 있는지 유무 체크
            if (MyEvent != null)
            {
                if (number % 10 == 0)
                {
                    MyEvent("Active" + number); //이벤트 발생
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
        }
    }

 

    //구독자 클래스 선언
    public class Subscriber
    {
        static void Main(string[] args)
        {
            Publisher p = new Publisher();
            p.MyEvent += new MyEventHandler(doAction);


            for (int i = 0; i < 50; i++)
            {
                p.Do(i);
            }
        }

        static public void doAction(string message)
        {
            Console.WriteLine(message);
        }
    }
}





액션 사용법 <- 굉장히 많이 씀

예)
public class ClassA
{
  public event Action<string> OnAdd;

  private void SomethingHappened()
  {
    OnAdd?.Invoke("It Happened");
  }
}

public class ClassB
{

  public ClassB()
  {
    var myClass = new ClassA();
    myClass.OnAdd += Add;
    myClass.OnAdd += Add;
    myClass.OnAdd += Add;
    myClass.OnAdd += Add;
  }

  private void Add(string Input)
  {
    //do something
  }  
}



옵저버 패턴

가장 큰 예시 )

플레이어가 죽었다!
그렇게 된다면
1. 화면 어두워짐
2. 점수 계산
3. 남아있는 몬스터 모두 정지
4. 보상 정리
.... 등등등


이 모든걸 한 메소드에 담기엔 너무 힘들다.
따라서, 해당 액션에 담는다!

잘못된 예)
void Death()
{
    화면어둡게();
    점수계산();
    몬스터정지();
    보상정리();
    .....
}

올바른 예)
public event Action<bool> death

해당 액션이 있는 클래스를 가져와서
화면어둡,점수계산 등 각자 본인이 가지고 있는 함수를
클래스.death += 형태로 포함시킨다.

그리고, 플레이어가 죽으면
death?.invoke() 를 진행한다







 
 
 */

// 이후 모두 스킵