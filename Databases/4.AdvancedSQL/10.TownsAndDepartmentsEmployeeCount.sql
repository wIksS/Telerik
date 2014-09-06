use TelerikAcademy;

SELECT  DepartmentID, COUNT(*) AS EmployeesCount, t.Name
FROM Employees e
        JOIN Addresses a
        ON a.AddressID = e.AddressID
        JOIN Towns t
        ON a.TownID = t.TownID
GROUP BY e.DepartmentID, t.Name
ORDER BY e.DepartmentID