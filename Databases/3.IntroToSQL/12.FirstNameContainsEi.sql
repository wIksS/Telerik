use TelerikAcademy;

SELECT * FROM Employees e
WHERE CHARINDEX('ei',e.LastName) > 0