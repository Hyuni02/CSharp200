using System.ComponentModel.Design;
using System.Diagnostics;

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
        public void func35() {
            string input = "ak12 uses 5.56mm ammo, ak15 uses 7.62mm ammo";
            int count = 0;
            for (int i = 0; i < input.Length; i++) {
                if (input[i] == 'm') {
                    count++;
                }
            }
            Console.WriteLine(count);   
        }
        public void func36() {
            int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            int count = 0;
            for (int i = 0; i < data.Length; i++) {
                if (data[i] % 2 == 0) {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        public void func37() {
            int a = 3;
            switch (a) {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                case 3:
                    Console.WriteLine("3");
                    break;
                default:
                    Console.WriteLine("no match");
                    break;
            }
        }
        public void func38() {
            int a = 0;
            while (a < 10) {
                a++;
                if(a%3 == 0) {
                    continue;
                }
                else {
                    Console.WriteLine(a);
                }
            }
        }
        public void func39() {
            int a = 0;
            do {
                a++;
                if (a % 3 == 0) {
                    continue;
                }
                else {
                    Console.WriteLine(a);
                }
            } while (a < 10);
           }
        public void func40() {
            //이중 for문
        }
        public void func41() {
            int p = 0, n = 0, t = 0;
            for (int i = 0; i < 10; i++) {
                p = 0;
                n = 1;
                for(int j = 0; j < i; j++) {
                    Console.Write(n);
                    Console.Write(", ");
                    t = n;
                    n += p;
                    p = t;
                }
                Console.WriteLine("");
            }

        }
        public void func42() {
            int size = 4;
            for (int i = 1, j=0; i <= size; i++,j=0) {
                for(int k = 1; k <= size-i; k++) {
                    Console.Write("  ");
                }
                while(j!=2 * i - 1) {
                    Console.Write("* ");
                    j++;
                }
                Console.WriteLine();
            }
        }
        public void func43() {
            Console.WriteLine(MathF.Floor(1.1f));
            Console.WriteLine(MathF.Ceiling(1.1f));
        }
        public void func44() {
            Console.WriteLine(MathF.Round(1.3f));
            Console.WriteLine(MathF.Round(1.5f));
            Console.WriteLine(MathF.Round(-1.3f));
            Console.WriteLine(MathF.Round(-1.5f));
        }
        public void func45() {
            Console.WriteLine(MathF.Abs(-10));
            Console.WriteLine(MathF.Pow(2, 3));
        }
        public void func46() {
            double x = 5.7;
            int div = (int)(x / 3);
            Console.WriteLine(div);
            double mod = x % 3;
            Console.WriteLine(mod);
        }
        public void func47() {
            Console.WriteLine(MathF.Sqrt(4));
        }
        public void func48() {
            //modf없음
        }
        public void func49() {
            Random rand = new Random();
            Console.WriteLine(rand.Next(10));
        }
        public void func50() {
            int[] arr = { 1, 2, 3, 4, 5 };
            Random random = new Random();
            arr=arr.OrderBy(x => random.Next()).ToArray();
            foreach (int x in arr) Console.WriteLine(x);
        }
        public void func51() {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime.ToString());
        }
        public void func52() {
            DateTime start = DateTime.Now;
            int n = 0;
            for(int i = 0; i < 100000; i++) {
                n++;
            }
            DateTime end = DateTime.Now;
            Console.WriteLine(end - start);
        }
        public void func53() {
            string ak12 = "마일리";
            string ak12_2 = "마일리";
            string an94 = "안구사";

            Console.WriteLine(ak12.Equals(an94));
            Console.WriteLine(ak12.Equals(ak12_2));
        }
        public void func54() {
            string ak12 = "마일리는 ak12의 닉네임입니다.";
            int idx = ak12.IndexOf("ak12");
            Console.WriteLine(idx.ToString());
        }
        public void func55() {
            string ak12 = "마일리는 ak12의 닉네임입니다.";
            Console.Write(ak12.Length.ToString());
        }
        public void func56() {
            string ak12 = "ak12";
            string an94 = "AN94";

            Console.WriteLine(ak12.ToUpper());
            Console.WriteLine(an94.ToLower());
        }
        public void func57() {
            string miley = "Miley";
            string ak12 = "ak12";
            string sentense = "";
            sentense += miley;
            sentense += " is ";
            sentense += ak12;
            sentense += "'s nickname";
            Console.WriteLine(sentense);
        }
        public void func58() {
            string sentence = "i coding";
            sentence = sentence.Insert(2, "hate ");
            Console.WriteLine(sentence);
        }
    }
}
