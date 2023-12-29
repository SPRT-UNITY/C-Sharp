using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public void NameAndAge() 
        {
            Console.WriteLine("이름을 입력해주세요");
            string name = Console.ReadLine();
            Console.WriteLine("나이를 입력해주세요");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"이름은 {name}, 나이는 {age}살입니다");
        }

        public void SimpleCalculator() 
        {
            Console.WriteLine("두 숫자를 입력해주세요");
            string str = Console.ReadLine();
            int one = int.Parse(str.Split(' ')[0]);
            int two = int.Parse(str.Split(' ')[1]);
            Console.WriteLine($"{one} + {two} = {one + two}");
            Console.WriteLine($"{one} - {two} = {one - two}");
            Console.WriteLine($"{one} * {two} = {one * two}");
            Console.WriteLine($"{one} / {two} = {one / two}");
            Console.WriteLine($"{one} % {two} = {one % two}");
        }

        public void CelciusToFahrenheit() 
        {
            Console.WriteLine("섭씨 온도를 입력해주세요");
            double celcius = Double.Parse(Console.ReadLine());
            Console.WriteLine($"섭씨 {celcius}도는 화씨로 {celcius * 9/5 + 32}도입니다.");
        }

        public void CalculateBMI() 
        {
            Console.WriteLine("체중을 입력해주세요(단위 kg)");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("신장을 입력해주세요(단위 cm)");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine($"BMI 수치는 {(weight / (Math.Pow(height /100, 2))).ToString("N2")}입니다.");
        }
    }
}
