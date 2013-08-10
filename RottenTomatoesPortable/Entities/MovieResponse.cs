using Newtonsoft.Json;

namespace RottenTomatoesPortable.Entities
{
    public class MovieResponse
    {
        [JsonProperty("movies")]
        public Movie[] Movies { get; set; }
    }
}