namespace FatturazioneElettronica.IPA
{
    using Newtonsoft.Json;

    public partial class Result
    {
        /// <summary>
        /// Codice di ritorno
        /// </summary>
        [JsonProperty("cod_err")]
        public double CodErr { get; set; }

        /// <summary>
        /// Descrizione errore
        /// </summary>
        [JsonProperty("desc_err", NullValueHandling = NullValueHandling.Ignore)]
        public string DescErr { get; set; }

        /// <summary>
        /// Numero di occorrenze trovate
        /// </summary>
        [JsonProperty("num_items")]
        public double NumItems { get; set; }
    }

    public abstract class WsJson
    {
        
    }
}
