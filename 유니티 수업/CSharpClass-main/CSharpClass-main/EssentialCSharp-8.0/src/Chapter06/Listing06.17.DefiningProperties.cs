﻿// Non-nullable field is uninitialized. Consider declaring as nullable.
#pragma warning disable CS8618
// Disabled pending introductin to object initializers
#pragma warning disable IDE0017 

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_17
{
    public class Program
    {
        public static void Main()
        {
            Employee employee = new Employee();

            // Call the FirstName property's setter
            employee.FirstName = "Inigo";

            // Call the FirstName property's getter
            System.Console.WriteLine(employee.FirstName);
        }
    }

    class Employee
    {
        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                _FirstName = value;
            }
        }

        private string _FirstName;

    }
}


//프로퍼티

//이후 전체 스킵