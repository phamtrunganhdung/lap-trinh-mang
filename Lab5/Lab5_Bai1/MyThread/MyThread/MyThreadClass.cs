﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyThread
{
    class MyThreadClass
    {
        private const int RANDOM_SLEEP_MAX = 1000;
        private const int LOOP_COUNT = 10;

        private String greeting;

        public MyThreadClass(String greeting)
        {
            this.greeting = greeting;
        }
        public void runMyThread()
        {
            Random rand = new Random();
            for (int i = 0; i < LOOP_COUNT; i++)
            {
                Console.WriteLine(greeting + "(Thread ID:)" + Thread.CurrentThread.GetHashCode() + ")");
                try
                {
                    Thread.Sleep(rand.Next(0, RANDOM_SLEEP_MAX));
                }
                catch (ThreadAbortException)
                {
                    
                }
            }
        }
    }
}
