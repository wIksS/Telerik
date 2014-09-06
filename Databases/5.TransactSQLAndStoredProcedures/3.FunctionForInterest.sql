use Bank;
GO

CREATE FUNCTION ufn_NewSumAfterInterests
	(@sum money, @yearlyInterest decimal(5,2),@numberOfMonths float)
RETURNS money
AS
BEGIN
	return (@sum * (@yearlyInterest/100)*(@numberOfMonths /12)) + @sum
END
GO

DROP FUNCTION dbo.ufn_NewSumAfterInterests

SELECT dbo.ufn_NewSumAfterInterests(1000,6.5,12)
GO