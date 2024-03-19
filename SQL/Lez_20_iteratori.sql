-- DDL

CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Salary DECIMAL(10, 2)
);

CREATE TABLE Dipendenti(
	dipendentiID INT PRIMARY KEY IDENTITY (1,1),
	nominativo NVARCHAR(250),
	salario DECIMAL (10,2)
);

 
-- DML
INSERT INTO Employees (EmployeeID, FirstName, LastName, Salary) VALUES
(1, 'John', 'Doe', 50000),
(2, 'Jane', 'Smith', 60000),
(3, 'Emily', 'Jones', 70000);


-- SP che analizza ogni riga e può manipolarla 


--DECLARE EmployeeCursor CURSOR FOR 
--SELECT FirstName+ ' ' + LastName, Salary FROM Employees

-- OPEN CURSOR			
--OPEN EmployeeCursor

--DECLARE @nominativo VARCHAR(250);
--DECLARE @salary DECIMAL (10,2);
---- RECUPERO DELLA PRIMA RIGA 
--FETCH NEXT FROM EmployeeCursor INTO @nominativo, @salary;

--WHILE @@FETCH_STATUS = 0
--BEGIN
--	PRINT @nominativo + ' ' +CAST(@salary AS VARCHAR);
--	FETCH NEXT FROM EmployeeCursor INTO @nominativo, @salary;
--END

--CLOSE EmployeeCursor


--------------------------------------
DROP PROCEDURE IF EXISTS ExportToAnotherTable
CREATE PROCEDURE ExportToAnotherTable AS
BEGIN
	DECLARE EmployeeCursorDue CURSOR FOR 
	SELECT FirstName+ ' ' + LastName, Salary FROM Employees

	OPEN EmployeeCursorDue		

	DECLARE @nominativo VARCHAR(250);
	DECLARE @salary DECIMAL (10,2);
	-- RECUPERO DELLA PRIMA RIGA 
	FETCH NEXT FROM EmployeeCursorDue INTO @nominativo, @salary;

	WHILE @@FETCH_STATUS = 0
	BEGIN
		BEGIN TRY
			INSERT INTO Dipendenti(nominativo,salario)VALUES
			(@nominativo,@salary)
			PRINT @nominativo + ' ' +CAST(@salary AS VARCHAR);
		END TRY
		BEGIN CATCH
			PRINT 'Non sono riuscito ad inserire:' + @nominativo 
		END CATCH 
	
		FETCH NEXT FROM EmployeeCursorDue INTO @nominativo, @salary;
	END

	CLOSE EmployeeCursorDue
END

	

SELECT * FROM Dipendenti
EXEC ExportToAnotherTable
SELECT * FROM Dipendenti