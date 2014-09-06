CREATE TABLE #TempTable (
        EmployeeID INT,
        ProjectID INT
)
 
INSERT INTO #TempTable
SELECT ep.EmployeeID AS EmployeeID,
        ep.ProjectID AS ProjectID
FROM EmployeesProjects ep
 
DROP TABLE EmployeesProjects
 
CREATE TABLE EmployeesProjects (
        EmployeeID INT,
        ProjectID INT
)
 
INSERT INTO EmployeesProjects
SELECT tt.EmployeeID AS EmployeeID,
        tt.ProjectID AS ProjectID
FROM #TempTable tt