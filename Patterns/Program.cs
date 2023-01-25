using Patterns.Singleton.Multithreading;
using Patterns.Singleton.Simple;

namespace Patterns
{
    class Program
    {
        public static void Main()
        {
            testSingleton();
        }

        public static void testSingleton()
        {
            SingletonSimpleTest simpleTest = new SingletonSimpleTest();
            //simpleTest.Run();
            simpleTest.RunInThreads();

            Console.WriteLine();

            SingletonWithMultithreadingTest multithreadingTest = new SingletonWithMultithreadingTest();
            multithreadingTest.Run();
        }
    }
}