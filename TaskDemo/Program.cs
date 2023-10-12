// See https://aka.ms/new-console-template for more information

using TaskDemo;

JobScheduler.Current=new DedicatedThreadJobScheduler(1);
// Job.Run(() => Console.WriteLine($"Job1, thread:{Thread.CurrentThread.ManagedThreadId}"));
// Job.Run(() => Console.WriteLine($"Job2, thread:{Thread.CurrentThread.ManagedThreadId}"));
// Job.Run(() => Console.WriteLine($"Job3, thread:{Thread.CurrentThread.ManagedThreadId}"));
// Job.Run(() => Console.WriteLine($"Job4, thread:{Thread.CurrentThread.ManagedThreadId}"));
// Job.Run(() => Console.WriteLine($"Job5, thread:{Thread.CurrentThread.ManagedThreadId}"));
// Job.Run(() => Console.WriteLine($"Job6, thread:{Thread.CurrentThread.ManagedThreadId}"));

Job.Run(()=>{
    Thread.Sleep(1000);
    Console.WriteLine("11");
}).ContinueWith(_=>{
    Thread.Sleep(1000);
    Console.WriteLine("12");    
}).ContinueWith(_=>{
    Thread.Sleep(1000);
    Console.WriteLine("13");    
});
Console.WriteLine("Hello, World!");