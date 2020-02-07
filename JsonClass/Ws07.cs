//-----------------------------------------------------------------------
// <copyright file="Ws07.cs" company="Studio A&T s.r.l.">
//     Copyright (c) Studio A&T s.r.l. All rights reserved.
// </copyright>
// <author>Nicogis</author>
//-----------------------------------------------------------------------
namespace FatturazioneElettronica.IPA
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    /// Questo servizio web consente di estrarre dall'iPA informazioni relativa ad una entità, sia essa un Ente, un'Unità Organizzativa, un'Area Organizzativa Omogenea, 
    /// un servizio generico, un Servizio di Fatturazione Elettronica, un Responsabile o un Referente, associata ad uno specifico indirizzo email. 
    /// Se un indirizzo mail è associato a più entità all'interno di iPA, verranno visualizzate le informazioni di dettaglio relative a ciascuna delle entità individuate. 
    /// </summary>
    public partial class Ws07 : WsJson
    {
        [JsonProperty("data")]
        public List<DataWs07> Data { get; set; }

        [JsonProperty("result", Required = Required.Always)]
        public Result Result { get; set; }
    }

    public partial class DataWs07
    {
        /// <summary>
        /// Codice Ente accreditato in IPA
        /// </summary>
        [JsonProperty("cod_amm", Required = Required.Always)]
        public string CodAmm { get; set; }

        /// <summary>
        /// Codice dell'entità
        /// </summary>
        [JsonProperty("cod_entita", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string CodEntita { get; set; }

        /// <summary>
        /// Denominazione Ente accreditato in IPA
        /// </summary>
        [JsonProperty("des_amm", Required = Required.Always)]
        public string DesAmm { get; set; }

        /// <summary>
        /// Tipo email:PEC|CECPAC|ALTRO
        /// </summary>
        [JsonProperty("tipo_email", Required = Required.Always)]
        public string TipoEmail { get; set; }

        /// <summary>
        /// Tipo entità: AMM|AOO|UO|SERVAMM|SERVAOO|SERVOU|RESPAOO|RESPUO
        /// </summary>
        [JsonProperty("tipo_entita", Required = Required.Always)]
        public string TipoEntita { get; set; }
    }
}
