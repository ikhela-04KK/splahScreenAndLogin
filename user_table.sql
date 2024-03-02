CREATE TABLE dbo.Users (
	user_id INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
	full_name [NVARCHAR](80), 
	email [NVARCHAR](80),
	password [NVARCHAR](80)
);
