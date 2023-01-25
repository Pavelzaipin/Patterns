using System;

namespace Patterns.Singleton.Simple
{
    class SingletonSimpleTest
    {
        public void Run()
        {
            SomeNumber someNumber1 = SomeNumber.GetInstance();
            SomeNumber someNumber2 = SomeNumber.GetInstance();

            Console.WriteLine("First number is " + someNumber1.GetNumber());
            Console.WriteLine("Second number is " + someNumber2.GetNumber());

            Console.WriteLine("Instance is equale: " + (someNumber1 == someNumber2));
        }

        public void RunInThreads()
        {
            Thread process1 = new Thread(() =>
            {
                SomeNumber someNumberThread1 = SomeNumber.GetInstance();
                Console.WriteLine("First number in thread: " + someNumberThread1.GetNumber());
            });
            Thread process2 = new Thread(() =>
            {
                SomeNumber someNumberThread2 = SomeNumber.GetInstance();
                Console.WriteLine("Second number in thread: " + someNumberThread2.GetNumber());
            });

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();
        }
    }
}
