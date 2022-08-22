//-----------------------------------------------------------------------
// <copyright file="Ws19_AOO.cs" company="Studio A&T s.r.l.">
//     Copyright (c) Studio A&T s.r.l. All rights reserved.
// </copyright>
// <author>Nicogis</author>
//-----------------------------------------------------------------------
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FatturazioneElettronica.IPA
{
    /// <summary>
    /// L'IPA consente la ricerca di informazioni utili relative alle Aree Organizzative Omogenee, 
    /// ove definite, per ciascun ente in esso accreditato.
    /// Ogni Area Organizzativa Omogenea, di seguito AOO, è univocamente individuata in due
    /// modalità:
    /// - codice univoco AOO, attribuito dal sistema, composto da 7 caratteri di cui il primo è
    /// sempre il carattere A. Tale codice è esposto nelle funzioni di consultazione a
    /// disposizione degli utenti pubblici del portale IPA e identifica univocamente l’AOO
    /// nell’intero indice.
    /// - codice AOO, attribuito dal singolo ente. Il codice identifica univocamente l'AOO solo
    /// nell’ambito del singolo ente, pertanto per identificare una AOO tra due enti è
    /// necessario combinare l’informazione con il codice IPA dell’ente.Tale codice non è
    /// presente nelle funzioni di consultazione a disposizione degli utenti pubblici del
    /// portale IPA.
    /// Questo servizio web consente di estrarre dall'IPA informazioni su una specifica Area
    /// Organizzativa Omogenea associata ad un ente fornendo il codice univoco AOO sopra
    /// definito.
    /// </summary>
    public class Ws19_AOO : Ws<Ws19>
    {

        public Ws19_AOO(string codAmm, string authId) : this(codAmm, null, null, authId)
        {
            this.CodAmm = codAmm;

        }

        public Ws19_AOO(string codAmm, string codUniAOO, string authId) : this(codAmm, codUniAOO, null,authId)
        {
            this.CodAmm = codAmm;
            this.CodUniAOO = codUniAOO;
        }

        public Ws19_AOO(string codAmm, string codUniAOO, string storico, string authId) : base(authId)
        {
            this.CodAmm = codAmm;
            this.CodUniAOO = codUniAOO;
            this.Storico = storico;
        }


        public new Ws19 Request()
        {
            this.AddParameters(new KeyValuePair<string, string>("COD_AMM", this.CodAmm));
            this.AddParameters(new KeyValuePair<string, string>("COD_UNI_AOO", this.CodUniAOO));
            this.AddParameters(new KeyValuePair<string, string>("STORICO", this.Storico));

            return base.Request();
        }

        public new Task<Ws19> RequestAsync()
        {
            this.AddParameters(new KeyValuePair<string, string>("COD_AMM", this.CodAmm));
            this.AddParameters(new KeyValuePair<string, string>("COD_UNI_AOO", this.CodUniAOO));
            this.AddParameters(new KeyValuePair<string, string>("STORICO", this.Storico));


            return base.RequestAsync();
        }

        public string CodAmm
        {
            get;
            set;
        }

        public string CodUniAOO
        {
            get;
            set;
        }

        public string Storico
        {
            get;
            set;
        }

    }
}
