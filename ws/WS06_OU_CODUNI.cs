namespace FatturazioneElettronica.IPA
{
    using System.Collections.Generic;

    /// <summary>
    /// L’iPA mette a disposizione del pubblico una serie di informazioni relative agli Enti in esso accreditati. A ciascun Ente possono essere associati una serie di uffici (detti anche Unità Organizzative). Ogni ufficio può essere individuato univocamente attraverso il codice detto: codice univoco dell’ufficio. Se un ufficio è destinatario di fatturazione elettronica, possiede anche altre informazioni (visibili on-line sul sito dell’iPA nella entità “Servizio di Fatturazione Elettronica”) oltre quelle inerenti l’ufficio stesso. In particolare ad ogni Servizio di Fatturazione Elettronica degli Enti è associato anche un Codice Fiscale, il quale non identifica univocamente ne l’ufficio destinatario di Fatturazione Elettronica ne l’Ente di appartenenza di detto ufficio. In altre parole lo stesso codice fiscale può essere in uso a più Servizi di Fatturazione Elettronica e di Enti diversi.   Questo servizio web consente di estrarre dall’ iPA informazioni relative ad una specifica Unità Organizzativa di un Ente accreditato in iPA. 
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
