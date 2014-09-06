use TelerikAcademy;

SELECT * FROM Employees e
LEFT OUTER JOIN Employees m
ON  m.EmployeeID = e.ManagerID
