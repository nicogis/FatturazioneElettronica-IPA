namespace FatturazioneElettronica.IPA
{
    using System.Collections.Generic;

    /// <summary>
    /// L’iPA mette a disposizione del pubblico i dati utili alla Fatturazione Elettronica. Ciascun servizio di fatturazione elettronica risulta associato ad un ufficio (detto anche Unità Organizzativa) che può essere individuato univocamente attraverso il codice detto: codice univoco dell’ufficio. L’ufficio destinatario di fatturazione elettronica, possiede anche altre informazioni (visibili on-line sul sito dell’ iPA nella entità “Servizio di Fatturazione Elettronica”) oltre quelle inerenti l’ufficio stesso.  In particolare ad ogni Servizio di Fatturazione Elettronica degli Enti è associato anche un Codice Fiscale, il quale non identifica univocamente né l’ufficio destinatario di Fatturazione Elettronica né l’Ente di appartenenza di detto ufficio, motivo per il quale lo stesso codice fiscale può essere in uso a più Servizi di Fatturazione Elettronica, nonché ad Enti differenti.   Questo servizio web consente di estrarre dall’iPA informazioni su tutti i Servizi di Fatturazione Elettronica associati ad un Ente specifico. 
    /// </summary>
    public class Ws04_SFE : Ws<Ws04>
    {
        public Ws04_SFE(string codAmm, string authId) : base(authId)
        {
            this.CodAmm = codAmm; 
        }

        public new Ws04 Request()
        {
            this.AddParameters(new KeyValuePair<string, string>("COD_AMM", this.CodAmm));
            
            return base.Request();
        }

        public string CodAmm
        {
            get;
            set;
        }

    }
}
