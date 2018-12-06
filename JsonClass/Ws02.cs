namespace FatturazioneElettronica.IPA
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    /// Response: L’iPA consente la ricerca di informazioni utili relative alle Aree Organizzative Omogenee, ove definite, per ciascuna amministrazione in esso accreditata. Ogni Area Organizzativa Omogenea (detta anche Ufficio di Protocollo) è univocamente individuata attraverso due codici: il codice iPA dell’amministrazione in cui è definita ed il codice AOO, ovvero il codice univoco assegnato all’AOO dall’Ente stesso all’atto della sua creazione. Gli uffici dell’Ente potranno poi essere associati esclusivamente ad una delle AOO definite per l’Ente stesso. Questo servizio web consente di estrarre dall’ iPA informazioni su tutte le aree organizzative omogenee associate al codice iPA fornito. Il servizio consente, inoltre, di impostare come parametro di ricerca anche il codice AOO, oltre il codice iPA. Si tenga presente che nel caso in cui l’utente fornisca congiuntamente i due codici (codice iPA e codice AOO) dalla ricerca potrà essere estratta solo ed esclusivamente una Area Organizzativa Omogenea.
    /// </summary>
    public partial class Ws02 : WsJson
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataWs02> Data { get; set; }

        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public Result Result { get; set; }
    }

    public partial class DataWs02
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
