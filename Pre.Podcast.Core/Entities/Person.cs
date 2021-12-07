using Pre.Podcast.Core.Interfaces;
using Pre.Podcast.Core.Arguments;
using System;

namespace Pre.Podcast.Core.Entities
{
    public delegate void UpdateHandler(object sender, EpisodeEventArgs e);
    public class Person : ISubsciber
    {
        public static event UpdateHandler UpdatePerson;
        public string Name { get; set; }
        public void Update(ISubject subject, Episode episode)
        {    
            SendMessage(episode);            
        }

        private void SendMessage(Episode episode)
        {            
            string updatestring = "A error hase accured";
            updatestring = $"There is a new episode out({episode.Name}) for {Name}" ;
            UpdatePerson?.Invoke(this, new EpisodeEventArgs(updatestring));
        }
    }
}



 