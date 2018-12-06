namespace FatturazioneElettronica.IPA
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    /// response: L’iPA mette a disposizione del pubblico una serie di informazioni che gli Enti in esso accreditati sono tenuti a pubblicare. Per ciascun Ente possono essere definite: una struttura di Unità Organizzative e un insieme di Aree Organizzative Omogenee, a ciascuna delle quali possono essere associati una serie di servizi.  Questo servizio web consente di estrarre dall’ iPA informazioni relativa ad un Ente specifico. 
    /// </summary>
    public partial class Ws05 : WsJson
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public DataWs05 Data { get; set; }

        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public Result Result { get; set; }
    }

    public partial class DataWs05
    {
        /// <summary>
        /// Acronimo dell'Ente
        /// </summary>
        [JsonProperty("acronimo", NullValueHandling = NullValueHandling.Ignore)]
        public string Acronimo { get; set; }

        /// <summary>
        /// Cap registrato in IPA per la sede legale dell'Ente
        /// </summary>
        [JsonProperty("cap", NullValueHandling = NullValueHandling.Ignore)]
        public string Cap { get; set; }

        /// <summary>
        /// Categoria dell'Ente in IPA
        /// </summary>
        [JsonProperty("categoria", NullValueHandling = NullValueHandling.Ignore)]
        public string Categoria { get; set; }

        /// <summary>
        /// Codice fiscale dell'Ente
        /// </summary>
        [JsonProperty("cf", NullValueHandling = NullValueHandling.Ignore)]
        public string Cf { get; set; }

        /// <summary>
        /// Codice Ente accreditato in IPA
        /// </summary>
        [JsonProperty("cod_amm")]
        public string CodAmm { get; set; }

        /// <summary>
        /// Cognome del responsabile dell'Ente
        /// </summary>
        [JsonProperty("cogn_resp", NullValueHandling = NullValueHandling.Ignore)]
        public string CognResp { get; set; }

        /// <summary>
        /// Comune registrato in IPA per la sede legale dell'Ente
        /// </summary>
        [JsonProperty("comune", NullValueHandling = NullValueHandling.Ignore)]
        public string Comune { get; set; }

        /// <summary>
        /// Data di accreditamento dell'Ente
        /// </summary>
        [JsonProperty("data_accreditamento", NullValueHandling = NullValueHandling.Ignore)]
        public string DataAccreditamento { get; set; }

        /// <summary>
        /// Denominazione Ente accreditato in IPA
        /// </summary>
        [JsonProperty("des_amm", NullValueHandling = NullValueHandling.Ignore)]
        public string DesAmm { get; set; }

        /// <summary>
        /// Indirizzo postale registrato in IPA per la sede legale dell'Ente
        /// </summary>
        [JsonProperty("indirizzo", NullValueHandling = NullValueHandling.Ignore)]
        public string Indirizzo { get; set; }

        /// <summary>
        /// livello di accessibilità del sito dell'Ente
        /// </summary>
        [JsonProperty("liv_accessibili", NullValueHandling = NullValueHandling.Ignore)]
        public double? LivAccessibili { get; set; }

        /// <summary>
        /// Indirizzo email primario associato all’Ente di tipo PEC|CECPAC
        /// </summary>
        [JsonProperty("mail1", NullValueHandling = NullValueHandling.Ignore)]
        public string Mail1 { get; set; }

        /// <summary>
        /// Indirizzo email associato all’Ente
        /// </summary>
        [JsonProperty("mail2", NullValueHandling = NullValueHandling.Ignore)]
        public string Mail2 { get; set; }

        /// <summary>
        /// Indirizzo email associato all’Ente
        /// </summary>
        [JsonProperty("mail3", NullValueHandling = NullValueHandling.Ignore)]
        public string Mail3 { get; set; }

        /// <summary>
        /// Indirizzo email primario associato all’Ente
        /// </summary>
        [JsonProperty("mail4", NullValueHandling = NullValueHandling.Ignore)]
        public string Mail4 { get; set; }

        /// <summary>
        /// Indirizzo email associato all’Ente
        /// </summary>
        [JsonProperty("mail5", NullValueHandling = NullValueHandling.Ignore)]
        public string Mail5 { get; set; }

        /// <summary>
        /// Nome del responsabile dell'Ente
        /// </summary>
        [JsonProperty("nome_resp", NullValueHandling = NullValueHandling.Ignore)]
        public string NomeResp { get; set; }

        /// <summary>
        /// Provincia registrata in IPA per la sede legale dell'Ente
        /// </summary>
        [JsonProperty("provincia", NullValueHandling = NullValueHandling.Ignore)]
        public string Provincia { get; set; }

        [JsonProperty("Referenti", NullValueHandling = NullValueHandling.Ignore)]
        public List<Referenti> Referenti { get; set; }

        /// <summary>
        /// Regione registrata in IPA per la sede legale dell'Ente
        /// </summary>
        [JsonProperty("regione", NullValueHandling = NullValueHandling.Ignore)]
        public string Regione { get; set; }

        /// <summary>
        /// Sito istituzionale dell'Ente
        /// </summary>
        [JsonProperty("sito_istituzionale", NullValueHandling = NullValueHandling.Ignore)]
        public string SitoIstituzionale { get; set; }

        /// <summary>
        /// Tipologia dell’Ente in IPA
        /// </summary>
        [JsonProperty("tipologia", NullValueHandling = NullValueHandling.Ignore)]
        public string Tipologia { get; set; }

        /// <summary>
        /// Titolo del responsabile dell'Ente
        /// </summary>
        [JsonProperty("titolo_resp", NullValueHandling = NullValueHandling.Ignore)]
        public string TitoloResp { get; set; }
    }

    public partial class Referenti
    {
        /// <summary>
        /// Cognome del referente dell'Ente
        /// </summary>
        [JsonProperty("cogn_ref", NullValueHandling = NullValueHandling.Ignore)]
        public string CognRef { get; set; }

        /// <summary>
        /// Nome del referente dell'Ente
        /// </summary>
        [JsonProperty("nome_ref", NullValueHandling = NullValueHandling.Ignore)]
        public string NomeRef { get; set; }
    }

    
}
