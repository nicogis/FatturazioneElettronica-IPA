namespace FatturazioneElettronica.IPA
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    /// Result: L’iPA mette a disposizione del pubblico una serie di informazioni relative alle Unità Organizzative di cui le amministrazione in esso accreditate risultano costituite. Ogni Unità Organizzativa può essere individuata univocamente attraverso un codice: il codice univoco dell’ufficio. Inoltre, se un ufficio è destinatario di fatturazione elettronica, ad esso risultano associate anche altre informazioni (visibili on-line sul sito dell’iPA nella entità “Servizio di Fatturazione Elettronica”), oltre quelle inerenti l’ufficio stesso.    Questo servizio web consente di estrarre dall’ iPA la lista delle Unità Organizzative facenti capo ad uno specifico codice iPA.
    /// </summary>
    public partial class Ws03 : WsJson
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataWs03> Data { get; set; }

        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public Result Result { get; set; }
    }

    public partial class DataWs03
    {
        /// <summary>
        /// CapregistratoinIPAperlasededell'UO
        /// </summary>
        [JsonProperty("cap", NullValueHandling = NullValueHandling.Ignore)]
        public string Cap { get; set; }

        /// <summary>
        /// Codice Ente accreditato in IPA
        /// </summary>
        [JsonProperty("cod_amm", NullValueHandling = NullValueHandling.Ignore)]
        public string CodAmm { get; set; }

        /// <summary>
        /// Codice AOO
        /// </summary>
        [JsonProperty("cod_aoo", NullValueHandling = NullValueHandling.Ignore)]
        public string CodAoo { get; set; }

        /// <summary>
        /// Codice Univoco dell'UO
        /// </summary>
        [JsonProperty("cod_uni_ou", NullValueHandling = NullValueHandling.Ignore)]
        public string CodUniOu { get; set; }

        /// <summary>
        /// Cognomedelresponsabiledell'UO
        /// </summary>
        [JsonProperty("cogn_resp", NullValueHandling = NullValueHandling.Ignore)]
        public string CognResp { get; set; }

        /// <summary>
        /// ComuneregistratoinIPAperlasededell'UO
        /// </summary>
        [JsonProperty("comune", NullValueHandling = NullValueHandling.Ignore)]
        public string Comune { get; set; }

        /// <summary>
        /// Nome dell'UO
        /// </summary>
        [JsonProperty("des_ou", NullValueHandling = NullValueHandling.Ignore)]
        public string DesOu { get; set; }

        /// <summary>
        /// NumerodifaxregistratoinIPAperdell’UO
        /// </summary>
        [JsonProperty("fax", NullValueHandling = NullValueHandling.Ignore)]
        public string Fax { get; set; }

        /// <summary>
        /// IndirizzopostaleregistratoinIPAperlasededell'UO
        /// </summary>
        [JsonProperty("indirizzo", NullValueHandling = NullValueHandling.Ignore)]
        public string Indirizzo { get; set; }

        /// <summary>
        /// Indirizzoemailprimarioassociatoall’UO
        /// </summary>
        [JsonProperty("mail1", NullValueHandling = NullValueHandling.Ignore)]
        public string Mail1 { get; set; }

        /// <summary>
        /// Indirizzoemailassociatoall’UO
        /// </summary>
        [JsonProperty("mail2", NullValueHandling = NullValueHandling.Ignore)]
        public string Mail2 { get; set; }

        /// <summary>
        /// Indirizzoemailassociatoall’UO
        /// </summary>
        [JsonProperty("mail3", NullValueHandling = NullValueHandling.Ignore)]
        public string Mail3 { get; set; }

        /// <summary>
        /// Indirizzoemaildelresponsabiledell'UO
        /// </summary>
        [JsonProperty("mail_resp", NullValueHandling = NullValueHandling.Ignore)]
        public string MailResp { get; set; }

        /// <summary>
        /// Nomedelresponsabiledell'UO
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
        /// NumeroditelefonoregistratoinIPAperdell’UO
        /// </summary>
        [JsonProperty("tel", NullValueHandling = NullValueHandling.Ignore)]
        public string Tel { get; set; }

        /// <summary>
        /// Numeroditelefonodelresponsabiledell'UO
        /// </summary>
        [JsonProperty("tel_resp", NullValueHandling = NullValueHandling.Ignore)]
        public string TelResp { get; set; }
    }
}
