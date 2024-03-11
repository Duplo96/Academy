-- DDL
DROP TABLE IF EXISTS Libri
CREATE TABLE Libro 
(	libroID INT PRIMARY KEY IDENTITY (1,1),
	titolo VARCHAR(250) NOT NULL,
	autore VARCHAR(50) NOT NULL,
	isbn CHAR(13) NOT NULL UNIQUE, 
	categoria VARCHAR (50) DEFAULT 'N.D',
);
-- DML

INSERT INTO Libro (titolo,autore,isbn) VALUES
('Moby Dick', 'Pippo','0959591239431');
INSERT INTO Libro (titolo,autore,isbn) VALUES
('Uno nessuno centomila', 'Pluto','0959591239432');
INSERT INTO Libro (titolo,autore,isbn) VALUES
('Romeo e Giuliettan', 'Paperino','0959591239433');
INSERT INTO Libro (titolo,autore,isbn) VALUES
('Geronimo', 'Minnie','0959591239435');
INSERT INTO Libro (titolo,autore,isbn) VALUES
('La coscienza di zeno', 'Paperina','0959591239437');
INSERT INTO Libro (titolo,autore,isbn) VALUES
('La bibbian', 'Ettore','0959591239438');
INSERT INTO Libro (titolo,autore,isbn,categoria) VALUES
('Pip', 'Gianni','0959591239440',null);


SELECT * FROM Libro;

SELECT * FROM Libro WHERE categoria IS NULL;

SELECT * FROM Libro WHERE categoria IS NOT NULL;

SELECT * FROM Libro WHERE autore = 'Pippo';

SELECT * FROM Libro 
	WHERE titolo LIKE '%an%' 
		OR autore LIKE '%an%' 
		OR isbn LIKE '%an%';

SELECT * FROM Libro WHERE isbn = '0959591239438';



