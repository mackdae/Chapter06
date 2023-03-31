using System;

namespace p191_Return
{
    class MainApp
    {
        //6.2 return에 대해

        //재귀호출: 메소드가 자기자신을 호출
        //초급알고리즘
        //피보나치수열

        //p191
        static int Fibonacci(int n)
        {
            if (n < 2) //(n==0||n==1)
                return n; //1,2항은 0과1로 고정
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2); //재귀호출
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
            Console.WriteLine($"10번째 피보나치 수 : {Fibonacci(10)}\n");

            PrintProfile("", "123-4567");
            PrintProfile("박상현", "456-1230");
            Console.WriteLine();

            //피보나치수열 10항까지 출력
            for (int i = 0; i < 10; i++)
                Console.Write(Fibonacci(i) + ",");
            Console.WriteLine();

            //피보나치수열 다른방법
            int n = 10; //출력할 피보나치수열 길이
            int a = 0; //1항
            int b = 1; //2항
            int c;
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + ","); //1항이 있는 a를 출력
                c = a + b; //b에 넣을 3항을 구함
                a = b; //a에 2항을 넣음
                b = c; //b에 3항을 넣음
                //n만큼 반복
            }
            Console.WriteLine();

            /*
            시간 복잡도는 알고리즘이 문제를 해결하는 데 걸리는 시간의 측정입니다.
            일반적으로 입력 크기 n에 대한 함수로 표현되며, 
            최선, 평균, 최악의 경우에 따라 다른 값을 가집니다.
            
            피보나치 수열의 경우, 
            일반적으로 재귀 함수를 사용하면 O(2 ^ n)의 시간 복잡도를 가지게 됩니다.
            하지만, 이를 반복문으로 구현하면 O(n)의 시간 복잡도를 가집니다. 
            또한, 행렬을 이용한 방법으로 구현하면 O(log n)의 시간 복잡도를 가지게 됩니다.

            시간 복잡도를 고려하여 알고리즘을 설계하면, 
            큰 입력에 대해서도 빠른 속도로 문제를 해결할 수 있으며, 
            성능을 향상시킬 수 있습니다.
            */
        }
    }
}
