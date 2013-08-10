using Newtonsoft.Json;
using PropertyChanged;

namespace RottenTomatoesPortable.Entities
{
    [ImplementPropertyChanged]
    public class ReleaseDates
    {
        [JsonProperty("theater")]
        public string Theater { get; set; }

        [JsonProperty("dvd")]
        public string Dvd { get; set; }
    }
}