using Newtonsoft.Json;
using PropertyChanged;

namespace RottenTomatoesPortable.Entities
{
    [ImplementPropertyChanged]
    public class Cast
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("characters")]
        public string[] Characters { get; set; }
    }
}