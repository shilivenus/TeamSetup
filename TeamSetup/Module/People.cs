using Newtonsoft.Json;

namespace TeamSetup
{
    public class People
    {
        public People(string name, int rank)
        {
            Name = name;
            Rank = rank;
        }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }
    }
}