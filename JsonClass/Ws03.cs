//-----------------------------------------------------------------------
// <copyright file="Ws03.cs" company="Studio A&T s.r.l.">
//     Copyright (c) Studio A&T s.r.l. All rights reserved.
// </copyright>
// <author>Nicogis</author>
//-----------------------------------------------------------------------
namespace FatturazioneElettronica.IPA
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    /// Questo servizio web consente di estrarre dall' iPA la lista delle Unità Organizzative facenti capo ad uno specifico codice iPA. 
    /// </summary>
    public partial class Ws03 :WsJson
    {
        [JsonProperty("data")]
        public List<DataWs03> Data { get; set; }

        [JsonProperty("result", Required = Required.Always)]
        public Result Result { get; set; }
    }

    public partial class DataWs03
    {
        /// <summary>
        /// Cap registrato in IPA per la sede dell'UO
        /// </summary>
        [JsonProperty("cap", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Cap { get; set; }

        /// <summary>
        /// Codice Ente accreditato in IPA
        /// </summary>
        [JsonProperty("cod_amm", Required = Required.Always)]
        public string CodAmm { get; set; }

        /// <summary>
        /// Codice AOO
        /// </summary>
        [JsonProperty("cod_aoo", Required = Required.AllowNull)]
        public string CodAoo { get; set; }

        /// <summary>
        /// Codice Univoco dell'UO
        /// </summary>
        [JsonProperty("cod_uni_ou", Required = Required.Always)]
        public string CodUniOu { get; set; }

        /// <summary>
        /// Cognome del responsabile dell'UO
        /// </summary>
        [JsonProperty("cogn_resp", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string CognResp { get; set; }

        /// <summary>
        /// Comune registrato in IPA per la sede dell'UO
        /// </summary>
        [JsonProperty("comune", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Comune { get; set; }

        /// <summary>
        /// Nome dell'UO
        /// </summary>
        [JsonProperty("des_ou", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string DesOu { get; set; }

        /// <summary>
        /// Numero di fax registrato in IPA per dell'UO
        /// </summary>
        [JsonProperty("fax", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Fax { get; set; }

        /// <summary>
        /// Indirizzo postale registrato in IPA per la sede dell'UO
        /// </summary>
        [JsonProperty("indirizzo", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Indirizzo { get; set; }

        /// <summary>
        /// Indirizzo email primario associato all'UO
        /// </summary>
        [JsonProperty("mail1", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Mail1 { get; set; }

        /// <summary>
        /// Indirizzo email associato all'UO
        /// </summary>
        [JsonProperty("mail2", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Mail2 { get; set; }

        /// <summary>
        /// Indirizzo email associato all'UO
        /// </summary>
        [JsonProperty("mail3", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Mail3 { get; set; }

        /// <summary>
        /// Indirizzo emaildelresponsabiledell'UO
        /// </summary>
        [JsonProperty("mail_resp", Required = Required.AllowNull)]
        public string MailResp { get; set; }

        /// <summary>
        /// Nome del responsabile dell'UO
        /// </summary>
        [JsonProperty("nome_resp", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string NomeResp { get; set; }

        /// <summary>
        /// Provincia registrata in IPA per la sede dell'UO
        /// </summary>
        [JsonProperty("provincia", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Provincia { get; set; }

        /// <summary>
        /// Regione registrata in IPA per la sede dell'UO
        /// </summary>
        [JsonProperty("regione", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Regione { get; set; }

        /// <summary>
        /// Numero di telefono registrato in IPA per dell'UO
        /// </summary>
        [JsonProperty("tel", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Tel { get; set; }

        /// <summary>
        /// Numero di telefono del responsabile dell'UO
        /// </summary>
        [JsonProperty("tel_resp", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string TelResp { get; set; }
    }
}
