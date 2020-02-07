//-----------------------------------------------------------------------
// <copyright file="Ws08.cs" company="Studio A&T s.r.l.">
//     Copyright (c) Studio A&T s.r.l. All rights reserved.
// </copyright>
// <author>Nicogis</author>
//-----------------------------------------------------------------------
namespace FatturazioneElettronica.IPA
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    /// Questo servizio web consente di estrarre dall' iPA informazioni su tutte le aree organizzative omogenee cessate associate al codice iPA fornito. 
    /// Il servizio consente, inoltre, di impostare come parametro di ricerca anche il codice AOO, oltre il codice iPA. Si tenga presente che nel caso in cui 
    /// l'utente fornisca congiuntamente i due codici (codice iPA e codice AOO) dalla ricerca potrà essere estratta solo ed esclusivamente una Area Organizzativa Omogenea. 
    /// </summary>

    public partial class Ws08 : WsJson
    {
        [JsonProperty("data")]
        public List<DataWs08> Data { get; set; }

        [JsonProperty("result", Required = Required.Always)]
        public Result Result { get; set; }
    }

    public partial class DataWs08
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
        /// Cognome del responsabile dell'AOO
        /// </summary>
        [JsonProperty("cogn_resp", Required = Required.Always)]
        public string CognResp { get; set; }

        /// <summary>
        /// Comune registrato in IPA per la sede dell'AOO
        /// </summary>
        [JsonProperty("comune", Required = Required.Always)]
        public string Comune { get; set; }

        /// <summary>
        /// Data cessazione AOO
        /// </summary>
        [JsonProperty("dat_fine_val", Required = Required.Always)]
        public string DatFineVal { get; set; }

        /// <summary>
        /// Nome dell'AOO
        /// </summary>
        [JsonProperty("des_aoo", Required = Required.Always)]
        public string DesAoo { get; set; }

        /// <summary>
        /// Numero di fax registrato in IPA per dell'AOO
        /// </summary>
        [JsonProperty("fax", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Fax { get; set; }

        /// <summary>
        /// Indirizzo postale registrato in IPA per la sede dell'AOO
        /// </summary>
        [JsonProperty("indirizzo", Required = Required.Always)]
        public string Indirizzo { get; set; }

        /// <summary>
        /// Indirizzo email primario associato all'AOO
        /// </summary>
        [JsonProperty("mail1", Required = Required.Always)]
        public string Mail1 { get; set; }

        /// <summary>
        /// Indirizzo email associato all'AOO
        /// </summary>
        [JsonProperty("mail2", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Mail2 { get; set; }

        /// <summary>
        /// Indirizzo email associato all'AOO
        /// </summary>
        [JsonProperty("mail3", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Mail3 { get; set; }

        /// <summary>
        /// Indirizzo email del responsabile dell'AOO
        /// </summary>
        [JsonProperty("mail_resp", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string MailResp { get; set; }

        /// <summary>
        /// Nome del responsabile dell'AOO
        /// </summary>
        [JsonProperty("nome_resp", Required = Required.Always)]
        public string NomeResp { get; set; }

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
        /// Numero di telefono registrato in IPA per dell'AOO
        /// </summary>
        [JsonProperty("tel", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Tel { get; set; }

        /// <summary>
        /// Numero di telefono del responsabile dell'AOO
        /// </summary>
        [JsonProperty("tel_resp", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string TelResp { get; set; }
    }
}
