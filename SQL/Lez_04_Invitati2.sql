--DDL 
DROP TABLE IF EXISTS Contatto
CREATE TABLE Contatto(
	ContattoID INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(50) NOT NULL,
	cognome VARCHAR(50) NOT NULL,
	email VARCHAR(100) NOT NULL,
	cod_fis CHAR(16) NOT NULL UNIQUE

);

--INSERT INTO Contatto(nome,cognome,email,cod_fis) VALUES
--('Giovanni','Pace','gio@pace.com','PCAGNN'),
--('Valeria','Verdi','vale@verdi.com','VLRVRD'),
--('Tiziano','Titone','tiz@titone.com','TTNTZN')


INSERT INTO Contatto(nome,cognome,email,cod_fis) VALUES
('Marika','Mariko' ,'mar@mar.com', 'VLRVRD');
INSERT INTO Contatto(nome,cognome,email,cod_fis) VALUES
('Marika','Mariko' ,'mar@mar.com', 'MARRSS');
INSERT INTO Contatto(nome,cognome,email,cod_fis) VALUES
('Marika','Mariko' ,'mar@mar.com', 'MARMAR');
INSERT INTO Contatto(nome,cognome,email,cod_fis) VALUES
('Mario','Marikotti' ,'mar@mar.com', 'MRRERR');

INSERT INTO Contatto(nome,cognome,email,cod_fis) VALUES
('Maria','Mariani' ,'mar@mrn.com', 'MARMRN');
INSERT INTO Contatto(nome,cognome,email,cod_fis) VALUES
('Marilino','Mariottide' ,'mar@mrn.com', 'MRLMRT');


-- QUERY LANGUAGE
SELECT * FROM Contatto;
SELECT ContattoID, nome, cognome,email,cod_fis FROM Contatto;
SELECT nome,email,cod_fis FROM Contatto;
SELECT cognome,email,cod_fis FROM Contatto;

--ALIAS
SELECT nome AS 'First Name', cognome AS 'Last Name', email AS Email FROM Contatto;

--RICERCA

SELECT * FROM Contatto WHERE nome ='Marika' AND cognome='Mariko';

SELECT * FROM Contatto WHERE nome ='Marika' OR cognome='Mariko' OR nome='Giovanni';
SELECT * FROM Contatto WHERE nome IN ('Mario', 'Giovanni','Marika');

SELECT * FROM Contatto WHERE nome <> 'Marika';

-- LIKE
-- Tutto ciò che inizia per Ma...
SELECT * FROM Contatto WHERE nome LIKE 'Ma%';

-- Tutto ciò che finisce per ...io
SELECT * FROM Contatto WHERE nome LIKE '%io';

-- Tutto ciò che contiene almeno una volta ..io..
SELECT * FROM Contatto WHERE nome LIKE '%io%';

-- RICERCA PUNTUALE

SELECT * FROM Contatto WHERE nome LIKE 'Mari____';

SELECT * FROM Contatto WHERE nome LIKE '_a__o';





