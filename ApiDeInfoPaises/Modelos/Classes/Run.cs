using System.Text.Json.Serialization; 
namespace countryproj{ 

    public class Run
    {
        [JsonPropertyName("official")]
        public string official { get; set; }

        [JsonPropertyName("common")]
        public string common { get; set; }
    }

}