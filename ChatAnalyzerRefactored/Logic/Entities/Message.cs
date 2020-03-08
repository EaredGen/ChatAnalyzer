using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAnalyzer.Logic
{
    class Message
    {
        public char owner;
        public TimeSpan time;

        public Message(char owner, TimeSpan time)
        {
            this.owner = owner;
            this.time = time;
        }
    }
}
