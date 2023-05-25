namespace FatturazioneElettronica.IPA
{
    using Newtonsoft.Json;
    using System.Collections.Generic;


    /// <summary>
    /// L’Indice dei domicili digitali delle Pubbliche Amministrazioni e dei gestori di pubblici 
    /// servizi(IPA) è l’elenco pubblico di fiducia contenente i domicili digitali da utilizzare per
    /// le comunicazioni e per lo scambio di informazioni e per l’invio di documenti validi a tutti
    /// gli effetti di legge tra le pubbliche amministrazioni, i gestori di pubblici servizi e i privati.
    /// Le PEC di un ente accreditato in IPA sono gli indirizzi elettronici eletti presso un servizio
    /// di posta elettronica certificata.
    /// Ogni ente è identificato univocamente dal codice IPA attribuito al termine del processo
    /// di accreditamento in IPA.
    /// Il codice IPA di un ente è esposto nelle informazioni dell’ente consultabili sul portale IPA.
    /// Questo servizio web consente di estrarre dall’IPA la lista delle PEC di un ente fornendo il
    /// relativo codice IP
    /// </summary>
    public partial class Ws20 : WsJson
    {
        [JsonProperty("data", Required = Required.AllowNull)]
        public DataWs20 Data { get; set; }

        [JsonProperty("result", Required = Required.Always)]
        public Result Result { get; set; }
    }

    public partial class DataWs20
    {
        /// <summary>
        /// Codice di avviamento postale registrato in iPA per la sede dell'Ente
        /// </summary>
        [JsonProperty("cap", Required = Required.AllowNull)]
        public string Cap { get; set; }

        /// <summary>
        /// Codice dell'Ente come è accreditato sull'iPA
        /// </summary>
        [JsonProperty("cod_amm", Required = Required.Always)]
        public string CodAmm { get; set; }

        /// <summary>
        /// Comune registrato in iPA per la sede dell'Ente
        /// </summary>
        [JsonProperty("comune", Required = Required.AllowNull)]
        public string Comune { get; set; }

        /// <summary>
        /// Data in cui è stato pubblicato la nuova pec
        /// </summary>
        [JsonProperty("data_pubblicazione", Required = Required.Always)]
        public string DataPubblicazione { get; set; }

        /// <summary>
        /// Descrizione dell'Ente
        /// </summary>
        [JsonProperty("denominazione", Required = Required.Always)]
        public string Denominazione { get; set; }

        /// <summary>
        /// Indirizzo postale registrato in iPA per la sede dell'Ente
        /// </summary>
        [JsonProperty("indirizzo", Required = Required.AllowNull)]
        public string Indirizzo { get; set; }

        /// <summary>
        /// PEC o servizio elettronico di recapito certificato qualificato associato ad un Ente
        /// </summary>
        [JsonProperty("pec", Required = Required.Always)]
        public string Pec { get; set; }

        /// <summary>
        /// Provincia registrata in iPA per la sede dell'Ente
        /// </summary>
        [JsonProperty("provincia", Required = Required.AllowNull)]
        public string Provincia { get; set; }

        /// <summary>
        /// Regione registrata in iPA per la sede dell'Ente
        /// </summary>
        [JsonProperty("regione", Required = Required.AllowNull)]
        public string Regione { get; set; }

        /// <summary>
        /// Tipo dell'indirizzo elettronico
        /// </summary>
        [JsonProperty("tipo", Required = Required.Always)]
        public string Tipo { get; set; }
    }
}
