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
    /// Questo servizio web consente di estrarre dall' iPA la lista delle Unità Organizzative facenti capo ad uno specifico codice iPA. 
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

        public new System.Threading.Tasks.Task<Ws03> RequestAsync()
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
