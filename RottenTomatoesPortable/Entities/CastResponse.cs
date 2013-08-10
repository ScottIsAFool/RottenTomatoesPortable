using Newtonsoft.Json;

namespace RottenTomatoesPortable.Entities
{
    public class CastResponse
    {
        [JsonProperty("cast")]
        public Cast[] Cast { get; set; }
    }
}