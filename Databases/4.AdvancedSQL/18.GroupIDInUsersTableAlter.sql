ALTER TABLE Users	
ADD GroupID int
GO

Alter Table Users
ADD CONSTRAINT FK_Users_Groups
FOREIGN KEY (GroupID)
REFERENCES Groups(GroupID)