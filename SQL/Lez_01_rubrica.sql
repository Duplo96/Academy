 -- Sono un commento 
 /*
 Sono un commento multilinea
 */


 --DDL
DROP TABLE IF EXISTS Persona;
CREATE TABLE Persona(
	nome VARCHAR(50) NOT NULL,
	cognome CHAR(50) NOT NULL,
	telefono VARCHAR(50),
	cod_fis CHAR (16) NOT NULL, --UNIQUE MODO IMPLICITO PER DEFINIRE LA CHIAVE UNICA
	UNIQUE(cod_fis)
);

 --Elimina la tabella
-- DROP TABLE Persona;

-- --Aggiunta di una colonna

ALTER TABLE Persona 
ADD email VARCHAR(50) NOT NULL;

-- -- Elimina Colonna
ALTER TABLE Persona DROP COLUMN email;

-- -- Modifica di una colonna
-- ALTER TABLE Persona ALTER COLUMN email VARCHAR(100) NOT NULL;

  --DML
  INSERT INTO Persona(nome,cognome,telefono,cod_fis) VALUES 
  ('Giovanni','Pace','+34539395','PCAGNN'),
  ('Valeria','Verdi','+395466','VLRVRD');

  --QUERY LANGUAGE
  SELECT * FROM Persona;

