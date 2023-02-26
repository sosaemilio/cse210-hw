public class Log
{
    //Attributes
    private string filename;

    //Constructor
    public Log()
    {
        filename = "activity.log";
    }

    //Methods
    public void SaveLog(string activityName)
    {
        DateTime today = DateTime.Now;
        File.AppendAllText(filename, $"[{today}] - {activityName}" + Environment.NewLine);
    }

    public int GetLogsInteger()
    {
        int totalLogs = 0;
        try 
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            totalLogs = lines.Count();
        } 
        catch (FileNotFoundException e)
        {
            Console.WriteLine($"File not found! ERROR: {e.Message}");
        }
        return totalLogs;
    }
}