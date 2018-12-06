namespace FatturazioneElettronica.IPA
{
    using System.Collections.Generic;

    /// <summary>
    /// L’iPA consente la ricerca di informazioni utili relative alle Aree Organizzative Omogenee, ove definite, per ciascuna amministrazione in esso accreditata. Ogni Area Organizzativa Omogenea (detta anche Ufficio di Protocollo) è univocamente individuata attraverso due codici: il codice iPA dell’amministrazione in cui è definita ed il codice AOO, ovvero il codice univoco assegnato all’AOO dall’Ente stesso all’atto della sua creazione. Gli uffici dell’Ente potranno poi essere associati esclusivamente ad una delle AOO definite per l’Ente stesso. Questo servizio web consente di estrarre dall’ iPA informazioni su tutte le aree organizzative omogenee associate al codice iPA fornito. Il servizio consente, inoltre, di impostare come parametro di ricerca anche il codice AOO, oltre il codice iPA. Si tenga presente che nel caso in cui l’utente fornisca congiuntamente i due codici (codice iPA e codice AOO) dalla ricerca potrà essere estratta solo ed esclusivamente una Area Organizzativa Omogenea.
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
