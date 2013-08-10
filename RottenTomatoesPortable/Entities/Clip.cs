using Newtonsoft.Json;
using PropertyChanged;

namespace RottenTomatoesPortable.Entities
{
    [ImplementPropertyChanged]
    public class Clip
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }
    }
}