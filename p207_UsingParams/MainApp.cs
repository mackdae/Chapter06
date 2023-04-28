using System;

namespace p207_UsingParams
{
    class MainApp
    {
        // 6.8 가변 개수의 인수
        // 개수가 유연하게 변할 수 있는 인수
        // params 키워드와 배열로 선언
        int SumA(params int[] args)
        {
            int sum = 0;
            for (int i = 0; i < args.Length; i++)
                sum += args[i];
            return sum;
        }
        // 매개변수의 개수가 유한하다면 메소드 오버로딩이 적절
        // 형식은 같으나 인수의 개수만 유연하게 달라질 경우 가변 개수의 인수가 적합

        static int Sum(params int[] args)
        {
            Console.Write("Summing... ");
            int sum = 0;
            for(int i=0; i<args.Length;i++)
            {
                if (i > 0)
                    Console.Write(", ");
                Console.Write(args[i]);
                sum += args[i];
            }
            Console.WriteLine();
            return sum;
        }
        static void Main(string[] args)
        {
            int sum = Sum(3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine($"Sum : {sum}");
        }
    }
}
