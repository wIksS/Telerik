CREATE TABLE Users(
	UserID int IDENTITY PRIMARY KEY,
	Username nvarchar(50), --UNIQUE (it should be here but there
	Password nvarchar(50),
	Full_Name nvarchar(50),
	Last_Login datetime,
	CHECK(LEN(Password) > 5)
)