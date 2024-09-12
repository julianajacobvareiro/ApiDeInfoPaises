using System.Text.Json.Serialization; 
namespace countryproj{ 

    public class Flags
    {
        [JsonPropertyName("png")]
        public string png { get; set; }

        [JsonPropertyName("svg")]
        public string svg { get; set; }

        [JsonPropertyName("alt")]
        public string alt { get; set; }
    }

}