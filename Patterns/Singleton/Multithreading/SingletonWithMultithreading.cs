using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Singleton.Multithreading
{
    public class SingletonWithMultithreading
    {
        private SingletonWithMultithreading() { }

        private static SingletonWithMultithreading? _instance { get; set; }

        private static readonly object _lock = new object();

        public string Value { get; private set; }

        public static SingletonWithMultithreading GetInstance(string value)
        {
            if(_instance == null)
            {
                lock(_lock)
                {
                    if(_instance == null)
                    {
                        _instance = new SingletonWithMultithreading();
                        _instance.Value = value;
                    }
                }
            }

            return _instance;
        }
    }
}
