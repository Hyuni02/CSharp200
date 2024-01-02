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
    }
}
