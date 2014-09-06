DECLARE empCursor CURSOR READ_ONLY FOR 
	SELECT e.FirstName, e.LastName, t.Name,
                o.FirstName, o.LastName
        FROM TelerikAcademy.dbo.Employees e
                INNER JOIN Addresses a
                        ON a.AddressID = e.AddressID
                INNER JOIN Towns t
                        ON t.TownID = a.TownID,
        TelerikAcademy.dbo.Employees o
                INNER JOIN Addresses a1
                        ON a1.AddressID = o.AddressID
                INNER JOIN Towns t1
                        ON t1.TownID = a1.AddressID 
	
	OPEN empCursor
        DECLARE @firstName1 NVARCHAR(50)
        DECLARE @lastName1 NVARCHAR(50)
        DECLARE @town NVARCHAR(50)
        DECLARE @firstName2 NVARCHAR(50)
        DECLARE @lastName2 NVARCHAR(50)
        FETCH NEXT FROM empCursor
                INTO @firstName1, @lastName1, @town, @firstName2, @lastName2
 
        WHILE @@FETCH_STATUS = 0
                BEGIN
					PRINT @firstName1 + ' ' + @lastName1 +
					      '     ' + @town + '      ' + @firstName2 + ' ' + @lastName2
					FETCH NEXT 
						FROM empCursor
                        INTO @firstName1, @lastName1, @town, @firstName2, @lastName2
                END
 
        CLOSE empCursor
        DEALLOCATE empCursor	
GO