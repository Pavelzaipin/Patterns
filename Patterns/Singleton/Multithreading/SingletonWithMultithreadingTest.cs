using System;

namespace Patterns.Singleton.Multithreading
{
    internal class SingletonWithMultithreadingTest
    {
        
        public void Run()
        {
            Thread process1 = new Thread(() =>
            {
                Console.WriteLine(GetValueFromInstance("First initialization"));
            });
            Thread process2 = new Thread(() =>
            {
                Console.WriteLine(GetValueFromInstance("Second initialization attempt"));
            });

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();
        }

        private string GetValueFromInstance(string value)
        {
            SingletonWithMultithreading singleton = SingletonWithMultithreading.GetInstance(value);
            return singleton.Value;
        }
    }
}
