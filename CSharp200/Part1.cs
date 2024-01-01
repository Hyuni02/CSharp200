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
            Console.WriteLine("M1911 제작년도 : " + YEAR_M1911);
            Console.WriteLine("AK47 제작년도 : " + YEAR_AK47);
        }
        public void func5() {
            int one = 1;
            int two = 2;
            Console.WriteLine("1+2=" + $"{one + two}");
            Console.WriteLine("1-2=" + $"{one - two}");
        }
        public void func6() {
            int two = 2;
            int eight = 8;
            int sum1 = 2;
            int sum2 = 2;

            sum1 = sum1 + two;
            sum2 += eight;

            Console.WriteLine("sum1 = " + sum1);
            Console.WriteLine("sum2 = " + sum2);
        }
        public void func7() {
            char character = 'a';
            int integer = 100;
            double precision = 3.14;
            bool is_true = true;
            string word = "Hello World";
            Console.WriteLine(character);
            Console.WriteLine(integer);
            Console.WriteLine(precision);
            Console.WriteLine(is_true);
            Console.WriteLine(word);
        }
        public void func8() {
            int x = 10;
            int y = 1;
            if (x > y) {
                Console.WriteLine("x > y");
            }
            else {
                Console.WriteLine("x < y");
            }
        }
        public void func9() {
            int sum1 = 0;
            int sum2 = 0;
            int one = 1;
            int two = 2;
            for (int i = 0; i < 5; i++) {
                sum1 += one;
                sum2 += two;
            }

            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
        }
        public void func10() {
            const int ARRAY_SIZE = 3;
            int[] ints = new int[ARRAY_SIZE];
            ints[0] = 2012;
            ints[1] = 2015;
            ints[2] = 1994;
            Console.WriteLine(ints[0]);
            Console.WriteLine(ints[1]);
            Console.WriteLine(ints[2]);
        }
        public void func11() {
            Plus(1, 2);
        }
        private void Plus(int a, int b) {
            Console.WriteLine(a + b);
        }
        public void func12() {
            Console.WriteLine("before comment");
            //Console.WriteLine("comment");
            Console.WriteLine("after comment");
        }
        public void func13() {
            var fir = new first.fir();
            fir.print();
            var sec = new second.sec();
            sec.print();
        }
    }
}
namespace first {
    internal class fir {
        int integer = 1;
        public void print() {
            Console.WriteLine(integer + "from first");
        }
    }
}
namespace second {
    internal class sec {
        int integer = 2;
        public void print() {
            Console.WriteLine(integer + "from second");
        }
    }
}

