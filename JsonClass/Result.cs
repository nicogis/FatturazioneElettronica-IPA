namespace FatturazioneElettronica.IPA
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public partial class Result
    {
        /// <summary>
        /// Codice di ritorno
        /// </summary>
        [JsonProperty("cod_err", Required = Required.Always)]
        public int CodErr { get; set; }

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

        /// <summary>
        /// Codice errore IPA
        /// </summary>
        public string CodErrDescription { 
            get
            {
                if (WsJson.ErrorCodes.ContainsKey(this.CodErr))
                {
                    return WsJson.ErrorCodes[this.CodErr];
                }

                return null;
            }
        }

    }

    public abstract class WsJson
    {
        internal static readonly Dictionary<int, string> ErrorCodes = new Dictionary<int, string>
        {   { 0, "Nessun errore" },
            { 1, "Parametro CF mancante" },
            { 2, "Parametro CF non valorizzato" },
            { 3, "Parametro CF valorizzato erroneamente" },
            { 11, "Parametro EMAIL non valorizzato" },
            { 12, "Parametro EMAIL valorizzato erroneamente" },
            { 20, "Parametro COD_AMM mancante" },
            {21 , "Parametro COD_AMM non valorizzato" },
            {22 , "Parametro COD_AMM valorizzato erroneamente" },
            {23 , "Valore COD_AMM non presente in archivio" },
            {30 , "Parametro COD_UNI_OU mancante" },
            {31 , "Parametro COD_UNI_OU non valorizzato" },
            {32 , "Parametro COD_UNI_OU valorizzato erroneamente" },
            {40 , "Parametro COD_AOO mancante" },
            {41 , "Parametro COD_AOO non valorizzato" },
            {42 , "Parametro COD_AOO valorizzato erroneamente" },
            {50 , "Parametro DESCR mancante" },
            {51 , "Parametro DESCR non valorizzato" },
            {52 , "Parametro DESCR valorizzato erroneamente" },
            {60 , "Parametro DOM_DIG mancante" },
            {61 , "Parametro DOM_DIG non valorizzato" },
            {62 , "Parametro DOM_DIG valorizzato erroneamente" },
            {70 , "Parametro COD_UNI_AOO mancante" },
            {71 , "Parametro COD_UNI_AOO non valorizzato" },
            {72 , "Parametro COD_UNI_AOO valorizzato erroneamente" },
            {900 , "Parametro AUTH_ID mancante" },
            {901 , "Parametro AUTH_ID non valorizzato" },
            {902 , "Parametro AUTH_ID valorizzato erroneamente" }
        };
    }
}
