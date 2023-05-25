namespace FatturazioneElettronica.IPA
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.ConstrainedExecution;
    using System.Security.Cryptography;
    using System.Xml.Linq;

    /// <summary>
    /// L’Indice dei domicili digitali delle Pubbliche Amministrazioni e dei gestori di pubblici 
    /// servizi(IPA) è l’elenco pubblico di fiducia contenente i domicili digitali da utilizzare per
    /// le comunicazioni e per lo scambio di informazioni e per l’invio di documenti validi a tutti
    /// gli effetti di legge tra le pubbliche amministrazioni, i gestori di pubblici servizi e i privati.
    /// I domicili digitali di un ente accreditato in IPA sono gli indirizzi elettronici eletti presso
    /// un servizio di posta elettronica certificata o un servizio elettronico di recapito certificato
    /// qualificato valido ai fini delle comunicazioni elettroniche aventi valore legale associati
    /// alle Aree Organizzative Omogenee dell’ente stesso.
    /// Ogni Ente è identificato univocamente dal suo Codice Fiscale inserito in fase di
    /// accreditamento in IPA.
    /// Ogni Servizio di fatturazione elettronica è caratterizzato da un Codice Fiscale ed essere
    /// associato ad una ed una sola Unità organizzativa che può essere dotata di domicili
    /// digitali.
    /// Il Codice Fiscale di un Ente e di un Servizio di fatturazione elettronica sono esposti nelle
    /// informazioni dell’Ente consultabili sul portale IPA.
    /// Questo servizio web consente di estrarre dall’IPA la lista dei domicili digitali di un ente e
    /// dei suoi Servizi di fatturazione elettronica fornendone il relativo Codice Fiscale.
    /// </summary>
    public partial class Ws23 : WsJson
    {
        [JsonProperty("data", Required = Required.AllowNull)]
        public List<DataWs23> Data { get; set; }

        [JsonProperty("result", Required = Required.Always)]
        public Result Result { get; set; }
    }

    public partial class DataWs23
    {
        /// <summary>
        /// Codice dell'Ente come è accreditato sull'iPA
        /// </summary>
        [JsonProperty("cod_amm", Required = Required.Always)]
        public string CodAmm { get; set; }

        /// <summary>
        /// Descrizione dell'Ente
        /// </summary>
        [JsonProperty("des_amm", Required = Required.Always)]
        public string DesAmm { get; set; }

        /// <summary>
        /// PEC o servizio elettronico di recapito certificato qualificato associato ad una AOO
        /// </summary>
        [JsonProperty("domicilio_digitale", Required = Required.Always)]
        public string DomicilioDigitale { get; set; }

        /// <summary>
        /// Tipo domicilio digitale
        /// </summary>
        [JsonProperty("tipo", Required = Required.Always)]
        public string Tipo { get; set; }
    }
}
