using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Events_and_Delegets.Program2;

namespace Events_and_Delegets
{
    internal class Program2
    {
        public delegate void myDelegate(string text);
        public delegate void calculate(int a, int b);
        public delegate void Anonymsdelegate(string str);
        static void Main(string[] args)
        {
            myDelegate d1 = Program2.greeting2;
            d1 += Program2.greeting;

            calculate c = add;
            c += mul;

            //MyClass.myGreetDelegate(d1);
            //MyClass.calc(c);
            Anonymsdelegate ad = delegate (string s) { Console.WriteLine(s); };
            Anonymsdelegate ad2 = s => { Console.WriteLine(s); };
            //MyClass.anonDel(ad);

            Func<string, string> getMas = getMessage;
            //getMas += getMessage2;
            //Console.WriteLine(getMas("asdfaskdjasdkgk"));

            Action<int, int> ac = calc;
            //ac(10, 70);

            Predicate<int> pre = isChild;
            Console.WriteLine(pre(10));

        }
        static bool isChild(int age)
        {
            return true ? age < 18 : false;
        }

        static void calc(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static string getMessage(string s)
        {
            return "Mesasge is : " + s;
        }
        public static string getMessage2(string s)
        {
            return "Mesasge2 : " + s;
        }

        static void add(int a, int b)
        {
            Console.WriteLine("add: " + (a + b));
        }
        static void mul(int a, int b)
        {
            Console.WriteLine("mul: " + a * b);
        }

        private static void greeting(string text)
        {
            Console.WriteLine("GM!!! " + text);
        }
        private static void greeting2(string text)
        {
            Console.WriteLine("GN!!! " + text);
        }
    }

    class MyClass

    {
        public string name = "asd";
        public static void myGreetDelegate(myDelegate del)
        {
            del("Yashh");

        }

        public static void calc(calculate cal)
        {
            cal(5, 2);
        }
        public static void anonDel(Anonymsdelegate del)
        {
            del("Hello !!!!");
        }
    }
}
