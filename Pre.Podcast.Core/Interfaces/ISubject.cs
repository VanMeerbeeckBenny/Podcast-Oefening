using Pre.Podcast.Core.Entities;

namespace Pre.Podcast.Core.Interfaces
{
    public interface ISubject
    {
        public void AddSubscriber(ISubsciber subject);
        public void RemoveSubscriber(ISubject subject);
        public void Notify();
        public void Notify(Episode epsiode);
    }
}