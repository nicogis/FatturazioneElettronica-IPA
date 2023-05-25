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
    /// Questo servizio web consente di estrarre dall’IPA la storia di una PEC, riportando le date
    /// in cui sono intercorse tutte le variazioni, impostando come parametro di ricerca la PEC
    /// stessa.
    /// </summary>
    public partial class Ws22 : WsJson
    {
        [JsonProperty("data", Required = Required.AllowNull)]
        public DataWs22 Data { get; set; }

        [JsonProperty("result", Required = Required.Always)]
        public Result Result { get; set; }
    }

    public partial class DataWs22
    {
        /// <summary>
        /// Codice dell'Ente come è accreditato sull'iPA
        /// </summary>
        [JsonProperty("cod_amm", Required = Required.Always)]
        public string CodAmm { get; set; }

        /// <summary>
        /// Data in cui è stata pubblicata la nuova pec
        /// </summary>
        [JsonProperty("data_cancellazione", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string DataCancellazione { get; set; }

        /// <summary>
        /// Data in cui è stato pubblicata la nuova pec
        /// </summary>
        [JsonProperty("data_pubblicazione", Required = Required.Always)]
        public string DataPubblicazione { get; set; }

        /// <summary>
        /// Descrizione dell'Ente
        /// </summary>
        [JsonProperty("denominazione", Required = Required.Always)]
        public string Denominazione { get; set; }

        /// <summary>
        /// PEC o servizio elettronico di recapito certificato qualificato associato ad un ente
        /// </summary>
        [JsonProperty("pec", Required = Required.Always)]
        public string Pec { get; set; }

        /// <summary>
        /// Tipo pec
        /// </summary>
        [JsonProperty("tipo", Required = Required.Always)]
        public string Tipo { get; set; }
    }
}
