//-----------------------------------------------------------------------
// <copyright file="Ws22_PEC_STOR.cs" company="Studio A&T s.r.l.">
//     Copyright (c) Studio A&T s.r.l. All rights reserved.
// </copyright>
// <author>Nicogis</author>
//-----------------------------------------------------------------------
namespace FatturazioneElettronica.IPA
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// L’Indice dei domicili digitali delle Pubbliche Amministrazioni e dei gestori di pubblici 
    /// servizi(IPA) è l’elenco pubblico di fiducia contenente i domicili digitali da utilizzare per
    /// le comunicazioni e per lo scambio di informazioni e per l’invio di documenti validi a tutti
    /// gli effetti di legge tra le pubbliche amministrazioni, i gestori di pubblici servizi e i privati.
    /// Le PEC di un ente accreditato in IPA sono gli indirizzi elettronici eletti presso un servizio
    /// di posta elettronica certificata.
    /// Ogni ente è identificato univocamente dal codice IPA attribuito al termine del processo
    /// di accreditamento in IPA.
    /// Il codice IPA di un ente è esposto nelle informazioni dell’ente consultabili sul portale IPA.
    /// Questo servizio web consente di estrarre dall’IPA la lista delle PEC che un ente ha eletto
    /// dal momento del suo accreditamento in IPA sino alla data di estrazione.
    /// Il servizio consente, inoltre, di ottenere l’elenco delle PEC elette nel tempo, riportando le
    /// date in cui sono intercorse tutte le variazioni, impostando come parametro di ricerca il
    /// codice IPA.
    /// </summary>
    public class Ws22_PEC_STOR : Ws<Ws22>
    {
        public Ws22_PEC_STOR(string pec, string authId) : base(authId)
        {
            this.PEC = pec;

        }


        public new Ws22 Request()
        {
            this.AddParameters(new KeyValuePair<string, string>("PEC", this.PEC));


            return base.Request();
        }

        public new Task<Ws22> RequestAsync()
        {
            this.AddParameters(new KeyValuePair<string, string>("PEC", this.PEC));


            return base.RequestAsync();
        }

        public string PEC
        {
            get;
            set;
        }


    }
}