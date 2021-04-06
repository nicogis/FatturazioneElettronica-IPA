namespace FatturazioneElettronica.IPA
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    ///   Questo servizio web consente di estrarre dall'iPA informazioni su tutti gli uffici che sono Nodi di Smistamento Ordini associati ad un Ente specifico.
    /// </summary>
    public partial class Ws15 : WsJson
    {
        [JsonProperty("data")]
        public List<DataWs15> Data { get; set; }

        [JsonProperty("result", Required = Required.Always)]
        public Result Result { get; set; }
    }

    public partial class DataWs15
    {
        /// <summary>
        /// Codice fiscale del nodo di smistamento ordini
        /// </summary>
        [JsonProperty("cf", Required = Required.Always)]
        public string Cf { get; set; }

        /// <summary>
        /// Codice Ente accreditato in IPA
        /// </summary>
        [JsonProperty("cod_amm", Required = Required.Always)]
        public string CodAmm { get; set; }

        /// <summary>
        /// Codice AOO
        /// </summary>
        [JsonProperty("cod_aoo", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string CodAoo { get; set; }

        /// <summary>
        /// Codice Univoco dell'Ufficio del nodo di smistamento ordini
        /// </summary>
        [JsonProperty("cod_uni_ou", Required = Required.Always)]
        public string CodUniOu { get; set; }

        /// <summary>
        /// Data di inizio validità del nodo di smistamento ordini
        /// </summary>
        [JsonProperty("dat_val_canale_trasm_nso", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string DatValCanaleTrasmNso { get; set; }

        /// <summary>
        /// Nome dell'UO
        /// </summary>
        [JsonProperty("des_ou", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string DesOu { get; set; }

        /// <summary>
        /// Data di validazione del cf
        /// </summary>
        [JsonProperty("dt_verifica_cf", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string DtVerificaCf { get; set; }

        /// <summary>
        /// Stato del canale ordini
        /// </summary>
        [JsonProperty("stato_canale", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string StatoCanale { get; set; }
    }
}
