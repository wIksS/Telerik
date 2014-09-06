use TelerikAcademy;

UPDATE Users
SET Last_Login = GETDATE();
GO

UPDATE Groups
SET Name = 'The ' + Name
WHERE Groups.GroupID = 1