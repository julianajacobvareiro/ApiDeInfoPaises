using ApiDeInfoPaises.Modelos.Servicos; 
using countryproj;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Linq;

namespace ApiDeInfoPaises
{
	public partial class Form1 : Form
	{
		private List<Root> root;
		private APIService apiService;
		private DialogService dialogService;
		private NetworkService networkService;
		private CountryRepository countryRepository;
		private DataGridViewRow previousSelectedRow;

		private System.Windows.Forms.Timer textTimer; // Especifica o Timer do Windows Forms
		private string loadingText = "Loading..."; // Texto a ser exibido
		private int currentLetterIndex = 0; // �ndice da letra atual

		public Form1()
		{
			InitializeComponent();

			string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "database.db");
			countryRepository = new CountryRepository(dbPath);

			apiService = new APIService(countryRepository);
			dialogService = new DialogService();
			networkService = new NetworkService();

			InitializeDataGridView();
			LoadCountries();

			cmbPaises.SelectedIndexChanged += cmbPaises_SelectedIndexChanged;

			// Inicializa��o do Timer
			textTimer = new System.Windows.Forms.Timer();
			textTimer.Interval = 300; // Define o intervalo em milissegundos (300ms)
			textTimer.Tick += TextTimer_Tick; // Associa o evento Tick

		}

		private string GetContinentsAsString(List<string> continents)
		{
			return string.Join(", ", continents); // Junta os continentes em uma string
		}


		private void InitializeDataGridView()
		{
			dataGridViewCountries.AutoGenerateColumns = false;

			dataGridViewCountries.Columns.Add(new DataGridViewTextBoxColumn
			{
				DataPropertyName = "name",
				HeaderText = "Nome"
			});

			dataGridViewCountries.Columns.Add(new DataGridViewTextBoxColumn
			{
				DataPropertyName = "capitalString",
				HeaderText = "Capital"
			});

			dataGridViewCountries.Columns.Add(new DataGridViewTextBoxColumn
			{
				DataPropertyName = "region",
				HeaderText = "Regi�o"
			});

			dataGridViewCountries.Columns.Add(new DataGridViewTextBoxColumn
			{
				DataPropertyName = "SubRegionString",
				HeaderText = "Sub-Regi�o"
			});

			dataGridViewCountries.Columns.Add(new DataGridViewTextBoxColumn
			{
				DataPropertyName = "ContinentsString", // Coluna para continentes
				HeaderText = "Continente"
			});

			dataGridViewCountries.Columns.Add(new DataGridViewTextBoxColumn
			{
				DataPropertyName = "population",
				HeaderText = "Popula��o"
			});

			dataGridViewCountries.Columns.Add(new DataGridViewTextBoxColumn
			{
				DataPropertyName = "giniString",
				HeaderText = "�ndice Gini"
			});

			dataGridViewCountries.Columns.Add(new DataGridViewTextBoxColumn
			{
				DataPropertyName = "LanguagesString",
				HeaderText = "L�nguas"
			});

			dataGridViewCountries.Columns.Add(new DataGridViewImageColumn
			{
				DataPropertyName = "flagImage",
				HeaderText = "Bandeira",
				ImageLayout = DataGridViewImageCellLayout.Zoom
			});
		}


		private async void LoadCountries()
		{
			ShowLoading();
			progressBar.Minimum = 0;
			progressBar.Maximum = 100;
			progressBar.Value = 0;
			progressBar.Visible = true;

			// Inicie o Timer ao come�ar o carregamento
			TextTimer.Start();
			loadingLabel.Text = ""; // Limpa o texto inicial
			currentLetterIndex = 0; // Reinicia o �ndice

			try
			{
				if (networkService.CheckInternetConnection())
				{
					// Usa IProgress para atualizar a ProgressBar
					var progress = new Progress<int>(ReportProgress);

					// Carrega os pa�ses da API
					root = await apiService.FetchCountriesAsync();

					// Salva os pa�ses no banco de dados
					countryRepository.SaveCountries(root);

					// Adiciona uma verifica��o para garantir que os continentes sejam atribu�dos corretamente
					foreach (var country in root)
					{
						// Aqui, o ContinentsString deve ser populado corretamente
						country.continentsString = string.Join(", ", country.continents);
					}


					// Ordena os pa�ses por nome em ordem alfab�tica
					root = root.OrderBy(c => c.name.common).ToList(); // Ordena��o

					// Carrega bandeiras
					for (int i = 0; i < root.Count; i++)
					{
						await Task.Run(() => LoadFlags(root[i], progress, i + 1, root.Count)); // Passa o �ndice atual e o total
					}

					dataGridViewCountries.DataSource = root;
					cmbPaises.DataSource = root;
					cmbPaises.DisplayMember = "name.common";

				}
				else
				{
					root = countryRepository.GetCountries(); // Carrega dados do banco de dados local

					// Ordena os pa�ses por nome em ordem alfab�tica
					root = root.OrderBy(c => c.name.common).ToList(); // Ordena��o

					dataGridViewCountries.DataSource = root;
					cmbPaises.DataSource = root;
					cmbPaises.DisplayMember = "name.common";
				}
			}
			catch (Exception ex)
			{
				dialogService.ShowDialog("Erro", "Erro ao carregar pa�ses: " + ex.Message);
			}
			finally
			{
				progressBar.Visible = false;
				HideLoading();

				textTimer.Stop(); // Para o Timer ap�s carregar
				loadingLabel.Text = "Loading..."; // Exibe o texto completo ap�s o carregamento

			}
		}

		private void LoadFlags(Root country, IProgress<int> progress, int currentIndex, int total)
		{
			// Carrega a bandeira do pa�s
			country.flagImage = LoadImageFromUrl(country.flags.png);


			if (progressBar != null)
			{
				int percentage = (currentIndex * 100) / total; // Calcula a porcentagem
				progress.Report(percentage); // Relata progresso
			}

		}

		private void ShowLoading()
		{
			loadingLabel.Visible = true; 
			loadingLabel.Text = ""; // Limpa o texto
			currentLetterIndex = 0; // Reseta o �ndice da letra
			TextTimer.Start(); // Inicia o Timer

		}

		private void HideLoading()
		{
			loadingLabel.Visible = false;
			TextTimer.Stop(); // Para o Timer
			loadingLabel.Text = ""; // Limpa o texto da label
		}


		private void ReportProgress(int value)
		{

			if (InvokeRequired)
			{
				Invoke(new Action<int>(ReportProgress), value);
				return;
			}

			progressBar.Value = value;
		}


		private void dataGridViewCountries_SelectionChanged(object sender, EventArgs e)
		{
			if (dataGridViewCountries.CurrentRow == null) return;

			var selectedCountry = (Root)dataGridViewCountries.CurrentRow.DataBoundItem;

			lblCountryName.Text = selectedCountry.name.common;
			lblCapital.Text = selectedCountry.capital != null && selectedCountry.capital.Count > 0 ? selectedCountry.capital[0] : "N/A";
			lblRegion.Text = selectedCountry.region ?? "N/A";
			lblSubRegion.Text = selectedCountry.subregion ?? "N/A";
			lblPopulation.Text = selectedCountry.population.ToString();
			lblContinent.Text = selectedCountry.ContinentsString.ToString();
			lblGiniIndex.Text = selectedCountry.GiniString ?? "N/A";
			lblLanguages.Text = selectedCountry.LanguagesString ?? "N/A";
			picFlag.Image = selectedCountry.flags != null ? LoadImageFromUrl(selectedCountry.flags.png) : Image.FromFile("static/img/no-flag.png");
		}


		private Image LoadImageFromUrl(string url)
		{
			try
			{
				using (var client = new WebClient())
				{
					using (var stream = client.OpenRead(url))
					{
						return Image.FromStream(stream);
					}
				}
			}
			catch
			{
				return Image.FromFile("static/img/no-flag.png");
			}
		}

		private void cmbPaises_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selectedCountry = (Root)cmbPaises.SelectedItem;

			if (previousSelectedRow != null)
			{
				previousSelectedRow.DefaultCellStyle.BackColor = dataGridViewCountries.DefaultCellStyle.BackColor;
			}

			// Encontra a linha correspondente na DataGridView
			foreach (DataGridViewRow row in dataGridViewCountries.Rows)
			{
				var country = (Root)row.DataBoundItem;
				if (country != null && country.name.common == selectedCountry.name.common)
				{
					row.DefaultCellStyle.BackColor = Color.DarkSeaGreen; //Muda a cor da linha quando um pa�s � selecionado
					previousSelectedRow = row;
					break;
				}
			}
		}

		
		private void TextTimer_Tick(object sender, EventArgs e)
		{
			if (currentLetterIndex < loadingText.Length)
			{
				loadingLabel.Text += loadingText[currentLetterIndex]; // Adiciona a pr�xima letra
				currentLetterIndex++; // Move para a pr�xima letra
			}
			else
			{
				// Quando o texto completo � exibido, reinicia o �ndice e limpa a label
				currentLetterIndex = 0; // Reinicia para o come�o
				loadingLabel.Text = ""; // Limpa a label para recome�ar o efeito
			}
		}
	}
}
