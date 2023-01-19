public class Resume 
{
    //Atributes
    public string _name;
    public List<Job> _jobs = new List<Job>();  

    //Constructor
    public Resume()
    {
    }

    // Methods
    public void displayResume()
    {
        Console.WriteLine($"Name: {_name}");
        
        foreach (Job job in _jobs)
        {
            job.DisplayJobTitle();
        }
    }

}