using Newtonsoft.Json;

namespace RottenTomatoesPortable.Entities
{
    public class Review
    {
        [JsonProperty("critic")]
        public string Critic { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("freshness")]
        public Freshness Freshness { get; set; }

        [JsonProperty("publication")]
        public string Publication { get; set; }

        [JsonProperty("quote")]
        public string Quote { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }

        [JsonProperty("original_score")]
        public string OriginalScore { get; set; }
    }
}