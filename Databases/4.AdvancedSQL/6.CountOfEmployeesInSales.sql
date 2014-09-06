use TelerikAcademy;

SELECT COUNT(e.Salary) FROM Employees e
JOIN Departments d
ON d.DepartmentID = e.DepartmentID
WHERE d.Name = 'Sales';