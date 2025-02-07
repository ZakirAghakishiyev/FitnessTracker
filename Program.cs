namespace FirnessTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var test1 = new FitTrack("Sade Versiya");
            var run = new Running("Qacis", 30);
            var cycle = new Cycling("Velo", 60);
            test1.AddUser("Zakir");
            test1.AddUser("user1");
            test1.AddUser("user2");
            test1.AddUser("user3");

            test1.DeleteUser("user1");
            test1.DeleteUser("user1");
            test1.DeleteUser("user110");
            test1.AddUser("user3");

            test1.TrackSteps(1000);
            test1.TrackSteps(100000);

            test1.SetCurrentActivity(run);
            test1.PrintInfo();

            run.CalculateCalories();
            Console.WriteLine(new string('-', 50));

            var test2 = new FitTrackPro("Pro Versiya");
            test2.AddUser("Zakir");
            test2.AddUser("user1");
            test2.AddUser("user2");
            test2.AddUser("user3");

            test2.DeleteUser("user1");
            test2.DeleteUser("user1");
            test2.DeleteUser("user110");
            test2.AddUser("user3");

            test2.TrackSteps(1000);
            test2.TrackSteps(100000);

            test2.SetCurrentActivity(cycle);
            test2.PrintInfo();
            Console.WriteLine(new string('-', 50));
        }
    }
}
