//-----------------------------------------------------------------------
// <copyright file="Ws09_DOM_DIG_AOO.cs" company="Studio A&T s.r.l.">
//     Copyright (c) Studio A&T s.r.l. All rights reserved.
// </copyright>
// <author>Nicogis</author>
//-----------------------------------------------------------------------
namespace FatturazioneElettronica.IPA
{
    using System.Collections.Generic;

    /// <summary>
    /// Questo servizio web consente di estrarre dall'iPA informazioni relativa alla lista dei domicili digitali di un Ente, 
    /// tramite la lista delle sue Aree Organizzative Omogenee o di una sua singola occorrenza. 
    /// </summary>
    public class Ws09_DOMDIGAOO : Ws<Ws09>
    {
        public Ws09_DOMDIGAOO(string codAmm, string codAOO, string authId) : base(authId)
        {
            this.CodAmm = codAmm;
            this.CodAOO = codAOO;
        }

        public Ws09_DOMDIGAOO(string codAmm, string authId) : this(codAmm, null, authId)
        {

        }

        public new Ws09 Request()
        {
            this.AddParameters(new KeyValuePair<string, string>("COD_AMM", this.CodAmm));
            this.AddParameters(new KeyValuePair<string, string>("COD_AOO", this.CodAOO));

            return base.Request();
        }

        public new System.Threading.Tasks.Task<Ws09> RequestAsync()
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
