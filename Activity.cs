using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirnessTracker;

internal abstract class Activity
{
    protected Activity(string activityName, int duration)
    {
        ActivityName = activityName;
        Duration = duration;

    }

    public string ActivityName { get; set; }
    public int Duration { get; set; }
    public int CaloriesBurned { get; set; }
    public int CaloriesBurnedPerMinute { get; set; }

    public abstract void CalculateCalories();
}
