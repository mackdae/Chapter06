using System;

namespace p202_UsingOut
{
    class MainApp
    {
        // 6.6 출력전용 매개변수
        // 메소드에서 여러개의 결과를 얻으려면
        // ref 대신 out 사용하면 컴파일러가 체크해줘서 조금 더 안전
        // 매개변수에 결과를 저장하지 않으면 오류 출력

        static void Divide1(int a, int b, out int c, out int d)
        {
            c = a / b;
            d = a % b;
        }

        static void Main(string[] args)
        {
            int a = 20;
            int b = 3;
            Divide1(a, b, out int c, out int d);
            // 호출하는 쪽에서 초기화하지 않은 지역변수 c,d를 out 매개변수로 넘길 수 있음
            // 해당 메소드에서 지역변수를 할당할 것을 컴파일러가 보장하기 때문

            Console.WriteLine($"a:{a}, b:{b}, a/b:{c}, a%b:{d}");

        //다른버전
        //    int[] cde;
        //    cde = Divide2(a, b);
        //    Console.WriteLine(cde);
        //}
        //static int[] Divide2(int a, int b)
        //{
        //    int[] abc = new int[2];
        //    abc[0] = a / b;
        //    abc[1] = a % b;
        //    return abc;
        //실패ㅠㅜ
        }
    }
}
