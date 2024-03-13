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

CREATE TABLE Iscrizione(
	studenteRIF INT NOT NULL,
	esameRIF INT NOT NULL,
	data_iscr DATETIME DEFAULT CURRENT_TIMESTAMP,
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

INSERT INTO Iscrizione(studenteRIF,esameRIF) VALUES
	(1,2),
	(1,5),
	(2,2),
	(2,4),
	(2,5);

SELECT * FROM Esame
SELECT * FROM Studente

-- DROP TABLE Studente_Esame
-- DROP TABLE Esame

SELECT *
FROM Studente 
JOIN Iscrizione ON Studente.studenteID = Iscrizione.studenteRIF
JOIN Esame ON Iscrizione.esameRIF=Esame.esameID;


