using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pre.Podcast.Core.Entities;

namespace Pre.Podcast.Core.Interfaces
{
    public interface ISubsciber
    {
        public void Update(ISubject subject, Episode episode);
    }
}
