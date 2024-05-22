La SELECT è una proiezioni es. SELECT * FROM PERSONA WHERE PERSONAID = 1 Selezione tutte le colonne dalla tabella persona dove filtriamo con il WHERE per personaID

FOREIGN KEY VINCOLO D' IDENTITA RELAZIONALE

DDL: Data Definition Language, manipoliamo la struttura del database
DML: Data Manipolation Language, manipoliamo i dati
QL: Query Language: Non posso modificare dati con il QL serve solo a filtrare dati
Store Procedure: è un metodo che permette di effettuare operazioni DML o QL passando dei parametri tabelle temporanee

View: Una tabella virtuale il cui contenuto è definito da una query

Struttura ereditaria di interfaccie
contenitori di IEnumerable ICollection IList List Abbiamo 3 interfaccie per i principi SOLID di programmazione

Tipo oggetto: Istanza di una classe

Tipo Primitivo: stringhe, interi, booleano

Framework: Un insieme di librerie che intercorrono tra di loro

Posso effettuare l override(La ridefinizione) di un metodo solo se il metodo è virtual.

I metodi astratti sono metodi senza corpo e devono per forza essere implementati nelle classi figlie

Utilizzo dell'interfaccia su metodi generici

DAL design pattern architetturale

Il generic è un tipo generico che tramite generico tipo possiamo poi utilizzarlo nel tipo di cui abbiamo bisogno lo utlizziamo nelle interfaccie

Var posso ridichiarla let una volta ridichiarata può essere sovrascritta ma dichiarata una volta sola

Scope globale(contesto)

Static: Definiamo static un attributto o un metodo che all avvio del programma viene allocato

Entrypoint: il main è il nostro entrypoint

La firma di un metodo è una firma (signature) ovvero la definizione/dichiarazione del metodo con tipo di ritorno, nome del metodo, tipo e nome degli eventuali parametri passati in input

overload è possibilità di ridefinire un metodo con diversa firma

REST API:(Application programm interface) interfaccia di programmazione delle applicazioni conforme, interrogata tramite protocollo e rispettando una tipologia di comunicazione (JSON combinazione chiave valore, XML)

Architettura client server:

Richiesta client server in protocollo http

GET: Una richiesta get passa per l URL web, ha un limite di caratteri che possiamo richiedere, ha un destinatario e un mittente e di risposta una stringa (negli header)

POST: Nella post inserisco mittente e destinatario nell'header mentre il suo contenuto è nel body Se il payload è troppo grande viene scomposto in automatico dall'altro lato, se perdo un pacchetto questo viene rinviato

Serializzatore json

Buffer overflow Parse riconosce i vari elementi dell'oggetto

Stringify trasforma l'oggetto in una stringa

mine type l' encoding, suggerita al destinatario per leggere il nostro dato

La pagina HTML inizia con il DOCTYPE serve a suggerire il tipo di scrittura del codice

Un browser è un

Chrome

La restfull costruisce gli endPoint

Una view è una tabella virtuale il cui contenuto è definito da una query

Una store procedure consiste in una richiesta SQL contenuta in un DataBase

DTO Data transfer Object = Un pattern per nascondere dati tra services e controller

Parte invariante del database struttura

Soft delete creo una colonna per gestire tramite booleano o datatime l'eliminazione del dato (che non viene eliminato nella pratica ma viene solo settato quel campo), in una possibile join dobbiamo fare attenzione che il campo sia null o false evitarla nelle One to One

Partial class crea una classe parziale che posso dividere in un altro file

AddSingleton viene inizializzato subito

AddScoped non viene allocato all'inizio fino all'utilizzo

Migrazione specifica per fare DDL

Una riga della tabella che può contenere diverse tipologie di dati al suo interno es. intero e stringa In JS è un insieme di dati eterogenei

Il DOM è tutti gli elementi all'interno del codice, è l albero che viene creato dai tag HTML

Typescript è un super set di funzioni input typescript output javascript

Object è una classe da cui tutte ereditano

Una funzione è

L'impronta di un contenuto è rappresentazione digitale del documento composta da una sequenza di simboli binari di lunghezza fissa che garantisce una associazione praticamente biunivoca tra l'impronta stessa ed il documento di origine.

Size viene calcolata length invece è già disponibile

IIS internet information services che mi garantisce la raggiungibilità della view

La scatola di penne è aggreagazione perché entrambi esistono Il mazzo di fiori è composizione perché il mazzo non esiste senza i fiori

processo per binding statico o dinamico persona per = new Docente() è un binding dinamico

int numero= 5 è un binding statico

Injection possiblità di creare una proprietà e iniettarla

typescript super set di funzioni sulla base di javascript per renderlo typesafe

typesafe= controllo del tipo per non cambiare variabili tipizzati

Polimorfismo è typesafe, grazie al binding automatico si trasforma e non può più cambiare

ORM: Mapping del database Object relation mapping

Migrazione: è quel processo che mi permette di riversare i dettagli di una classe C# nel database tramite la creazione del DDL ogni modifica effettua una nuova migrazione tramite creazione di file con un timeStamp

direttiva using è una direttiva che mi permette di utilizzare una variabile in un sottocontesto

component in angular è una porzione di codice che ha 4 file ts hmtl css e spec

il selettore '@Component' permette di innestare sottoforma di tag il componente

linguaggio di markup linguaggio di marcatori, modifico la sua visualizzazione es. HTML

Single page application non ricarica tutto il DOM ma lo manipola

Router outlet ci permette di riportare il risultato di un componente e innestarlo dove serve, la particolarità del router outlet non cambia mai pagina e cambia il comportamento di google chrome intercettando la path/URL

Ngoninit al caricamento di tutto il component

Binding in angualr ce lo permette forms module

Binding bidirenzionale tutte le variabili che inserisco all interno del ts sono visibili anche dall' HTML

NgModule banana in the box

Interface in angular possiamo visualizzare metodi e proprietà somiglia ad un astrazione in C#

Extend in typescript estende metodi e attributi della classe padre alla classe figlio

Promise gestisce delle chiamate asincrone, rimane in attesa del completamento può avere due risultati Rejected e resolved

DBSET collezione di tutte le tipoligie di elemento relative ad un'entità

Provider per effettuare la Get, effettuiamo un injection constructor(private http: HttpClient){}

entità righe omogenee

information hiding la capacità di nascondere informazioni dove non posso accedere ai dettagli o attributi della classe

Lo static è un attributo di classe

Modificatori di accesso: Public Private Protected

Protected: L'accesso è limitato alla classe o ai tipi derivati dalla classe che li contiene.

distinct seleziona un elemento senza ripetizioni

SELECT * FROM STUDENTE JOIN STUDENTE_ESAME ON STUDENTE.STUDENTEID = STUDENTE_ESAME.STUDENTERIF JOIN ESAME ON STUDENTE_ESAME.ESAMERIF = ESAME.ESAMEID

AGGIUNGERE UN UNIQUE ALTER TABLE Person.Password
ADD CONSTRAINT AK_Password UNIQUE (PasswordHash, PasswordSalt);

Linguaggio server side

la parte di manipolazione e costruzione della struttura del mio codice gira all interno del server

Un assembly è un insieme di parti o componenti che vengono assemblate insieme per formare un prodotto completo. Questo termine è comunemente usato in vari contesti, come la produzione industriale, la costruzione di macchinari, l'elettronica e l'informatica.

Two tier è un architettura di un'applicazione web business logic e db, soprannominata fat client le operazioni di BSL e composizione del DOM

DBMS è il software per lavorare sul database

Query aggregazione group by, AVG, Count,MAX,MIN,SUM

UNIQUE Vincolo interno sul dato Vincoli in SQL

vincolo d'integrità referenziale
vincolo interno
Dato e informazione: L'informazione è una composizione di dati Il dato è un elemento atomico

cookie: storage d'informazioni, viene emesso per la prima volta dal server, viene poi creato da google chrome

Il cookie

middleware Tutto ciò che si frappone tra controller e services

TOKEN:
ISSUER Persona che richiede il token Audience verifica che il token sia proveniente dalla stessa fonte della sorgente

Lifetime Validazione durata IssuerSIgningKey Valida per ogni singola richiesta che la chiave sia valida

MongoDB non ha schema, non esistono join o rif quindi attenzione all'ON delete cascade perché non esiste Quando si lavora con MongoDB si lavora con un approccio CodeFirst Embending gestito le informazioni nel document specifico
