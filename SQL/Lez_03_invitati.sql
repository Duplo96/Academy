-- DDL
CREATE TABLE Contatto(
	ContattoID INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(50) NOT NULL,
	cognome VARCHAR(50) NOT NULL,
	email VARCHAR(100) NOT NULL,
	cod_fis CHAR(16) NOT NULL UNIQUE

);

INSERT INTO Contatto(nome,cognome,email,cod_fis) VALUES
('Giovanni','Pace','gio@pace.com','PCAGNN'),
('Valeria','Verdi','vale@verdi.com','VLRVRD'),
('Tiziano','Titone','tiz@titone.com','TTNTZN')

INSERT INTO Contatto(nome,cognome,email,cod_fis) VALUES
('Marika','Mariko' ,'mar@mar.com', 'MARMAR');

DELETE FROM Contatto WHERE ContattoID=3;
DELETE FROM Contatto WHERE cod_fis='MARMAR';

SELECT * FROM Contatto