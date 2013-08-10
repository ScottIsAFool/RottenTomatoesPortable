using Newtonsoft.Json;
using PropertyChanged;

namespace RottenTomatoesPortable.Entities
{
    [ImplementPropertyChanged]
    public class Links
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("alternate")]
        public string Alternate { get; set; }

        [JsonProperty("cast")]
        public string Cast { get; set; }

        [JsonProperty("clips")]
        public string Clips { get; set; }

        [JsonProperty("reviews")]
        public string Reviews { get; set; }

        [JsonProperty("similar")]
        public string Similar { get; set; }
    }
}