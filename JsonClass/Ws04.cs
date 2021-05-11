//-----------------------------------------------------------------------
// <copyright file="Ws04.cs" company="Studio A&T s.r.l.">
//     Copyright (c) Studio A&T s.r.l. All rights reserved.
// </copyright>
// <author>Nicogis</author>
//-----------------------------------------------------------------------
namespace FatturazioneElettronica.IPA
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    /// Questo servizio web consente di estrarre dall'iPA informazioni su tutti i Servizi di Fatturazione Elettronica associati ad un Ente specifico.
    /// </summary>
    public partial class Ws04 : WsJson
    {
        [JsonProperty("data", Required = Required.AllowNull)]
        public List<DataWs04> Data { get; set; }

        [JsonProperty("result", Required = Required.Always)]
        public Result Result { get; set; }
    }

    public partial class DataWs04
    {
        /// <summary>
        /// Codice fiscale del servizio di fatturazione elettronica
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
        /// Codice Univoco dell'Ufficio di fatturazione elettronica
        /// </summary>
        [JsonProperty("cod_uni_ou", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string CodUniOu { get; set; }

        /// <summary>
        /// Data di inizio validità del servizio di fatturazione
        /// </summary>
        [JsonProperty("dat_val_canale_trasm_sfe", Required = Required.Always)]
        public string DatValCanaleTrasmSfe { get; set; }

        /// <summary>
        /// Nome dell'UO
        /// </summary>
        [JsonProperty("des_ou", Required = Required.Always)]
        public string DesOu { get; set; }

        /// <summary>
        /// Data di validazione del cf
        /// </summary>
        [JsonProperty("dt_verifica_cf", Required = Required.Always)]
        public string DtVerificaCf { get; set; }

        /// <summary>
        /// Stato del canale di fatturazione
        /// </summary>
        [JsonProperty("stato_canale", Required = Required.Always)]
        public string StatoCanale { get; set; }
    }
}
