use TelerikAcademy;

INSERT INTO Users(Username,Password,Full_Name,Last_Login)
 SELECT LOWER(SUBSTRING(e.FirstName,0,3)) + ' ' + LOWER(e.LastName),
LOWER(SUBSTRING(e.FirstName,0,3)) + '   ' + LOWER(e.LastName) ,
 e.FirstName + ' ' + e.LastName , GETDATE() FROM Employees e