﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic5
{
    class Program
    {
        int someModifier = 0;
        public int instanceVariable = 10;
        public int instanceMethod()
        {
            return 0;
        }

        class MyMath
        {
            public static int Abs(int input)
            {
                return (input < 0) ? -input : input;
                /*
                if(input < 0)
                {
                    return -input;
                }
                else
                {
                    return input;
                }
                */
            }

            public static double Abs(double input)
            {
                return (input < 0) ? -input : input;
            }
            
            // Abs ( long )
            public static long Abs(long input)
            {
                return (input < 0) ? -input : input;
            }

            // Abs ( long )
            /* Method Signature가 같은 경우 오버로딩 불가!
            public static int Abs(long a2)
            {
                return 0;
            }
            */
        }

        class Test
        {
            public void TestMethod()
            {
                Program.Main(new string[] { "" });
            }
            
            // Method Signature
            public int Sum(int min, int max)
            {
                int output = 0;
                for (int i = min; i <= max; i++)
                {
                    output += i;
                }
                return output;
            }
        }

        class MethodExample
        {
            public int Power(int x)
            {
                return x * x;
            }

            public int Multi(int x, int y)
            {
                return x * y;
            }

            public void Print()
            {
                Console.WriteLine("Print() 메서드 호출됨");
            }
        }

        static void Main(string[] args)
        {
            MethodExample me = new MethodExample();
            Console.WriteLine(me.Power(10));
            Console.WriteLine(me.Power(20));
            Console.WriteLine(me.Multi(52, 273));
            Console.WriteLine(me.Multi(103, 32));
            me.Print();

            Test test = new Test();
            Console.WriteLine(test.Sum(1, 100));

            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-273));

            // 클래스 메서드에서는 인스턴스 변수메서드 접근 불가!
            // 객체를 만들어 접근해야한다.
            //Console.WriteLine(instanceVariable);
            //instanceMethod();
            Program p = new Program();
            Console.WriteLine(p.instanceVariable);
            p.instanceMethod();

            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-274));
            Console.WriteLine(MyMath.Abs(52.273));
            Console.WriteLine(MyMath.Abs(21474812312323));
        }
    }
}
