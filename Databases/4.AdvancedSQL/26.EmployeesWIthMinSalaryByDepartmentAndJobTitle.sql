SELECT MIN(Salary) AS [Minimal Salary],
        e.JobTitle AS [Job Title],
        d.Name AS [Department Name],
        MIN(e.FirstName + ' ' + e.LastName) AS [FULL Name]
FROM Employees e
INNER JOIN Departments d
ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, E.JobTitle