//-----------------------------------------------------------------------
// <copyright file="Ws13_DOM_DIG.cs" company="Studio A&T s.r.l.">
//     Copyright (c) Studio A&T s.r.l. All rights reserved.
// </copyright>
// <author>Nicogis</author>
//-----------------------------------------------------------------------
namespace FatturazioneElettronica.IPA
{
    using System.Collections.Generic;

    /// <summary>
    /// Questo servizio web consente di estrarre dall'iPA informazioni relativa alla lista delle variazioni storiche di un domicilio digitale. 
    /// </summary>
    public class Ws13_DOM_DIG : Ws<Ws13>
    {
        public Ws13_DOM_DIG(string domDig, string authId) : base(authId)
        {
            this.DomDig = domDig; 
        }

        public new Ws13 Request()
        {
            this.AddParameters(new KeyValuePair<string, string>("DOM_DIG", this.DomDig));
            
            return base.Request();
        }

        public new System.Threading.Tasks.Task<Ws13> RequestAsync()
        {
            this.AddParameters(new KeyValuePair<string, string>("DOM_DIG", this.DomDig));

            return base.RequestAsync();
        }

        public string DomDig
        {
            get;
            set;   
        }

    }
}
