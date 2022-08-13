// Non-nullable field is uninitialized. Consider declaring as nullable.
#pragma warning disable CS8618

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_10
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

        // Caution:  Parameter names use PascalCase
        public void SetName(string FirstName, string LastName)
        {
            //필드에있는 FirstName과 매개변수의 이름이 값음. 모호함을 없애고자 this를 사용했음.
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
    }
}