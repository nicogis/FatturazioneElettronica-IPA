#### Indice delle Pubblice Amministrazioni

### Descrizione
Libreria sviluppata in c# per interrogare i web services dell'IPA. Per maggiore dettagli visitare il [sito iPA](https://www.indicepa.gov.it/documentale/n-consulta-dati.php)

Per utilizzare i Web Services è necessario chiedere una specifica autorizzazione. 
Occorre selezionare la voce del menu Richiedi Authorization ID e compilare la form dedicata al seguente [link](https://www.indicepa.gov.it/registr-user-ws/ws-registrazione-start.php)

### Utilizzo

```csharp

                myAuthId = "XXXXXXXX";
		
		Ws01_SFE_CF a = new Ws01_SFE_CF("03301860524", myAuthId);

		Ws01 aa = a.Request();

		

		Ws02_AOO b = new Ws02_AOO("03301860524", myAuthId);
		Ws02 bb = b.Request();

		

		Ws03_OU c = new Ws03_OU("03301860524", myAuthId);
		Ws03 cc = c.Request();

		

		Ws04_SFE d = new Ws04_SFE("03301860524", myAuthId);
		Ws04 dd = d.Request();

		

		Ws05_AMM e = new Ws05_AMM("03301860524", myAuthId);
		Ws05 ee = e.Request();

		

		Ws06_OU_CODUNI f = new Ws06_OU_CODUNI("000000", myAuthId);
		Ws06 ff = f.Request();

		

		Ws07_EMAIL g = new Ws07_EMAIL("pippo@pluto.it", myAuthId);
		Ws07 gg = g.Request();
		

		Ws08_AOOC h = new Ws08_AOOC("03301860524","2323" ,myAuthId);
		Ws08 hh = h.Request();
	   


```


### Installazione
```
	PM> Install-Package StudioAT.FatturazioneElettronica.IPA -Version 1.3.0
```
dalla Console di Gestione Pacchetti di Visual Studio

### Requisiti
Microsoft .NET 4.6.2 o superiore

### Licenza
Il progetto è rilasciato sotto licenza GNU Library General Public License (LGPL).
