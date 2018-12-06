//-----------------------------------------------------------------------
// <copyright file="Ws01_SFE_CF.cs" company="Studio A&T s.r.l.">
//     Copyright (c) Studio A&T s.r.l. All rights reserved.
// </copyright>
// <author>Nicogis</author>
//-----------------------------------------------------------------------
namespace FatturazioneElettronica.IPA
{
    using System.Collections.Generic;

    /// <summary>
    /// L’iPA mette a disposizione del pubblico i dati utili alla Fatturazione Elettronica. Ogni ufficio (detto anche Unità Organizzativa) può essere individuato univocamente attraverso il codice detto: codice univoco dell’ufficio. Se un ufficio è destinatario di fatturazione elettronica, possiede anche altre informazioni (visibili on-line sul sito dell’iPA nella entità “Servizio di Fatturazione Elettronica”) oltre quelle inerenti l’ufficio stesso.  In particolare ad ogni Servizio di Fatturazione Elettronica degli Enti è associato anche un Codice Fiscale, il quale non identifica univocamente né l’ufficio destinatario di Fatturazione Elettronica né l’Ente di appartenenza di detto ufficio. In altre parole lo stesso codice fiscale può essere in uso a più Servizi di Fatturazione Elettronica e di Enti diversi.   Questo servizio web consente di estrarre dall’iPA informazioni su tutti gli uffici destinatari di Fatturazione Elettronica associati al Codice Fiscale fornito.
    /// </summary>
    public class Ws01_SFE_CF : Ws<Ws01>
	{
		public Ws01_SFE_CF(string codiceFiscale, string authId) : base(authId)
        { 
            this.CF = codiceFiscale;
        }

        public new Ws01 Request()
        {
            this.AddParameters(new KeyValuePair<string, string>("CF", this.CF));
            return base.Request();
        }

        public string CF
        {
            get;
            set;
        }
	}
}

