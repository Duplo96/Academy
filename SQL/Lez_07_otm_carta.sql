--DDL 

DROP TABLE IF EXISTS Carta;
DROP TABLE IF EXISTS Persona;

CREATE TABLE Persona(
	personaID INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(250) NOT NULL,
	cognome VARCHAR(250) NOT NULL,
	email VARCHAR (250) NOT NULL UNIQUE

);

CREATE TABLE Carta(
	cartaID INT PRIMARY KEY IDENTITY(1,1),
	codice VARCHAR(10) NOT NULL UNIQUE,
	negozio VARCHAR(50) NOT NULL,
	personaRIF INT NOT NULL,
	FOREIGN KEY (personaRIF) REFERENCES Persona(personaID) ON DELETE CASCADE --CASCADE fa riferimento anche alla tabella Persona, può anche essere set null;
);

INSERT INTO Persona(nome,cognome,email)VALUES
	('Giovanni','Pace','gio@pace.com'),
	('Valeria','Verdi','val@ver.com'),
	('Mario','Rossi','val@rossi.com'),
	('Marika','Mariko','mar@ko.com')



INSERT INTO Carta(codice,negozio,personaRIF)VALUES
	('ABC123', 'Coop', 1),
	('ABC127', 'Conad', 1),
	('ABC128', 'Tigotà', 2),
	('ABC126', 'Conad', 3),
	('ABC125', 'Coop', 3)



--DELETE FROM Persona WHERE personaID=1; -- Permessa grazie a ON DELETE CASCADE;

SELECT * FROM Persona;
SELECT * FROM Carta;


--Cerco tutte le carte di Giovanni Pace
SELECT * 
FROM Persona 
	JOIN Carta ON Persona.personaID = Carta.personaRIF -- Join serve ad unire tabelle
	WHERE personaID=1;


SELECT nome,cognome,email,codice,negozio
FROM Persona 
	JOIN Carta ON Persona.personaID = Carta.personaRIF -- Join serve ad unire tabelle
	WHERE personaID=1;

--Voglio sapere a chi appartiene la ABC123
SELECT * 
FROM Carta
	JOIN Persona ON Carta.personaRIF = Persona.personaID
	WHERE codice='ABC123';

--Voglio vedere tutte le persone e le relative carte fedelta
SELECT * 
	FROM Persona
	LEFT JOIN Carta ON Persona.personaID = Carta.personaRIF;