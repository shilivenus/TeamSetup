using System.Collections.Generic;

namespace TeamSetup
{
    public class Teams
    {
        public Teams()
        {
            Team = new List<List<People>>();
        }
        public List<List<People>> Team { get; set; }
    }
}