﻿namespace Test
{
    using BenchmarkDotNet.Running;
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
#if RELEASE
            BenchmarkRunner.Run<Benchmark>();
#else
            Benchmark b = new Benchmark();
            b.Count = 3;
            b.GlobalSetup();
            var x = b.ReadDataUsingEntityFramework();
#endif
        }
    }
}