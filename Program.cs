using System;

namespace CSharpCompositeDelegates
{

    public delegate void MyDelegate(int arg1, int arg2);

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



        }
    }
}