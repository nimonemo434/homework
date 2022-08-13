// Non-nullable field is uninitialized. Consider declaring as nullable.
#pragma warning disable CS8618

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_07
{
    
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string? Salary;

        public string GetName()
        {
            return $"{ FirstName }  { LastName }";
        }
    }
}

//자신 필드에 선언된 변수들은 가져와서 사용할 수 있다(인스턴스가 없어도. 물론 누군가가 인스턴스를 만들어서 사용해야지 효력이 있음)