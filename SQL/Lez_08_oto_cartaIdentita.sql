--DDL
DROP TABLE IF EXISTS CartaIdentita;
DROP TABLE IF EXISTS Persona;

CREATE TABLE Persona(
	personaID INT PRIMARY KEY IDENTITY (1,1),
	nome VARCHAR(250) NOT NULL,
	cognome VARCHAR(250) NOT NULL,
	email VARCHAR(50) NOT NULL UNIQUE
);
CREATE TABLE CartaIdentita(
	cartaidentitaID INT PRIMARY KEY IDENTITY (1,1),
	codice VARCHAR(50) NOT NULL UNIQUE,
	scadenza DATE NOT NULL,
	personaRIF INT UNIQUE NOT NULL,
	FOREIGN KEY (personaRIF) REFERENCES PERSONA (personaID) ON DELETE CASCADE
	);


INSERT INTO Persona(nome,cognome,email) VALUES
	('Giovanni','Pace','gio@pace.com'),
	('Tiziano','Titone','tiz@pace.com'),
	('Pippo','Paperino','pip@pace.com');

INSERT INTO CartaIdentita(codice,scadenza,personaRIF) VALUES
	('ABC123','2020-01-01',1),
	('ABC124','2020-01-01',2),
	('ABC125','2020-01-01',3);

SELECT * FROM Persona 

