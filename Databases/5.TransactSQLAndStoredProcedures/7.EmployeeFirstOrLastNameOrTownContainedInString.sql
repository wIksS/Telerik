CREATE FUNCTION dbo.regexFind
	(@source varchar(5000),@regexp varchar(1000),@ignoreCase bit = 0)
	RETURNS bit AS
BEGIN
	DECLARE @hr integer
	DECLARE @objRegExp integer
	DECLARE @results bit
	
	SET @results = 0

	EXECUTE @hr = sp_OACreate 'VBScript.RegExp', @objRegExp OUTPUT
	IF @hr <> 0 
	BEGIN
		EXEC @hr = sp_OADestroy @objRegExp
	RETURN NULL
	END
	EXECUTE @hr = sp_OASetProperty @objRegExp, 'Pattern', @regexp
	IF @hr <> 0 
	BEGIN
		EXEC @hr = sp_OADestroy @objRegExp
	RETURN NULL
	END
	EXECUTE @hr = sp_OASetProperty @objRegExp, 'Global', false
	IF @hr <> 0 
	BEGIN
		EXEC @hr = sp_OADestroy @objRegExp
	RETURN NULL
	END
	EXECUTE @hr = sp_OASetProperty @objRegExp, 'IgnoreCase', @ignoreCase
	IF @hr <> 0 
	BEGIN
		EXEC @hr = sp_OADestroy @objRegExp
	RETURN NULL
	END	
	EXECUTE @hr = sp_OAMethod @objRegExp, 'Test', @results OUTPUT, @source
	IF @hr <> 0 
	BEGIN
		EXEC @hr = sp_OADestroy @objRegExp
	RETURN NULL
	END
	EXECUTE @hr = sp_OADestroy @objRegExp
	IF @hr <> 0 
	BEGIN
		RETURN NULL
	END
	
	RETURN @results
END
GO

--returns all employees with given town AND 
--(first name OR last name OR middle name)
CREATE FUNCTION fn_Find 
	( @regularExpression nvarchar(30) )
	RETURNS TABLE
AS
RETURN 
	SELECT e.FirstName, e.MiddleName, e.LastName, t.Name AS Town
	FROM TelerikAcademy.dbo.Employees e, TelerikAcademy.dbo.Addresses a, TelerikAcademy.dbo.Towns t
	WHERE e.AddressID = a.AddressID
	AND a.TownID = t.TownID
	AND 1 = dbo.regexFind(LOWER(t.Name), @regularExpression,1)
	AND (1 = dbo.regexFind(LOWER(e.FirstName), @regularExpression,1)
		OR 1 = dbo.regexFind(LOWER(ISNULL(e.MiddleName, '')), @regularExpression,1)
		OR 1 = dbo.regexFind(LOWER(e.LastName), @regularExpression,1))
GO

-- Usage:
SELECT * FROM fn_Find('^[oistmiahf]+$')
GO