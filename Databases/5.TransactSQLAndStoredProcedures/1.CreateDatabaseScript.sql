CREATE DATABASE Bank
GO

use Bank;

CREATE TABLE Persons(
	PersonID int IDENTITY PRIMARY KEY,
	FirstName nvarchar(50),
	LastName nvarchar(50),
	SSN nvarchar(8),
)
GO

CREATE TABLE Accounts(
	AccountID int IDENTITY PRIMARY KEY,
	Balance money,
	PersonID int,
)

ALTER TABLE Accounts
	ADD CONSTRAINT fk_Accounts_Persons
	FOREIGN KEY (PersonID)
	REFERENCES Persons(PersonID)
GO

INSERT INTO Persons(FirstName,LastName,SSN)
VALUES 
	('Pesho','Peshkata','88888'),
	('Bai','Shilio','89588'),
	('Gosho','Bashtata na gosho','12345'),
	('Sestrata','Na Gosho','54321')	
GO

INSERT INTO Accounts(Balance,PersonID)
VALUES 
	(5000,1),
	(4000,2),
	(3000,3),
	(2000,4)

GO