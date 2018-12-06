namespace FatturazioneElettronica.IPA
{
    using System.Collections.Generic;

    /// <summary>
    /// L’iPA mette a disposizione del pubblico una serie di informazioni che gli Enti in esso accreditati sono tenuti a pubblicare. Per ciascun Ente possono essere definite due entità: Unità Organizzative e Aree Organizzative Omogenee, a ciascuna delle quali possono essere associati una serie di servizi. Questo servizio web consente di estrarre dall’iPA informazioni relativa ad una entità, sia essa un Ente, un’Unità Organizzativa, un’Area Organizzativa Omogenea, un servizio generico, un Servizio di Fatturazione Elettronica, un Responsabile o un Referente, associata ad uno specifico indirizzo email.Se un indirizzo mail è associato a più entità all’interno di iPA, verranno visualizzate le informazioni di dettaglio relative a ciascuna delle entità individuate. 
    /// </summary>
    public class Ws07_EMAIL : Ws<Ws07>
    {
        public Ws07_EMAIL(string email, string authId) : base(authId)
        {
            this.Email = email; 
        }

        public new Ws07 Request()
        {
            this.AddParameters(new KeyValuePair<string, string>("EMAIL", this.Email));
            
            return base.Request();
        }

        public string Email
        {
            get;
            set;
        }

    }
}
