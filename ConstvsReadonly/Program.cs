using System;

namespace ConstvsReadonly
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");
        //}
    }

    class MyClass
    {

        public const double PI = 3.14;

        public const string MY_ERROR = "some error";

        public readonly int _a;

        public static readonly int _b;

        static MyClass()
        {
            _b = 3;
        }


        public MyClass(int a)
        {
            _a = a;
            
        }
        public void Foo()
        {
            Console.WriteLine(MY_ERROR);
            Console.WriteLine(_a);
            Console.WriteLine(_b);
        }

        class Program
        {

            static void Main(string[] args)
            {

                MyClass myClass = new MyClass(4);
                myClass.Foo();


            }
        }


    }

        








}
