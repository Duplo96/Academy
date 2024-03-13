--DDL

CREATE TABLE Studente (
	studenteID INT PRIMARY KEY IDENTITY  (1,1),
	nominativo VARCHAR(250) NOT NULL,
	matricola VARCHAR(250) NOT NULL UNIQUE 
);

CREATE TABLE Esame
(
	esameID INT PRIMARY KEY IDENTITY (1,1),
	titolo VARCHAR(250) NOT NULL,
	data_esame DATE NOT NULL,
	crediti INT CHECK (crediti >= 0) NOT NULL
);

CREATE TABLE Studente_Esame(
	studenteRIF INT NOT NULL,
	esameRIF INT NOT NULL,
	FOREIGN KEY (studenteRIF) REFERENCES Studente(studenteID) ON DELETE CASCADE,
	FOREIGN KEY	(esameRIF) REFERENCES Esame(esameID) ON DELETE CASCADE,
	PRIMARY KEY (studenteRIF,esameRIF) --PRIMARY KEY ELETTA	
);

INSERT INTO Studente(nominativo, matricola)VALUES
	('Giovanni','ABC123'),
	('Valeria', 'ABC124'),
	('Mario', 'ABC125'),
	('Marika', 'ABC126');

INSERT INTO Esame(titolo,data_esame,crediti)VALUES
	('Analisi I','2020-01-01',6),
	('Analisi I','2020-02-02',6),
	('Fisica I','2020-01-01',6),
	('Fisica I','2020-02-02',6),
	('Basi di dati I','2020-03-03',6)

INSERT INTO Studente_Esame(studenteRIF,esameRIF) VALUES
	(1,2),
	(1,5),
	(2,2),
	(2,4),
	(2,5);

SELECT * FROM Esame
SELECT * FROM Studente

-- DROP TABLE Studente_Esame
-- DROP TABLE Esame

-- VOGLIO TUTTI GLI ESAMI A CUI E ISCRITTA VALERIA
SELECT *
	FROM Studente
	JOIN Studente_Esame ON Studente.studenteID = Studente_Esame.esameRIF
	JOIN Esame ON Studente_Esame.esameRIF = Esame.esameID
	WHERE matricola ='ABC124';

-- VOGLIO TUTTI GLI ISCRITTI AD UN ESAME SPECIFICO
SELECT * 
	FROM ESAME 
	JOIN Studente_Esame ON Esame.esameID = Studente_Esame.esameRIF
	JOIN Studente ON Studente_Esame.studenteRIF = Studente.studenteID
	WHERE titolo = 'Analisi I' AND data_esame ='2020-02-02';

-- TUTTI GLI STUDENTI ISCRITTI E NON ISCRITTI AD UN ESAME
SELECT * 
FROM Studente
	LEFT JOIN Studente_Esame ON Studente.studenteID = Studente_Esame.esameRIF
	LEFT JOIN Esame ON Studente_Esame.esameRIF = Esame.esameID;

SELECT * 
FROM Studente
	RIGHT JOIN Studente_Esame ON Studente.studenteID = Studente_Esame.esameRIF
	RIGHT JOIN Esame ON Studente_Esame.esameRIF = Esame.esameID;

-- VOGLIO TUTTI 
SELECT * 
FROM Studente
	FULL JOIN Studente_Esame ON Studente.studenteID = Studente_Esame.esameRIF
	FULL JOIN Esame ON Studente_Esame.esameRIF = Esame.esameID;
	
SELECT * 
FROM Studente
	LEFT JOIN Studente_Esame ON Studente.studenteID = Studente_Esame.esameRIF
	LEFT JOIN Esame ON Studente_Esame.esameRIF = Esame.esameID
UNION
SELECT * 
FROM Studente
	RIGHT JOIN Studente_Esame ON Studente.studenteID = Studente_Esame.esameRIF
	RIGHT JOIN Esame ON Studente_Esame.esameRIF = Esame.esameID;

