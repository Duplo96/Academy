Database
SELECT:

sql
Copia codice
SELECT * FROM PERSONA WHERE PERSONAID = 1
Seleziona tutte le colonne dalla tabella "PERSONA" filtrando con il WHERE per "PERSONAID".
FOREIGN KEY: Vincolo di identità relazionale.

Data Definition Language (DDL):
- Manipolazione della struttura del database.
Data Manipulation Language (DML):

Manipolazione dei dati.
Query Language (QL):

Serve solo a filtrare dati, non modifica dati.
Stored Procedure:

Metodo per effettuare operazioni DML o QL passando parametri e tabelle temporanee.
View:

Tabella virtuale il cui contenuto è definito da una query.
Migrazione:

Processo per trasferire i dettagli di una classe C# nel database tramite la creazione di DDL; ogni modifica effettua una nuova migrazione con creazione di file con un timestamp.
Soft Delete:

Creazione di una colonna per gestire l'eliminazione del dato tramite booleano o datetime; il dato non viene eliminato ma solo settato su quel campo. Attenzione nelle join che il campo sia null o false; evitarla nelle relazioni One-to-One.
ORM (Object-Relational Mapping):

Mapping del database.
Query di Aggregazione:

GROUP BY, AVG, COUNT, MAX, MIN, SUM.
Esempio di JOIN:

sql
Copia codice
SELECT * FROM STUDENTE 
JOIN STUDENTE_ESAME ON STUDENTE.STUDENTEID = STUDENTE_ESAME.STUDENTERIF 
JOIN ESAME ON STUDENTE_ESAME.ESAMERIF = ESAME.ESAMEID
Aggiungere un vincolo UNIQUE:

sql
Copia codice
ALTER TABLE Person.Password
ADD CONSTRAINT AK_Password UNIQUE (PasswordHash, PasswordSalt);
Vincoli in SQL:

Vincolo d'integrità referenziale.
Vincolo interno (UNIQUE).
DBMS:

Software per lavorare sul database.
Programmazione
Tipi di Dati:

Tipo Oggetto: Istanza di una classe.
Tipo Primitivo: Stringhe, interi, booleano.
Framework:

Insieme di librerie che intercorrono tra di loro.
Metodi:

Override: Ridefinizione di un metodo; possibile solo se il metodo è virtual.
Metodi Astratti: Metodi senza corpo che devono essere implementati nelle classi figlie.
Firma di un Metodo (Signature): Definizione/dichiarazione del metodo con tipo di ritorno, nome del metodo, tipo e nome dei parametri.
Overload: Possibilità di ridefinire un metodo con diversa firma.
Scope:

Globale: Contesto globale.
Static: Attributo o metodo allocato all'avvio del programma.
Entry Point: Il main è l'entry point del programma.
Programmazione Orientata agli Oggetti:

Polimorfismo: Sicuro per i tipi (typesafe), grazie al binding automatico.
Ereditarietà di Interfacce: Contenitori di IEnumerable, ICollection, IList, List.
Binding Statico/Dinamico:
Binding Statico: int numero= 5.
Binding Dinamico: persona per = new Docente().
Classi e Oggetti:

Partial Class: Classe parziale che può essere divisa in un altro file.
Static: Attributo di classe.
Modificatori di Accesso: Public, Private, Protected.
Design Pattern:

DAL (Data Access Layer): Design pattern architetturale.
DTO (Data Transfer Object): Pattern per nascondere dati tra servizi e controller.
Dependency Injection:

AddSingleton: Inizializzato subito.
AddScoped: Non viene allocato fino all'utilizzo.
Assembly:

Insieme di parti o componenti assemblate insieme per formare un prodotto completo.
Middleware:

Tutto ciò che si frappone tra controller e services.
Linguaggi e Tecnologie Web
JavaScript e TypeScript:

Var: Può essere ridichiarata.
Let: Dichiarata una volta sola, può essere sovrascritta.
TypeScript: Superset di funzioni per rendere JavaScript typesafe.
TypeSafe: Controllo del tipo per non cambiare variabili tipizzate.
DOM (Document Object Model):

Albero che viene creato dai tag HTML.
HTML:

Inizia con il DOCTYPE per suggerire il tipo di scrittura del codice.
API REST:

REST API: Interfaccia di programmazione delle applicazioni conforme, interrogata tramite protocollo, utilizzando JSON o XML.
GET: Richiesta passa per l'URL, con limiti di caratteri; risposta in stringa negli header.
POST: Contenuto nel body, mittente e destinatario nell'header; se il payload è troppo grande viene scomposto automaticamente.
Serializzatore JSON: Trasforma l'oggetto in una stringa (Stringify) e riconosce i vari elementi (Parse).
Cookie:

Storage di informazioni; emesso per la prima volta dal server e creato dal browser.
Token:

Issuer: Persona che richiede il token.
Audience: Verifica che il token provenga dalla stessa fonte.
Lifetime: Validazione durata.
IssuerSigningKey: Valida per ogni singola richiesta.
Architettura
Architettura Client-Server:

Richiesta client-server in protocollo HTTP.
Two-Tier:

Architettura di un'applicazione web con business logic e database; soprannominata fat client per operazioni di BSL e composizione del DOM.
Single Page Application (SPA):

Non ricarica tutto il DOM, ma lo manipola.
Angular
Component:

Porzione di codice con file ts, html, css e spec.
Selector:

@Component permette di innestare sottoforma di tag il componente.
NgOnInit:

Al caricamento di tutto il componente.
Binding:

Forms module permette il binding.
Binding Bidirezionale: Variabili inserite nel ts sono visibili anche nell'HTML.
NgModule:

Rappresentato come "banana in the box".
Router Outlet:

Permette di riportare il risultato di un componente e innestarlo dove serve; non cambia mai pagina e cambia il comportamento del browser intercettando la path/URL.
Interfaccia:

Permette di visualizzare metodi e proprietà; somiglia a un'astrazione in C#.
Extend:

Estende metodi e attributi della classe padre alla classe figlio.
Promise:

Gestisce chiamate asincrone; può avere due risultati: Rejected e Resolved.
HttpClient:

Esempio di provider per effettuare una GET con injection:
typescript
Copia codice
constructor(private http: HttpClient){}
Altri Concetti
Information Hiding:

Capacità di nascondere informazioni, non accessibili ai dettagli o attributi della classe.
Distinct:

Seleziona un elemento senza ripetizioni.
IIS (Internet Information Services):

Garantisce la raggiungibilità della view.
MongoDB:

Database senza schema; attenzione alle join e ON DELETE CASCADE perché non esistono. Si lavora con un approccio CodeFirst Embedding gestendo le informazioni nel documento specifico.
