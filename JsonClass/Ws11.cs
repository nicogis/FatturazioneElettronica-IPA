namespace FatturazioneElettronica.IPA
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    /// Questo servizio web consente di estrarre dall'iPA informazioni relativa alla lista delle variazioni storiche dei domicili digitali di un Ente, 
    /// tramite la lista delle sue Aree Organizzative Omogenee o di una sua singola occorrenza. 
    /// </summary>
    public partial class Ws11 :WsJson
    {
        [JsonProperty("data")]
        public List<DataWs11> Data { get; set; }

        [JsonProperty("result", Required = Required.Always)]
        public Result Result { get; set; }
    }

    public partial class DataWs11
    {
        /// <summary>
        /// Cap registrato in IPA per la sede dell'AOO
        /// </summary>
        [JsonProperty("cap", Required = Required.Always)]
        public string Cap { get; set; }

        /// <summary>
        /// Codice Ente accreditato in IPA
        /// </summary>
        [JsonProperty("cod_amm", Required = Required.Always)]
        public string CodAmm { get; set; }

        /// <summary>
        /// Codice AOO
        /// </summary>
        [JsonProperty("cod_aoo", Required = Required.Always)]
        public string CodAoo { get; set; }

        /// <summary>
        /// Comune registrato in IPA per la sede dell'AOO
        /// </summary>
        [JsonProperty("comune", Required = Required.Always)]
        public string Comune { get; set; }

        /// <summary>
        /// Data pubblicazione cancellazione Domicilio digitale
        /// </summary>
        [JsonProperty("data_cancellazione", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string DataCancellazione { get; set; }

        /// <summary>
        /// Data pubblicazione nuovo Domicilio digitale
        /// </summary>
        [JsonProperty("data_pubblicazione", Required = Required.Always)]
        public string DataPubblicazione { get; set; }

        /// <summary>
        /// Nome Ente
        /// </summary>
        [JsonProperty("des_amm", Required = Required.Always)]
        public string DesAmm { get; set; }

        /// <summary>
        /// Nome dell'AOO
        /// </summary>
        [JsonProperty("des_aoo", Required = Required.Always)]
        public string DesAoo { get; set; }

        /// <summary>
        /// Domicilio digitale
        /// </summary>
        [JsonProperty("domicilio_digitale", Required = Required.Always)]
        public string DomicilioDigitale { get; set; }

        /// <summary>
        /// Numero di fax registrato in IPA per l'AOO
        /// </summary>
        [JsonProperty("fax", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Fax { get; set; }

        /// <summary>
        /// Indirizzo postale registrato in IPA per la sede dell'AOO
        /// </summary>
        [JsonProperty("indirizzo", Required = Required.Always)]
        public string Indirizzo { get; set; }

        /// <summary>
        /// Provincia registrata in IPA per la sede dell'AOO
        /// </summary>
        [JsonProperty("provincia", Required = Required.Always)]
        public string Provincia { get; set; }

        /// <summary>
        /// Regione registrata in IPA per la sede dell'AOO
        /// </summary>
        [JsonProperty("regione", Required = Required.Always)]
        public string Regione { get; set; }

        /// <summary>
        /// Numero di telefono registrato in IPA per l'AOO
        /// </summary>
        [JsonProperty("tel", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Tel { get; set; }

        /// <summary>
        /// Tipo Domicilio digitale; attualmente solo PEC
        /// </summary>
        [JsonProperty("tipo", Required = Required.Always)]
        public string Tipo { get; set; }
    }
}
