namespace FatturazioneElettronica.IPA
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    /// Questo servizio web consente di estrarre dall'iPA informazioni su tutti gli uffici che sono Nodi di Smistamento Ordini associati al Codice Fiscale fornito.
    /// </summary>
    public partial class Ws14 : WsJson  
    {
        [JsonProperty("data")]
        public List<DataWs14> Data { get; set; }

        [JsonProperty("result", Required = Required.Always)]
        public Result Result { get; set; }
    }

    public partial class DataWs14
    {
        /// <summary>
        /// Codice Ente accreditato in IPA
        /// </summary>
        [JsonProperty("cod_amm", Required = Required.Always)]
        public string CodAmm { get; set; }

        /// <summary>
        /// Denominazione Ente accreditato in IPA
        /// </summary>
        [JsonProperty("des_amm", Required = Required.Always)]
        public string DesAmm { get; set; }

        [JsonProperty("OU", Required = Required.Always)]
        public List<Ou> Ou { get; set; }
    }
}
