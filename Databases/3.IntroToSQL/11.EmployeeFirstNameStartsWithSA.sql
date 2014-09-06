use TelerikAcademy;

SELECT * FROM Employees e
WHERE SUBSTRING(e.FirstName,0,3)= 'SA'