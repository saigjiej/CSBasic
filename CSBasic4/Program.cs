﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic4
{
    /*class Math
    {
    }*/
    class Car
    {
        int carNumber;
        DateTime inTime;
        DateTime outTime;

        public void SetInTime()
        {
            this.inTime = DateTime.Now;
        }
        public void SetOutTime()
        {
            this.inTime = DateTime.Now;
        }
    }
    class Program
    {
        class FirstClass
        {

        }

        class SecondClass
        {

        }
        static void Main(string[] args)
        {
            Car[] cars = new Car[10];

            Random random = new Random();
            Console.WriteLine(random.Next());
            Console.WriteLine(random.Next(100));
            Console.WriteLine(random.Next(10, 19));
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());

            //List<int> list = new List<int>();
            //list.Add(52);
            //list.Add(273);
            //list.Add(32);
            //list.Add(64);
            List<int> list = new List<int>() { 52, 273, 32, 64 };
            
            foreach (var item in list)
            {
                Console.WriteLine("Count: " + list.Count + "\titem: " + item);
                list.Remove(item);
            }

            Console.WriteLine(Math.Abs(-52273));
            Console.WriteLine(Math.Ceiling(52.273));
            Console.WriteLine(Math.Floor(52.273));
            Console.WriteLine(Math.Round(52.263));
            Console.WriteLine(Math.Round(52.563));
            Console.WriteLine(Math.Max(52, 273));
            Console.WriteLine(Math.Min(52, 274));
        }
    }
}
