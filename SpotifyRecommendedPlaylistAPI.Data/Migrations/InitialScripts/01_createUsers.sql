IF NOT EXISTS(SELECT name FROM sysobjects WHERE name = 'Users' AND type = 'U')
   BEGIN
	CREATE TABLE Users
	(UserID int IDENTITY(1,1) NOT NULL CONSTRAINT UserPKey PRIMARY KEY,
	Name nvarchar(200) NOT NULL,
	UserName nvarchar(200) NOT NULL,
	Email nvarchar(200) NULL,
	Phone nvarchar(200) NULL)
   END
GO