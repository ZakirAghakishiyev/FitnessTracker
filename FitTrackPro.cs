namespace FirnessTracker;

internal class FitTrackPro: FitTrack
{
    public FitTrackPro(string deviceName) : base(deviceName)
    {
        DeviceName= deviceName;
        BatteryLife = 48;
        TotalSteps = 0;
        Users = new string[5];
    }
    public override void TrackSteps(int steps)
    {
        if (0 < steps && steps < 100000)
        {
            TotalSteps += steps;
            Console.WriteLine($"Tracked {steps} steps. Total steps: {TotalSteps}.");
            return;
        }
        Console.WriteLine("Invalid number of steps. Please enter a value between 1 and 100,000.");
    }
}
