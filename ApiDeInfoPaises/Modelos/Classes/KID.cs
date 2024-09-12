using System.Text.Json.Serialization; 
namespace countryproj{ 

    public class KID
    {
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("symbol")]
        public string symbol { get; set; }
    }

}