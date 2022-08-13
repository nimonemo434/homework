namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_02
{
    using Listing07_01;

    public class Program
    {
        public static void Main()
        {
            Contact contact = new Contact();
            contact.Name = "Inigo Montoya";
            // ...
        }
    }
}

//부모 클래스의 변수를 사용한다.

//이후 전체스킵



//상속 직접 사용할 것. 음식으로 가지치기하자. 음식 - 한식,일식,중식,양싱 ... - 김치,김밥, .... 스파게티, .... 

//가상,   추상
//virtual, abstract, override, base 

/*
abstract - 클래스 가능
virtual - 클래스 불가능
 


ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
//Virtual 와 override 그리고 base 사용법

virtual 을 사용함으로써 다시 정의 할 수 있는 여지를 준다.
override라고 쓰고 재정의한다고 알려준다.

public class MonsterBaseSetting
{
    public virtual void Attack()
    {
        float attackDamage = 3.0f;
        Debug.log("Attack!");
    }

    public void StrongAttack()
    {
        Debug.log("Strong!");
    }
}

public class ZombieMonster : MonsterBaseSetting
{
    public override void Attack()
    {
        base.Attack();
        Debug.log("Plus Dot Damage");

        StrongAttack(); <- 부모의 함수 사용 가능(상속받았음으로)
    }
    
    //만약 StrongAttack()을 정의한다면..?
}


 

abstract는 함수의 내용을 정의할 수 없다.



//다중 상속 안됨. 하지만 인터페이스는 다중 상속이 가능함.
//인터페이스는 다음 장

 
 */