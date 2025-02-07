using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirnessTracker;

internal abstract class FitTrackBase
{
    public string DeviceName { set; get; }
    public int BatteryLife { set; get; }
    public int TotalSteps { set; get; }
    public string[] Users { set; get; }
    public string[] DeletedUsers { set; get; } = new string[10];
    public Activity CurrentActivity { set; get; }
    int userCount = 0;

    public FitTrackBase(string deviceName)
    {
        DeviceName = deviceName;
        BatteryLife = 24;
        TotalSteps = 0;
        Users = new string[3];
    }

    public virtual void TrackSteps(int steps)
    {
        if (0 < steps && steps < 50000)
        {
            TotalSteps += steps;
            Console.WriteLine($"Tracked {steps} steps. Total steps: {TotalSteps}.");
            return;
        }
        Console.WriteLine("Invalid number of steps. Please enter a value between 1 and 50,000.");
    }

    public void AddUser(string user)
    {
        if (userCount < Users.Length)
        {
            Console.WriteLine($"User {user} has been added.");
            Users[userCount++] = user;
            return;
        }
        Console.WriteLine($"Cannot add more users. The limit of {Users.Length} users has been reached.");
    }
    public virtual void PrintInfo()
    {
        string activityToBePrinted = (CurrentActivity != null) ? $"current activity is {CurrentActivity.ActivityName}," : "";

        Console.WriteLine($"FitTrack Pro is called {DeviceName},{activityToBePrinted} it has {BatteryLife} hours of battery life, {TotalSteps} total steps, and {userCount} users.");
    }

    public void DeleteUser(string user)
    {
        for (int i = 0; i < Users.Length; i++)
        {
            if (Users[i] == user)
            {
                for (int j = 0; j < DeletedUsers.Length; j++)
                {
                    if (DeletedUsers[j] == null) DeletedUsers[j] = user;
                    break;
                }
                for (int j = i; j < Users.Length - 1; j++)
                {
                    Users[j] = Users[j + 1];
                }
                userCount--;
                Users[Users.Length-1] = "Undefined";
                Console.WriteLine($"{user} is deleted succesfully");
                return;
            }
            foreach (var deletedUser in DeletedUsers)
            {
                if (deletedUser == user)
                {
                    Console.WriteLine($"{user} has already been deleted");
                    return;
                }
            }
        }
        Console.WriteLine("No such user");

    }

    public void SetCurrentActivity(Activity activity)
    {
        CurrentActivity = activity;
    }
}

