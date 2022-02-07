using System;

namespace Shoniz.Framework.ApplicationService
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
