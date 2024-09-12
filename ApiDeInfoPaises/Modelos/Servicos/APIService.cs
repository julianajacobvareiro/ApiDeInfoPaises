using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Newtonsoft.Json;
using System.Data.SQLite;
using countryproj;



namespace ApiDeInfoPaises.Modelos.Servicos
{
    public class APIService
    {
        private List<Root> root;
        private readonly CountryRepository _repository;

		public APIService(CountryRepository repository)
		{
			_repository = repository;
		}

		public async Task<List<Root>> FetchCountriesAsync()
		{
			using (var client = new HttpClient())
			{
				var response = await client.GetAsync("https://restcountries.com/v3.1/all");
				var responseBody = await response.Content.ReadAsStringAsync();
				var countries = JsonConvert.DeserializeObject<List<Root>>(responseBody);
				_repository.SaveCountries(countries);
				return countries;
			}
		}

		public List<Root> GetCountriesFromDatabase()
		{
			return _repository.GetCountries();
		}

		public async Task<Response> GetCountry(string urlBase, string controller)
        {
            try
            {
                var client = new HttpClient();

                client.BaseAddress = new Uri(urlBase);

                var response = await client.GetAsync(controller);

                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = result
                    };
                }

                var Paises = JsonConvert.DeserializeObject<List<Root>>(result);

                return new Response
                {
                    IsSuccess = true,
                    Result = Paises
                };
            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }

        }               
    }
}
