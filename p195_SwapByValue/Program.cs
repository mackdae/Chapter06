using System;

namespace p195_SwapByValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;
            Console.WriteLine($"초기) x:{x}, y:{y}");

            // 6.3 매개변수에 대해
            // 메소드가 호출자에게서 전달받은 값을 받는 변수
            Swap1(x, y); // 인수 x,y
            Console.WriteLine($"6.3)  x:{x}, y:{y}");
            // 메소드가 인수를 매개변수를 받아들일 때는 데이터의 복사가 이루어짐
            // = 값에 의한 전달 pass by value
            // Swap1 메소드 호출 후에도 xy의 값은 바뀌지 않음

            // 6.4 참조에 의한 매개변수 전달
            // 매개변수를 메소드에 참조로 전달하는 방법
            Swap2(ref x, ref y); // 인수 ref x, ref y
            Console.WriteLine($"6.4)  x:{x}, y:{y}");
            // 매개변수가 메소드에 넘겨진 원본변수를 직접 참조
            // Swap2의 매개변수ab를 수정하면 원본변수xy에 수정이 이루어짐
            // = 참조에 의한 전달 pass by reference
        }

        public static void Swap1(int a, int b) // a=3,b=4
            // xy의 값을 ab로 복사
            // xy와 ab는 별개의 메모리 공간을 사용
        {
            int temp = b;//temp=4
            b = a; //b=3
            a = temp; //a=4
        }
        public static void Swap2(ref int a, ref int b) // a=x,b=y
            // ab는 xy가 사용하는 메모리 공간을 참조
            // ab의 값을 수정 = xy의 값을 수정
        {
            int temp = b;//temp=4
            b = a; //b=3
            a = temp; //a=4
        }
        //a,b가 매개변수 x,y가 인수
    }
}