## 21) Differenza tra un'istanza di una classe ed una variabile locale

**Breve:** Un'istanza di una classe è un oggetto creato da una classe e conserva lo stato e il comportamento definiti dalla classe stessa, mentre una variabile locale è una variabile definita all'interno di un blocco di codice e ha un'esistenza limitata al suo ambito.

**Esaustiva:** Un'istanza di una classe è un oggetto creato utilizzando il costruttore della classe stessa e conserva lo stato e il comportamento definiti da quella classe. Le istanze di una classe possono essere utilizzate per accedere e manipolare i dati e i comportamenti della classe stessa. D'altra parte, una variabile locale è una variabile definita all'interno di un blocco di codice, come ad esempio una funzione o un metodo, e ha un'esistenza limitata al suo ambito di visibilità. Le variabili locali vengono allocate sullo stack e vengono distrutte una volta che il controllo esce dal blocco in cui sono definite.

## 22) Concetto di eccezione in OOP e come gestirla

**Breve:** Un'eccezione in OOP è un'istanza della classe Exception o di una classe derivata, che rappresenta un errore o una situazione anomala durante l'esecuzione del programma. Le eccezioni possono essere gestite utilizzando blocchi try-catch o blocchi finally per catturare, gestire e/o rilanciare le eccezioni.

**Esaustiva:** In OOP, un'eccezione è un'istanza della classe Exception o di una classe derivata da Exception, che rappresenta un errore o una situazione anomala durante l'esecuzione del programma. Le eccezioni possono essere causate da errori di sintassi, errori di logica, errori di runtime, o da altre condizioni impreviste. Per gestire le eccezioni, è possibile utilizzare blocchi try-catch, in cui il codice sospetto viene inserito nel blocco try e le eccezioni vengono catturate e gestite nel blocco catch. Inoltre, è possibile utilizzare il blocco finally per eseguire le operazioni di pulizia o di rilascio delle risorse, indipendentemente dal fatto che un'eccezione sia stata sollevata o meno.

## 23) Utilizzo e potenziali problematiche dell'ereditarietà multipla in OOP

**Breve:** L'ereditarietà multipla in OOP consente a una classe di ereditare i membri da più di una classe base. In C#, l'ereditarietà multipla non è direttamente supportata, ma è possibile utilizzare l'ereditarietà multipla tramite le interfacce. Le problematiche principali dell'ereditarietà multipla includono l'ambiguità dei metodi ereditati e il problema del diamante.

**Esaustiva:** In C#, l'ereditarietà multipla diretta, dove una classe deriva da più di una classe base, non è consentita. Tuttavia, è possibile utilizzare l'ereditarietà multipla attraverso le interfacce, dove una classe può implementare più interfacce. Ciò consente di ottenere funzionalità simili all'ereditarietà multipla. Le interfacce consentono di definire un contratto comune che può essere implementato da diverse classi. Tuttavia, ci sono potenziali problematiche associate all'ereditarietà multipla, come l'ambiguità dei metodi ereditati e il problema del diamante. Per evitare queste problematiche, C# preferisce l'implementazione dell'ereditarietà multipla tramite le interfacce, che non presentano tali ambiguità poiché le interfacce non contengono implementazioni di metodi.

## 24) Utilizzo della parola chiave "base" in OOP

**Breve:** In C#, la parola chiave "base" viene utilizzata per accedere ai membri della classe base da una classe derivata. Viene utilizzata principalmente all'interno di un costruttore derivato per invocare il costruttore della classe base.

**Esaustiva:** In C#, la parola chiave base viene utilizzata per accedere ai membri della classe base da una classe derivata. Viene principalmente utilizzata all'interno di un costruttore derivato per invocare il costruttore della classe base corrispondente. Questo è utile quando la classe base ha un costruttore che accetta parametri e si desidera invocare quel costruttore dalla classe derivata. La parola chiave base può anche essere utilizzata per chiamare i metodi e gli attributi della classe base all'interno dei metodi della classe derivata.

## 25) Utilizzo della parola chiave "this" in OOP

**Breve:** In C#, la parola chiave "this" viene utilizzata per fare riferimento all'istanza corrente della classe, consentendo di accedere agli attributi e ai metodi dell'oggetto corrente. Viene comunemente utilizzata per evitare ambiguità tra nomi di parametri e attributi e per passare l'oggetto corrente come argomento a un altro metodo.

**Esaustiva:** La parola chiave "this" in C# viene utilizzata per fare riferimento all'istanza corrente della classe, consentendo di accedere agli attributi e ai metodi dell'oggetto corrente. Viene comunemente utilizzata in situazioni in cui ci sono ambiguità tra nomi di parametri e attributi della classe, per distinguere tra i due. Ad esempio, quando un parametro ha lo stesso nome di un attributo della classe, è possibile utilizzare "this" per fare riferimento all'attributo della classe anziché al parametro. Inoltre, "this" può essere utilizzata per passare l'oggetto corrente come argomento a un altro metodo o per restituire l'oggetto corrente da un metodo, consentendo la concatenazione di chiamate di metodi.

## 26) Concetto di binding in OOP e i suoi tipi

**Breve:** Il binding in OOP è il processo di associazione di un'invocazione di metodo o di un riferimento a un'istanza di classe al codice che implementa quel metodo o quella classe. I tipi di binding includono il binding statico e il binding dinamico.

**Esaustiva:** Il binding in OOP si riferisce al processo di associazione di un'invocazione di metodo o di un riferimento a un'istanza di classe al codice che implementa quel metodo o quella classe. Questo processo può avvenire a tempo di compilazione (binding statico) o a tempo di esecuzione (binding dinamico). Il binding statico avviene quando il tipo di oggetto è noto a tempo di compilazione, mentre il binding dinamico avviene quando il tipo di oggetto può essere determinato solo a tempo di esecuzione.

## 27) Concetto di garbage collection in OOP e il suo funzionamento

**Breve:** La garbage collection in OOP è un meccanismo automatico per gestire la memoria liberando gli oggetti non più utilizzati. Funziona identificando gli oggetti che non sono più raggiungibili dalla radice dell'applicazione e liberando la memoria occupata da questi oggetti.

**Esaustiva:** La garbage collection (raccolta dei rifiuti) in OOP è un meccanismo automatico per gestire la memoria liberando gli oggetti che non sono più utilizzati dall'applicazione. Funziona identificando gli oggetti che non sono più raggiungibili dalla radice dell'applicazione (come ad esempio gli oggetti creati sullo stack o i riferimenti globali) e quindi marcati per la liberazione della memoria. Il funzionamento della garbage collection può variare a seconda del linguaggio di programmazione e dell'implementazione specifica. In C#, ad esempio, il processo di garbage collection è gestito dal runtime di .NET. Periodicamente, il garbage collector esegue una scansione dell'heap di memoria gestita per individuare gli oggetti non utilizzati e liberare lo spazio occupato da essi. La garbage collection aiuta a prevenire i memory leak e semplifica la gestione della memoria per lo sviluppatore, poiché non è necessario esplicitamente deallocare la memoria utilizzata dagli oggetti. Tuttavia, è importante tenere presente che la garbage collection può causare brevi pause nell'esecuzione del programma mentre esegue la pulizia della memoria, quindi è importante ottimizzare il codice per ridurre al minimo il carico sulla garbage collector.


## **Mi crei una tabella con il SELECT?**
