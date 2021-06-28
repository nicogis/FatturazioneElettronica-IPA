//-----------------------------------------------------------------------
// <copyright file="Ws08_AOOC.cs" company="Studio A&T s.r.l.">
//     Copyright (c) Studio A&T s.r.l. All rights reserved.
// </copyright>
// <author>Nicogis</author>
//-----------------------------------------------------------------------
namespace FatturazioneElettronica.IPA
{
    using System.Collections.Generic;
    using System.Threading.Tasks;


    /// <summary>
    /// Questo servizio web consente di estrarre dall'iPA informazioni su tutti gli uffici che sono Nodi di Smistamento Ordini associati ad un Ente specifico.
    /// </summary>
    public class Ws15_NSO : Ws<Ws15>
    {
        public Ws15_NSO(string codAmm, string authId) : base(authId)
        {
            this.CodAmm = codAmm;
            
        }

        public new Ws15 Request()
        {
            this.AddParameters(new KeyValuePair<string, string>("COD_AMM", this.CodAmm));
            

            return base.Request();
        }

        public new Task<Ws15> RequestAsync()
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
