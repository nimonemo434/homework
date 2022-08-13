namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_01
{
    interface IFileCompression
    {
        void Compress(string targetFileName, string[] fileList);
        void Uncompress(
            string compressedFileName, string expandDirectoryName);
    }
}

//인터페이스 설명 - 클래스와 비슷하지만, 직접 구현하지않고 정의 만 한다.

//abstract와 Interface의 차이는 정말 많지만 그중 가장 큰 차이점은
//Interface는 다중 상속이 가능하다는 것.
//Interface는 인스턴스 필드가 포함될 수 없다는 것.
//사용 할 것이다라는 것만 가능하다.

//abstract이 좀더 확장하는 느낌.

//예시 - 게임 - (여기서부터 인터페이스) 몬스터, 재화, 무기, 캐릭터 - 이후 확장

//이후 모두 스킵