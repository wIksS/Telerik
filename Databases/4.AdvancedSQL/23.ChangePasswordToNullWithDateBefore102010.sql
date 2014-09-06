use TelerikAcademy;

UPDATE Users
SET Password = null
FROM Users u 
WHERE u.Last_Login < '10.03.2010'