use TelerikAcademy;

SELECT t.Name as [Name] 
FROM Towns t
UNION
SELECT d.Name as [Name]
FROM Departments d
