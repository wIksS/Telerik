use Bank;
GO

CREATE PROC usp_UpdateAccountBalance
(@accoundID int, @interestRate decimal(5,2))
AS
	UPDATE Accounts
	SET Balance = dbo.ufn_NewSumAfterInterests(Balance,@interestRate,1)
	WHERE AccountID = @accoundID
GO
DROP PROC usp_UpdateAccountBalance

EXEC dbo.usp_UpdateAccountBalance 1, 6.5
SELECT * FROM Accounts
WHERE AccountID = 1

SELECT dbo.ufn_NewSumAfterInterests(5.00,6.5,12)
