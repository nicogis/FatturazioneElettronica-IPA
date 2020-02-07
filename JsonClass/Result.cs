namespace FatturazioneElettronica.IPA
{
    using Newtonsoft.Json;

    public partial class Result
    {
        /// <summary>
        /// Codice di ritorno
        /// </summary>
        [JsonProperty("cod_err", Required = Required.Always)]
        public double CodErr { get; set; }

        /// <summary>
        /// Descrizione errore
        /// </summary>
        [JsonProperty("desc_err", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string DescErr { get; set; }

        /// <summary>
        /// Numero di occorrenze trovate
        /// </summary>
        [JsonProperty("num_items", Required = Required.Always)]
        public double NumItems { get; set; }
    }

    public abstract class WsJson
    {
        
    }
}
