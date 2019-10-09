if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[INSERT_COMPANY]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].INSERT_COMPANY
GO
 CREATE PROCEDURE INSERT_COMPANY(
								@Id UNIQUEIDENTIFIER,
								@NameInKhmer NVARCHAR(255),
								@NameInEnglish NVARCHAR(255),
								@Email NVARCHAR(255),
								@Phone NVARCHAR(255),
								@Location NVARCHAR(255),
								@Active BIT,
								@Logo VARBINARY(MAX),
								@CreatedBy NVARCHAR(255),
								@CreatedDate DATETIME
							  )
AS 
BEGIN
	INSERT INTO COMPANY (
	   [ID]
      ,[NameInKhmer]
      ,[NameInEnglish]
      ,[Email]
      ,[Phone]
      ,[Location]
      ,[Active]
      ,[Logo]
      ,[CreatedBy]
      ,[CreatedDate])
	VALUES(@Id,@NameInKhmer,@NameInEnglish,@Email,@Phone,@Location,@Active,@Logo,@CreatedBy,@CreatedDate)
END
GO
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[UPDATE_COMPANY]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].UPDATE_COMPANY
GO
 CREATE PROCEDURE UPDATE_COMPANY(
								@Id UNIQUEIDENTIFIER,
								@NameInKhmer NVARCHAR(255),
								@NameInEnglish NVARCHAR(255),
								@Email NVARCHAR(255),
								@Phone NVARCHAR(255),
								@Location NVARCHAR(255),
								@Active BIT,
								@Logo VARBINARY(MAX),
								@UpdatedBy NVARCHAR(255),
								@UpdatedDate DATETIME
							  )
AS 
BEGIN
		UPDATE COMPANY SET
		[NameInKhmer] = @NameInKhmer
      ,[NameInEnglish] = @NameInEnglish
      ,[Email] = @Email
      ,[Phone] = @Phone
      ,[Location] = @Location
      ,[Active] = @Active
      ,[Logo] = @Logo
      ,[UpdatedBy] = @UpdatedBy
      ,[UpdatedDate] = @UpdatedDate
	  WHERE ID = @Id
END

GO
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[INSERT_USER]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].INSERT_USER
GO
 CREATE PROCEDURE INSERT_USER(
								@Id UNIQUEIDENTIFIER,
								@FirstName NVARCHAR(255),
								@LastName NVARCHAR(255),
								@Username NVARCHAR(255),
								@Password NVARCHAR(255),
								@Position NVARCHAR(255),
								@Phone NVARCHAR(255),
								@Active BIT,
								@BranchId UNIQUEIDENTIFIER,
								@CreatedBy NVARCHAR(255),
								@CreatedDate DATETIME
							  )
AS 
BEGIN
	INSERT INTO [USER] (
	   [ID]
      ,[FirstName]
      ,[LastName]
      ,[Username]
      ,[Password]
      ,[Position]
      ,[Phone]
      ,[Active]
      ,[BranchId]
      ,[CreatedBy]
      ,[CreatedDate])
	VALUES(@Id,@FirstName,@LastName,@Username,@Password,@Position,@Phone,@Active,@BranchId,@CreatedBy,@CreatedDate)
END
GO
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[UPDATE_USER]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].UPDATE_USER
GO
 CREATE PROCEDURE UPDATE_USER(
								@Id UNIQUEIDENTIFIER,
								@FirstName NVARCHAR(255),
								@LastName NVARCHAR(255),
								@Username NVARCHAR(255),
								@Password NVARCHAR(255),
								@Position NVARCHAR(255),
								@Phone NVARCHAR(255),
								@Active BIT,
								@BranchId UNIQUEIDENTIFIER,
								@UpdatedBy NVARCHAR(255),
								@UpdatedDate DATETIME
							  )
AS 
BEGIN
	UPDATE [USER] SET
      [FirstName] = @FirstName
      ,[LastName] = @LastName
      ,[Username] = @Username
      ,[Password] = @Password
      ,[Position] = @Position
      ,[Phone] = @Phone
      ,[Active] = @Active
      ,[BranchId] = @BranchId
	  ,[UpdatedBy] = @UpdatedBy
	  ,[UpdatedDate] = @UpdatedDate
	  WHERE ID = @Id
END
GO
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[INSERT_CUSTOMER]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].INSERT_CUSTOMER
go
create PROCEDURE INSERT_CUSTOMER(
								@ID UNIQUEIDENTIFIER,
								@CustomerName NVARCHAR(MAX),
								@Gender VARCHAR(MAX),
								@Address NVARCHAR(MAX),
								@Photo VARBINARY(MAX),
								@Active BIT,
								@OtherContact VARCHAR(MAX),
								@MemberShipID UNIQUEIDENTIFIER,
								@CreateBy NVARCHAR(MAX),
								@CreatedDate DATETIME)
								
AS
BEGIN
INSERT INTO CUSTOMER(
[ID]
,[CustomerName]
,[Gender]
,[Address]
,[Photo]
,[Active]
,[OtherContact]
,[MemberShipID]
,[CreateBy]
,[CreateDate]
)
VALUES(@ID ,@CustomerName,@Gender,@Address,@Photo,@Active,@OtherContact,@MemberShipID ,@CreateBy,@CreatedDate)
END
GO
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[UPDATE_CUSTOMER]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].UPDATE_CUSTOMER
go
create PROCEDURE UPDATE_CUSTOMER(
								@ID UNIQUEIDENTIFIER,
								@CustomerName NVARCHAR(MAX),
								@Gender VARCHAR(MAX),
								@Address NVARCHAR(MAX),
								@Photo VARBINARY(MAX),
								@Active BIT,
								@OtherContact VARCHAR(MAX),
								@MemberShipID UNIQUEIDENTIFIER,
								@UpdateBy NVARCHAR(MAX),
								@UpdateDate DATETIME)
								
AS
BEGIN
UPDATE CUSTOMER SET
[CustomerName]=@CustomerName
,[Gender]=@Gender
,[Address]=@Address
,[Photo]=@Photo
,[Active]=@Active
,[OtherContact]=@OtherContact
,[MemberShipID]=@MemberShipID
,[UpdateBy]=@UpdateBy
,[UpdateDate]=@UpdateDate
WHERE ID=@ID
END