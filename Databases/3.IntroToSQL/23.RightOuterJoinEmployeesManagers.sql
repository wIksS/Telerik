use TelerikAcademy;

SELECT * FROM Employees m
RIGHT OUTER JOIN Employees e
ON  e.ManagerID= m.EmployeeID 
