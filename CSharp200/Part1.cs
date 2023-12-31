using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp200 {
    internal class Part1 {
        public void func1() {
            Console.WriteLine("Hello C# World!");
        }
        public void func2() {
            int number = 0;
            string input = Console.ReadLine();
            int.TryParse(input, out number);
            Console.WriteLine("입력한 숫자는 : " + number);
        }
        public void func3() {
            int one = 1;
            int two = 2;
            int sum = one + two;
            Console.WriteLine("1+2=" + sum);
        }
        public void func4() {
            const int YEAR_M1911 = 1911;
            const int YEAR_AK47 = 1947;
            Console.WriteLine("M1911 제작년도 : " +  YEAR_M1911);
            Console.WriteLine("AK47 제작년도 : " +  YEAR_AK47);
        }
        public void func5() {
            int one = 1;
            int two = 2;
            Console.WriteLine("1+2=" + $"{one + two}");
            Console.WriteLine("1-2=" + $"{one - two}");
        }
    }
}
