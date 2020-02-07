//-----------------------------------------------------------------------
// <copyright file="Ws12_DOM_DIG_STOR_OU.cs" company="Studio A&T s.r.l.">
//     Copyright (c) Studio A&T s.r.l. All rights reserved.
// </copyright>
// <author>Nicogis</author>
//-----------------------------------------------------------------------
namespace FatturazioneElettronica.IPA
{
    using System.Collections.Generic;

    /// <summary>
    /// Questo servizio web consente di estrarre dall'iPA informazioni relativa alla lista delle variazioni storiche dei domicili digitali di un Ufficio, 
    /// corrispondente alla lista dei domicili digitali della AOO da cui dipende o è dipeso. 
    /// </summary>
    public class Ws12_DOM_DIG_STOR_OU : Ws<Ws12>
    {
        public Ws12_DOM_DIG_STOR_OU(string codUniOU, string authId) : base(authId)
        {
            this.CodUniOU = codUniOU; 
        }

        public new Ws12 Request()
        {
            this.AddParameters(new KeyValuePair<string, string>("COD_UNI_OU", this.CodUniOU));
            
            return base.Request();
        }

        public string CodUniOU
        {
            get;
            set;   
        }

    }
}
