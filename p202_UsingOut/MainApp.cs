using System;

namespace p202_UsingOut
{
    class MainApp
    {
        //6.6 출력 전용 매개변수

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
            Console.WriteLine($"a:{a}, b:{b}, a/b:{c}, a%b:{d}");

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
