using System;
using Pre.Podcast.Core.Entities;
using Pre.Podcast.Core.Arguments;

namespace Pre.Podcast.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person person1 = new Person { Name = "Benny" };
            Person person2 = new Person { Name = "Jeffke" };
            Person person3 = new Person { Name = "Cindy" };
            Person person4 = new Person { Name = "Danny" };
            Person person5 = new Person { Name = "Eddy" };
            PodCast podcast = new PodCast("kittycat");


            Person.UpdatePerson += Print;

            podcast.AddSubscriber(person1);            
            podcast.AddEpisode(new Episode { Name = "Kitty fales" });
            podcast.AddSubscriber(person2);
            podcast.AddEpisode(new Episode { Name = "Kitty fales2" });
            podcast.AddSubscriber(person3);
            podcast.AddEpisode(new Episode { Name = "Kitty fales3" });
            podcast.AddSubscriber(person4);
            podcast.AddSubscriber(person5);
            podcast.AddEpisode(new Episode { Name = "Kitty fales4" });


        }


        private static void Print(object sender, EpisodeEventArgs e)
        {
            Console.WriteLine(e.Alert);
        }

    }
}
