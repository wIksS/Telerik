SELECT TOP 1 t.Name AS [Town], COUNT(e.EmployeeID) AS [EmployeeCount]
FROM Employees e
INNER JOIN Addresses a
ON e.AddressID = a.AddressID
INNER JOIN Towns t
ON t.TownID = a.TownID
GROUP BY t.Name
ORDER BY EmployeeCount DESC