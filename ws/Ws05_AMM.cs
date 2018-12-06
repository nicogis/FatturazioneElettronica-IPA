//-----------------------------------------------------------------------
// <copyright file="Ws05_AMM.cs" company="Studio A&T s.r.l.">
//     Copyright (c) Studio A&T s.r.l. All rights reserved.
// </copyright>
// <author>Nicogis</author>
//-----------------------------------------------------------------------
namespace FatturazioneElettronica.IPA
{
    using System.Collections.Generic;

    /// <summary>
    /// L’iPA mette a disposizione del pubblico una serie di informazioni che gli Enti in esso accreditati sono tenuti a pubblicare. Per ciascun Ente possono essere definite: una struttura di Unità Organizzative e un insieme di Aree Organizzative Omogenee, a ciascuna delle quali possono essere associati una serie di servizi.  Questo servizio web consente di estrarre dall’ iPA informazioni relativa ad un Ente specifico. 
    /// </summary>
    public class Ws05_AMM : Ws<Ws05>
    {
        public Ws05_AMM(string codAmm, string authId) : base(authId)
        {
            this.CodAmm = codAmm; 
        }

        public new Ws05 Request()
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
