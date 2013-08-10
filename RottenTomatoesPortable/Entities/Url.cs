using Newtonsoft.Json;

namespace RottenTomatoesPortable.Entities
{
    public class Url
    {
        [JsonProperty("review")]
        public string Review { get; set; }
    }
}