## Domanda 1: Quali sono le caratteristiche principali di SQL Server?

**Breve**: SQL Server è un sistema di gestione di database relazionali (RDBMS) sviluppato da Microsoft. Le sue caratteristiche principali includono sicurezza avanzata, scalabilità, integrazione con altri prodotti Microsoft, funzionalità di business intelligence e supporto per lo sviluppo di applicazioni.

**Esaustiva**: SQL Server offre una vasta gamma di funzionalità che lo rendono un sistema di gestione di database robusto e versatile. Alcune delle sue caratteristiche principali includono:

- Sicurezza avanzata: SQL Server fornisce meccanismi di autenticazione e autorizzazione sofisticati per proteggere i dati sensibili. Ciò include l'accesso basato sui ruoli, l'audit e la crittografia dei dati.
- Scalabilità: SQL Server è progettato per gestire carichi di lavoro di database di varie dimensioni, da piccole applicazioni a grandi sistemi aziendali. Supporta clustering, mirroring e replica per garantire l'affidabilità e la scalabilità.
- Integrazione con altri prodotti Microsoft: SQL Server è integrato con altri prodotti Microsoft come Visual Studio, SharePoint e Excel, facilitando lo sviluppo di soluzioni end-to-end.
- Funzionalità di business intelligence: SQL Server offre strumenti avanzati per l'analisi dei dati, l'elaborazione di dati in memoria (tabular model e columnstore index), il data mining e la creazione di report.
- Supporto per lo sviluppo di applicazioni: SQL Server fornisce un ambiente di sviluppo ricco di strumenti e linguaggi di programmazione come T-SQL, .NET Framework e PowerShell, facilitando lo sviluppo di applicazioni e soluzioni personalizzate.
  ## Domanda 2: Come creare un nuovo database in SQL Server?

**Breve**: Utilizzare la query "CREATE DATABASE" seguita dal nome desiderato del database.

**Esaustiva**: Per creare un nuovo database in SQL Server, è possibile utilizzare la seguente sintassi SQL:

CREATE DATABASE NomeDatabase;
Ad esempio, per creare un nuovo database chiamato "MyDatabase", si può eseguire la query:

CREATE DATABASE MyDatabase;
Questa query crea un nuovo database vuoto con il nome specificato. È possibile specificare ulteriori opzioni come la dimensione iniziale del file di dati, la dimensione massima, la crescita automatica e la posizione del file di log. Per esempio:
``` sql
CREATE DATABASE MyDatabase
ON PRIMARY
(
NAME = MyDatabase_Data,
FILENAME = 'C:\\...\\MyDatabase.mdf',
SIZE = 10MB,
MAXSIZE = UNLIMITED,
FILEGROWTH = 5MB
)
LOG ON
(
NAME = MyDatabase_Log,
FILENAME = 'C:\\...\\MyDatabase.ldf',
SIZE = 5MB,
MAXSIZE = 50MB,
FILEGROWTH = 1MB
);
```
Questa query crea un nuovo database chiamato "MyDatabase" con file di dati e di log specificati, impostando dimensioni iniziali, massime e incrementi di crescita automatica.

## Domanda 3: Il linguaggio SQL è divisibile in quali sottoinsiemi funzionali?

**Breve**: Il linguaggio SQL è suddiviso principalmente in quattro sottoinsiemi funzionali: DDL (Data Definition Language), DML (Data Manipulation Language), DQL (Data Query Language) e DCL (Data Control Language).

**Esaustiva**: Il linguaggio SQL (Structured Query Language) è suddiviso in diversi sottoinsiemi funzionali, ognuno dei quali serve a uno scopo specifico nell'interazione con i database:

- DDL (Data Definition Language): Questo sottoinsieme è utilizzato per definire e modificare la struttura degli oggetti nel database. Le istruzioni DDL includono "CREATE" (per creare nuovi oggetti come tabelle, viste, indici, etc.), "ALTER" (per modificare la struttura degli oggetti esistenti) e "DROP" (per eliminare gli oggetti dal database).

- DML (Data Manipulation Language): Questo sottoinsieme è utilizzato per manipolare i dati all'interno del database. Le istruzioni DML principali sono "INSERT" (per inserire nuovi record), "UPDATE" (per aggiornare i record esistenti) e "DELETE" (per eliminare i record esistenti).

- DQL (Data Query Language): Questo sottoinsieme è utilizzato per interrogare i dati all'interno del database per estrarre informazioni. L'istruzione principale in DQL è "SELECT", che consente di specificare le colonne da recuperare, le tabelle da cui recuperare i dati e le condizioni per filtrare i risultati.

- DCL (Data Control Language): Questo sottoinsieme è utilizzato per gestire i diritti di accesso e i permessi nel database. Le istruzioni principali in DCL sono "GRANT" (per concedere autorizzazioni agli utenti) e "REVOKE" (per revocare autorizzazioni precedentemente concesse).

Ogni sottoinsieme svolge un ruolo fondamentale nell'interazione con il database, consentendo agli utenti di definire la struttura dei dati, manipolare i dati stessi, interrogare le informazioni desiderate e controllare l'accesso ai dati.

## Domanda 4: Come creare una nuova tabella in un database SQL Server?

**Breve**: Utilizzare la query "CREATE TABLE" specificando il nome della tabella e le colonne con i relativi tipi di dati.

**Esaustiva**: Per creare una nuova tabella in un database SQL Server, si utilizza la seguente sintassi SQL:

CREATE TABLE NomeTabella (
NomeColonna1 TipoDato1,
NomeColonna2 TipoDato2,
...
NomeColonnaN TipoDatoN
);
Ad esempio, per creare una tabella chiamata "Clienti" con le colonne "IDCliente" di tipo int e "Nome" di tipo varchar(50), si può eseguire la query:

CREATE TABLE Clienti (
IDCliente int,
Nome varchar(50)
);
È possibile specificare ulteriori vincoli come chiavi primarie, chiavi esterne, vincoli di unicità e vincoli di controllo durante la creazione della tabella.

CREATE TABLE Ordini (
IDOrdine int PRIMARY KEY,
IDCliente int,
DataOrdine date,
FOREIGN KEY (IDCliente) REFERENCES Clienti(IDCliente)
);
Questa query crea una tabella chiamata "Ordini" con una chiave primaria "IDOrdine", una chiave esterna "IDCliente" che fa riferimento alla tabella "Clienti", e una colonna "DataOrdine" di tipo data.

## Domanda 5: Quali sono i tipi più comuni utilizzati in SQL Server?

**Breve**: I tipi di dati comuni in SQL Server includono int, varchar, decimal, datetime e bit.

**Esaustiva**: SQL Server offre una vasta gamma di tipi di dati per soddisfare le esigenze di memorizzazione dei diversi tipi di informazioni. Alcuni dei tipi di dati più comuni utilizzati includono:

- int: Utilizzato per memorizzare numeri interi, sia positivi che negativi, con una precisione di 4 byte.

- varchar(n): Utilizzato per memorizzare stringhe di caratteri di lunghezza variabile fino a un massimo di n caratteri.

- decimal(p, s): Utilizzato per memorizzare numeri decimali con una precisione p (numero totale di cifre) e una scala s (numero di cifre dopo il punto decimale).

- datetime: Utilizzato per memorizzare date e orari. È in grado di rappresentare date da gennaio 1753 a dicembre 9999 con una precisione di 3.33 millisecondi.

- bit: Utilizzato per memorizzare valori booleani, che possono essere True (1) o False (0).

- nvarchar(n): Simile a varchar, ma utilizzato per memorizzare stringhe di caratteri Unicode di lunghezza variabile fino a un massimo di n caratteri.

- float(n): Utilizzato per memorizzare numeri in virgola mobile con una precisione variabile, dove n specifica il numero di bit utilizzati per memorizzare il numero.

- char(n): Utilizzato per memorizzare stringhe di caratteri di lunghezza fissa esattamente n caratteri.

Questi sono solo alcuni esempi dei tipi di dati più comuni in SQL Server. È possibile utilizzare una vasta gamma di altri tipi di dati per adattarsi alle esigenze specifiche di un'applicazione o di un set di dati.

## Domanda 6: Come inserire i dati in una tabella SQL Server utilizzando la query INSERT?

**Breve**: Utilizzare la query "INSERT INTO" seguita dal nome della tabella e i valori da inserire.

**Esaustiva**: Per inserire dati in una tabella SQL Server, si utilizza la seguente sintassi SQL:

INSERT INTO NomeTabella (NomeColonna1, NomeColonna2, ..., NomeColonnaN)
VALUES (Valore1, Valore2, ..., ValoreN);
Ad esempio, per inserire un nuovo cliente nella tabella "Clienti" con un IDCliente pari a 1 e un nome "Mario Rossi", si può eseguire la query:

INSERT INTO Clienti (IDCliente, Nome)
VALUES (1, 'Mario Rossi');
È anche possibile inserire più righe di dati in una singola query utilizzando la stessa sintassi:

INSERT INTO Clienti (IDCliente, Nome)
VALUES (2, 'Luigi Verdi'),
(3, 'Giovanna Bianchi'),
(4, 'Anna Neri');
Questo inserirà quattro nuove righe nella tabella "Clienti". È importante assicurarsi che i valori inseriti rispettino i vincoli di integrità dei dati, come ad esempio la chiave primaria e i vincoli di unicità. In caso contrario, l'operazione di inserimento potrebbe generare errori.

## Domanda 7: Come modificare i dati esistenti in una tabella SQL utilizzando la query UPDATE?

**Breve**: Utilizzare la query "UPDATE" seguita dal nome della tabella, impostando i valori da modificare e utilizzando la clausola WHERE per specificare quali righe devono essere modificate.

**Esaustiva**: Per modificare i dati esistenti in una tabella SQL Server, si utilizza la seguente sintassi SQL:

UPDATE NomeTabella
SET NomeColonna1 = NuovoValore1, NomeColonna2 = NuovoValore2, ..., NomeColonnaN = NuovoValoreN
WHERE Condizione;
Ad esempio, per aggiornare il nome di un cliente con IDCliente pari a 1 nella tabella "Clienti" da "Mario Rossi" a "Marco Rossi", si può eseguire la query:

UPDATE Clienti
SET Nome = 'Marco Rossi'
WHERE IDCliente = 1;
Questa query modificherà il nome del cliente con IDCliente uguale a 1 da "Mario Rossi" a "Marco Rossi".

È possibile aggiornare più colonne contemporaneamente specificando più clausole "SET":

UPDATE Tabella
SET Colonna1 = Valore1, Colonna2 = Valore2
WHERE Condizione;
Inoltre, è possibile utilizzare la clausola "WHERE" per specificare quali righe devono essere modificate. Se viene omessa, l'istruzione "UPDATE" modificherà tutte le righe della tabella. Tuttavia, è consigliabile utilizzare la clausola "WHERE" in modo da evitare modifiche non desiderate su tutte le righe della tabella.

## Domanda 8: Come modificare i dati da una tabella SQL Server utilizzando la query DELETE?

**Breve**: Utilizzare la query "DELETE FROM" seguita dal nome della tabella e dalla clausola WHERE per specificare quali righe eliminare.

**Esaustiva**: Per eliminare dati da una tabella SQL Server, si utilizza la seguente sintassi SQL:

DELETE FROM NomeTabella
WHERE Condizione;
Ad esempio, per eliminare un cliente con IDCliente pari a 1 dalla tabella "Clienti", si può eseguire la query:

DELETE FROM Clienti
WHERE IDCliente = 1;
Questa query eliminerà tutte le righe dalla tabella "Clienti" che soddisfano la condizione specificata, cioè quelle con IDCliente uguale a 1.

Se la clausola "WHERE" viene omessa, tutte le righe della tabella verranno eliminate. È importante utilizzare la clausola "WHERE" con attenzione per evitare di eliminare dati in modo non intenzionale.

Inoltre, è possibile utilizzare l'istruzione "DELETE" in combinazione con le clausole "JOIN" per eliminare righe in base alle relazioni con altre tabelle. Questo è utile quando si vogliono eliminare righe in una tabella che soddisfano determinate condizioni basate su dati presenti in altre tabelle.

## Domanda 9: Come utilizzare la clausola WHERE per filtrare i risultati di una query SELECT?

**Breve**: Utilizzare la clausola "WHERE" seguita da una condizione per filtrare i risultati in base a criteri specifici.

**Esaustiva**: La clausola "WHERE" è utilizzata in SQL per filtrare i risultati di una query SELECT in base a determinati criteri. Ecco un esempio:

SELECT \*
FROM Tabella
WHERE Colonna = Valore;
In questo esempio, "Tabella" è il nome della tabella da cui si desidera selezionare i dati, "Colonna" è il nome della colonna su cui si vuole applicare il filtro e "Valore" è il valore che si vuole confrontare con i valori della colonna. Solo le righe che soddisfano la condizione specificata nella clausola "WHERE" verranno incluse nei risultati della query.

È possibile combinare più condizioni utilizzando operatori logici come "AND" e "OR" per creare filtri più complessi:

SELECT \*
FROM Tabella
WHERE Colonna1 = Valore1 AND Colonna2 = Valore2;
In questo esempio, la query selezionerà solo le righe in cui entrambe le condizioni specificate sono vere.

La clausola "WHERE" può anche essere utilizzata per confrontare valori utilizzando operatori di confronto come "=", "<", ">", "<=", ">=" e "<>" (o "!=" per la disuguaglianza), oltre a utilizzare funzioni di confronto come "LIKE" per confronti parziali di stringhe e "IN" per confronti multipli:

SELECT \*
FROM Tabella
WHERE Colonna LIKE 'Valore%';

SELECT \*
FROM Tabella
WHERE Colonna IN (Valore1, Valore2, Valore3);
Questi sono solo alcuni esempi delle molte possibilità offerte dalla clausola "WHERE" per filtrare i risultati di una query SELECT in base a criteri specifici.

## Domanda 10: Qual è la differenza tra INNER JOIN, LEFT JOIN e RIGHT JOIN in SQL Server?

**Breve**: INNER JOIN restituisce solo le righe che hanno corrispondenze in entrambe le tabelle coinvolte nella join. LEFT JOIN restituisce tutte le righe dalla tabella a sinistra e le corrispondenze dalla tabella a destra. RIGHT JOIN restituisce tutte le righe dalla tabella a destra e le corrispondenze dalla tabella a sinistra.

**Esaustiva**: Le join sono utilizzate in SQL per combinare righe da due o più tabelle basate su una condizione di corrispondenza specificata. Ecco le differenze tra INNER JOIN, LEFT JOIN e RIGHT JOIN:

INNER JOIN: Restituisce solo le righe che hanno corrispondenze in entrambe le tabelle coinvolte nella join. Le righe che non hanno corrispondenze vengono eliminate dal risultato finale. Ad esempio:
SELECT \*
FROM TabellaA
INNER JOIN TabellaB ON TabellaA.ID = TabellaB.ID;
Questa query restituirà solo le righe che hanno un ID comune nelle tabelle "TabellaA" e "TabellaB".

LEFT JOIN: Restituisce tutte le righe dalla tabella a sinistra (prima tabella specificata) e le corrispondenze dalla tabella a destra. Se non ci sono corrispondenze nella tabella a destra, vengono restituiti valori NULL per le colonne della tabella a destra. Ad esempio:
SELECT \*
FROM TabellaA
LEFT JOIN TabellaB ON TabellaA.ID = TabellaB.ID;
Questa query restituirà tutte le righe dalla tabella "TabellaA" e solo le corrispondenze dalla tabella "TabellaB".

RIGHT JOIN: Restituisce tutte le righe dalla tabella a destra (seconda tabella specificata) e le corrispondenze dalla tabella a sinistra. Se non ci sono corrispondenze nella tabella a sinistra, vengono restituiti valori NULL per le colonne della tabella a sinistra. Questo tipo di join è meno comune di INNER JOIN e LEFT JOIN. Ad esempio:
SELECT \*
FROM TabellaA
RIGHT JOIN TabellaB ON TabellaA.ID = TabellaB.ID;
Questa query restituirà tutte le righe dalla tabella "TabellaB" e solo le corrispondenze dalla tabella "TabellaA".

In **breve**, INNER JOIN restituisce solo le corrispondenze, LEFT JOIN restituisce tutte le righe dalla tabella a sinistra e le corrispondenze dalla tabella a destra, mentre RIGHT JOIN restituisce tutte le righe dalla tabella a destra e le corrispondenze dalla tabella a sinistra. La scelta del tipo di join dipende dalle esigenze specifiche della query e dalla struttura dei dati.

## Domanda 11: Quali sono le funzioni di aggregazione comuni in SQL Server e come utilizzarle?

**Breve**: Le funzioni di aggregazione comuni includono SUM, AVG, COUNT, MAX e MIN. Si utilizzano per eseguire calcoli su un insieme di valori.

**Esaustiva**: Le funzioni di aggregazione sono utilizzate in SQL per eseguire calcoli su un insieme di valori e restituire un singolo risultato aggregato. Ecco le funzioni di aggregazione comuni:

- SUM(): Restituisce la somma di tutti i valori in un insieme di valori.
  SELECT SUM(Colonna) AS Somma
  FROM Tabella;
- AVG(): Restituisce la media di tutti i valori in un insieme di valori numerici.
  SELECT AVG(Colonna) AS Media
  FROM Tabella;
- COUNT(): Restituisce il numero di righe in un insieme di valori.
  SELECT COUNT(\*) AS NumeroDiRighe
  FROM Tabella;
- MAX(): Restituisce il valore massimo in un insieme di valori.
  SELECT MAX(Colonna) AS Massimo
  FROM Tabella;
- MIN(): Restituisce il valore minimo in un insieme di valori.
  SELECT MIN(Colonna) AS Minimo
  FROM Tabella;
  Queste sono solo alcune delle funzioni di aggregazione più comuni in SQL Server. È possibile utilizzare queste funzioni in combinazione con la clausola "GROUP BY" per eseguire calcoli aggregati su gruppi di righe basati su valori di una o più colonne.

SELECT Colonna, SUM(AltraColonna) AS Somma
FROM Tabella
GROUP BY Colonna;
Questo esempio calcola la somma di "AltraColonna" per ogni valore unico nella colonna "Colonna". Le funzioni di aggregazione sono strumenti potenti per analizzare dati aggregati e ottenere informazioni utili dai dati memorizzati nel database.

## Domanda 12: Come utilizzare la clausola HAVING per filtrare i risultati di una query dopo aver utilizzato GROUP BY?

**Breve**: La clausola HAVING viene utilizzata per filtrare i risultati di una query dopo aver utilizzato GROUP BY, applicando condizioni alle righe aggregate.

**Esaustiva**: Dopo aver utilizzato la clausola GROUP BY per aggregare i dati in gruppi, è possibile applicare ulteriori filtri ai risultati aggregati utilizzando la clausola HAVING. Ecco un esempio:

SELECT ColonnaA, COUNT(_) AS NumeroDiRighe
FROM Tabella
GROUP BY ColonnaA
HAVING COUNT(_) > 10;
In questo esempio, la query conta il numero di righe per ogni valore unico nella colonna "ColonnaA". La clausola HAVING viene utilizzata per filtrare i risultati in modo che vengano restituiti solo i gruppi in cui il numero di righe è maggiore di 10.

È possibile applicare qualsiasi condizione valida alla clausola HAVING, proprio come si farebbe con la clausola WHERE. Tuttavia, mentre la clausola WHERE viene utilizzata per filtrare le righe prima dell'aggregazione, la clausola HAVING viene utilizzata per filtrare i risultati aggregati dopo l'aggregazione.

SELECT ColonnaA, SUM(ColonnaB) AS Somma
FROM Tabella
GROUP BY ColonnaA
HAVING SUM(ColonnaB) > 1000;
In questo esempio, la query somma i valori della colonna "ColonnaB" per ogni valore unico nella colonna "ColonnaA". La clausola HAVING viene utilizzata per restituire solo i gruppi in cui la somma dei valori di "ColonnaB" supera 1000.

La clausola HAVING è un componente potente per filtrare i risultati di una query dopo l'aggregazione e può essere utilizzata per analizzare e selezionare dati in base a condizioni specifiche sui risultati aggregati.

## Domanda 13: Qual è lo scopo delle chiavi primarie e delle chiavi esterne?

**Breve**: Le chiavi primarie identificano univocamente ogni riga in una tabella, mentre le chiavi esterne stabiliscono relazioni tra le tabelle.

**Esaustiva**: Le chiavi primarie e le chiavi esterne sono concetti fondamentali nel progettare relazioni tra tabelle in un database relazionale:

- Chiave Primaria (Primary Key):
  Una chiave primaria è un attributo o un insieme di attributi che identifica univocamente ogni riga in una tabella.
  Le chiavi primarie garantiscono l'unicità delle righe all'interno di una tabella e forniscono un metodo efficiente per individuare rapidamente righe specifiche.
  Ogni tabella può avere una sola chiave primaria e non può contenere valori NULL.
  Esempio di definizione di una chiave primaria:
  CREATE TABLE Tabella (
  ID INT PRIMARY KEY,
  Nome VARCHAR(50)
  );
- Chiave Esterna (Foreign Key):
  Una chiave esterna è un attributo o un insieme di attributi in una tabella che stabilisce una relazione con la chiave primaria di un'altra tabella.
  Le chiavi esterne creano vincoli di integrità referenziale che garantiscono che i valori nelle colonne corrispondenti esistano nella tabella padre (tabella con la chiave primaria).
  Le chiavi esterne consentono di creare relazioni tra tabelle, consentendo di collegare informazioni correlate tra loro.
  Esempio di definizione di una chiave esterna:
  CREATE TABLE Ordini (
  ID INT PRIMARY KEY,
  ClienteID INT,
  FOREIGN KEY (ClienteID) REFERENCES Clienti(ID)
  );
  In questo esempio, "ClienteID" nella tabella "Ordini" è una chiave esterna che fa riferimento alla chiave primaria "ID" nella tabella "Clienti". Ciò indica che ogni ordine è associato a un cliente esistente nella tabella "Clienti".

In sintesi, le chiavi primarie e le chiavi esterne sono strumenti cruciali per la progettazione di database relazionali, consentendo di mantenere l'integrità dei dati e di stabilire relazioni significative tra le tabelle.

## Domanda 14: Cos'è l'indice in SQL Server e perché è importante?

**Breve**: Un indice in SQL Server è una struttura che migliora le prestazioni delle query identificando rapidamente le righe di una tabella. È importante perché accelera l'accesso ai dati, riducendo il tempo di esecuzione delle query.

**Esaustiva**: In SQL Server, un indice è una struttura dati che migliora le prestazioni delle query identificando rapidamente le righe di una tabella. Quando si esegue una query che include una clausola WHERE, un JOIN o un'operazione di ordinamento, l'uso di un indice consente al motore di database di trovare rapidamente le righe interessate senza dover esaminare ogni singola riga della tabella. Ciò porta a tempi di risposta più veloci e migliora le prestazioni complessive del database.

L'importanza degli indici risiede nella loro capacità di ottimizzare le prestazioni delle query. Senza indici, il motore di database potrebbe dover eseguire una scansione completa della tabella per trovare le righe che soddisfano i criteri della query, soprattutto su grandi set di dati. Questo può causare ritardi significativi nell'esecuzione delle query e influire negativamente sulle prestazioni complessive del sistema.

Gli indici possono essere creati su una o più colonne di una tabella e possono essere di diversi tipi, come indici clustered e non clustered, indici unici e indici filtrati. La progettazione degli indici è una parte essenziale dell'ottimizzazione delle prestazioni del database e richiede una valutazione attenta delle query più frequenti eseguite sul database.

È importante tenere presente che l'uso eccessivo degli indici può avere un impatto negativo sulle prestazioni durante le operazioni di inserimento, aggiornamento e eliminazione dei dati, poiché ogni modifica ai dati può richiedere la ricostruzione degli indici stessi. Pertanto, è essenziale bilanciare la creazione degli indici per migliorare le prestazioni delle query con l'impatto sulle prestazioni delle operazioni di gestione dei dati.

## Domanda 15: Cos'è la normalizzazione del database e perché è importante?

**Breve**: La normalizzazione del database è il processo di organizzare i dati in una struttura logica ottimale per ridurre la ridondanza e migliorare l'integrità dei dati. È importante perché promuove l'efficienza, la coerenza e la manutenibilità del database.

**Esaustiva**: La normalizzazione del database è un processo di progettazione che mira a organizzare i dati in una struttura logica ottimale, al fine di ridurre la ridondanza dei dati e migliorare l'integrità e l'efficienza complessiva del database. Questo processo coinvolge la suddivisione delle tabelle in più tabelle più piccole e correlate, eliminando le dipendenze ridondanti e garantendo che ogni tabella rappresenti una singola entità o concetto di dati.

L'importanza della normalizzazione del database risiede in diversi benefici:

- Riduzione della ridondanza dei dati: La normalizzazione elimina la duplicazione dei dati, consentendo di risparmiare spazio di archiviazione e riducendo il rischio di inconsistenze dei dati.

- Miglioramento dell'integrità dei dati: Una struttura di database normalizzata riduce il rischio di anomalie dei dati, come l'inserimento, l'aggiornamento o l'eliminazione anomali, mantenendo i dati coerenti e affidabili.

- Facilità di gestione e manutenzione: Una struttura di database ben normalizzata semplifica la gestione dei dati e le operazioni di manutenzione, rendendo più semplice l'aggiunta, la modifica o l'eliminazione dei dati senza compromettere l'integrità del database.

- Miglioramento delle prestazioni delle query: In alcuni casi, una struttura di database normalizzata può migliorare le prestazioni delle query, consentendo di eseguire ricerche più efficienti e di recuperare i dati più rapidamente.

- La normalizzazione del database segue una serie di forme normali, che definiscono i requisiti di progettazione per garantire la massima efficienza e integrità dei dati. Le forme normali più comuni sono la Prima Forma Normale (1NF), la Seconda Forma Normale (2NF) e la Terza Forma Normale (3NF), anche se esistono forme normali più avanzate come la Forma Normale di Boyce-Codd (BCNF) e la Quarta Forma Normale (4NF). La scelta della forma normale dipende dalle esigenze specifiche del database e dalla complessità dei dati.

## Domanda 16: Cos'è una transazione in SQL Server e quali sono le proprietà ACID?

**Breve**: Una transazione in SQL Server è un'unità logica di lavoro che garantisce l'integrità dei dati. Le proprietà ACID (Atomicità, Coerenza, Isolamento, Durabilità) definiscono le caratteristiche chiave di una transazione.

**Esaustiva**: Una transazione in SQL Server è un'operazione logica che consiste in una serie di azioni di database eseguite come un'unica unità. Queste azioni possono includere inserimenti, aggiornamenti o eliminazioni di dati in una o più tabelle. Una transazione viene utilizzata per garantire l'integrità dei dati, consentendo di eseguire un gruppo di azioni come un'unica operazione atomica.

Le proprietà ACID sono un insieme di caratteristiche fondamentali che definiscono il comportamento di una transazione e garantiscono la coerenza e l'affidabilità dei dati. Ecco una panoramica delle proprietà ACID:

- Atomicità (Atomicity): Questa proprietà garantisce che una transazione sia eseguita completamente o non eseguita affatto. In altre parole, una transazione viene eseguita completamente o viene annullata se si verifica un errore, senza lasciare lo stato del database in uno stato intermedio.

- Coerenza (Consistency): La proprietà di coerenza garantisce che il database si trovi in uno stato coerente prima e dopo l'esecuzione di una transazione. Le transazioni non devono violare le regole di integrità del database, come vincoli di chiave primaria, vincoli di unicità o vincoli di referenziale.

- Isolamento (Isolation): Questa proprietà garantisce che una transazione sia eseguita in modo isolato rispetto ad altre transazioni eseguite contemporaneamente nel database. Ogni transazione deve apparire come se fosse eseguita da sola, senza interferenze da parte di altre transazioni. L'isolamento previene problemi come la lettura sporca, la lettura non ripetibile e la fantasma.

- Durabilità (Durability): La proprietà di durabilità garantisce che i cambiamenti apportati dal completamento di una transazione siano permanenti e persistano anche in caso di guasto del sistema o riavvio del database. Una volta completata con successo, una transazione deve essere duratura e non deve essere influenzata da eventuali problemi di sistema successivi.

Queste proprietà sono essenziali per garantire l'affidabilità e l'integrità dei dati in un sistema di database. Le transazioni che rispettano le proprietà ACID possono garantire che il database rimanga in uno stato coerente e affidabile, anche in presenza di errori o situazioni anomale.

## Domanda 17: Come utilizzare le istruzioni COMMIT e ROLLBACK per gestire le transazioni?

**Breve**: COMMIT viene utilizzato per confermare una transazione, rendendo permanenti le modifiche apportate al database. ROLLBACK viene utilizzato per annullare una transazione, ripristinando il database allo stato precedente alla transazione.

**Esaustiva**: Nella gestione delle transazioni in SQL Server, le istruzioni COMMIT e ROLLBACK svolgono un ruolo fondamentale nel garantire l'integrità dei dati e la coerenza del database. Ecco come vengono utilizzate:

COMMIT: L'istruzione COMMIT viene utilizzata per confermare una transazione. Quando viene eseguita un'istruzione COMMIT, tutte le modifiche apportate dalla transazione vengono rese permanenti e il database viene aggiornato con le nuove informazioni. Dopo il COMMIT, le modifiche non possono essere annullate e diventano permanenti nel database. Ad esempio:
BEGIN TRANSACTION;

-- Esegui le operazioni della transazione qui

COMMIT;
ROLLBACK: L'istruzione ROLLBACK viene utilizzata per annullare una transazione e ripristinare il database allo stato precedente alla transazione. Quando viene eseguita un'istruzione ROLLBACK, tutte le modifiche apportate dalla transazione vengono annullate e il database torna allo stato che aveva prima dell'inizio della transazione. Questo è utile in caso di errore o fallimento durante l'esecuzione della transazione. Ad esempio:
BEGIN TRANSACTION;

-- Esegui le operazioni della transazione qui

IF @@ERROR <> 0
ROLLBACK;
ELSE
COMMIT;
In questo esempio, viene eseguito un controllo sull'eventuale presenza di errori durante l'esecuzione della transazione. Se viene rilevato un errore, la transazione viene annullata utilizzando l'istruzione ROLLBACK. In caso contrario, la transazione viene confermata con l'istruzione COMMIT.

È importante utilizzare le istruzioni COMMIT e ROLLBACK in modo appropriato per garantire l'integrità dei dati e prevenire anomalie nel database. Le transazioni ben gestite contribuiscono alla coerenza e all'affidabilità del sistema di database.

## Domanda 18: Qual è lo scopo dei trigger in SQL Server e come crearne uno?

**Breve**: I trigger in SQL Server sono procedure automatiche che vengono eseguite in risposta a determinati eventi nel database. Si possono utilizzare per implementare logica aziendale o per garantire l'integrità dei dati.

**Esaustiva**: I trigger in SQL Server sono speciali procedure automatiche che vengono eseguite in risposta a determinati eventi, come l'inserimento, l'aggiornamento o l'eliminazione di dati in una tabella. I trigger consentono di eseguire automaticamente azioni specifiche o logica aziendale quando si verificano determinati eventi nel database.

Lo scopo principale dei trigger può essere riassunto nei seguenti punti:

Implementare logica aziendale: I trigger possono essere utilizzati per implementare logica aziendale complessa che deve essere eseguita in risposta a determinati eventi nel database. Ad esempio, è possibile utilizzare un trigger per aggiornare automaticamente altre tabelle del database quando vengono apportate modifiche a una tabella specifica.

Garantire l'integrità dei dati: I trigger possono essere utilizzati per applicare regole o vincoli aziendali ai dati nel database. Ad esempio, è possibile utilizzare un trigger per verificare se i dati inseriti rispettano determinati criteri e impedire l'inserimento di dati non validi.

Per creare un trigger in SQL Server, è necessario utilizzare l'istruzione CREATE TRIGGER. Ecco un esempio di come creare un trigger:

CREATE TRIGGER NomeTrigger
ON NomeTabella
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
-- Logica del trigger qui
END;
In questo esempio:

"NomeTrigger" è il nome del trigger che si sta creando.
"NomeTabella" è il nome della tabella su cui si desidera attivare il trigger.
"AFTER INSERT, UPDATE, DELETE" specifica gli eventi che attiveranno il trigger. In questo caso, il trigger verrà attivato dopo un'operazione di inserimento, aggiornamento o eliminazione.
"BEGIN" e "END" delimitano il blocco di codice del trigger, all'interno del quale viene definita la logica da eseguire quando il trigger viene attivato.
All'interno del blocco di codice del trigger, è possibile inserire qualsiasi logica necessaria per gestire l'evento specifico che ha attivato il trigger. È importante prestare attenzione alla logica del trigger per garantire che sia efficiente e non influenzi negativamente le prestazioni del database.

## Domanda 19: Cos'è una stored procedure in SQL Server e come crearla?

**Breve**: Una stored procedure in SQL Server è un insieme di istruzioni SQL precompilate che possono essere eseguite ripetutamente. Sono utilizzate per implementare logica complessa nel database.

**Esaustiva**: Una stored procedure in SQL Server è un oggetto del database contenente un insieme di istruzioni SQL precompilate e salvate nel server. Le stored procedure consentono di eseguire operazioni complesse, applicare logica aziendale e creare una modularità nel codice del database. Sono utili per migliorare le prestazioni, la sicurezza e la manutenibilità del database.

Ecco come creare una stored procedure in SQL Server:

CREATE PROCEDURE NomeProcedura
@Parametro1 TipoDato,
@Parametro2 TipoDato
AS
BEGIN
-- Corpo della stored procedure
-- Utilizzare @Parametro1 e @Parametro2 nel codice per eseguire operazioni
END;
In questo esempio:

"NomeProcedura" è il nome della stored procedure che si sta creando.
"@Parametro1" e "@Parametro2" sono parametri della stored procedure con i relativi tipi di dati. Possono essere utilizzati per passare valori alla stored procedure quando viene eseguita.
"AS" indica l'inizio del corpo della stored procedure.
Il corpo della stored procedure contiene le istruzioni SQL che verranno eseguite quando la stored procedure viene chiamata.
Dopo aver definito la stored procedure, può essere eseguita utilizzando l'istruzione EXEC o chiamandola direttamente dal codice dell'applicazione:

EXEC NomeProcedura @Parametro1 = Valore1, @Parametro2 = Valore2;
Le stored procedure offrono diversi vantaggi, tra cui:

Riutilizzo del codice: Le istruzioni SQL complesse possono essere scritte una volta e riutilizzate più volte.
Prestazioni: Le stored procedure possono essere precompilate e memorizzate nella cache del server, migliorando le prestazioni delle esecuzioni ripetute.
Sicurezza: Le stored procedure possono essere utilizzate per limitare l'accesso diretto alle tabelle del database, consentendo di controllare l'accesso ai dati in modo più granulare.
Manutenibilità: Le stored procedure facilitano la manutenzione del codice del database, consentendo di apportare modifiche alla logica di business senza dover modificare l'applicazione stessa.
In generale, le stored procedure sono uno strumento potente per la gestione dei dati in SQL Server e vengono ampiamente utilizzate per implementare logica complessa nel database.

## Domanda 20: Qual è la differenza tra una stored procedure e una funzione in SQL Server?

**Breve**: Una stored procedure è un insieme di istruzioni SQL che possono eseguire operazioni complesse e possono anche modificare i dati. Una funzione restituisce un valore scalare o una tabella e viene utilizzata principalmente per calcoli o manipolazioni di dati.

**Esaustiva**: Le stored procedure e le funzioni sono entrambe oggetti del database utilizzati per raggruppare un insieme di istruzioni SQL e consentire la loro riutilizzabilità. Tuttavia, ci sono diverse differenze significative tra di loro:

Tipo di ritorno:

Una stored procedure può eseguire una serie di operazioni complesse e non è limitata a un singolo valore di ritorno. Può anche modificare i dati nel database. Tuttavia, non restituisce direttamente valori.
Una funzione, al contrario, restituisce un singolo valore scalare o una tabella come risultato. Non può essere utilizzata per modificare i dati.
Utilizzo:

Le stored procedure sono utilizzate principalmente per eseguire operazioni complesse come transazioni, elaborazioni di dati e logica aziendale. Possono essere chiamate da altre stored procedure, da applicazioni client o dallo stesso database.
Le funzioni sono utilizzate principalmente per calcoli e manipolazioni di dati. Possono essere utilizzate in qualsiasi contesto in cui sia necessario un valore, come una query SELECT, un'assegnazione di variabile o in un'espressione.
Modifiche dei dati:

Le stored procedure possono essere utilizzate per modificare i dati nel database tramite istruzioni INSERT, UPDATE o DELETE. Possono anche eseguire operazioni di gestione del database come la creazione o l'eliminazione di tabelle.
Le funzioni non possono modificare direttamente i dati nel database. Sono utilizzate principalmente per calcoli basati su dati esistenti e restituiscono valori basati su tali calcoli.
Ecco un esempio di definizione di una stored procedure e di una funzione in SQL Server:

Stored Procedure:

CREATE PROCEDURE NomeProcedura
AS
BEGIN
-- Logica della stored procedure
END;
Funzione:

CREATE FUNCTION NomeFunzione
(@Parametro INT)
RETURNS INT
AS
BEGIN
-- Logica della funzione
RETURN @Parametro \* 2;
END;
In sintesi, le stored procedure e le funzioni sono entrambe utili strumenti per organizzare e riutilizzare il codice SQL, ma differiscono per il tipo di ritorno e per l'uso principale.

## Domanda 21: Tipicamente quante tabelle ci sono in una relazione one to many?

**Breve**: In una relazione one-to-many, tipicamente ci sarà una tabella per l'entità "one" e una tabella per l'entità "many".

**Esaustiva**: In una relazione one-to-many, tipicamente si avrà una tabella per l'entità "one" e una tabella per l'entità "many". Ad esempio, consideriamo una relazione tra un'entità "Cliente" e un'entità "Ordine". In questo caso, ci sarebbe una tabella "Cliente" che rappresenta l'entità "one" (ogni cliente può avere molti ordini) e una tabella "Ordine" che rappresenta l'entità "many" (ogni ordine è associato a un solo cliente). La tabella "Ordine" avrà un riferimento alla tabella "Cliente" tramite una chiave esterna, che stabilisce la relazione tra le due tabelle. Questo è un modello comune in molte basi di dati relazionali e consente di gestire facilmente le relazioni one-to-many tra le entità.

## Domanda 22: Tipicamente quante tabelle ci sono in una relazione many-to-many?

**Breve**: In una relazione many-to-many, tipicamente sono necessarie tre tabelle: due tabelle per le entità coinvolte e una tabella di collegamento per rappresentare l'associazione tra di esse.

**Esaustiva**: In una relazione many-to-many, tipicamente sono necessarie tre tabelle per gestire l'associazione tra le entità coinvolte. Ad esempio, consideriamo una relazione tra un'entità "Studente" e un'entità "Corso", dove ogni studente può iscriversi a più corsi e ogni corso può essere frequentato da più studenti. In questo caso, avremmo una tabella "Studente" che rappresenta gli studenti, una tabella "Corso" che rappresenta i corsi e una terza tabella, spesso chiamata "StudenteCorso" o "Iscrizione", che funge da tabella di collegamento. Quest'ultima tabella avrà solitamente due colonne che fungono da chiavi esterne, una per collegarsi alla tabella "Studente" e l'altra per collegarsi alla tabella "Corso". Questo modello consente di gestire le relazioni many-to-many tra le entità in modo efficiente e scalabile, consentendo a ciascuno studente di iscriversi a più corsi e a ciascun corso di avere più studenti iscritti.

## Domanda 23: Tipicamente quante tabelle ci sono in una relazione one-to-one?

**Breve**: In una relazione one-to-one, tipicamente ci sarà una tabella per ciascuna delle due entità coinvolte, quindi due tabelle in totale.

**Esaustiva**: In una relazione one-to-one, tipicamente ci sarà una tabella per ciascuna delle due entità coinvolte. Questo significa che, in totale, ci saranno due tabelle. Ad esempio, consideriamo una relazione tra un'entità "Persona" e un'entità "DocumentoIdentità", dove ogni persona può avere al massimo un documento d'identità e ogni documento d'identità è associato a una sola persona. In questo caso, avremmo una tabella "Persona" che contiene le informazioni personali e una tabella "DocumentoIdentità" che contiene le informazioni sul documento d'identità. Entrambe le tabelle avrebbero una chiave primaria e una chiave esterna per collegarle l'una all'altra, stabilendo cos\'ec la relazione one-to-one tra di esse. Questo modello permette di mantenere un'organizzazione logica dei dati, garantendo che ogni entità abbia una relazione diretta e univoca con un'altra entità.
