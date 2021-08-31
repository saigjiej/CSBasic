﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic7
{
    class Wanted<T>
        //where T : Student
    {
        public T Value;
        public Wanted(T value)
        {
            this.Value = value;
        }
    }

    class Program
    {
        class Student
        {
            public override string ToString()
            {
                return "학생";
            }
        }

        static void Main(string[] args)
        {
            Wanted<string> ws = new Wanted<string>("string");
            Wanted<int> wi = new Wanted<int>(42);
            Wanted<Student> wstu = new Wanted<Student>(new Student());
            Console.WriteLine(ws.Value);
            Console.WriteLine(wi.Value);
            Console.WriteLine(wstu.ToString());
        }
    }
}
