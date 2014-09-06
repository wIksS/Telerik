use TelerikAcademy;

SELECT COUNT(e.Salary) FROM Employees e
WHERE e.ManagerID IS NULL