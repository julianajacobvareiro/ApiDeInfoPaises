using System.Text.Json.Serialization; 
namespace countryproj{ 

    public class Name
    {
        [JsonPropertyName("common")]
        public string common { get; set; }

        [JsonPropertyName("official")]
        public string official { get; set; }

        [JsonPropertyName("nativeName")]
        public NativeName nativeName { get; set; }


        public override string ToString()
        {
            return $"{common}";
        }
    }

}