namespace ApiDeInfoPaises
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			cmbPaises = new ComboBox();
			lblPaises = new Label();
			lblCountryName = new Label();
			lblCapital = new Label();
			lblRegion = new Label();
			lblSubRegion = new Label();
			lblPopulation = new Label();
			lblGiniIndex = new Label();
			picFlag = new PictureBox();
			lblPais = new Label();
			lblCapitalPais = new Label();
			lblRegiao = new Label();
			lblSubRegiao = new Label();
			lblPopulacao = new Label();
			lblGini = new Label();
			dataGridViewCountries = new DataGridView();
			progressBar = new ProgressBar();
			lblLingua = new Label();
			lblLanguages = new Label();
			loadingLabel = new Label();
			TextTimer = new System.Windows.Forms.Timer(components);
			lblContinente = new Label();
			lblContinent = new Label();
			((System.ComponentModel.ISupportInitialize)picFlag).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridViewCountries).BeginInit();
			SuspendLayout();
			// 
			// cmbPaises
			// 
			cmbPaises.BackColor = Color.Wheat;
			cmbPaises.Font = new Font("Segoe UI", 10F);
			cmbPaises.FormattingEnabled = true;
			cmbPaises.Location = new Point(318, 70);
			cmbPaises.Margin = new Padding(4);
			cmbPaises.Name = "cmbPaises";
			cmbPaises.Size = new Size(641, 31);
			cmbPaises.TabIndex = 0;
			cmbPaises.SelectedIndexChanged += cmbPaises_SelectedIndexChanged;
			// 
			// lblPaises
			// 
			lblPaises.AutoSize = true;
			lblPaises.BackColor = Color.Transparent;
			lblPaises.Font = new Font("Papyrus", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblPaises.ForeColor = Color.DarkRed;
			lblPaises.Location = new Point(82, 70);
			lblPaises.Margin = new Padding(4, 0, 4, 0);
			lblPaises.Name = "lblPaises";
			lblPaises.Size = new Size(225, 38);
			lblPaises.TabIndex = 1;
			lblPaises.Text = "Selecione um País";
			// 
			// lblCountryName
			// 
			lblCountryName.BackColor = Color.Wheat;
			lblCountryName.BorderStyle = BorderStyle.Fixed3D;
			lblCountryName.Font = new Font("Segoe UI", 10F);
			lblCountryName.Location = new Point(195, 211);
			lblCountryName.Margin = new Padding(4, 0, 4, 0);
			lblCountryName.Name = "lblCountryName";
			lblCountryName.Size = new Size(376, 28);
			lblCountryName.TabIndex = 3;
			// 
			// lblCapital
			// 
			lblCapital.BackColor = Color.Wheat;
			lblCapital.BorderStyle = BorderStyle.Fixed3D;
			lblCapital.Font = new Font("Segoe UI", 10F);
			lblCapital.Location = new Point(195, 271);
			lblCapital.Margin = new Padding(4, 0, 4, 0);
			lblCapital.Name = "lblCapital";
			lblCapital.Size = new Size(376, 28);
			lblCapital.TabIndex = 4;
			// 
			// lblRegion
			// 
			lblRegion.BackColor = Color.Wheat;
			lblRegion.BorderStyle = BorderStyle.Fixed3D;
			lblRegion.Font = new Font("Segoe UI", 10F);
			lblRegion.Location = new Point(195, 331);
			lblRegion.Margin = new Padding(4, 0, 4, 0);
			lblRegion.Name = "lblRegion";
			lblRegion.Size = new Size(376, 30);
			lblRegion.TabIndex = 5;
			// 
			// lblSubRegion
			// 
			lblSubRegion.BackColor = Color.Wheat;
			lblSubRegion.BorderStyle = BorderStyle.Fixed3D;
			lblSubRegion.Font = new Font("Segoe UI", 10F);
			lblSubRegion.Location = new Point(195, 390);
			lblSubRegion.Margin = new Padding(4, 0, 4, 0);
			lblSubRegion.Name = "lblSubRegion";
			lblSubRegion.Size = new Size(376, 29);
			lblSubRegion.TabIndex = 6;
			// 
			// lblPopulation
			// 
			lblPopulation.BackColor = Color.Wheat;
			lblPopulation.BorderStyle = BorderStyle.Fixed3D;
			lblPopulation.Font = new Font("Segoe UI", 10F);
			lblPopulation.Location = new Point(195, 503);
			lblPopulation.Margin = new Padding(4, 0, 4, 0);
			lblPopulation.Name = "lblPopulation";
			lblPopulation.Size = new Size(376, 28);
			lblPopulation.TabIndex = 7;
			// 
			// lblGiniIndex
			// 
			lblGiniIndex.BackColor = Color.Wheat;
			lblGiniIndex.BorderStyle = BorderStyle.Fixed3D;
			lblGiniIndex.Font = new Font("Segoe UI", 10F);
			lblGiniIndex.Location = new Point(195, 624);
			lblGiniIndex.Margin = new Padding(4, 0, 4, 0);
			lblGiniIndex.Name = "lblGiniIndex";
			lblGiniIndex.Size = new Size(376, 27);
			lblGiniIndex.TabIndex = 8;
			// 
			// picFlag
			// 
			picFlag.BackColor = Color.Transparent;
			picFlag.BorderStyle = BorderStyle.Fixed3D;
			picFlag.Location = new Point(614, 169);
			picFlag.Margin = new Padding(4);
			picFlag.Name = "picFlag";
			picFlag.Size = new Size(319, 213);
			picFlag.SizeMode = PictureBoxSizeMode.AutoSize;
			picFlag.TabIndex = 9;
			picFlag.TabStop = false;
			// 
			// lblPais
			// 
			lblPais.AutoSize = true;
			lblPais.BackColor = Color.Transparent;
			lblPais.Font = new Font("Papyrus", 10.2F, FontStyle.Bold);
			lblPais.ForeColor = Color.DarkRed;
			lblPais.Location = new Point(79, 211);
			lblPais.Margin = new Padding(4, 0, 4, 0);
			lblPais.Name = "lblPais";
			lblPais.Size = new Size(47, 27);
			lblPais.TabIndex = 10;
			lblPais.Text = "País";
			// 
			// lblCapitalPais
			// 
			lblCapitalPais.AutoSize = true;
			lblCapitalPais.BackColor = Color.Transparent;
			lblCapitalPais.Font = new Font("Papyrus", 10.2F, FontStyle.Bold);
			lblCapitalPais.ForeColor = Color.DarkRed;
			lblCapitalPais.Location = new Point(77, 275);
			lblCapitalPais.Margin = new Padding(4, 0, 4, 0);
			lblCapitalPais.Name = "lblCapitalPais";
			lblCapitalPais.Size = new Size(75, 27);
			lblCapitalPais.TabIndex = 11;
			lblCapitalPais.Text = "Capital";
			// 
			// lblRegiao
			// 
			lblRegiao.AutoSize = true;
			lblRegiao.BackColor = Color.Transparent;
			lblRegiao.Font = new Font("Papyrus", 10.2F, FontStyle.Bold);
			lblRegiao.ForeColor = Color.DarkRed;
			lblRegiao.Location = new Point(79, 337);
			lblRegiao.Margin = new Padding(4, 0, 4, 0);
			lblRegiao.Name = "lblRegiao";
			lblRegiao.Size = new Size(71, 27);
			lblRegiao.TabIndex = 12;
			lblRegiao.Text = "Região";
			// 
			// lblSubRegiao
			// 
			lblSubRegiao.AutoSize = true;
			lblSubRegiao.BackColor = Color.Transparent;
			lblSubRegiao.Font = new Font("Papyrus", 10.2F, FontStyle.Bold);
			lblSubRegiao.ForeColor = Color.DarkRed;
			lblSubRegiao.Location = new Point(77, 395);
			lblSubRegiao.Margin = new Padding(4, 0, 4, 0);
			lblSubRegiao.Name = "lblSubRegiao";
			lblSubRegiao.Size = new Size(113, 27);
			lblSubRegiao.TabIndex = 13;
			lblSubRegiao.Text = "Sub Região";
			// 
			// lblPopulacao
			// 
			lblPopulacao.AutoSize = true;
			lblPopulacao.BackColor = Color.Transparent;
			lblPopulacao.Font = new Font("Papyrus", 10.2F, FontStyle.Bold);
			lblPopulacao.ForeColor = Color.DarkRed;
			lblPopulacao.Location = new Point(77, 506);
			lblPopulacao.Margin = new Padding(4, 0, 4, 0);
			lblPopulacao.Name = "lblPopulacao";
			lblPopulacao.Size = new Size(97, 27);
			lblPopulacao.TabIndex = 14;
			lblPopulacao.Text = "População";
			// 
			// lblGini
			// 
			lblGini.AutoSize = true;
			lblGini.BackColor = Color.Transparent;
			lblGini.Font = new Font("Papyrus", 10.2F, FontStyle.Bold);
			lblGini.ForeColor = Color.DarkRed;
			lblGini.Location = new Point(78, 627);
			lblGini.Margin = new Padding(4, 0, 4, 0);
			lblGini.Name = "lblGini";
			lblGini.Size = new Size(100, 27);
			lblGini.TabIndex = 15;
			lblGini.Text = "Índice Gini";
			// 
			// dataGridViewCountries
			// 
			dataGridViewCountries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
			dataGridViewCountries.BackgroundColor = Color.Wheat;
			dataGridViewCountries.BorderStyle = BorderStyle.Fixed3D;
			dataGridViewCountries.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = SystemColors.Control;
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
			dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dataGridViewCountries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dataGridViewCountries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.Wheat;
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			dataGridViewCountries.DefaultCellStyle = dataGridViewCellStyle2;
			dataGridViewCountries.Location = new Point(614, 424);
			dataGridViewCountries.Margin = new Padding(4);
			dataGridViewCountries.Name = "dataGridViewCountries";
			dataGridViewCountries.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCountries.RowHeadersWidth = 51;
			dataGridViewCountries.Size = new Size(1119, 228);
			dataGridViewCountries.TabIndex = 17;
			dataGridViewCountries.SelectionChanged += dataGridViewCountries_SelectionChanged;
			// 
			// progressBar
			// 
			progressBar.Location = new Point(1172, 351);
			progressBar.Margin = new Padding(4);
			progressBar.Name = "progressBar";
			progressBar.Size = new Size(249, 31);
			progressBar.TabIndex = 18;
			// 
			// lblLingua
			// 
			lblLingua.AutoSize = true;
			lblLingua.BackColor = Color.Transparent;
			lblLingua.Font = new Font("Papyrus", 10.2F, FontStyle.Bold);
			lblLingua.ForeColor = Color.DarkRed;
			lblLingua.Location = new Point(78, 569);
			lblLingua.Margin = new Padding(4, 0, 4, 0);
			lblLingua.Name = "lblLingua";
			lblLingua.Size = new Size(67, 27);
			lblLingua.TabIndex = 20;
			lblLingua.Text = "Lingua";
			// 
			// lblLanguages
			// 
			lblLanguages.BackColor = Color.Wheat;
			lblLanguages.BorderStyle = BorderStyle.Fixed3D;
			lblLanguages.Font = new Font("Segoe UI", 10F);
			lblLanguages.Location = new Point(195, 564);
			lblLanguages.Margin = new Padding(4, 0, 4, 0);
			lblLanguages.Name = "lblLanguages";
			lblLanguages.Size = new Size(376, 29);
			lblLanguages.TabIndex = 19;
			// 
			// loadingLabel
			// 
			loadingLabel.BackColor = Color.Transparent;
			loadingLabel.BorderStyle = BorderStyle.Fixed3D;
			loadingLabel.Font = new Font("Poor Richard", 14F, FontStyle.Bold);
			loadingLabel.ForeColor = Color.DarkRed;
			loadingLabel.Location = new Point(1443, 351);
			loadingLabel.Margin = new Padding(4, 0, 4, 0);
			loadingLabel.Name = "loadingLabel";
			loadingLabel.Size = new Size(114, 31);
			loadingLabel.TabIndex = 21;
			loadingLabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// TextTimer
			// 
			TextTimer.Tick += TextTimer_Tick;
			// 
			// lblContinente
			// 
			lblContinente.AutoSize = true;
			lblContinente.BackColor = Color.Transparent;
			lblContinente.Font = new Font("Papyrus", 10.2F, FontStyle.Bold);
			lblContinente.ForeColor = Color.DarkRed;
			lblContinente.Location = new Point(77, 448);
			lblContinente.Margin = new Padding(4, 0, 4, 0);
			lblContinente.Name = "lblContinente";
			lblContinente.Size = new Size(106, 27);
			lblContinente.TabIndex = 23;
			lblContinente.Text = "Continente";
			// 
			// lblContinent
			// 
			lblContinent.BackColor = Color.Wheat;
			lblContinent.BorderStyle = BorderStyle.Fixed3D;
			lblContinent.Font = new Font("Segoe UI", 10F);
			lblContinent.Location = new Point(195, 445);
			lblContinent.Margin = new Padding(4, 0, 4, 0);
			lblContinent.Name = "lblContinent";
			lblContinent.Size = new Size(376, 28);
			lblContinent.TabIndex = 22;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(11F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(1769, 700);
			Controls.Add(lblContinente);
			Controls.Add(lblContinent);
			Controls.Add(loadingLabel);
			Controls.Add(lblLingua);
			Controls.Add(lblLanguages);
			Controls.Add(progressBar);
			Controls.Add(dataGridViewCountries);
			Controls.Add(lblGini);
			Controls.Add(lblPopulacao);
			Controls.Add(lblSubRegiao);
			Controls.Add(lblRegiao);
			Controls.Add(lblCapitalPais);
			Controls.Add(lblPais);
			Controls.Add(picFlag);
			Controls.Add(lblGiniIndex);
			Controls.Add(lblPopulation);
			Controls.Add(lblSubRegion);
			Controls.Add(lblRegion);
			Controls.Add(lblCapital);
			Controls.Add(lblCountryName);
			Controls.Add(lblPaises);
			Controls.Add(cmbPaises);
			Font = new Font("Segoe UI", 12F);
			Margin = new Padding(4);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)picFlag).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridViewCountries).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox cmbPaises;
        private Label lblPaises;
        private Label lblCountryName;
        private Label lblCapital;
        private Label lblRegion;
        private Label lblSubRegion;
        private Label lblPopulation;
        private Label lblGiniIndex;
        private PictureBox picFlag;
        private Label lblPais;
        private Label lblCapitalPais;
        private Label lblRegiao;
        private Label lblSubRegiao;
        private Label lblPopulacao;
        private Label lblGini;
        private DataGridView dataGridViewCountries;
        private ProgressBar progressBar;
        private Label lblLingua;
        private Label lblLanguages;
		private Label loadingLabel;
		private System.Windows.Forms.Timer TextTimer;
		private Label lblContinente;
		private Label lblContinent;
	}
}
