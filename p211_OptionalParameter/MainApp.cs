using System;

namespace p211_OptionalParameter
{
    class MainApp
    {
        // 6.9 명명된 인수
        // 잘 안쓰임 가능함정도

        // 6.10 선택적 인수
        // 메소드의 매개변수는 기본값을 가질 수 있음 변수 초기화하듯 메소드 선언 가능
        // 기본값을 가진 매개변수는 메소드를 호출할 때 인수를 생략할 수 있음
        // 기본값을 가진 매개변수는 필요에 따라 인수를 할당하거나 안할 수 있기 때문에 선택적 인수

        static void PrintProfile(string name, string phone = "")
        {
            Console.WriteLine($"Name:{name}, Phone:{phone}");
        }
        static void Main(string[] args)
        {
            PrintProfile("중근");
            PrintProfile("관순", "010-123-1234");
            PrintProfile(name: "봉길");
            PrintProfile(name: "동주", phone: "010-789-7890");
        }
    }
}
