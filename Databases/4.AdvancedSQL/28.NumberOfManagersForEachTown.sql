SELECT t.Name AS [Town], COUNT(e.EmployeeID) AS [ManagerCount]
FROM Employees e
        INNER JOIN Addresses a
                ON e.AddressID = a.AddressID
        INNER JOIN Towns t
                ON t.TownID = a.TownID
 
        WHERE e.EmployeeID IN (
                SELECT DISTINCT m.EmployeeID
                FROM Employees m
                        INNER JOIN Employees e
                                ON e.ManagerID = m.EmployeeID)
GROUP BY t.Name