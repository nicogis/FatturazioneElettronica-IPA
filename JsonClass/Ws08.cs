namespace FatturazioneElettronica.IPA
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public partial class Ws08 : WsJson
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataWs08> Data { get; set; }

        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public Result Result { get; set; }
    }

    public partial class DataWs08
    {
        /// <summary>
        /// Cap registrato in IPA per la sede dell'AOO
        /// </summary>
        [JsonProperty("cap", NullValueHandling = NullValueHandling.Ignore)]
        public string Cap { get; set; }

        /// <summary>
        /// Codice Ente accreditato in IPA
        /// </summary>
        [JsonProperty("cod_amm")]
        public string CodAmm { get; set; }

        /// <summary>
        /// Codice AOO
        /// </summary>
        [JsonProperty("cod_aoo")]
        public string CodAoo { get; set; }

        /// <summary>
        /// Cognome del responsabile dell'AOO
        /// </summary>
        [JsonProperty("cogn_resp", NullValueHandling = NullValueHandling.Ignore)]
        public string CognResp { get; set; }

        /// <summary>
        /// Comune registrato in IPA per la sede dell'AOO
        /// </summary>
        [JsonProperty("comune", NullValueHandling = NullValueHandling.Ignore)]
        public string Comune { get; set; }

        /// <summary>
        /// Data cessazione AOO
        /// </summary>
        [JsonProperty("dat_fine_val", NullValueHandling = NullValueHandling.Ignore)]
        public string DatFineVal { get; set; }

        /// <summary>
        /// Nome dell'AOO
        /// </summary>
        [JsonProperty("des_aoo", NullValueHandling = NullValueHandling.Ignore)]
        public string DesAoo { get; set; }

        /// <summary>
        /// Numero di fax registrato in IPA per dell’AOO
        /// </summary>
        [JsonProperty("fax", NullValueHandling = NullValueHandling.Ignore)]
        public string Fax { get; set; }

        /// <summary>
        /// Indirizzo postale registrato in IPA per la sede dell'AOO
        /// </summary>
        [JsonProperty("indirizzo", NullValueHandling = NullValueHandling.Ignore)]
        public string Indirizzo { get; set; }

        /// <summary>
        /// Indirizzo email primario associato all’AOO
        /// </summary>
        [JsonProperty("mail1", NullValueHandling = NullValueHandling.Ignore)]
        public string Mail1 { get; set; }

        /// <summary>
        /// Indirizzo email associato all’AOO
        /// </summary>
        [JsonProperty("mail2", NullValueHandling = NullValueHandling.Ignore)]
        public string Mail2 { get; set; }

        /// <summary>
        /// Indirizzo email associato all’AOO
        /// </summary>
        [JsonProperty("mail3", NullValueHandling = NullValueHandling.Ignore)]
        public string Mail3 { get; set; }

        /// <summary>
        /// Indirizzo email del responsabile dell'AOO
        /// </summary>
        [JsonProperty("mail_resp", NullValueHandling = NullValueHandling.Ignore)]
        public string MailResp { get; set; }

        /// <summary>
        /// Nome del responsabile dell'AOO
        /// </summary>
        [JsonProperty("nome_resp")]
        public string NomeResp { get; set; }

        /// <summary>
        /// Provincia registrata in IPA per la sede dell'AOO
        /// </summary>
        [JsonProperty("provincia", NullValueHandling = NullValueHandling.Ignore)]
        public string Provincia { get; set; }

        /// <summary>
        /// Regione registrata in IPA per la sede dell'AOO
        /// </summary>
        [JsonProperty("regione", NullValueHandling = NullValueHandling.Ignore)]
        public string Regione { get; set; }

        /// <summary>
        /// Numero di telefono registrato in IPA per dell’AOO
        /// </summary>
        [JsonProperty("tel", NullValueHandling = NullValueHandling.Ignore)]
        public string Tel { get; set; }

        /// <summary>
        /// Numero di telefono del responsabile dell'AOO
        /// </summary>
        [JsonProperty("tel_resp", NullValueHandling = NullValueHandling.Ignore)]
        public string TelResp { get; set; }
    }

    

    
}
