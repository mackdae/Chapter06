using System;

namespace p214_LocalFunction
{
    class MainApp
    {
        // 6.11 로컬함수(Local Function)
        // 로컬함수는 메소드 안에서 선언되고 해당 메소드 안에서만 사용
        //유니티에서는 그룹지정할때나 쓸 것
        //메소드 안의 메소드 같은 느낌인가??
        // 클래스의 맴버가 아니라서 함수라고 부름
        // 자신이 존재하는 지역 안의 변수를 사용 가능
        // 메소드 밖에서 쓸 일 없는 반복작업을 묶어놓는데에 제격

        static string ToLowerString(string input)
        {
            var arr = input.ToCharArray();
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = ToLowerChar(i);
            }
            char ToLowerChar(int i)
            {
                if (arr[i] < 65 || arr[i] > 90)
                    return arr[i];
                else
                    return (char)(arr[i]+32);
            }
            return new string(arr);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ToLowerString("Hello!"));
            Console.WriteLine(ToLowerString("Good Morning."));
            Console.WriteLine(ToLowerString("This is C#."));
        }
    }
}
