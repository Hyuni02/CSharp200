﻿using System;
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
    }
}
