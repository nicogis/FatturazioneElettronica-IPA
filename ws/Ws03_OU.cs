//-----------------------------------------------------------------------
// <copyright file="Ws03_OU.cs" company="Studio A&T s.r.l.">
//     Copyright (c) Studio A&T s.r.l. All rights reserved.
// </copyright>
// <author>Nicogis</author>
//-----------------------------------------------------------------------
namespace FatturazioneElettronica.IPA
{
    using System.Collections.Generic;

    /// <summary>
    /// L’iPA mette a disposizione del pubblico una serie di informazioni relative alle Unità Organizzative di cui le amministrazione in esso accreditate risultano costituite. Ogni Unità Organizzativa può essere individuata univocamente attraverso un codice: il codice univoco dell’ufficio. Inoltre, se un ufficio è destinatario di fatturazione elettronica, ad esso risultano associate anche altre informazioni (visibili on-line sul sito dell’iPA nella entità “Servizio di Fatturazione Elettronica”), oltre quelle inerenti l’ufficio stesso.    Questo servizio web consente di estrarre dall’ iPA la lista delle Unità Organizzative facenti capo ad uno specifico codice iPA.
    /// </summary>
    public class Ws03_OU : Ws<Ws03>
    {
        public Ws03_OU(string codAmm, string authId) : base(authId)
        {
            this.CodAmm = codAmm; 
        }

        public new Ws03 Request()
        {
            this.AddParameters(new KeyValuePair<string, string>("COD_AMM", this.CodAmm));
            
            return base.Request();
        }

        public string CodAmm
        {
            get;
            set;
        }

    }
}
