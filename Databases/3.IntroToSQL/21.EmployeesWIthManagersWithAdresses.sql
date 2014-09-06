use TelerikAcademy;

SELECT * FROM Employees e
INNER JOIN Employees m
ON e.ManagerID = m.EmployeeID 
JOIN Addresses a
ON a.AddressID = e.EmployeeID
