// See https://aka.ms/new-console-template for more information
using TaskDemo;

Console.WriteLine("Hello, World!");

        Job.Run(_ => Console.WriteLine($"Job1, thread:{Thread.CurrentThread.ManagedThreadId}"));
        Job.Run(_=>Console.WriteLine($"Job2, thread:{Thread.CurrentThread.ManagedThreadId}"));
        Job.Run(_=>Console.WriteLine($"Job3, thread:{Thread.CurrentThread.ManagedThreadId}"));