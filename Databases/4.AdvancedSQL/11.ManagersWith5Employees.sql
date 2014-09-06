use TelerikAcademy;

SELECT m.FirstName + ' ' + m.LastName as [Full Name], COUNT(*) as [Employees Count] FROM Employees e
JOIN Employees m
ON e.ManagerID = m.EmployeeID
GROUP BY m.FirstName, m.LastName
HAVING COUNT(*) = 5
