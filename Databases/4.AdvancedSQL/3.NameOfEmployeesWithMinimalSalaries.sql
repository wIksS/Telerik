use TelerikAcademy;

SELECT FirstName, LastName, Salary, DepartmentID
FROM Employees e
WHERE Salary =
                (
                        SELECT MIN(Salary)
                        FROM Employees
                        WHERE DepartmentID = e.DepartmentID
                )