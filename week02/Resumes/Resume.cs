public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine(_name);
        Console.WriteLine();
        Console.WriteLine("Work history:");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}