using System.Collections.Generic;

namespace Days.Shared
{
    class Bot
    {

        public Bot(int botID)
        {
            this.ID = botID;
        }

        public int ID { get; set; }

        public Bot LowBot { get; set; }

        public Bot HighBot { get; set; }

        public List<int> Chips { get; set; } = new List<int>();
    }
}
