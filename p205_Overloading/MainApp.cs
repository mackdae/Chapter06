using System;

namespace p205_Overloading
{
    class MainApp
    {
        // 6.7 메소드 오버로딩: 과적하다
        // 하나의 메소드 이름에 여러 개의 구현을 올림
        // 실행할 메소드를 찾는 작업은 컴파일 타임에 이루어짐 성능저하 없음

        static int Plus(int a, int b)
        {
            Console.WriteLine("Calling int Plus(int,int)...");
            return a + b;
        }
        static int Plus(int a, int b, int c)
        {
            Console.WriteLine("Calling int Plus(int,int,int)...");
            return a + b+c;
        }
        static double Plus(double a, double b)
        {
            Console.WriteLine("Calling int Plus(double,double)...");
            return (int)(a + b); //double 결과를 int로 형변환
        }
        static double Plus(int a, double b)
        {
            Console.WriteLine("Calling int Plus(int,double)...");
            return a + b; // int와 double을 계산하면 결과는 double
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Plus(1, 2));
            Console.WriteLine(Plus(1, 2, 3));
            Console.WriteLine(Plus(1.1, 2.4));
            Console.WriteLine(Plus(1, 2.4));
        }
    }
}
