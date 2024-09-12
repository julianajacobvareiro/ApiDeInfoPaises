using System.Text.Json.Serialization; 
namespace countryproj{ 

    public class Translations
    {
        [JsonPropertyName("ara")]
        public Ara ara { get; set; }

        [JsonPropertyName("bre")]
        public Bre bre { get; set; }

        [JsonPropertyName("ces")]
        public Ces ces { get; set; }

        [JsonPropertyName("cym")]
        public Cym cym { get; set; }

        [JsonPropertyName("deu")]
        public Deu deu { get; set; }

        [JsonPropertyName("est")]
        public Est est { get; set; }

        [JsonPropertyName("fin")]
        public Fin fin { get; set; }

        [JsonPropertyName("fra")]
        public Fra fra { get; set; }

        [JsonPropertyName("hrv")]
        public Hrv hrv { get; set; }

        [JsonPropertyName("hun")]
        public Hun hun { get; set; }

        [JsonPropertyName("ita")]
        public Ita ita { get; set; }

        [JsonPropertyName("jpn")]
        public Jpn jpn { get; set; }

        [JsonPropertyName("kor")]
        public Kor kor { get; set; }

        [JsonPropertyName("nld")]
        public Nld nld { get; set; }

        [JsonPropertyName("per")]
        public Per per { get; set; }

        [JsonPropertyName("pol")]
        public Pol pol { get; set; }

        [JsonPropertyName("por")]
        public Por por { get; set; }

        [JsonPropertyName("rus")]
        public Rus rus { get; set; }

        [JsonPropertyName("slk")]
        public Slk slk { get; set; }

        [JsonPropertyName("spa")]
        public Spa spa { get; set; }

        [JsonPropertyName("srp")]
        public Srp srp { get; set; }

        [JsonPropertyName("swe")]
        public Swe swe { get; set; }

        [JsonPropertyName("tur")]
        public Tur tur { get; set; }

        [JsonPropertyName("urd")]
        public Urd urd { get; set; }

        [JsonPropertyName("zho")]
        public Zho zho { get; set; }
    }

}