namespace FatturazioneElettronica.IPA
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    /// Questo servizio web consente di estrarre dall'iPA informazioni relativa alla lista delle variazioni storiche di un domicilio digitale.   
    /// </summary>
    public partial class Ws13 :WsJson
    {
        [JsonProperty("data")]
        public List<DataWs13> Data { get; set; }

        [JsonProperty("result", Required = Required.Always)]
        public Result Result { get; set; }
    }

    public partial class DataWs13
    {
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
        /// Data pubblicazione cancellazione Domicilio digitale
        /// </summary>
        [JsonProperty("data_cancellazione", Required = Required.AllowNull)]
        public string DataCancellazione { get; set; }

        /// <summary>
        /// Data pubblicazione nuovo Domicilio digitale
        /// </summary>
        [JsonProperty("data_pubblicazione", Required = Required.Always)]
        public string DataPubblicazione { get; set; }

        /// <summary>
        /// Nome Ente
        /// </summary>
        [JsonProperty("des_Amm", Required = Required.Always)]
        public string DesAmm { get; set; }

        /// <summary>
        /// Nome dell'AOO
        /// </summary>
        [JsonProperty("des_aoo", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string DesAoo { get; set; }

        /// <summary>
        /// Domicilio digitale
        /// </summary>
        [JsonProperty("domicilio_digitale", Required = Required.Always)]
        public string DomicilioDigitale { get; set; }

        /// <summary>
        /// Tipo Domicilio digitale; attualmente solo PEC
        /// </summary>
        [JsonProperty("tipo", Required = Required.Always)]
        public string Tipo { get; set; }
    }
}
