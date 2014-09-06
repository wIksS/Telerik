use TelerikAcademy;

SELECT e.FirstName, e.Salary 
FROM Employees e
WHERE e.Salary <=
	(SELECT MIN(Salary) FROM Employees) + 
	(0.1*(SELECT MIN(Salary) FROM Employees))