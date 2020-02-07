namespace FatturazioneElettronica.IPA
{
    using Newtonsoft.Json;

    public partial class Ou
    {
        /// <summary>
        /// Codice Univoco Ufficio destinatario di Fatturazione Elettroniche
        /// </summary>
        [JsonProperty("cod_uni_ou", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string CodUniOu { get; set; }

        /// <summary>
        /// Denominazione Unita Organizzativa
        /// </summary>
        [JsonProperty("des_ou", Required = Required.Always)]
        public string DesOu { get; set; }

        /// <summary>
        /// A: Canale Attivo, V: In Fase di validazione
        /// </summary>
        [JsonProperty("stato_canale", Required = Required.Always)]
        public string StatoCanale { get; set; }
    }
}
