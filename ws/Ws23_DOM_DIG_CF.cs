//-----------------------------------------------------------------------
// <copyright file="Ws23_DOM_DIG_CF.cs" company="Studio A&T s.r.l.">
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
    public class Ws23_DOM_DIG_CF : Ws<Ws23>
    {
        public Ws23_DOM_DIG_CF(string cf, string authId) : base(authId)
        {
            this.CF = cf;

        }


        public new Ws23 Request()
        {
            this.AddParameters(new KeyValuePair<string, string>("CF", this.CF));


            return base.Request();
        }

        public new Task<Ws23> RequestAsync()
        {
            this.AddParameters(new KeyValuePair<string, string>("CF", this.CF));


            return base.RequestAsync();
        }

        public string CF
        {
            get;
            set;
        }


    }
}
