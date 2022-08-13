namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_06
{
    using Listing06_05;
    using System;

    public class Program
    {
        public static void Main()
        {
            Employee employee1 = new Employee();
            Employee employee2;
            employee2 = new Employee();

            employee1.FirstName = "Inigo";
            employee1.LastName = "Montoya";
            employee1.Salary = "Too Little";
            IncreaseSalary(employee1);
            Console.WriteLine(
                "{0} {1}: {2}",
                employee1.FirstName,
                employee1.LastName,
                employee1.Salary);
        }

        static void IncreaseSalary(Employee employee)
        {
            //인스턴스 변수에 접근함
            employee.Salary = "Enough to survive on";
        }
    }
}


//10번 줄과 11번,12번 줄은 결국 Employee라는 클래스를 사용해서 다른 인스턴스를 생성했다.