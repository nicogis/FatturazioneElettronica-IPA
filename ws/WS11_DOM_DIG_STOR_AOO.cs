//-----------------------------------------------------------------------
// <copyright file="Ws11_DOM_DIG_STOR_AOO.cs" company="Studio A&T s.r.l.">
//     Copyright (c) Studio A&T s.r.l. All rights reserved.
// </copyright>
// <author>Nicogis</author>
//-----------------------------------------------------------------------
namespace FatturazioneElettronica.IPA
{
    using System.Collections.Generic;

    /// <summary>
    /// Questo servizio web consente di estrarre dall'iPA informazioni relativa alla lista delle variazioni storiche dei domicili digitali di un Ente, 
    /// tramite la lista delle sue Aree Organizzative Omogenee o di una sua singola occorrenza. 
    /// </summary>
    public class Ws11_DOM_DIG_STOR_AOO : Ws<Ws11>
    {
        public Ws11_DOM_DIG_STOR_AOO(string codAmm, string codAOO, string authId) : base(authId)
        {
            this.CodAmm = codAmm;
            this.CodAOO = codAOO;
        }

        public Ws11_DOM_DIG_STOR_AOO(string codAmm, string authId) : this(codAmm, null, authId)
        {

        }

        public new Ws11 Request()
        {
            this.AddParameters(new KeyValuePair<string, string>("COD_AMM", this.CodAmm));
            this.AddParameters(new KeyValuePair<string, string>("COD_AOO", this.CodAOO));

            return base.Request();
        }

        public new System.Threading.Tasks.Task<Ws11> RequestAsync()
        {
            this.AddParameters(new KeyValuePair<string, string>("COD_AMM", this.CodAmm));
            this.AddParameters(new KeyValuePair<string, string>("COD_AOO", this.CodAOO));

            return base.RequestAsync();
        }

        public string CodAmm
        {
            get;
            set;
        }

        public string CodAOO
        {
            get;
            set;
        }

    }
}
