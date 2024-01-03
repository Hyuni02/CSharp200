using System.ComponentModel.Design;

namespace CSharp200 {
    internal class Part2 {
        public void func16() {
            char c1 = 'c';
            //char c2 = 200; 지원 안함

            Console.WriteLine(c1);
            //Console.WriteLine(c2);
        }
        public void func17() {
            string str = "string";
            string str2 = "string2";
            Console.WriteLine(str);
            Console.WriteLine(str2);
            Console.WriteLine(str + str2);
        }
        public void func18() {
            int posi = 100;
            int neg = -100;
            int ascii = 'a';
            Console.WriteLine(posi);
            Console.WriteLine(neg);
            Console.WriteLine(ascii);
        }
        public void func19() {
            double pi_d = 3.14;
            float pi_f = 3.14f;
            Console.WriteLine(pi_d);
            Console.WriteLine(pi_f);
        }
        public void func20() {
            int x = 1;
            int y = 2;
            bool same = x == y;
            Console.WriteLine(same);
        }
        public void func21() {
            int a = 1;
            int b = 2;
            int c = a + b;
            Console.WriteLine(c);
        }
        public void func22() {
            int a = 1;
            int b = -2;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
        }
        public void func23() {
            int a = 1;
            Console.WriteLine(a++);
            Console.WriteLine(a++);
            Console.WriteLine(++a);
            Console.WriteLine(a--);
            Console.WriteLine(a--);
            Console.WriteLine(--a);
        }
        public void func24() {
            int a = 1;
            int b = 2;
            int c = 2;
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(b == c);
            Console.WriteLine(b != c);
        }
        public void func25() {
            bool a = true;
            bool b = false;
            Console.WriteLine(a && b);
            Console.WriteLine(a || b);
        }
        public void func26() {
            int a = 1;
            int b = 2;
            Console.WriteLine(a > b ? a : b);
        }
        public void func27() {
            int a = 1, b = 2;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        public void func28() {
            //비트 연산자
        }
        public void func29() {
            int a = 1;
            float b = 2.2f;
            int c = (int)(b / a);
            Console.WriteLine(c);
        }
        public void func30() {
            //명시적 변환
        }
        public void func31() {
            Console.WriteLine(sizeof(int));
            Console.WriteLine(sizeof(float));
            Console.WriteLine(sizeof(double));
            Console.WriteLine(sizeof(char));
        }
        public void func32() {
            int a = 1;
            if (a == 0) Console.WriteLine("a=0");
            else if (a < 0) Console.WriteLine("a<0");
            else Console.WriteLine("a>0");
        }
        public void func33() {
            //if 중첩으로 최대값 찾기
        }
        public void func34() {
            int a = 7;
            for(int i = 0; i < 10; i++) {
                if(i % 3 == 0) {
                    continue;
                }
                else if(i == a) {
                    break;
                }
                else{
                    Console.WriteLine(i);
                }
            }
        }
    }
}
