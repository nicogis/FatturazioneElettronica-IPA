﻿//-----------------------------------------------------------------------
// <copyright file="Ws06_OU_CODUNI.cs" company="Studio A&T s.r.l.">
//     Copyright (c) Studio A&T s.r.l. All rights reserved.
// </copyright>
// <author>Nicogis</author>
//-----------------------------------------------------------------------
namespace FatturazioneElettronica.IPA
{
    using System.Collections.Generic;

    /// <summary>
    /// Questo servizio web consente di estrarre dall' iPA informazioni relative ad una specifica Unità Organizzativa di un Ente accreditato in iPA. 
    /// </summary>
    public class Ws06_OU_CODUNI : Ws<Ws06>
    {
        public Ws06_OU_CODUNI(string codUniOU, string authId) : base(authId)
        {
            this.CodUniOU = codUniOU; 
        }

        public new Ws06 Request()
        {
            this.AddParameters(new KeyValuePair<string, string>("COD_UNI_OU", this.CodUniOU));
            
            return base.Request();
        }

        private string codUniOU = null;
        public string CodUniOU
        {
            get { return codUniOU; }
            set
            {
                if (value?.Length != 6)
                {
                    throw new System.Exception("COD_UNI_OU deve essere di 6 caratteri!");
                }

                codUniOU = value; 
            }
                
        }

    }
}
