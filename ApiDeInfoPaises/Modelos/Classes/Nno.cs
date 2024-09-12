using System.Text.Json.Serialization; 
namespace countryproj{ 

    public class Nno
    {
        [JsonPropertyName("official")]
        public string official { get; set; }

        [JsonPropertyName("common")]
        public string common { get; set; }
    }

}