using System.Text.Json.Serialization; 
namespace countryproj{ 

    public class Zdj
    {
        [JsonPropertyName("official")]
        public string official { get; set; }

        [JsonPropertyName("common")]
        public string common { get; set; }
    }

}