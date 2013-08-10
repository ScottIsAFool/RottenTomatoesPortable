using Newtonsoft.Json;
using PropertyChanged;

namespace RottenTomatoesPortable.Entities
{
    [ImplementPropertyChanged]
    public class Posters
    {
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("profile")]
        public string Profile { get; set; }

        [JsonProperty("detailed")]
        public string Detailed { get; set; }

        [JsonProperty("original")]
        public string Original { get; set; }
    }
}