using System;

namespace _19_ReadonlyMethod
{
    struct ACSetting
    {
        public double currentInCelsius;
        public double target;

        public readonly double GetFahrenheit()
        {
            // 화씨 계산 결과를 target에 저장
            target = currentInCelsius * 1.8 + 32;
            return target;  // target 반환
        }
    }
    
    class MainAPp
    {
        static void Main(string[] args)
        {
            ACSetting acs;
            acs.currentInCelsius = 25;
            acs.target = 25;

            Console.WriteLine($"{acs.GetFahrenheit()}");
            Console.WriteLine($"{acs.target}");
        }
    }
}
