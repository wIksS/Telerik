CREATE TABLE Users(
	UserID int IDENTITY PRIMARY KEY,
	Username nvarchar(50) UNIQUE,
	Password nvarchar(50),
	Full_Name nvarchar(50),
	Last_Login datetime,
	CHECK(LEN(Password) > 5)
)
GO

CREATE VIEW UsersEnteredToday AS 
SELECT * FROM Users u
WHERE DATEDIFF(d,u.Last_Login, GETDATE()) = 0