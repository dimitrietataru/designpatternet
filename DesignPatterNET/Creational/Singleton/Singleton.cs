﻿using System;

namespace Singleton
{
    public sealed class Singleton
    {
        public string Value { get; set; }
        private static Singleton instance = null;
        private static readonly object lockObj = new object();

        private Singleton() {}

        public static Singleton GetInstance()
        {
            Console.WriteLine("Getting singleton instance..");

            lock (lockObj)
            {
                if (instance == null)
                {
                    Console.WriteLine("Creating a new instance.." + Environment.NewLine);
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}