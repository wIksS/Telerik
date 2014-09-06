use TelerikAcademy;

SELECT * FROM Employees e
INNER JOIN Departments d
ON d.DepartmentID = e.DepartmentID
WHERE d.Name IN('Sales','Finance')
AND e.HireDate > '1995' AND e.HireDate < '2005'
