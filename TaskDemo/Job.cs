namespace TaskDemo;

public class Job
{
    private readonly Action _work;
    private Job? _continue;

    public Job(Action work)=> _work=work;
    public JobStatus Status{get; internal set;}
    
    internal protected virtual void Invoke()
    {
        Status=JobStatus.Running;
        _work();
        Status=JobStatus.Completed;
        _continue?.Start();
    }

    public void Start(JobScheduler? scheduler=null)
        => (scheduler??JobScheduler.Current).QueueJob(this);

    public static Job Run(Action work)
    {
        var job=new Job(work);
        job.Start();
        return job;
    }

    public Job ContinueWith(Action<Job> tobeContinued){
        if(_continue==null){
            var job=new Job(()=>tobeContinued(this));
            _continue=job;
        }else{
            _continue.ContinueWith(tobeContinued);
        }
        return this;
    }
}

public enum JobStatus
{
    Created,
    Scheduled,
    Running,
    Completed
}