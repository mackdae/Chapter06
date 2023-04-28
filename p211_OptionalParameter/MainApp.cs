using System;

namespace p211_OptionalParameter
{
    class MainApp
    {
        // 6.9 명명된 인수
        // 잘 안쓰임 가능함정도
        // 메소드를 호출하면 순서에 따라 매개변수에 인수를 할당하지만
        // 인수의 이름에 근거하여 데이터를 할당 가능

        // 6.10 선택적 인수
        // 메소드의 매개변수는 기본값을 가질 수 있음
        // 매개변수를 초기화하듯 메소드 선언
        // 기본값을 가진 매개변수는 메소드를 호출할 때 인수 생략 가능
        // 필요에 따라 인수를 할당하거나 안할 수 있기 때문에 선택적 인수 Optional Argument
        // 인수를 염두에 두지 않아도 되도록 편의를 제공하지만 모호함 증가
        // 메소드 오버로딩과 함께 사용되면 혼란을 야기할 수도

        static void PrintProfile(string name, string phone = "")
        {
            Console.WriteLine($"Name:{name}, Phone:{phone}");
        }
        static void Main(string[] args)
        {
            PrintProfile("중근");
            PrintProfile("관순", "010-123-1234");
            PrintProfile(name: "봉길");
            PrintProfile(phone: "010-789-7890", name: "동주");
        }
    }
}
