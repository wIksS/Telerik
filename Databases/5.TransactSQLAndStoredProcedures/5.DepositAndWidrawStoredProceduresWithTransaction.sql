use Bank;
GO

CREATE PROC usp_WidrawMoney
(@AccountID int, @Money money)
AS
	BEGIN TRAN
	UPDATE Accounts
	SET Balance = Balance - @Money
	WHERE AccountID = @AccountID
	COMMIT TRAN
GO		
	
CREATE PROC usp_DepositMoney
(@AccountID int, @Money money)
AS
	BEGIN TRAN
	UPDATE Accounts
	SET Balance = Balance + @Money
	WHERE AccountID = @AccountID
	COMMIT TRAN
GO		
	