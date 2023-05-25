namespace FatturazioneElettronica.IPA
{
    using Newtonsoft.Json;

    /// <summary>
    /// Questo servizio web consente di estrarre dall'iPA informazioni relative ad una Area Organizzativa Omogenea
    /// </summary>
    public partial class Ws18 : WsJson
    {
        [JsonProperty("data", Required = Required.AllowNull)]
        public DataWs18 Data { get; set; }

        [JsonProperty("result", Required = Required.Always)]
        public Result Result { get; set; }
    }

    public partial class DataWs18
    {
        /// <summary>
        /// Cap registrato in IPA per la sede dell'AOO
        /// </summary>
        [JsonProperty("cap", Required = Required.AllowNull)]
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
        /// Codice univoco AOO
        /// </summary>
        [JsonProperty("cod_uni_aoo", Required = Required.Always)]
        public string CodUniAoo { get; set; }

        /// <summary>
        /// Cognome del responsabile dell'AOO
        /// </summary>
        [JsonProperty("cogn_resp", Required = Required.AllowNull)]
        public string CognResp { get; set; }

        /// <summary>
        /// Comune registrato in IPA per la sede dell'AOO
        /// </summary>
        [JsonProperty("comune", Required = Required.AllowNull)]
        public string Comune { get; set; }

        /// <summary>
        /// Nome dell'AOO
        /// </summary>
        [JsonProperty("des_aoo", Required = Required.Always)]
        public string DesAoo { get; set; }

        /// <summary>
        /// Numero di fax registrato in IPA per dell’AOO
        /// </summary>
        [JsonProperty("fax", Required = Required.AllowNull)]
        public string Fax { get; set; }

        /// <summary>
        /// Indirizzo postale registrato in IPA per la sede dell'AOO
        /// </summary>
        [JsonProperty("indirizzo", Required = Required.AllowNull)]
        public string Indirizzo { get; set; }

        /// <summary>
        /// Indirizzo email primario associato all’AOO
        /// </summary>
        [JsonProperty("mail1", Required = Required.AllowNull)]
        public string Mail1 { get; set; }

        /// <summary>
        /// Indirizzo email associato all’AOO
        /// </summary>
        [JsonProperty("mail2", Required = Required.AllowNull)]
        public string Mail2 { get; set; }

        /// <summary>
        /// Indirizzo email associato all’AOO
        /// </summary>
        [JsonProperty("mail3", Required = Required.AllowNull)]
        public string Mail3 { get; set; }

        /// <summary>
        /// Indirizzo email del responsabile dell'AOO
        /// </summary>
        [JsonProperty("mail_resp", Required = Required.AllowNull)]
        public string MailResp { get; set; }

        /// <summary>
        /// Nome del responsabile dell'AOO
        /// </summary>
        [JsonProperty("nome_resp", Required = Required.AllowNull)]
        public string NomeResp { get; set; }

        /// <summary>
        /// Provincia registrata in IPA per la sede dell'AOO
        /// </summary>
        [JsonProperty("provincia", Required = Required.AllowNull)]
        public string Provincia { get; set; }

        /// <summary>
        /// Regione registrata in IPA per la sede dell'AOO
        /// </summary>
        [JsonProperty("regione", Required = Required.AllowNull)]
        public string Regione { get; set; }

        /// <summary>
        /// Numero di telefono registrato in IPA per dell’AOO
        /// </summary>
        [JsonProperty("tel", Required = Required.AllowNull)]
        public string Tel { get; set; }

        /// <summary>
        /// Numero di telefono del responsabile dell'AOO
        /// </summary>
        [JsonProperty("tel_resp", Required = Required.AllowNull)]
        public string TelResp { get; set; }
    }
}
