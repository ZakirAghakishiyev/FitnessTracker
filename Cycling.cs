namespace FirnessTracker;

internal class Cycling : Activity
{

    public Cycling(string activityName, int duration) : base(activityName, duration)
    {
        CaloriesBurnedPerMinute = 8;
    }
    public override void CalculateCalories()
    {
        CaloriesBurned = Duration * CaloriesBurnedPerMinute;
        Console.WriteLine($"Running {ActivityName} burned {CaloriesBurned} calories in {Duration} minutes.");
    }

}