//-----------------------------------------------------------------------
// <copyright file="Ws05.cs" company="Studio A&T s.r.l.">
//     Copyright (c) Studio A&T s.r.l. All rights reserved.
// </copyright>
// <author>Nicogis</author>
//-----------------------------------------------------------------------
namespace FatturazioneElettronica.IPA
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    /// Questo servizio web consente di estrarre dall' iPA informazioni relativa ad un Ente specifico. 
    /// </summary>
    public partial class Ws05 :WsJson
    {
        [JsonProperty("data")]
        public DataWs05 Data { get; set; }

        [JsonProperty("result", Required = Required.Always)]
        public Result Result { get; set; }
    }

    public partial class DataWs05
    {
        /// <summary>
        /// Acronimo dell'Ente
        /// </summary>
        [JsonProperty("acronimo", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Acronimo { get; set; }

        /// <summary>
        /// Cap registrato in IPA per la sede legale dell'Ente
        /// </summary>
        [JsonProperty("cap", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Cap { get; set; }

        /// <summary>
        /// Categoria dell'Ente in IPA
        /// </summary>
        [JsonProperty("categoria", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Categoria { get; set; }

        /// <summary>
        /// Codice fiscale dell'Ente
        /// </summary>
        [JsonProperty("cf", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Cf { get; set; }

        /// <summary>
        /// Codice Ente accreditato in IPA
        /// </summary>
        [JsonProperty("cod_amm", Required = Required.Always)]
        public string CodAmm { get; set; }

        /// <summary>
        /// Cognome del responsabile dell'Ente
        /// </summary>
        [JsonProperty("cogn_resp", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string CognResp { get; set; }

        /// <summary>
        /// Comune registrato in IPA per la sede legale dell'Ente
        /// </summary>
        [JsonProperty("comune", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Comune { get; set; }

        /// <summary>
        /// Data di accreditamento dell'Ente
        /// </summary>
        [JsonProperty("data_accreditamento", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string DataAccreditamento { get; set; }

        /// <summary>
        /// Denominazione Ente accreditato in IPA
        /// </summary>
        [JsonProperty("des_amm", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string DesAmm { get; set; }

        /// <summary>
        /// Indirizzo postale registrato in IPA per la sede legale dell'Ente
        /// </summary>
        [JsonProperty("indirizzo", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Indirizzo { get; set; }

        /// <summary>
        /// livello di accessibilità del sito dell'Ente
        /// </summary>
        [JsonProperty("liv_accessibili", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public double? LivAccessibili { get; set; }

        /// <summary>
        /// Indirizzo email primario associato all’Ente di tipo PEC|CECPAC
        /// </summary>
        [JsonProperty("mail1", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Mail1 { get; set; }

        /// <summary>
        /// Indirizzo email associato all’Ente
        /// </summary>
        [JsonProperty("mail2", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Mail2 { get; set; }

        /// <summary>
        /// Indirizzo email associato all’Ente
        /// </summary>
        [JsonProperty("mail3", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Mail3 { get; set; }

        /// <summary>
        /// Indirizzo email primario associato all’Ente
        /// </summary>
        [JsonProperty("mail4", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Mail4 { get; set; }

        /// <summary>
        /// Indirizzo email associato all’Ente
        /// </summary>
        [JsonProperty("mail5", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Mail5 { get; set; }

        /// <summary>
        /// Nome del responsabile dell'Ente
        /// </summary>
        [JsonProperty("nome_resp", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string NomeResp { get; set; }

        /// <summary>
        /// Provincia registrata in IPA per la sede legale dell'Ente
        /// </summary>
        [JsonProperty("provincia", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Provincia { get; set; }

        /// <summary>
        /// Regione registrata in IPA per la sede legale dell'Ente
        /// </summary>
        [JsonProperty("regione", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Regione { get; set; }

        /// <summary>
        /// Sito istituzionale dell'Ente
        /// </summary>
        [JsonProperty("sito_istituzionale", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string SitoIstituzionale { get; set; }

        /// <summary>
        /// Tipologia dell’Ente in IPA
        /// </summary>
        [JsonProperty("tipologia", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Tipologia { get; set; }

        /// <summary>
        /// Titolo del responsabile dell'Ente
        /// </summary>
        [JsonProperty("titolo_resp", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string TitoloResp { get; set; }
    }


}
