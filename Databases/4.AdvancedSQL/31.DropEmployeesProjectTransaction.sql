BEGIN TRAN
DELETE FROM Employees
        SELECT d.Name
        FROM Employees e JOIN Departments d
        ON e.DepartmentID = d.DepartmentID
        WHERE d.Name = 'Sales'
        GROUP BY d.Name
ROLLBACK TRAN