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
            test2.AddUser("user4");
            test2.AddUser("user5");

            test2.DeleteUser("user1");
            test2.DeleteUser("user1");
            test2.DeleteUser("user110");
            test2.AddUser("user5");

            test2.TrackSteps(1000);
            test2.TrackSteps(100000);

            test2.SetCurrentActivity(cycle);
            test2.PrintInfo();
            Console.WriteLine(new string('-', 50));

            var test3 = new FitTrackProMax("Pro Versiya");
            test3.AddUser("Zakir");
            test3.AddUser("user1");
            test3.AddUser("user2");
            test3.AddUser("user3");
            test3.AddUser("user4");
            test3.AddUser("user5");
            test3.AddUser("user6");
            test3.AddUser("user7");

            test3.DeleteUser("user1");
            test3.DeleteUser("user1");
            test3.DeleteUser("user110");
            test3.AddUser("user7");
            test3.AddUser("user7");

            test3.TrackSteps(1000);
            test3.TrackSteps(100000);
            test3.TrackSteps(200000);

            test3.SetCurrentActivity(cycle);
            test3.PrintInfo();
            Console.WriteLine(new string('-', 50));
        }
    }
}
