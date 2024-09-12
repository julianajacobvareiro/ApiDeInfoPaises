using System.Text.Json.Serialization; 
using System.Collections.Generic; 
namespace countryproj{ 

    public class Root
    {
        [JsonPropertyName("name")]
        public Name name { get; set; }

        [JsonPropertyName("tld")]
        public List<string> tld { get; set; }

        [JsonPropertyName("cca2")]
        public string cca2 { get; set; }

        [JsonPropertyName("ccn3")]
        public string ccn3 { get; set; }

        [JsonPropertyName("cca3")]
        public string cca3 { get; set; }

        [JsonPropertyName("independent")]
        public bool? independent { get; set; }

        [JsonPropertyName("status")]
        public string status { get; set; }

        [JsonPropertyName("unMember")]
        public bool? unMember { get; set; }

        [JsonPropertyName("currencies")]
        public Currencies currencies { get; set; }

        [JsonPropertyName("idd")]
        public Idd idd { get; set; }

        [JsonPropertyName("capital")]
        public List<string> capital { get; set; }

        [JsonPropertyName("altSpellings")]
        public List<string> altSpellings { get; set; }

        [JsonPropertyName("region")]
        public string region { get; set; }

        [JsonPropertyName("subregion")]
        public string subregion { get; set; }

        //[JsonPropertyName("languages")]
        //public Languages languages { get; set; }

        [JsonPropertyName("translations")]
        public Translations translations { get; set; }

        [JsonPropertyName("latlng")]
        public List<double?> latlng { get; set; }

        [JsonPropertyName("landlocked")]
        public bool? landlocked { get; set; }

        [JsonPropertyName("area")]
        public double? area { get; set; }

        [JsonPropertyName("demonyms")]
        public Demonyms demonyms { get; set; }

        [JsonPropertyName("flag")]
        public string flag { get; set; }

        [JsonPropertyName("maps")]
        public Maps maps { get; set; }

        [JsonPropertyName("population")]
        public int? population { get; set; }

        [JsonPropertyName("car")]
        public Car car { get; set; }

        [JsonPropertyName("timezones")]
        public List<string> timezones { get; set; }

        [JsonPropertyName("continents")]
        public List<string> continents { get; set; }

        [JsonPropertyName("flags")]
        public Flags flags { get; set; }

        [JsonPropertyName("coatOfArms")]
        public CoatOfArms coatOfArms { get; set; }

        [JsonPropertyName("startOfWeek")]
        public string startOfWeek { get; set; }

        [JsonPropertyName("capitalInfo")]
        public CapitalInfo capitalInfo { get; set; }

        [JsonPropertyName("postalCode")]
        public PostalCode postalCode { get; set; }

        [JsonPropertyName("cioc")]
        public string cioc { get; set; }

        //[JsonPropertyName("gini")]
        //public Gini gini { get; set; }

        [JsonPropertyName("fifa")]
        public string fifa { get; set; }

        [JsonPropertyName("borders")]
        public List<string> borders { get; set; }


        [JsonPropertyName("gini")]
        public Dictionary<string, double> gini { get; set; }

        [JsonPropertyName("languages")]
        public Dictionary<string, string> Languages { get; set; }





		public string continentsString { get; set; }




		[JsonIgnore] 
		public Image flagImage { get; set; } 




		[JsonIgnore]
        public string GiniString
        {
            get
            {
                if (gini != null && gini.Count > 0)
                {
                    return string.Join(", ", gini.Select(g => $"{g.Key}: {g.Value}"));
                }
                return "N/A";
            }
        }


        [JsonIgnore]
        public string CapitalString
        {
            get
            {
                return capital != null && capital.Count > 0 ? capital[0] : "N/A";
            }
        }




        [JsonIgnore]
        public string LanguagesString
        {
            get
            {
                if (Languages != null && Languages.Count > 0)
                {
                    return string.Join(", ", Languages.Values);
                }
                return "N/A";
            }
        }



		// Propriedade para exibir os continentes como string
		public string ContinentsString => string.Join(", ", continents);



		// Nova propriedade para exibir a sub-região como string
		[JsonIgnore]
		public string SubRegionString
		{
			get
			{
				return subregion ?? "N/A"; // Retorna "N/A" se subregion for null
			}
		}


		public override string ToString()
        {
            return $"{name}";
        }
    }

}