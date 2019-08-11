if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ListAllUser]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].ListAllUser
GO
CREATE PROCEDURE ListAllUser
AS 
BEGIN
	SELECT * FROM [USER] WHERE Active = 1
END

GO
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[InsertUser]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].InsertUser
GO
CREATE PROCEDURE InsertUser(
								@Id UNIQUEIDENTIFIER,
								@FirstName NVARCHAR(255),
								@LastName NVARCHAR(255),
								@Username NVARCHAR(255),
								@Password NVARCHAR(255),
								@Position NVARCHAR(255),
								@Phone NVARCHAR(255),
								@Active BIT,
								@CreatedBy NVARCHAR(255),
								@CreatedDate DATETIME
							  )
AS 
BEGIN
	INSERT INTO [USER](ID, FirstName, LastName, Username, [Password], Position, Phone, Active, CreatedBy, CreatedDate)
	VALUES(@Id,@FirstName, @LastName, @Username, @Password, @Position, @Phone, @Active, @CreatedBy, @CreatedDate)
END

GO
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[UpdateUser]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].UpdateUser
GO
CREATE PROCEDURE UpdateUser(
								@Id UNIQUEIDENTIFIER,
								@FirstName NVARCHAR(255),
								@LastName NVARCHAR(255),
								@Username NVARCHAR(255),
								@Password NVARCHAR(255),
								@Position NVARCHAR(255),
								@Phone NVARCHAR(255),
								@Active BIT,
								@UpdatedBy NVARCHAR(255),
								@UpdatedDate DATETIME
							  )
AS 
BEGIN
	UPDATE [USER]
	SET 
	FirstName = @FirstName, 
	LastName = @LastName, 
	Username = @Username, 
	[Password] = @Password, 
	Position = @Position, 
	Phone = @Phone, 
	Active = @Active, 
	UpdatedBy = @UpdatedBy, 
	UpdatedDate = @UpdatedDate
	WHERE ID = @Id
END
GO
