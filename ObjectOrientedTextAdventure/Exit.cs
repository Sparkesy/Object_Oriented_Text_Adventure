using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedTextAdventure
{
    public class Exit
    {
        private string Description;
        private Room Destination;
        private bool locked;
        private items unlockedwith;
        private string ExitShortName;
        private string LockedReason;

        public string ExitDescription { get { return Description; } set { Description = value; } }
        public Room ExitDestination { get { return Destination; } set { Destination = value; } }
        public bool islocked { get { return locked; } set {locked = value; } }
        public items ExitUnlockedwith { get { return unlockedwith; } set { unlockedwith = value; } }
        public string ExtShortName { get { return ExitShortName; } set { ExitShortName = value; } } 
        public string ExitLockedReason { get { return LockedReason; } set { LockedReason = value; } }
    }
}
