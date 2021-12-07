using Pre.Podcast.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre.Podcast.Core.Arguments
{
    public class EpisodeEventArgs
    {
        public string Alert { get;}

        public EpisodeEventArgs(string alert)
        {
            this.Alert = alert;
        }
    }
}
