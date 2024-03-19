USE Lez_22_citta;

CREATE TABLE Citta(
	cittaID INTEGER PRIMARY KEY IDENTITY (1,1),
	nome VARCHAR(250) NOT NULL,
	prov VARCHAR(3) NOT NULL
);

INSERT INTO Citta (nome,prov) VALUES
('Pescara','PE'),
('Maccarese','FM')

ALTER TABLE Citta ADD CONSTRAINT CHK_nome UNIQUE (nome);

SELECT * FROM Citta
SELECT * FROM Citta