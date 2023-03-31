using System;

namespace SunMyeongEun_ex1
{
    class MainApp
    {
        //연습문제1.
        //다음 코드에서 Square() 메소드를 구현해 프로그램을 완성
        //Square() 함수는 매개변수를 제곱하여 반환
        //수를 입력하세요: 3
        //결과: 9
        //수를 입력하세요 : 34.2
        //결과: 1169.64

        static double Square(double arg)
        {
            return arg * arg;
        }
        static void Main(string[] args)
        {
            Console.Write("수를 입력하세요 : ");
            string input = Console.ReadLine();
            double arg = Convert.ToDouble(input);

            Console.WriteLine("결과 : {0}", Square(arg));
        }
    }
}