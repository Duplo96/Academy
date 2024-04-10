La SELECT è una proiezioni
es.
SELECT \* FROM PERSONA WHERE PERSONAID = 1
**Selezione tutte le colonne dalla tabella persona dove filtriamo con il WHERE per personaID**

**FOREIGN KEY VINCOLO D' IDENTITA RELAZIONALE**

- DDL: Data Definition Language, manipoliamo la struttura del database
- DML: Data Manipolation Language, manipoliamo i dati
- QL: Query Language: Non posso modificare dati con il QL serve solo a filtrare dati

Store Procedure: è un metodo che permette di effettuare operazioni DML o QL passando dei parametri
tabelle temporanee

View: Una tabella virtuale il cui contenuto è definito da una query

## Struttura ereditaria di interfaccie

IEnumerable
ICollection
IList
List
Abbiamo 3 interfaccie per i principi SOLID di programmazione

Tipo oggetto: Istanza di una classe

Tipo Primitivo: stringhe, interi, booleano

Framework: Un insieme di librerie che intercorrono tra di loro

Posso effettuare l override(La ridefinizione) di un metodo solo se il metodo è virtual.

I metodi astratti sono metodi senza corpo e devono per forza essere implementati nelle classi figlie

Utilizzo dell'interfaccia su metodi generici

DAL design pattern architetturale

Il **generic** è un tipo generico che tramite generico tipo possiamo poi utilizzarlo nel tipo di cui abbiamo bisogno lo utlizziamo nelle interfaccie

Var posso ridichiarla
let una volta ridichiarata può essere sovrascritta ma dichiarata una volta sola

Scope globale(contesto)

Static: Definiamo static un attributto o un metodo che all avvio del programma viene allocato

Entrypoint: il main è il nostro entrypoint

La firma di un metodo è una firma (signature) ovvero la definizione/dichiarazione del metodo con tipo di ritorno, nome del metodo, tipo e nome degli eventuali parametri passati in input

overload è possibilità di ridefinire un metodo con diversa firma

REST API:(Application programm interface) interfaccia di programmazione delle applicazioni conforme, interrogata tramite protocollo e rispettando una tipologia di comunicazione (JSON combinazione chiave valore, XML)

Architettura client server:

Richiesta client server in protocollo http

GET: Una richiesta get passa per l URL web, ha un limite di caratteri che possiamo richiedere, ha un destinatario e un mittente e di risposta una stringa (negli header)

POST: Nella post inserisco mittente e destinatario nell'header mentre il suo contenuto è nel body
Se il payload è troppo grande viene scomposto in automatico dall'altro lato, se perdo un pacchetto questo viene rinviato

Serializzatore json

Buffer overflow
Parse riconosce i vari elementi dell'oggetto

Stringify trasforma l'oggetto in una stringa

mine type l' encoding, suggerita al destinatario per leggere il nostro dato

La pagina HTML inizia con il DOCTYPE serve a suggerire il tipo di scrittura del codice

Un browser è un

Chrome

La restfull costruisce gli endPoint

Una view è una tabella virtuale il cui contenuto è definito da una query

Una store procedure consiste in una richiesta SQL contenuta in un DataBase

DTO Data transfer Object

Parte invariante del database struttura

Soft delete creo una colonna per gestire tramite booleano o datatime l'eliminazione del dato (che non viene eliminato nella pratica ma viene solo settato quel campo), in una possibile join dobbiamo fare attenzione che il campo sia null o false evitarla nelle One to One

Partial class crea una classe parziale che posso dividere in un altro file

AddSingleton viene inizializzato subito

AddScoped non viene allocato all'inizio fino all'utilizzo

Migrazione specifica per fare DDL

Una riga della tabella che può contenere diverse tipologie di dati al suo interno es. intero e stringa
In JS è un insieme di dati eterogenei

Il DOM è tutti gli elementi all'interno del codice, è l albero che viene creato dai tag HTML

Typescript è un super set di funzioni input typescript output javascript

Object è una classe da cui tutte ereditano

Una funzione è

L'impronta di un contenuto è rappresentazione digitale del documento composta da una sequenza di simboli binari di lunghezza fissa che garantisce una associazione praticamente biunivoca tra l'impronta stessa ed il documento di origine.

Size viene calcolata length invece è già disponibile

IIS internet information services che mi garantisce la raggiungibilità della view

La scatola di penne è aggreagazione perché entrambi esistono
Il mazzo di fiori è composizione perché il mazzo non esiste senza i fiori

processo per binding statico o dinamico
persona per = new Docente() è un binding dinamico

int numero= 5 è un binding statico
