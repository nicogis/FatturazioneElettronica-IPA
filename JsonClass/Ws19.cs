namespace FatturazioneElettronica.IPA
{
    using Newtonsoft.Json;

    /// <summary>
    /// L'IPA consente la ricerca di informazioni utili relative alle Aree Organizzative Omogenee, 
    /// ove definite, per ciascun ente in esso accreditato.
    /// Ogni Area Organizzativa Omogenea, di seguito AOO, è univocamente individuata in due
    /// modalità:
    /// - codice univoco AOO, attribuito dal sistema, composto da 7 caratteri di cui il primo è
    /// sempre il carattere A. Tale codice è esposto nelle funzioni di consultazione a
    /// disposizione degli utenti pubblici del portale IPA e identifica univocamente l’AOO
    /// nell’intero indice.
    /// - codice AOO, attribuito dal singolo ente. Il codice identifica univocamente l'AOO solo
    /// nell’ambito del singolo ente, pertanto per identificare una AOO tra due enti è
    /// necessario combinare l’informazione con il codice IPA dell’ente.Tale codice non è
    /// presente nelle funzioni di consultazione a disposizione degli utenti pubblici del
    /// portale IPA.
    /// Questo servizio web consente di estrarre dall'IPA informazioni su una specifica Area
    /// Organizzativa Omogenea associata ad un ente fornendo il codice univoco AOO sopra
    /// definito.
    /// </summary>
    public partial class Ws19 : WsJson
    {
        [JsonProperty("data", Required = Required.AllowNull)]
        public DataWs19 Data { get; set; }

        [JsonProperty("result", Required = Required.Always)]
        public Result Result { get; set; }
    }

    public partial class DataWs19
    {
        /// <summary>
        /// Codice di avviamento postale registrato in iPA per la sede dell'Area Organizzativa
        /// Omogenea
        /// </summary>
        [JsonProperty("cap", Required = Required.AllowNull)]
        public string Cap { get; set; }

        /// <summary>
        /// Codice dell'Ente come è accreditato sull'iPA
        /// </summary>
        [JsonProperty("cod_amm", Required = Required.Always)]
        public string CodAmm { get; set; }

        /// <summary>
        /// Codice dell'Area organizzativa Omogenea
        /// </summary>
        [JsonProperty("cod_aoo", Required = Required.Always)]
        public string CodAoo { get; set; }

        /// <summary>
        /// Codice univoco dell'Area organizzativa Omogenea
        /// </summary>
        [JsonProperty("cod_uni_aoo", Required = Required.Always)]
        public string CodUniAoo { get; set; }

        /// <summary>
        /// Cognome del responsabile dell'Area Organizzativa Omogenea
        /// </summary>
        [JsonProperty("cogn_resp", Required = Required.AllowNull)]
        public string CognResp { get; set; }

        /// <summary>
        /// Comune registrato in iPA per la sede dell'Area Organizzativa Omogenea
        /// </summary>
        [JsonProperty("comune", Required = Required.AllowNull)]
        public string Comune { get; set; }

        /// <summary>
        /// Data di cessazione dell'Area Organizzativa Omogenea
        /// </summary>
        [JsonProperty("data_cessazione", Required = Required.Always)]
        public string DataCessazione { get; set; }

        /// <summary>
        /// Denominazione dell'Area Organizzativa Omogenea
        /// </summary>
        [JsonProperty("des_aoo", Required = Required.Always)]
        public string DesAoo { get; set; }

        /// <summary>
        /// Numero di fax registrato in iPA per l'Area Organizzativa Omogenea
        /// </summary>
        [JsonProperty("fax", Required = Required.AllowNull)]
        public string Fax { get; set; }

        /// <summary>
        /// Indirizzo postale registrato in iPA per la sede dell'Area Organizzativa Omogenea
        /// </summary>
        [JsonProperty("indirizzo", Required = Required.AllowNull)]
        public string Indirizzo { get; set; }

        /// <summary>
        /// Indirizzo email associato all'Area Organizzativa Omogenea di tipo PEC
        /// </summary>
        [JsonProperty("mail1", Required = Required.AllowNull)]
        public string Mail1 { get; set; }

        /// <summary>
        /// Indirizzo email associato all'Area Organizzativa Omogenea di tipo PEC
        /// </summary>
        [JsonProperty("mail2", Required = Required.AllowNull)]
        public string Mail2 { get; set; }

        /// <summary>
        /// Indirizzo email associato all'Area Organizzativa Omogenea di tipo PEC
        /// </summary>
        [JsonProperty("mail3", Required = Required.AllowNull)]
        public string Mail3 { get; set; }

        /// <summary>
        /// Indirizzo email del responsabile dell'Area Organizzativa Omogenea
        /// </summary>
        [JsonProperty("mail_resp", Required = Required.AllowNull)]
        public string MailResp { get; set; }

        /// <summary>
        /// Nome del responsabile dell'Area Organizzativa Omogenea
        /// </summary>
        [JsonProperty("nome_resp", Required = Required.AllowNull)]
        public string NomeResp { get; set; }

        /// <summary>
        /// Provincia registrata in iPA per la sede dell'Area Organizzativa Omogenea
        /// </summary>
        [JsonProperty("provincia", Required = Required.AllowNull)]
        public string Provincia { get; set; }

        /// <summary>
        /// Regione registrata in iPA per la sede dell'Area Organizzativa Omogenea
        /// </summary>
        [JsonProperty("regione", Required = Required.AllowNull)]
        public string Regione { get; set; }

        /// <summary>
        /// Numero di telefono registrato in iPA per l'Area Organizzativa Omogenea
        /// </summary>
        [JsonProperty("tel", Required = Required.AllowNull)]
        public string Tel { get; set; }

        /// <summary>
        /// Numero di telefono del responsabile dell'Area Organizzativa Omogenea
        /// </summary>
        [JsonProperty("tel_resp", Required = Required.AllowNull)]
        public string TelResp { get; set; }
    }
}
