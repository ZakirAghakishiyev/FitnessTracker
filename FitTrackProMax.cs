namespace FirnessTracker;

internal class FitTrackProMax : FitTrackBase
{
    public FitTrackProMax(string deviceName) : base(deviceName)
    {
        DeviceName = deviceName;
        BatteryLife = 72;
        TotalSteps = 0;
        Users = new string[7];
    }
    public override void TrackSteps(int steps)
    {
        if (0 < steps && steps < 200000)
        {
            TotalSteps += steps;
            Console.WriteLine($"Tracked {steps} steps. Total steps: {TotalSteps}.");
            return;
        }
        Console.WriteLine("Invalid number of steps. Please enter a value between 1 and 200,000.");
    }
}