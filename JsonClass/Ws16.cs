namespace FatturazioneElettronica.IPA
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    /// Questo servizio web consente di estrarre dall'iPA informazioni relative ad una lista di Enti.
    /// </summary>
    public partial class Ws16 : WsJson
    {
        [JsonProperty("data")]
        public List<DataWs16> Data { get; set; }

        [JsonProperty("result", Required = Required.Always)]
        public Result Result { get; set; }
    }

    public partial class DataWs16
    {
        /// <summary>
        /// Acronimo dell'Ente
        /// </summary>
        [JsonProperty("acronimo", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Acronimo { get; set; }

        /// <summary>
        /// Codice Ente accreditato in IPA
        /// </summary>
        [JsonProperty("cod_amm", Required = Required.Always)]
        public string CodAmm { get; set; }

        /// <summary>
        /// Denominazione Ente accreditato in IPA
        /// </summary>
        [JsonProperty("des_amm", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string DesAmm { get; set; }
    }
}
