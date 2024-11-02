using System;

namespace Ex_01
{
    // 다음 코드에서 Square()메소드르 구현해 프로그램을 완성하세요.
    // Square() 함수는 매개변수를 제곱하여 반환합니다.
    // 프로그램의 실행 예는다음과 같습니다.

    // 수를 입력하세요. : 3
    // 결과: 9

    // 수를 입력하세요. : 34.2
    //결과 : 1169.64
    class MainApp
    {
        static double Square(double arg)
        {
            arg *= arg;
            return arg;
        }
        static void Main(string[] args)
        {
            Console.Write("수를 입력하세요. : ");
            string input = Console.ReadLine();
            double arg = Convert.ToDouble(input);

            Console.WriteLine("결과 : {0}", Square(arg));
        }
    }
}
