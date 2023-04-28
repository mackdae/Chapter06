using System;

namespace p199_RefReturn
{
    // 6.5 메소드의 결과를 참조로 반환
    // 참조반환값
    // 호출자가 반환결과를 참조로 다룰 수 있음

    class Product
    {
        private int price = 100;
        public ref int GetPrice() // ref 키워드로 메소드를 한정
        {
            return ref price; // 리턴문에도 필드나 객체 앞에 ref 키워드 추가
        }
        public void PrintPrice()
        {
            Console.WriteLine($"Price :{price}");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Product carrot = new Product();
            ref int ref_local_price = ref carrot.GetPrice(); // 참조지역변수
            int normal_local_price = carrot.GetPrice(); // ref를 안 붙이면 일반 메소드처럼 동작

            carrot.PrintPrice();
            Console.WriteLine($"Normal Local Price :{normal_local_price}");
            Console.WriteLine($"Ref Local Price :{ref_local_price}");
            Console.WriteLine($"Get Price :{carrot.GetPrice()}");

            // normal_local_price는 price의 데이터를 복사
            // ref_local_price는 price의 데이터 위치를 참조
            ref_local_price = 200;
            // ref_local_price를 수정하면 carrot.price의 내용도 바뀜

            carrot.PrintPrice();
            Console.WriteLine($"Normal Local Price :{normal_local_price}");
            Console.WriteLine($"Ref Local Price :{ref_local_price}");
            Console.WriteLine($"Get Price :{carrot.GetPrice()}");
        }
    }
}
