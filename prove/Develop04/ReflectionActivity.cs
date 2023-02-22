public class ReflectionActivity : Activity
{   
    // Attributes
    private List<string> questions;

    // Constructor
    public ReflectionActivity()
    {
        string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        string activityName = "Breathing Activity";
        base.SetActivity(activityName, description);
    }
}