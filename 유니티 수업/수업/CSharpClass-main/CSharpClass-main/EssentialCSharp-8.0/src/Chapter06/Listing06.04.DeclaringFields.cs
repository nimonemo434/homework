// Non-nullable field is uninitialized. Consider declaring as nullable.
#pragma warning disable CS8618

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_04
{

    public class Employee
    {
        //인스턴스 변수 - 인스턴스를 생성해야만 접근 할 수 있는 변수들
        public string FirstName;
        public string LastName;
        public string? Salary;
    }
}

//멤버 변수 - 클래스내에서 데이터를 저장하는 변수
//지역변수 - 메소드나 생성자 내부에 있는 변수