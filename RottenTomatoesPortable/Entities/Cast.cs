using Newtonsoft.Json;
using PropertyChanged;

namespace RottenTomatoesPortable.Entities
{
    [ImplementPropertyChanged]
    public class Cast
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("characters")]
        public string[] Characters { get; set; }
    }
}