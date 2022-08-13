// Justificaiton: only partial implementation provided for elucidation.
#pragma warning disable IDE0060 // Remove unused parameter

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_03
{
    using Listing06_01;

    class Program
    {
        static void Main()
        {
            //new를 사용해서 개체를 인스턴스화 한다.
            Employee employee1 = new Employee();
            Employee employee2;
            employee2 = new Employee();

            IncreaseSalary(employee1);
            IncreaseSalary(employee2);
        }

        static void IncreaseSalary(Employee employee)
        {
            // ...
        }
    }
}

//인스턴스 - 빵 틀로 빵을 찍어냈다면, 객체(빵) 하나하나를 해당 클래스의 인스턴스라고 한다.
//new가 개체를 위한 메모리 할당과 개체의 초기화, 해당 인스턴스에 대한 참조 반환을 런타임에 지시한다.

//해당 클래스를 생성하고, 더이상 접근할수없거나, 필요가 없다고 느끼면 가비지 컬렉터가 이를 자동 할당해제 한다.

//할당되어 있는 데이터를 프로그램이 끝났는데도 가지고 있다면 이를 데이터 누수라고 부르며,
//이런식의 데이터 누수를 C#은 가비지 컬렉터가 자동으로 막는다.