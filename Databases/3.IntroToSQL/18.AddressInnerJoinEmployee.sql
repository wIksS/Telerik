use TelerikAcademy;

SELECT * FROM Employees e
INNER JOIN Addresses a
ON e.AddressID = a.AddressID
