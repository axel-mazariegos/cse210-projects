public class Resume
{
    // The C# convention is to start member variables with an underscore _
    public string _name = "";
    public List<Job> _jobs;

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public Resume()
    {
    }

    // A method that displays the job information.
    public void Display()
    {
        Console.WriteLine("");
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs:");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
        Console.WriteLine("");

    }
}