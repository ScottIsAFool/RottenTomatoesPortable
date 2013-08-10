using Newtonsoft.Json;
using PropertyChanged;

namespace RottenTomatoesPortable.Entities
{
    [ImplementPropertyChanged]
    public class SearchResponse
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("movies")]
        public Movie[] Movies { get; set; }
    }
}
