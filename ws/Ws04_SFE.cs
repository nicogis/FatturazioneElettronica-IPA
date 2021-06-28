//-----------------------------------------------------------------------
// <copyright file="Ws04_SFE.cs" company="Studio A&T s.r.l.">
//     Copyright (c) Studio A&T s.r.l. All rights reserved.
// </copyright>
// <author>Nicogis</author>
//-----------------------------------------------------------------------
namespace FatturazioneElettronica.IPA
{
    using System.Collections.Generic;

    /// <summary>
    /// Questo servizio web consente di estrarre dall'iPA informazioni su tutti i Servizi di Fatturazione Elettronica associati ad un Ente specifico.
    /// </summary>
    public class Ws04_SFE : Ws<Ws04>
    {
        public Ws04_SFE(string codAmm, string authId) : base(authId)
        {
            this.CodAmm = codAmm; 
        }

        public new Ws04 Request()
        {
            this.AddParameters(new KeyValuePair<string, string>("COD_AMM", this.CodAmm));
            
            return base.Request();
        }

        public new System.Threading.Tasks.Task<Ws04> RequestAsync()
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
