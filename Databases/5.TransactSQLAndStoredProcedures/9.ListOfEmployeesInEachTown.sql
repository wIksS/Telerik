USE TelerikAcademy
DECLARE empCursor CURSOR READ_ONLY FOR
SELECT Name FROM Towns
OPEN empCursor
DECLARE @townName VARCHAR(50), @userNames VARCHAR(MAX)
FETCH NEXT FROM empCursor INTO @townName 
 
WHILE @@FETCH_STATUS = 0
	BEGIN
		BEGIN
		DECLARE nameCursor CURSOR READ_ONLY FOR
		SELECT a.FirstName, a.LastName
		FROM Employees a
		JOIN Addresses adr
		ON a.AddressID = adr.AddressID
		JOIN Towns t1
		ON adr.TownID = t1.TownID
		WHERE t1.Name = @townName
		OPEN nameCursor
		
		DECLARE @firstName VARCHAR(50), @lastName VARCHAR(50)
		FETCH NEXT FROM nameCursor INTO @firstName,  @lastName
		WHILE @@FETCH_STATUS = 0
		    BEGIN
		            SET @userNames = CONCAT(@userNames, @firstName, ' ', @lastName, ', ')
		            FETCH NEXT FROM nameCursor
		            INTO @firstName,  @lastName
		    END
		    CLOSE nameCursor
		    DEALLOCATE nameCursor
		            END
		            SET @userNames = LEFT(@userNames, LEN(@userNames) - 1)
		PRINT @townName + ' -> ' + @userNames
		FETCH NEXT FROM empCursor
		INTO @townName
	END
CLOSE empCursor
DEALLOCATE empCursor
 
GO
