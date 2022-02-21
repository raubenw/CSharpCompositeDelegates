using System;

namespace CSharpCompositeDelegates
{

    public delegate void MyDelegate(int arg1, int arg2);
    public delegate void MyOtherDelegate(int arg1, ref int arg2);

    class Progam
    {

        static void func1(int arg1, int arg2)
        {
            string result = (arg1 + arg2).ToString();
            Console.WriteLine("The result of func1 = " + result);
        }

        static void func2(int arg1, int arg2)
        {
            string result = (arg1 * arg2).ToString();
            Console.WriteLine("The result of func2 = " + result);
        }

        static void func3(int arg1, ref int arg2)
        {
            string result = (arg1 + arg2).ToString();
            arg2 += 20;
            Console.WriteLine("Result of func3 = " + result);
        }

        static void func4(int arg1, ref int arg2)
        {
            string result = (arg1 * arg2).ToString();
            Console.WriteLine("Result of func4 = " + result);
        }

        static void Main(string[] args)
        {
            MyDelegate f1 = func1;
            MyDelegate f2 = func2;

            int a = 10;
            int b = 20;

            Console.WriteLine("Delegate f1");
            f1(a, b);
            Console.WriteLine("Delegate f2");
            f2(a, b);

            MyDelegate f1f2 = f1 + f2;
            Console.WriteLine("Composite delegate");
            f1f2(a, b);

            Console.WriteLine("Composite deducting f1");
            f1f2 -= f1;
            f1f2(b, b);

            Console.WriteLine("\n\nPassing by reference delegates");
            MyOtherDelegate f3 = func3;
            MyOtherDelegate f4 = func4;

            int c = 10;
            int d = 20;

            Console.WriteLine("Delegate f3");
            f3(c, ref d);
            Console.WriteLine("Delegate f4");
            f4(c, ref d);

            Console.WriteLine("Composite delegates of f3 + f4");
            MyOtherDelegate f3f4 = f3 + f4;
            f3f4(c, ref d);

        }
    }
}