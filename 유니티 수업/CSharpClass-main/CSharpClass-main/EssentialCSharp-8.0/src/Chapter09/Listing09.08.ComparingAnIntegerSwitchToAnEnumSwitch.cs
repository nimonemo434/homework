namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_08
{
    using Listing09_10;

    public class Program
    {
        public void SwitchInt()
        {
            int connectionState;
            // ...
            // initialize connectionState for example
            connectionState = 2;

            switch(connectionState)
            {
                case 0:
                    // ...
                    break;
                case 1:
                    // ...
                    break;
                case 2:
                    // ...
                    break;
                case 3:
                    // ...
                    break;
            }

        }

        public void SwitchEnum()
        {
            ConnectionState connectionState;
            // ...

            // initialize connectionState for example
            connectionState = ConnectionState.Connecting;

            switch(connectionState)
            {
                case ConnectionState.Connected:
                    // ...
                    break;
                case ConnectionState.Connecting:
                    // ...
                    break;
                case ConnectionState.Disconnected:
                    // ...
                    break;
                case ConnectionState.Disconnecting:
                    // ...
                    break;
            }
        }
    }
}

//enum (열겨형)
/*
 정말 비교를 위해 존재하는 형식
개발자가 보기 편하도록 다양한 값들을 문자처럼 사용해서 비교를 위해 사용됨.
 
 
 */
//