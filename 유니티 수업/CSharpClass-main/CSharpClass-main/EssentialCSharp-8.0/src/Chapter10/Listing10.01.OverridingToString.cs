namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_01
{
    public struct Coordinate
    {
        public Coordinate(Longitude longitude, Latitude latitude)
        {
            Longitude = longitude;
            Latitude = latitude;
        }

        public Longitude Longitude { get; }
        public Latitude Latitude { get; }


        public override string ToString()
        {
            return $"{ Longitude } { Latitude }";
        }

        // ...
    }

    public struct Longitude { }
    public struct Latitude { }
}

//10장 스킵

//정리

/*
 
using 이란
namespace 란

함수(메소드)와 변수(int string float)
int i1 = 3;
string s1 = "문장";
float f1 = 0.12f;
bool isCheck = true;

배열?

for,foreach, while, if

|| 와 && 의 차이

클래스

상속
public protected private
virtual 와 override
interface

 
 
 
 
 */
