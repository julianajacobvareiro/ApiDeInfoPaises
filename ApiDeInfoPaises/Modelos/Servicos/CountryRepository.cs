using countryproj;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ApiDeInfoPaises.Modelos.Servicos
{
	public class CountryRepository
	{
		private readonly string _connectionString;
		
		public CountryRepository(string dbPath)
		{
			_connectionString = $"Data Source={dbPath};Version=3;";
			InitializeDatabase();
		}

		private void InitializeDatabase()
		{
			if (!File.Exists(_connectionString))
			{
				var dbFilePath = _connectionString.Split(';')[0].Replace("Data Source=", "");
				SQLiteConnection.CreateFile(dbFilePath);
			}

			using (var connection = new SQLiteConnection(_connectionString))
			{
				connection.Open();
				string sql = @"
                    CREATE TABLE IF NOT EXISTS Country (
                        Name TEXT,
                        Capital TEXT,
                        Region TEXT,
                        SubRegion TEXT,
                        Population INTEGER,
                        Gini REAL,
                        Languages TEXT,
                        Flag TEXT
                    )";


				using (var command = new SQLiteCommand(sql, connection))
				{
					command.ExecuteNonQuery();
				}
			}
		}

		public void SaveCountries(List<Root> countries)
		{
			using (var connection = new SQLiteConnection(_connectionString))
			{
				connection.Open();

				string deleteSql = "DELETE FROM Country"; // Limpa a tabela antes de inserir novos dados
				using (var deleteCommand = new SQLiteCommand(deleteSql, connection))
				{
					deleteCommand.ExecuteNonQuery();
				}

				foreach (var country in countries)
				{
					string sql = @"
                        INSERT INTO Country (Name, Capital, Region, SubRegion, Population, Gini, Languages, Flag) 
                        VALUES (@Name, @Capital, @Region, @SubRegion, @Population, @Gini, @Languages, @Flag)";

					using (var command = new SQLiteCommand(sql, connection))
					{
						command.Parameters.AddWithValue("@Name", country.name.common);
						command.Parameters.AddWithValue("@Capital", country.capital != null && country.capital.Count > 0 ? country.capital[0] : "N/A");
						command.Parameters.AddWithValue("@Region", country.region ?? "N/A");
						command.Parameters.AddWithValue("@SubRegion", country.subregion ?? "N/A");
						command.Parameters.AddWithValue("@Population", country.population ?? (object)DBNull.Value);
						command.Parameters.AddWithValue("@Gini", country.gini != null ? JsonConvert.SerializeObject(country.gini) : (object)DBNull.Value);
						command.Parameters.AddWithValue("@Languages", country.Languages != null ? JsonConvert.SerializeObject(country.Languages) : (object)DBNull.Value);
						command.Parameters.AddWithValue("@Flag", country.flags.png);
						command.ExecuteNonQuery();
					}
				}
			}
		}

		public List<Root> GetCountries()
		{
			var countries = new List<Root>();
			using (var connection = new SQLiteConnection(_connectionString))
			{
				connection.Open();
				string sql = "SELECT * FROM Country";
				using (var command = new SQLiteCommand(sql, connection))
				{
					using (var reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							
							var country = new Root
							{
									name = new Name { common = reader["Name"].ToString() },
									capital = reader["Capital"].ToString() == "N/A" ? null : new List<string> { reader["Capital"].ToString() },
									region = reader["Region"].ToString(),
									subregion = reader["SubRegion"].ToString(),
									population = reader["Population"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["Population"]),
									gini = reader["Gini"] == DBNull.Value ? null : JsonConvert.DeserializeObject<Dictionary<string, double>>(reader["Gini"].ToString()),
									Languages = reader["Languages"] == DBNull.Value ? null : JsonConvert.DeserializeObject<Dictionary<string, string>>(reader["Languages"].ToString()),
									flags = new Flags { png = reader["Flag"].ToString() }
							};
							countries.Add(country);
							
						}
					}
				}
			}
			return countries;
		}
				
	}
}

