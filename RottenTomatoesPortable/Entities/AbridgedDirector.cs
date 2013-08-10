using Newtonsoft.Json;
using PropertyChanged;

namespace RottenTomatoesPortable.Entities
{
    [ImplementPropertyChanged]
    public class Director
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}