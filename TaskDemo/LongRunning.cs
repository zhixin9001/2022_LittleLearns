namespace TaskDemo;

public class LongRunningDemo
{
    public static void Run()
    {
        var longTask=Task.Factory.StartNew(LongRunningMethod, TaskCreationOptions.LongRunning);
        var normalTask=Task.Factory.StartNew(NormalMethod);

        Task.WaitAll(longTask,normalTask);
    }

    static void LongRunningMethod()
    {
        // Simulate a long-running operation
        Console.WriteLine("Long-running task started on thread {0}.", Thread.CurrentThread.ManagedThreadId);
        Thread.Sleep(10000);
        Console.WriteLine("Long-running task finished on thread {0}.", Thread.CurrentThread.ManagedThreadId);
    }

    static void NormalMethod()
    {
        // Simulate a normal operation
        Console.WriteLine("Normal task started on thread {0}.", Thread.CurrentThread.ManagedThreadId);
        Thread.Sleep(1000);
        Console.WriteLine("Normal task finished on thread {0}.", Thread.CurrentThread.ManagedThreadId);
    }
}