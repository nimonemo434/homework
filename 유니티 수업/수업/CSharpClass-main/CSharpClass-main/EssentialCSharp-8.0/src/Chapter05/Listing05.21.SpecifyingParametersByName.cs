namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_21
{
    public class Program
    {
        public static void Main()
        {
            DisplayGreeting(
                firstName: "Inigo", lastName: "Montoya");
        }

        public static void DisplayGreeting(
            string firstName,
            string? middleName = null,
            string? lastName = null
            )
        {
            // ...
        }
    }
}

//이름으로 정하기

//메서드가 값을 지정할 수 있고, 지정되어 있다면 굳이 값을 넣지 않아도 된다.