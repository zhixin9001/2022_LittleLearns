using System.Collections.Concurrent;
namespace TaskDemo;

public class DedicatedThreadJobScheduler : JobScheduler
{
    private readonly BlockingCollection<Job> _queues=new();
    private readonly Thread[] _threads;

    public DedicatedThreadJobScheduler(int threadCount)
    {
        _threads=new Thread[threadCount];
        for(int index=0; index< threadCount; index++)
        {
            _threads[index] =new Thread(Invoke);
        }
        Array.ForEach(_threads, thread=>thread.Start());

        void Invoke(object? state){
            while(true){
                _queues.Take().Invoke();
            }
        }
    }

    public override void QueueJob(Job job)
    {
        _queues.Add(job);
    }
}