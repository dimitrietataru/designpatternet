using System;

namespace Singleton
{
    public sealed class Singleton
    {
        private static readonly object lockObj = new object();
        private static Singleton instance = null;

        private Singleton()
        {
        }

        public static Singleton Instance => GetInstance();

        public string Value { get; set; }

        private static Singleton GetInstance()
        {
            Console.WriteLine("Getting singleton instance..");

            lock (lockObj)
            {
                if (instance is null)
                {
                    Console.WriteLine("Creating a new instance.." + Environment.NewLine);
                    instance = new Singleton();
                }

                return instance;
            }
        }
    }
}
