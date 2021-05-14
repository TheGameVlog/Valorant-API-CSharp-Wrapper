using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantAPIWrapper
{
    public class Level
    {
        public string uuid { get; set; }
        public int charmLevel { get; set; }
        public string displayName { get; set; }
        public string displayIcon { get; set; }
        public string assetPath { get; set; }
    }

    public class Buddy
    {
        public string uuid { get; set; }
        public string displayName { get; set; }
        public bool isHiddenIfNotOwned { get; set; }
        public string themeUuid { get; set; }
        public string displayIcon { get; set; }
        public string assetPath { get; set; }
        public List<Level> levels { get; set; }
    }

    public class AllBuddies
    {
        public int status { get; set; }
        public List<Buddy> data { get; set; }
    }

    public class SingleBuddy
    {
        public int status { get; set; }
        public Buddy data { get; set; }
    }

}
