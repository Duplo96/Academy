
CREATE TABLE Albergo(
	albergoID INT PRIMARY KEY IDENTITY (1,1),
	nome VARCHAR(250) NOT NULL,
	indirizzo VARCHAR(250) NOT NULL,
	valutazione INT NOT NULL CHECK (valutazione BETWEEN 1 AND 5)
);

CREATE TABLE Cliente(
	clienteID INT PRIMARY KEY IDENTITY (1,1),
	nome VARCHAR(250) NOT NULL,
	cognome VARCHAR(250) NOT NULL,
	telefono VARCHAR(250) NOT NULL,
	email VARCHAR(250)
);

CREATE TABLE Camera(
	cameraID INT PRIMARY KEY IDENTITY (1,1),
	numero INT NOT NULL,
	tipo VARCHAR (250) NOT NULL CHECK (tipo IN ('singola','doppia','suite')),
	tariffa DECIMAL (5,2) NOT NULL,
	capacita_massima INT NOT NULL,
	albergoRIF INT NOT NULL,
	FOREIGN KEY (albergoRIF) REFERENCES Albergo (albergoID) ON DELETE CASCADE,
	UNIQUE (numero, albergoRIF)
);


CREATE TABLE Dipendenti (
	dipendentiID INT PRIMARY KEY IDENTITY (1,1),
	posizione VARCHAR(250) NOT NULL CHECK (posizione IN ('Receptionist','Manager','Pulizie')),
	nome VARCHAR(250) NOT NULL,
	cognome VARCHAR(250) NOT NULL,
	telefono VARCHAR(250) NOT NULL,
	email VARCHAR(250),
	albergoRIF INT NOT NULL,
	FOREIGN KEY(albergoRIF) REFERENCES Albergo (albergoID) ON DELETE CASCADE,
	UNIQUE(dipendentiID,albergoRIF)
);

CREATE TABLE Facilities (
	facilitiesID INT PRIMARY KEY IDENTITY (1,1),
	nome VARCHAR (250) NOT NULL, CHECK (nome IN ('Piscina','Spa','Palestra')),
	descrizione TEXT,
	orari_apertura VARCHAR(250),
	albergoRIF INT NOT NULL,
	FOREIGN KEY (albergoRIF) REFERENCES Albergo(albergoID) ON DELETE CASCADE
);

CREATE TABLE Prenotazione(
data_check_in DATE NOT NULL,
data_check_out DATE NOT NULL, 
clienteRIF INT NOT NULL,
cameraRIF INT NOT NULL,
FOREIGN KEY (clienteRIF) REFERENCES Cliente (clienteID),
FOREIGN KEY (cameraRIF) REFERENCES Camera (cameraID),
UNIQUE (data_check_out,data_check_in,clienteRIF,cameraRIF)
);

INSERT INTO Albergo (nome, Indirizzo, Valutazione)
VALUES ('Hotel Bella Vista', 'Via Roma, 123, Roma, Italia', 4),
       ('Grand Hotel Lux', 'Piazza Garibaldi, 5, Milano, Italia', 5),
       ('Seaside Resort', '100 Ocean Boulevard, Miami Beach, FL 33139, USA', 4);


INSERT INTO Cliente (nome, cognome, telefono, email)
VALUES ('Mario', 'Rossi', '+39 333 1234567', 'mario.rossi@example.com'),
       ('Laura', 'Bianchi', '+39 345 2345678', 'laura.bianchi@example.com'),
       ('Roberto', 'Verdi', '+39 333 3456789', 'roberto.verdi@example.com'),
       ('Anna', 'Esposito', '+39 345 4567890', 'anna.esposito@example.com'),
       ('Giuseppe', 'Russo', '+39 333 5678901', 'giuseppe.russo@example.com'),
       ('Sara', 'Romano', '+39 345 6789012', 'sara.romano@example.com'),
       ('Alessia', 'Colombo', '+39 333 7890123', 'alessia.colombo@example.com'),
       ('Luigi', 'Ferrari', '+39 345 8901234', 'luigi.ferrari@example.com'),
       ('Elena', 'Martini', '+39 333 9012345', 'elena.martini@example.com'),
       ('Marco', 'Moretti', '+39 345 0123456', 'marco.moretti@example.com');



INSERT INTO Camera (numero, tipo, tariffa, capacita_massima,albergoRIF)
VALUES ('101', 'Singola', 100, 1,3),
       ('102', 'Singola', 100, 1,2),
       ('103', 'Singola', 100, 1,1),
       ('201', 'Doppia', 150, 2,1),
       ('202', 'Doppia', 150, 2,1),
       ('203', 'Doppia', 150, 2,2),
       ('301', 'Suite', 250, 3,3),
       ('302', 'Suite', 250, 3,2),
       ('303', 'Suite', 250, 3,3),
       ('401', 'Singola', 100, 1,1),
       ('402', 'Singola', 100, 1,1),
       ('403', 'Singola', 100, 1,2),
       ('501', 'Doppia', 150, 2,2),
       ('502', 'Doppia', 150, 2,3),
       ('503', 'Doppia', 150, 2,3);

INSERT INTO Dipendenti (Posizione, Nome, Cognome, Telefono, Email,albergoRIF)
VALUES ('Receptionist', 'Giulia', 'Rossi', '+39 333 1234567', 'giulia.rossi@example.com',1),
       ('Manager', 'Marco', 'Bianchi', '+39 345 2345678', 'marco.bianchi@example.com',2),
       ('Receptionist', 'Alessia', 'Verdi', '+39 333 3456789', 'alessia.verdi@example.com',1),
       ('Manager', 'Roberto', 'Esposito', '+39 345 4567890', 'roberto.esposito@example.com',2),
       ('Pulizie', 'Luca', 'Russo', '+39 333 5678901', 'luca.russo@example.com',2),
       ('Receptionist', 'Francesca', 'Romano', '+39 345 6789012', 'francesca.romano@example.com',3),
       ('Manager', 'Paolo', 'Colombo', '+39 333 7890123', 'paolo.colombo@example.com',3),
       ('Pulizie', 'Elena', 'Ferrari', '+39 345 8901234', 'elena.ferrari@example.com',3),
       ('Receptionist', 'Simone', 'Martini', '+39 333 9012345', 'simone.martini@example.com',2),
       ('Pulizie', 'Chiara', 'Moretti', '+39 345 0123456', 'chiara.moretti@example.com',1);




INSERT INTO Facilities (nome, descrizione, orari_apertura,albergoRIF)
VALUES ('Piscina', 'Una piscina olimpionica con corsie separate per il nuoto e aree separate per il relax.', 'Lun-Ven 9:00-21:00, Sab-Dom 10:00-20:00',3),
       ('Spa', 'Una spa di lusso con sauna, bagno turco, vasca idromassaggio e varie opzioni di trattamento.', 'Lun-Dom 10:00-22:00',2),
       ('Palestra', 'Una palestra completamente attrezzata con attrezzature per il sollevamento pesi, macchine cardio e sale per lezioni di gruppo.', 'Lun-Ven 6:00-23:00, Sab-Dom 8:00-20:00',1)

INSERT INTO Prenotazione (data_check_in, data_check_out,cameraRIF,clienteRIF)
VALUES ('2024-03-15', '2024-03-20',3,1),
       ('2024-03-18', '2024-03-23',7,2),
       ('2024-03-21', '2024-03-24',9,3),
       ('2024-03-25', '2024-03-28',8,4),
       ('2024-03-28', '2024-04-02',6,5),
       ('2024-04-01', '2024-04-06',1,6),
       ('2024-04-05', '2024-04-09',2,7),
       ('2024-04-10', '2024-04-15',10,8),
       ('2024-04-15', '2024-04-20',11,9),
       ('2024-04-20', '2024-04-25',15,10);


	   SELECT * FROM Prenotazione