//-----------------------------------------------------------------------
// <copyright file="Ws18_AOO.cs" company="Studio A&T s.r.l.">
//     Copyright (c) Studio A&T s.r.l. All rights reserved.
// </copyright>
// <author>Nicogis</author>
//-----------------------------------------------------------------------
using System.Collections.Generic;

namespace FatturazioneElettronica.IPA
{
    /// <summary>
    /// Questo servizio web consente di estrarre dall'iPA informazioni relative ad una Area Organizzativa Omogenea
    /// </summary>
    public class Ws18_AOO : Ws<Ws18>
    {

        public Ws18_AOO(string codUniAOO, string authId) : base(authId)
        {
            this.CodUniAOO = codUniAOO;

        }

        public new Ws18 Request()
        {
            this.AddParameters(new KeyValuePair<string, string>("COD_UNI_AOO", this.CodUniAOO));


            return base.Request();
        }

        public string CodUniAOO
        {
            get;
            set;
        }

    }
}
