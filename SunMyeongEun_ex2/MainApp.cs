using System;

namespace SunMyeongEun_ex2
{
    class MainApp
    {
        //연습문제2.
        //다음 코드에서 Mean() 메소드를 실행한 후의 mean은 3이 아닌 0의 값을 가진다
        //mean이 0을 갖게 되는 원인은? 코드에서 고쳐야 할 부분은?

        //매개변수가 바뀌어도 원본변수는 바뀌지 않기 때문
        public static void Main()
        {
            double mean = 0;
            Mean(1, 2, 3, 4, 5, out mean); //out 추가
            Console.WriteLine("평균 : {0}", mean);
        }
        public static void Mean(
            double a, double b, double c, double d, double e, out double mean) //out 추가
        {
            mean = (a + b + c + d + e) / 5;
        }
    }
}
