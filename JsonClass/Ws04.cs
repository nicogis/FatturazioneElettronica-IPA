namespace FatturazioneElettronica.IPA
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    /// Response: L’iPA mette a disposizione del pubblico i dati utili alla Fatturazione Elettronica. Ciascun servizio di fatturazione elettronica risulta associato ad un ufficio (detto anche Unità Organizzativa) che può essere individuato univocamente attraverso il codice detto: codice univoco dell’ufficio. L’ufficio destinatario di fatturazione elettronica, possiede anche altre informazioni (visibili on-line sul sito dell’ iPA nella entità “Servizio di Fatturazione Elettronica”) oltre quelle inerenti l’ufficio stesso.  In particolare ad ogni Servizio di Fatturazione Elettronica degli Enti è associato anche un Codice Fiscale, il quale non identifica univocamente né l’ufficio destinatario di Fatturazione Elettronica né l’Ente di appartenenza di detto ufficio, motivo per il quale lo stesso codice fiscale può essere in uso a più Servizi di Fatturazione Elettronica, nonché ad Enti differenti.   Questo servizio web consente di estrarre dall’iPA informazioni su tutti i Servizi di Fatturazione Elettronica associati ad un Ente specifico. 
    /// </summary>
    public partial class Ws04 : WsJson
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataWs04> Data { get; set; }

        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public Result Result { get; set; }
    }

    public partial class DataWs04
    {
        /// <summary>
        /// Codice fiscale del servizio di fatturazione elettronica
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
        /// Codice Univoco dell'Ufficio di fatturazione elettronica
        /// </summary>
        [JsonProperty("cod_uni_ou")]
        public string CodUniOu { get; set; }

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
        /// Data di validazione del cf
        /// </summary>
        [JsonProperty("dt_verifca_cf", NullValueHandling = NullValueHandling.Ignore)]
        public string DtVerifcaCf { get; set; }

        /// <summary>
        /// Stato del canale di fatturazione
        /// </summary>
        [JsonProperty("stato_canale", NullValueHandling = NullValueHandling.Ignore)]
        public string StatoCanale { get; set; }
    }
}
