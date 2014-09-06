use TelerikAcademy;

SELECT e.DepartmentID, AVG(e.Salary) FROM Employees e
GROUP BY e.DepartmentID