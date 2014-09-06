use Bank;
GO

CREATE PROC usp_GetAllPersonWithMoreMoney
(@value money)
AS
	SELECT * FROM Persons p
	JOIN Accounts a
	ON a.PersonID = p.PersonID
	WHERE a.Balance > @value
GO

EXEC usp_GetAllPersonWithMoreMoney 2000