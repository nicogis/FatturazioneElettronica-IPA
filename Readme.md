#### Indice delle Pubblice Amministrazioni

### Descrizione
Libreria sviluppata in c# per interrogare i web services dell'IPA. Per maggiore dettagli visitare il [sito iPA](https://www.indicepa.gov.it/documentale/n-consulta-dati.php)

Per utilizzare i Web Services è necessario chiedere una specifica autorizzazione. 
Occorre selezionare la voce del menu Richiedi Authorization ID e compilare la form dedicata al seguente [link](https://www.indicepa.gov.it/registr-user-ws/ws-registrazione-start.php)

### Utilizzo

```csharp

        myAuthId = "XXXXXXXX";
		
		Ws01_SFE_CF a = new Ws01_SFE_CF("81034410609", myAuthId);
		Ws01 aa = a.Request();

		Ws02_AOO b = new Ws02_AOO("192", myAuthId);
		Ws02 bb = b.Request();

		Ws02_AOO b1 = new Ws02_AOO("1CYVL", "A1O", myAuthId);
		Ws02 bb1 = b1.Request();

		Ws03_OU c = new Ws03_OU("192", myAuthId);
		Ws03 cc = c.Request();

		Ws04_SFE d = new Ws04_SFE("192", myAuthId);
		Ws04 dd = d.Request();

		Ws05_AMM e = new Ws05_AMM("192", myAuthId);
		Ws05 ee = e.Request();

		Ws06_OU_CODUNI f = new Ws06_OU_CODUNI("01-B5D", myAuthId);
		Ws06 ff = f.Request();

		Ws07_EMAIL g = new Ws07_EMAIL("info@sdsdw.it", myAuthId);
		Ws07 gg = g.Request();

		Ws08_AOOC h = new Ws08_AOOC("191", "asdssds", myAuthId);
		Ws08 hh = h.Request();

		Ws08_AOOC h1 = new Ws08_AOOC("193", myAuthId);
		Ws08 hh1 = h1.Request();

		Ws09_DOM_DIG_AOO j = new Ws09_DOM_DIG_AOO("6CMVL", "AO1", myAuthId);
		Ws09 jj = j.Request();

		Ws09_DOM_DIG_AOO j1 = new Ws09_DOM_DIG_AOO("6CMVL", myAuthId);
		Ws09 jj1 = j1.Request();

		Ws10_DOM_DIG_OU o = new Ws10_DOM_DIG_OU("1BGMYH", myAuthId);
		Ws10 oo = o.Request();

		Ws11_DOM_DIG_STOR_AOO w = new Ws11_DOM_DIG_STOR_AOO("155", "sadsd", myAuthId);
		Ws11 ww = w.Request();

		Ws11_DOM_DIG_STOR_AOO w1 = new Ws11_DOM_DIG_STOR_AOO("155", myAuthId);
		Ws11 ww1 = w1.Request();

		Ws12_DOM_DIG_STOR_OU s = new Ws12_DOM_DIG_STOR_OU("FBGMYH", myAuthId);
		Ws12 ss = s.Request();

		Ws13_DOM_DIG t = new Ws13_DOM_DIG("pdfdfsd@legalmail.it", myAuthId);
		Ws13 tt = t.Request();

		Ws14_NSO_CF v = new Ws14_NSO_CF( "11111111111",myAuthId);
		Ws14 vv = v.Request();

		Ws15_NSO v1 = new Ws15_NSO("156", myAuthId);
		Ws15 vv1 = v1.Request();

		Ws16_DES_AMM v2 = new Ws16_DES_AMM("asdfdfsdfsdfsdffd", myAuthId);
		Ws16 vv2 = v2.Request();
	   

```


### Installazione
```
	PM> Install-Package StudioAT.FatturazioneElettronica.IPA -Version 1.6.2
```
dalla Console di Gestione Pacchetti di Visual Studio

### Requisiti
Microsoft .NET 4.6.2 o superiore

### Licenza
Il progetto è rilasciato sotto licenza GNU Library General Public License (LGPL).
