using System.Text.Json.Serialization; 
namespace countryproj{ 

    public class Demonyms
    {
        [JsonPropertyName("eng")]
        public Eng eng { get; set; }

        [JsonPropertyName("fra")]
        public Fra fra { get; set; }
    }

}