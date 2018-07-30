using Observer.Business;
using Observer.Interfaces;
using System.Collections.Generic;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var jobSeeker = new JobSeeker("Martin");
            var jobSeekers = new List<IObserver>
            {
                new JobSeeker("Tim"),
                new JobSeeker("Angela"),
                new JobSeeker("Jeff"),
            };

            var headHunter = new HeadHunter();

            headHunter.RegisterObserver(jobSeeker);
            headHunter.RegisterObservers(jobSeekers);

            headHunter.ShowUsers();
            headHunter.AddJob("Google job");
            headHunter.RemoveObserver(jobSeeker);
            headHunter.AddJob("Microsoft job");
        }
    }
}
