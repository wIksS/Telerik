use TelerikAcademy;

SELECT e.DepartmentID, e.JobTitle, AVG(e.Salary) FROM Employees e
GROUP BY e.DepartmentID,e.JobTitle