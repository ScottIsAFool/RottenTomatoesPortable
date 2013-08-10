using Newtonsoft.Json;
using PropertyChanged;

namespace RottenTomatoesPortable.Entities
{
    [ImplementPropertyChanged]
    public class ClipsResponse
    {
        [JsonProperty("clips")]
        public Clip[] Clips { get; set; }
    }

}
