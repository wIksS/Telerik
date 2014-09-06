use TelerikAcademy;

SELECT e.FirstName + e.LastName, ISNULL(m.FirstName, 'No Manager') FROM Employees e
LEFT JOIN Employees m
ON e.ManagerID = m.EmployeeID
