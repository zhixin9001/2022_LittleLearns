using TaskDemo;

#region Job1
// JobScheduler.Current = new DedicatedThreadJobScheduler(1);
// Job.Run(() => Console.WriteLine($"Job1, thread:{Thread.CurrentThread.ManagedThreadId}"));
// Job.Run(() => Console.WriteLine($"Job2, thread:{Thread.CurrentThread.ManagedThreadId}"));
// Job.Run(() => Console.WriteLine($"Job3, thread:{Thread.CurrentThread.ManagedThreadId}"));
// Job.Run(() => Console.WriteLine($"Job4, thread:{Thread.CurrentThread.ManagedThreadId}"));
// Job.Run(() => Console.WriteLine($"Job5, thread:{Thread.CurrentThread.ManagedThreadId}"));
// Job.Run(() => Console.WriteLine($"Job6, thread:{Thread.CurrentThread.ManagedThreadId}"));

// Job.Run(() =>
// {
//     Thread.Sleep(1000);
//     Console.WriteLine($"11 {Thread.CurrentThread.ManagedThreadId}");
// }).ContinueWith(_ =>
// {
//     Thread.Sleep(1000);
//     Console.WriteLine("12");
// }).ContinueWith(_ =>
// {
//     Thread.Sleep(1000);
//     Console.WriteLine("13");
// });
// Job.Run(() =>
// {
//     Thread.Sleep(1000);
//     Console.WriteLine($"21 {Thread.CurrentThread.ManagedThreadId}");
// }).ContinueWith(_ =>
// {
//     Thread.Sleep(1000);
//     Console.WriteLine("22");
// }).ContinueWith(_ =>
// {
//     Thread.Sleep(1000);
//     Console.WriteLine("23");
// });
// Job.Run(() =>
// {
//     Thread.Sleep(1000);
//     Console.WriteLine("31");
// }).ContinueWith(_ =>
// {
//     Thread.Sleep(1000);
//     Console.WriteLine("32");
// }).ContinueWith(_ =>
// {
//     Thread.Sleep(1000);
//     Console.WriteLine("33");
// });
// Console.WriteLine("Hello, World!");

#endregion

// LongRunningDemo.Run();


// await F1();
// await F2();
// await F3();

// static Job F1() => new Job(() =>
// {
//         Thread.Sleep(1000);
//         Console.WriteLine("F1");
// });

// static Job F2() => new Job(() =>
// {
//         Thread.Sleep(1000);
//         Console.WriteLine("F2");
// });

// static Job F3() => new Job(() =>
// {
//         Thread.Sleep(1000);
//         Console.WriteLine("F3");
// });


// await Task.Run(() => Console.WriteLine($"Task1, thread:{Thread.CurrentThread.ManagedThreadId}"));
// await Task.Run(() => Console.WriteLine($"Task2, thread:{Thread.CurrentThread.ManagedThreadId}"));
// await Task.Run(() => Console.WriteLine($"Task3, thread:{Thread.CurrentThread.ManagedThreadId}"));
// await Task.Run(() => Console.WriteLine($"Task4, thread:{Thread.CurrentThread.ManagedThreadId}"));

// await TaskA()
// .ContinueWith(_ => Console.WriteLine($"Task3, thread:{Thread.CurrentThread.ManagedThreadId}"))
// .ContinueWith(_ => Console.WriteLine($"Task4, thread:{Thread.CurrentThread.ManagedThreadId}"));
// TaskA();
// Console.WriteLine("3");

static async Task TaskA()
{
        Console.WriteLine($"Task1, thread:{Thread.CurrentThread.ManagedThreadId}");
        await Task.Delay(1);
        Console.WriteLine($"Task2, thread:{Thread.CurrentThread.ManagedThreadId}");
}

var taskA = Task.Run(() => DateTime.Now);
var taskB = taskA.ContinueWith(time => Console.WriteLine(time.Result));
await taskB;
