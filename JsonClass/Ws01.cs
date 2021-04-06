//-----------------------------------------------------------------------
// <copyright file="Ws01.cs" company="Studio A&T s.r.l.">
//     Copyright (c) Studio A&T s.r.l. All rights reserved.
// </copyright>
// <author>Nicogis</author>
//-----------------------------------------------------------------------
namespace FatturazioneElettronica.IPA
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    /// Questo servizio web consente di estrarre dall'iPA informazioni su tutti gli uffici destinatari di Fatturazione Elettronica associati al Codice Fiscale fornito. 
    /// </summary>
    public partial class Ws01 : WsJson
    {
        [JsonProperty("data")]
        public List<DataWs01> Data { get; set; }

        [JsonProperty("result", Required = Required.Always)]
        public Result Result { get; set; }
    }

    public partial class DataWs01
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

        [JsonProperty("ou", Required = Required.Always)]
        public List<Ou> Ou { get; set; }
    }
}