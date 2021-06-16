//-----------------------------------------------------------------------
// <copyright file="Ws14_NSO_CF.cs" company="Studio A&T s.r.l.">
//     Copyright (c) Studio A&T s.r.l. All rights reserved.
// </copyright>
// <author>Nicogis</author>
//-----------------------------------------------------------------------
namespace FatturazioneElettronica.IPA
{
    using System.Collections.Generic;

    /// <summary>
    /// Questo servizio web consente di estrarre dall'iPA informazioni su tutti gli uffici che sono Nodi di Smistamento Ordini associati al Codice Fiscale fornito.
    /// </summary>
    public class Ws14_NSO_CF : Ws<Ws14>
	{
		public Ws14_NSO_CF(string codiceFiscale, string authId) : base(authId)
        { 
            this.CF = codiceFiscale;
        }

        

        public new Ws14 Request()
        {
            this.AddParameters(new KeyValuePair<string, string>("CF", this.CF));
            return base.Request();
        }

        public new System.Threading.Tasks.Task<Ws14> RequestAsync()
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

