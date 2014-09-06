use TelerikAcademy;

SELECT * FROM Employees e
INNER JOIN Employees m
ON e.ManagerID = m.EmployeeID
