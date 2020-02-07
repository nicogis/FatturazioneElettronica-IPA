//-----------------------------------------------------------------------
// <copyright file="Ws06.cs" company="Studio A&T s.r.l.">
//     Copyright (c) Studio A&T s.r.l. All rights reserved.
// </copyright>
// <author>Nicogis</author>
//-----------------------------------------------------------------------
namespace FatturazioneElettronica.IPA
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    /// Questo servizio web consente di estrarre dall' iPA informazioni relative ad una specifica Unità Organizzativa di un Ente accreditato in iPA. 
    /// </summary>
    public partial class Ws06 : WsJson
    {
        [JsonProperty("data")]
        public List<DataWs06> Data { get; set; }

        [JsonProperty("result", Required = Required.Always)]
        public Result Result { get; set; }
    }

    public partial class DataWs06
    {
        /// <summary>
        /// Cap registrato in IPA per la sede dell'UO
        /// </summary>
        [JsonProperty("cap", Required = Required.Always)]
        public string Cap { get; set; }

        /// <summary>
        /// Codice fiscale del servizio di faturazione
        /// </summary>
        [JsonProperty("cf", Required = Required.Always)]
        public string Cf { get; set; }

        /// <summary>
        /// Codice fiscale del nodo di smistamento ordini
        /// </summary>
        [JsonProperty("cf_nso", Required = Required.Always)]
        public string CfNso { get; set; }

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
        /// Codice Univoco dell'UO
        /// </summary>
        [JsonProperty("cod_uni_ou", Required = Required.Always)]
        public string CodUniOu { get; set; }

        /// <summary>
        /// Cognome del responsabile dell'UO
        /// </summary>
        [JsonProperty("cogn_resp", Required = Required.Always)]
        public string CognResp { get; set; }

        /// <summary>
        /// Comune registrato in IPA per la sede dell'UO
        /// </summary>
        [JsonProperty("comune", Required = Required.Always)]
        public string Comune { get; set; }

        /// <summary>
        /// Data di inizio validità del nodo di smistamento ordini
        /// </summary>
        [JsonProperty("dat_val_canale_trasm_nso", Required = Required.Always)]
        public string DatValCanaleTrasmNso { get; set; }

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
        /// Data di validazione del cf del servizio di fatturazione
        /// </summary>
        [JsonProperty("dt_verifica_cf", Required = Required.Always)]
        public string DtVerificaCf { get; set; }

        /// <summary>
        /// Data di validazione del cf del nodo di smistamento ordini
        /// </summary>
        [JsonProperty("dt_verifica_cf_nso", Required = Required.Always)]
        public string DtVerificaCfNso { get; set; }

        /// <summary>
        /// Numero di fax dell'UO
        /// </summary>
        [JsonProperty("fax", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Fax { get; set; }

        /// <summary>
        /// Indirizzo postale registrato in IPA per la sede dell'UO
        /// </summary>
        [JsonProperty("indirizzo", Required = Required.Always)]
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
        /// Cognome del responsabile dell'UO
        /// </summary>
        [JsonProperty("mail_resp", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string MailResp { get; set; }

        /// <summary>
        /// Nome del responsabile dell'UO
        /// </summary>
        [JsonProperty("nome_resp", Required = Required.Always)]
        public string NomeResp { get; set; }

        /// <summary>
        /// Provincia registrata in IPA per la sede dell'UO
        /// </summary>
        [JsonProperty("provincia", Required = Required.Always)]
        public string Provincia { get; set; }

        /// <summary>
        /// Regione registrata in IPA per la sede dell'UO
        /// </summary>
        [JsonProperty("regione", Required = Required.Always)]
        public string Regione { get; set; }

        /// <summary>
        /// Stato del canale di fatturazione; A:Attivo|V=In fase di validazione
        /// </summary>
        [JsonProperty("stato_canale", Required = Required.Always)]
        public string StatoCanale { get; set; }

        /// <summary>
        /// Stato del canale di ordini; A:Attivo|V=In fase di validazione
        /// </summary>
        [JsonProperty("stato_canale_nso", Required = Required.Always)]
        public string StatoCanaleNso { get; set; }

        /// <summary>
        /// Numero di telefono dell'UO
        /// </summary>
        [JsonProperty("tel", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Tel { get; set; }

        /// <summary>
        /// Cognome del responsabile dell'UO
        /// </summary>
        [JsonProperty("tel_resp", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string TelResp { get; set; }
    }
}
