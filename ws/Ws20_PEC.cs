//-----------------------------------------------------------------------
// <copyright file="Ws20_PEC.cs" company="Studio A&T s.r.l.">
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
    /// Questo servizio web consente di estrarre dall’IPA la lista delle PEC di un ente fornendo il
    /// relativo codice IP
    /// </summary>
    public class Ws20_PEC : Ws<Ws20>
    {
        public Ws20_PEC(string codAmm, string authId) : base(authId)
        {
            this.CodAmm = codAmm;

        }


        public new Ws20 Request()
        {
            this.AddParameters(new KeyValuePair<string, string>("COD_AMM", this.CodAmm));


            return base.Request();
        }

        public new Task<Ws20> RequestAsync()
        {
            this.AddParameters(new KeyValuePair<string, string>("COD_AMM", this.CodAmm));


            return base.RequestAsync();
        }

        public string CodAmm
        {
            get;
            set;
        }


    }


}
