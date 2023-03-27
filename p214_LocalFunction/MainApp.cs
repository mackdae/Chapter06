using System;

namespace p214_LocalFunction
{
    class MainApp
    {
        // 6.11 로컬함수(Local Function)
        // 로컬함수는 메소드 안에서 선언되고 해당 메소드 안에서만 사용
        //유니티에서는 그룹지정할때나 쓸 것
        //메소드 안의 메소드 같은 느낌인가??

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
