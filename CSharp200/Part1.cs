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
    }
}
