namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_01
{
    // Use keyword struct to declare a value type 
    readonly public struct Angle
    {
        public Angle(int degrees, int minutes, int seconds)
        {
            Degrees = degrees;
            Minutes = minutes;
            Seconds = seconds;
        }
        // Using C# 6.0 read-only, automatically implemented properties
        public int Degrees { get; }
        public int Minutes { get; }
        public int Seconds { get; }

        public Angle Move(int degrees, int minutes, int seconds)
        {
            return new Angle(
                Degrees + degrees,
                Minutes + minutes,
                Seconds + seconds);
        }
    }

    // Declaring a class as a reference type
    // (declaring it as a struct would create a value type
    // larger than 16 bytes.)
    class Coordinate
    {
        public Angle Longitude { get; set; }
        public Angle Latitude { get; set; }
    }
}

//값 형식

//구조체 - 필요에 의해 만들어진 변수형

//Class와 크게 차이가 나는 것이 없다.
//거의 사용을 하지는 않지만 읽을수 있을 정도로만 알아 둘것.