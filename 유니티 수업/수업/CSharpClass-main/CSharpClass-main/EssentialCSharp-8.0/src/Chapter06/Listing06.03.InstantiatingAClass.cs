// Justificaiton: only partial implementation provided for elucidation.
#pragma warning disable IDE0060 // Remove unused parameter

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_03
{
    using Listing06_01;

    class Program
    {
        static void Main()
        {
            //new�� ����ؼ� ��ü�� �ν��Ͻ�ȭ �Ѵ�.
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

//�ν��Ͻ� - �� Ʋ�� ���� ���´ٸ�, ��ü(��) �ϳ��ϳ��� �ش� Ŭ������ �ν��Ͻ���� �Ѵ�.
//new�� ��ü�� ���� �޸� �Ҵ�� ��ü�� �ʱ�ȭ, �ش� �ν��Ͻ��� ���� ���� ��ȯ�� ��Ÿ�ӿ� �����Ѵ�.

//�ش� Ŭ������ �����ϰ�, ���̻� �����Ҽ����ų�, �ʿ䰡 ���ٰ� ������ ������ �÷��Ͱ� �̸� �ڵ� �Ҵ����� �Ѵ�.

//�Ҵ�Ǿ� �ִ� �����͸� ���α׷��� �����µ��� ������ �ִٸ� �̸� ������ ������� �θ���,
//�̷����� ������ ������ C#�� ������ �÷��Ͱ� �ڵ����� ���´�.