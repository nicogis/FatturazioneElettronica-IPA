//-----------------------------------------------------------------------
// <copyright file="Ws16_DES_AMM.cs" company="Studio A&T s.r.l.">
//     Copyright (c) Studio A&T s.r.l. All rights reserved.
// </copyright>
// <author>Nicogis</author>
//-----------------------------------------------------------------------
namespace FatturazioneElettronica.IPA
{
    using System.Collections.Generic;

    /// <summary>
    /// Questo servizio web consente di estrarre dall'iPA informazioni relative ad una lista di Enti.
    /// </summary>
    public class Ws16_DES_AMM : Ws<Ws16>
    {
        public Ws16_DES_AMM(string descr, string authId) : base(authId)
        {
            this.Descr = descr;
            
        }


        public new Ws16 Request()
        {
            this.AddParameters(new KeyValuePair<string, string>("DESCR", this.Descr));
            

            return base.Request();
        }

        public new System.Threading.Tasks.Task<Ws16> RequestAsync()
        {
            this.AddParameters(new KeyValuePair<string, string>("DESCR", this.Descr));


            return base.RequestAsync();
        }

        public string Descr
        {
            get;
            set;
        }


    }
}
