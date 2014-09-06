IF OBJECT_ID('dbo.concat') IS NOT NULL DROP Aggregate concat
GO
 
IF EXISTS (SELECT * FROM sys.assemblies WHERE name = 'concat_assembly')
       DROP assembly concat_assembly;
GO    
 
CREATE Assembly concat_assembly
   AUTHORIZATION dbo
   FROM 'C:\Users\geri\Documents\SQL Server Management Studio\Projects\4. T-SQL\Concatination.dll'
   WITH PERMISSION_SET = SAFE;
GO
 
CREATE AGGREGATE dbo.concat (
 
    @VALUE NVARCHAR(MAX)
  , @Delimiter NVARCHAR(4000)
 
) RETURNS NVARCHAR(MAX)
EXTERNAL Name concat_assembly.concat;
GO
 
--If execution of user code in the .NET Framework is disabled
sp_configure 'clr enabled', 1
GO
RECONFIGURE
GO
 
SELECT dbo.concat(FirstName + ' ' +LastName,', ')
   FROM Employees
GO