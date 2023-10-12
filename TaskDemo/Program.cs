// See https://aka.ms/new-console-template for more information

using TaskDemo;


Job.Run(() => Console.WriteLine($"Job1, thread:{Thread.CurrentThread.ManagedThreadId}"));
Job.Run(() => Console.WriteLine($"Job2, thread:{Thread.CurrentThread.ManagedThreadId}"));
Job.Run(() => Console.WriteLine($"Job3, thread:{Thread.CurrentThread.ManagedThreadId}"));
Console.WriteLine("Hello, World!");