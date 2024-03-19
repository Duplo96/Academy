CREATE TABLE Panino(
	paninoID INT PRIMARY KEY IDENTITY (1,1),
	nome VARCHAR(255) NOT NULL,
	descrizione VARCHAR(255) NOT NULL,
	prezzo DECIMAL (10,2) NOT NULL,
	Isvegan BIT DEFAULT 0
);

INSERT INTO Panino (nome,descrizione,prezzo,Isvegan) VALUES 
('Hamburger','Buono',12,DEFAULT);