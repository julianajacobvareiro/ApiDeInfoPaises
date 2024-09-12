using System.Text.Json.Serialization; 
namespace countryproj{ 

    public class Eng
    {
        [JsonPropertyName("official")]
        public string official { get; set; }

        [JsonPropertyName("common")]
        public string common { get; set; }

        [JsonPropertyName("f")]
        public string f { get; set; }

        [JsonPropertyName("m")]
        public string m { get; set; }
    }

}