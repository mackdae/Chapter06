using System;

namespace p191_Return
{
    class MainApp
    {
        //6.2 return에 대해

        //재귀호출
        //메소드가 자기자신을 호출
        //초급알고리즘
        //피보나치수열

        //p191
        static int Fibonacci(int n)
        {
            if (n < 2)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void PrintProfile(string name, string phone)
        {
            if (name == "")
            {
                Console.WriteLine("이름을 입력해주세요.");
                return;
            }
            Console.WriteLine($"Name:{name}, Phone:{phone}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"10번째 피보나치 수 : {Fibonacci(10)}");
            PrintProfile("", "123-4567");
            PrintProfile("박상현", "456-1230");
        }
    }
}
