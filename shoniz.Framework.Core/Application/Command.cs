using System;

namespace shoniz.Framework.Core.Application
{
    public abstract class Command
    {
        public Command()
        {
            TimeStamp = DateTime.Now;
        }

        public DateTime TimeStamp { get; set; }
    }
}
