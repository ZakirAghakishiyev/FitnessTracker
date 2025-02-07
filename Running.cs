namespace FirnessTracker;

internal class Running : Activity
{

    public Running(string activityName, int duration):base(activityName, duration) 
    {
        CaloriesBurnedPerMinute = 10;
    }
    public override void CalculateCalories()
    {
        CaloriesBurned = Duration * CaloriesBurnedPerMinute;
        Console.WriteLine($"Running {ActivityName} burned {CaloriesBurned} calories in {Duration} minutes.");
    }

}
