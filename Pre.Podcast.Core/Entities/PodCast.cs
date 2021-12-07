using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pre.Podcast.Core.Arguments;
using Pre.Podcast.Core.Interfaces;

namespace Pre.Podcast.Core.Entities
{
    
    public class PodCast : ISubject    {
       
        public string Title { get; }
        public List<Episode> Episodes { get;}
        public List<ISubsciber> Subscibers { get;}

        public PodCast(string title)
        {
            Title = title;
            Episodes = new List<Episode>();
            Subscibers = new List<ISubsciber>();
        }
        public PodCast(string title, List<Person>persons):this(title)
        {            
            Subscibers.AddRange(persons);
        }
        public void AddSubscriber(ISubsciber subject)
        {
            if (subject != null) Subscibers.Add(subject);
        }

        public void AddEpisode(Episode episode)
        {
            if (episode != null) Episodes.Add(episode);
            Notify(episode);           

        }

        public void Notify()
        {
            Subscibers.ForEach(person => person.Update(this, Episodes.Last()));            
        }

        public void Notify(Episode episode)
        {
            Subscibers.ForEach(person => person.Update(this, episode));
        }

        public void RemoveSubscriber(ISubject subject)
        {
            throw new NotImplementedException();
        }
    }
}
