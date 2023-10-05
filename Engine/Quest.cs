using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    internal class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
    }
}
