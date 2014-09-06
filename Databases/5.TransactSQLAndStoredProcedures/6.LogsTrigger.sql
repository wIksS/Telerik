use Bank;

CREATE TABLE Logs(
  LogID int NOT NULL PRIMARY KEY IDENTITY,
  AccountID int FOREIGN KEY
	REFERENCES Accounts(AccountID),
  OldSum money NOT NULL,
  NewSum money NOT NULL)
GO

CREATE TRIGGER bankTr_BalanceChange ON Accounts FOR UPDATE
AS
	INSERT INTO Logs (OldSum, NewSum, AccountID)
	SELECT d.Balance, i.Balance, d.AccountID
	FROM deleted d, inserted i
	WHERE d.AccountID = i.AccountID
GO

-- Usage:
EXEC dbo.usp_DepositMoney 1, 250
GO

SELECT * FROM Logs
GO