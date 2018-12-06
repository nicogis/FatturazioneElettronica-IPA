namespace FatturazioneElettronica.IPA
{
    using Newtonsoft.Json;

    /// <summary>
    /// Response: L’iPA mette a disposizione del pubblico una serie di informazioni relative agli Enti in esso accreditati. A ciascun Ente possono essere associati una serie di uffici (detti anche Unità Organizzative). Ogni ufficio può essere individuato univocamente attraverso il codice detto: codice univoco dell’ufficio. Se un ufficio è destinatario di fatturazione elettronica, possiede anche altre informazioni (visibili on-line sul sito dell’iPA nella entità “Servizio di Fatturazione Elettronica”) oltre quelle inerenti l’ufficio stesso. In particolare ad ogni Servizio di Fatturazione Elettronica degli Enti è associato anche un Codice Fiscale, il quale non identifica univocamente ne l’ufficio destinatario di Fatturazione Elettronica ne l’Ente di appartenenza di detto ufficio. In altre parole lo stesso codice fiscale può essere in uso a più Servizi di Fatturazione Elettronica e di Enti diversi.   Questo servizio web consente di estrarre dall’ iPA informazioni relative ad una specifica Unità Organizzativa di un Ente accreditato in iPA. 
    /// </summary>
    public partial class Ws06 : WsJson
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public DataWs06 Data { get; set; }

        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public Result Result { get; set; }
    }

    public partial class DataWs06
    {
        /// <summary>
        /// Cap registrato in IPA per la sede dell'UO
        /// </summary>
        [JsonProperty("cap", NullValueHandling = NullValueHandling.Ignore)]
        public string Cap { get; set; }

        /// <summary>
        /// Codice fiscale del servizio di faturazione
        /// </summary>
        [JsonProperty("cf")]
        public string Cf { get; set; }

        /// <summary>
        /// Codice Ente accreditato in IPA
        /// </summary>
        [JsonProperty("cod_amm")]
        public string CodAmm { get; set; }

        /// <summary>
        /// Codice AOO
        /// </summary>
        [JsonProperty("cod_aoo", NullValueHandling = NullValueHandling.Ignore)]
        public string CodAoo { get; set; }

        /// <summary>
        /// Codice Univoco dell'UO
        /// </summary>
        [JsonProperty("cod_uni_ou")]
        public string CodUniOu { get; set; }

        /// <summary>
        /// Cognome del responsabile dell'UO
        /// </summary>
        [JsonProperty("cogn_resp", NullValueHandling = NullValueHandling.Ignore)]
        public string CognResp { get; set; }

        /// <summary>
        /// Comune registrato in IPA per la sede dell'UO
        /// </summary>
        [JsonProperty("comune", NullValueHandling = NullValueHandling.Ignore)]
        public string Comune { get; set; }

        /// <summary>
        /// Data di inizio validità del servizio di fatturazione
        /// </summary>
        [JsonProperty("dat_val_canale_trasm_sfe", NullValueHandling = NullValueHandling.Ignore)]
        public string DatValCanaleTrasmSfe { get; set; }

        /// <summary>
        /// Nome dell'UO
        /// </summary>
        [JsonProperty("des_ou", NullValueHandling = NullValueHandling.Ignore)]
        public string DesOu { get; set; }

        /// <summary>
        /// Data di validazione del cf del servizio di fatturazione
        /// </summary>
        [JsonProperty("dt_verifica_cf", NullValueHandling = NullValueHandling.Ignore)]
        public string DtVerificaCf { get; set; }

        /// <summary>
        /// Numero di fax dell'UO
        /// </summary>
        [JsonProperty("fax", NullValueHandling = NullValueHandling.Ignore)]
        public string Fax { get; set; }

        /// <summary>
        /// Indirizzo postale registrato in IPA per la sede dell'UO
        /// </summary>
        [JsonProperty("indirizzo", NullValueHandling = NullValueHandling.Ignore)]
        public string Indirizzo { get; set; }

        /// <summary>
        /// Indirizzo email primario associato all’UO
        /// </summary>
        [JsonProperty("mail1", NullValueHandling = NullValueHandling.Ignore)]
        public string Mail1 { get; set; }

        /// <summary>
        /// Indirizzo email associato all’UO
        /// </summary>
        [JsonProperty("mail2", NullValueHandling = NullValueHandling.Ignore)]
        public string Mail2 { get; set; }

        /// <summary>
        /// Indirizzo email associato all’UO
        /// </summary>
        [JsonProperty("mail3", NullValueHandling = NullValueHandling.Ignore)]
        public string Mail3 { get; set; }

        /// <summary>
        /// Cognome del responsabile dell'UO
        /// </summary>
        [JsonProperty("mail_resp", NullValueHandling = NullValueHandling.Ignore)]
        public string MailResp { get; set; }

        /// <summary>
        /// Nome del responsabile dell'UO
        /// </summary>
        [JsonProperty("nome_resp", NullValueHandling = NullValueHandling.Ignore)]
        public string NomeResp { get; set; }

        /// <summary>
        /// Provincia registrata in IPA per la sede dell'UO
        /// </summary>
        [JsonProperty("provincia", NullValueHandling = NullValueHandling.Ignore)]
        public string Provincia { get; set; }

        /// <summary>
        /// Regione registrata in IPA per la sede dell'UO
        /// </summary>
        [JsonProperty("regione", NullValueHandling = NullValueHandling.Ignore)]
        public string Regione { get; set; }

        /// <summary>
        /// Stato del canale di fatturazione; A:Attivo|V=In fase di validazione
        /// </summary>
        [JsonProperty("stato_canale", NullValueHandling = NullValueHandling.Ignore)]
        public string StatoCanale { get; set; }

        /// <summary>
        /// Numero di telefono dell'UO
        /// </summary>
        [JsonProperty("tel", NullValueHandling = NullValueHandling.Ignore)]
        public string Tel { get; set; }

        /// <summary>
        /// Cognome del responsabile dell'UO
        /// </summary>
        [JsonProperty("tel_resp", NullValueHandling = NullValueHandling.Ignore)]
        public string TelResp { get; set; }
    }
}
