using System;

namespace p188_Method
{
    // 6.1 메소드
    // C#은 메소드와 함수를 구분, 자바영향으로 혼용
    // Method: 방법,방식. 객체의 일을 처리하는 방법 또는 방식
    // 어떠한 동작(기능)을 하는 코드들을 하나의 이름으로 묶어놓은 것
    // 메소드=기능 데이터=변수

    // 국제표기법
    // int phoneNumber 카멜 표기법(국제규격) PhoneNumber
    // int phone_number 스네이크 표기법 Phone_Number
    // 변수는 소문자로 시작, 메소드와 클래스는 대문자로 시작

    // 객체지향 프로그래밍에 언어는 코드 내의 모든 것을 객체(오브젝트)로 표현
    // 각 객체는 자신만의 속성(데이터= 변수)과 기능(메소드)을 갖고 있는데,
    // 클래스가 바로 이 객체를 위한 청사진(설계도)을 제공합니다.

    // 매개변수: 메소드가 호출자에게 전달받은 값을 받는 변수
    // 인수: 호출자가 매개변수에 넘기는 값
    // public static int Plus(int a, int b) a,b가 매개변수
    // Calculator.Plus(3, 4); 3,4가 인수
    // 메소드는 코드를 간추리는 한 편 읽기 쉽고 이해하기 쉽게 만듦

    class Calculator
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public int Minus(int a, int b)
        {
            return a - b;
        }
    }
    // static 한정자
    // 메소드나 필드(전역변수)가 클래스의 인스턴스가 아닌 클래스 자체에 소속되도록 지정하는 한정자
    // static을 쓰지 않으면 Calculator의 인스턴스를 만들어서 메소드를 호출
    class MainApp
    {
        public static void Main() // void 반환이 없는 메소드의 반환형식 자리에 넣음
        {
            int result1 = Calculator.Plus(3, 4);
            Console.WriteLine(result1);

            Calculator a = new Calculator();
            int result2 = a.Minus(3, 4);
            Console.WriteLine(result2);
        }
    }
}
