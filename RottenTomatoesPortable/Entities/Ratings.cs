using Newtonsoft.Json;
using PropertyChanged;

namespace RottenTomatoesPortable.Entities
{
    [ImplementPropertyChanged]
    public class Ratings
    {
        [JsonProperty("critics_rating")]
        public string CriticsRating { get; set; }

        [JsonProperty("critics_score")]
        public int CriticsScore { get; set; }

        [JsonProperty("audience_rating")]
        public string AudienceRating { get; set; }

        [JsonProperty("audience_score")]
        public int AudienceScore { get; set; }
    }
}