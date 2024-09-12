using System.Text.Json.Serialization; 
using System.Collections.Generic; 
namespace countryproj{ 

    public class Car
    {
        [JsonPropertyName("signs")]
        public List<string> signs { get; set; }

        [JsonPropertyName("side")]
        public string side { get; set; }
    }

}