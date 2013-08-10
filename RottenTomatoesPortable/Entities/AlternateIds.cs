using Newtonsoft.Json;
using PropertyChanged;

namespace RottenTomatoesPortable.Entities
{
    [ImplementPropertyChanged]
    public class AlternateIds
    {
        [JsonProperty("imdb")]
        public string Imdb { get; set; }
    }
}