using System.Runtime.CompilerServices;

namespace TaskDemo;

public struct JobAwaiter : ICriticalNotifyCompletion
{
    private readonly Job _job;
    public readonly bool IsCompleted => _job.Status == JobStatus.Completed;

    public JobAwaiter(Job job)
    {
        _job = job;
        if (job.Status == JobStatus.Created)
        {
            job.Start();
        }
    }

    public void OnCompleted(Action continuation)
    {
        _job.ContinueWith(_ => continuation());
    }

    public void GetResult() { }

    public void UnsafeOnCompleted(Action continuation)
    => OnCompleted(continuation);
}