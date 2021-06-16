//-----------------------------------------------------------------------
// <copyright file="Ws02_AOO.cs" company="Studio A&T s.r.l.">
//     Copyright (c) Studio A&T s.r.l. All rights reserved.
// </copyright>
// <author>Nicogis</author>
//-----------------------------------------------------------------------
namespace FatturazioneElettronica.IPA
{
    using System.Collections.Generic;

    /// <summary>
    /// Questo servizio web consente di estrarre dall' iPA informazioni su tutte le aree organizzative omogenee associate al codice iPA fornito. 
    /// Il servizio consente, inoltre, di impostare come parametro di ricerca anche il codice AOO, oltre il codice iPA. 
    /// Si tenga presente che nel caso in cui l'utente fornisca congiuntamente i due codici (codice iPA e codice AOO) dalla ricerca potrà essere estratta solo 
    /// ed esclusivamente una Area Organizzativa Omogenea. 
    /// </summary>
    public class Ws02_AOO : Ws<Ws02>
    {
        public Ws02_AOO(string codAmm, string codAOO, string authId) : base(authId)
        {
            this.CodAmm = codAmm;
            this.CodAOO = codAOO;
        }

        public Ws02_AOO(string codAmm, string authId) : this(codAmm, null, authId)
        {
            
        }

        public new Ws02 Request()
        {
            this.AddParameters(new KeyValuePair<string, string>("COD_AMM", this.CodAmm));
            this.AddParameters(new KeyValuePair<string, string>("COD_AOO", this.CodAOO));
            
            return base.Request();
        }

        public new System.Threading.Tasks.Task<Ws02> RequestAsync()
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
