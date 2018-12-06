namespace FatturazioneElettronica.IPA
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    /// Response : L’iPA mette a disposizione del pubblico i dati utili alla Fatturazione Elettronica. Ogni ufficio (detto anche Unità Organizzativa) può essere individuato univocamente attraverso il codice detto: codice univoco dell’ufficio. Se un ufficio è destinatario di fatturazione elettronica, possiede anche altre informazioni (visibili on-line sul sito dell’iPA nella entità “Servizio di Fatturazione Elettronica”) oltre quelle inerenti l’ufficio stesso.  In particolare ad ogni Servizio di Fatturazione Elettronica degli Enti è associato anche un Codice Fiscale, il quale non identifica univocamente né l’ufficio destinatario di Fatturazione Elettronica né l’Ente di appartenenza di detto ufficio. In altre parole lo stesso codice fiscale può essere in uso a più Servizi di Fatturazione Elettronica e di Enti diversi.   Questo servizio web consente di estrarre dall’iPA informazioni su tutti gli uffici destinatari di Fatturazione Elettronica associati al Codice Fiscale fornito. 
    /// </summary>
    public partial class Ws01 : WsJson
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataWs01> Data { get; set; }

        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public Result Result { get; set; }
    }

    public partial class DataWs01
    {
        /// <summary>
        /// Codice Ente accreditato in IPA
        /// </summary>
        [JsonProperty("cod_amm")]
        public string CodAmm { get; set; }

        /// <summary>
        /// Denominazione Ente accreditato in IPA
        /// </summary>
        [JsonProperty("des_amm")]
        public string DesAmm { get; set; }

        [JsonProperty("OU", NullValueHandling = NullValueHandling.Ignore)]
        public List<Ou> Ou { get; set; }
    }

    public partial class Ou
    {
        /// <summary>
        /// Codice Univoco Ufficio destinatario di Fatturazione Elettroniche
        /// </summary>
        [JsonProperty("cod_uni_ou", NullValueHandling = NullValueHandling.Ignore)]
        public string CodUniOu { get; set; }

        /// <summary>
        /// Denominazione Unita Organizzativa
        /// </summary>
        [JsonProperty("des_ou")]
        public string DesOu { get; set; }

        /// <summary>
        /// A: Canale Attivo, V: In Fase di validazione
        /// </summary>
        [JsonProperty("stato_canale")]
        public string StatoCanale { get; set; }
    }
}