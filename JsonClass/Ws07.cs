namespace FatturazioneElettronica.IPA
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    /// Response: L’iPA mette a disposizione del pubblico una serie di informazioni che gli Enti in esso accreditati sono tenuti a pubblicare. Per ciascun Ente possono essere definite due entità: Unità Organizzative e Aree Organizzative Omogenee, a ciascuna delle quali possono essere associati una serie di servizi. Questo servizio web consente di estrarre dall’iPA informazioni relativa ad una entità, sia essa un Ente, un’Unità Organizzativa, un’Area Organizzativa Omogenea, un servizio generico, un Servizio di Fatturazione Elettronica, un Responsabile o un Referente, associata ad uno specifico indirizzo email.Se un indirizzo mail è associato a più entità all’interno di iPA, verranno visualizzate le informazioni di dettaglio relative a ciascuna delle entità individuate. 
    /// </summary>
    public partial class Ws07 : WsJson
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataWs07> Data { get; set; }

        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public Result Result { get; set; }
    }

    public partial class DataWs07
    {
        /// <summary>
        /// Codice Ente accreditato in IPA
        /// </summary>
        [JsonProperty("cod_amm")]
        public string CodAmm { get; set; }

        /// <summary>
        /// Codice dell'entità
        /// </summary>
        [JsonProperty("cod_entita")]
        public string CodEntita { get; set; }

        /// <summary>
        /// Denominazione Ente accreditato in IPA
        /// </summary>
        [JsonProperty("des_amm", NullValueHandling = NullValueHandling.Ignore)]
        public string DesAmm { get; set; }

        /// <summary>
        /// Tipo email:PEC|CECPAC|ALTRO
        /// </summary>
        [JsonProperty("tipo_email", NullValueHandling = NullValueHandling.Ignore)]
        public string TipoEmail { get; set; }

        /// <summary>
        /// Tipo entità: AMM|AOO|UO|SERVAMM|SERVAOO|SERVOU|RESPAOO|RESPUO
        /// </summary>
        [JsonProperty("tipo_entita")]
        public string TipoEntita { get; set; }
    }

    
}
