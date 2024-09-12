using System.Text.Json.Serialization; 
namespace countryproj{ 

    public class Maps
    {
        [JsonPropertyName("googleMaps")]
        public string googleMaps { get; set; }

        [JsonPropertyName("openStreetMaps")]
        public string openStreetMaps { get; set; }
    }

}