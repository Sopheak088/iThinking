CREATE TABLE BRANCH 
(
	ID UNIQUEIDENTIFIER  PRIMARY KEY DEFAULT NEWID(),
	Name NVARCHAR(255) COLLATE  KHMER_100_BIN NOT NULL,
	Email NVARCHAR(255) COLLATE  KHMER_100_BIN NOT NULL,
	Phone NVARCHAR(255) COLLATE  KHMER_100_BIN NOT NULL,
	Location NVARCHAR(255) COLLATE  KHMER_100_BIN NOT NULL,
	Active BIT NOT NULL DEFAULT 1,
	CompanyId UNIQUEIDENTIFIER,
	CONSTRAINT COMPANY_PK_BRANCH_FK FOREIGN KEY(CompanyId)REFERENCES COMPANY(ID),
	CreatedBy NVARCHAR(255) COLLATE  KHMER_100_BIN NOT NULL,
	CreatedDate DATETIME NULL,
	UpdatedBy NVARCHAR(255) COLLATE  KHMER_100_BIN,
	UpdatedDate DATETIME NULL 
)
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[INSERT_BRANCH]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].INSERT_BRANCH
GO
CREATE PROCEDURE INSERT_BRANCH(
								@Id UNIQUEIDENTIFIER,
								@Name NVARCHAR(255),
								@Email NVARCHAR(255),
								@Phone NVARCHAR(255),
								@Location NVARCHAR(255),
								@Active BIT,
								@CompanyId UNIQUEIDENTIFIER,
								@CreatedBy NVARCHAR(255),
								@CreatedDate DATETIME
							  )
AS 
BEGIN
	INSERT INTO BRANCH(
	   [ID]
	  ,[Name]
      ,[Email]
      ,[Phone]
      ,[Location]
      ,[Active]
	  , CompanyId
      ,[CreatedBy]
      ,[CreatedDate])
	VALUES(@Id,@Name,@Email,@Phone,@Location,@Active,@CompanyId,@CreatedBy,@CreatedDate)
END
GO
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[UPDATE_BRANCH]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].UPDATE_BRANCH
GO
 CREATE PROCEDURE UPDATE_BRANCH(
								@Id UNIQUEIDENTIFIER,
								@Name NVARCHAR(255),
								@Email NVARCHAR(255),
								@Phone NVARCHAR(255),
								@Location NVARCHAR(255),
								@Active BIT,
								@CompanyId UNIQUEIDENTIFIER,
								@UpdatedBy NVARCHAR(255),
								@UpdatedDate DATETIME
							  )
AS 
BEGIN
		UPDATE BRANCH SET
	   [Name] = @Name
      ,[Email] = @Email
      ,[Phone] = @Phone
      ,[Location] = @Location
      ,[Active] = @Active
	  , CompanyId= @CompanyId
      ,[UpdatedBy] = @UpdatedBy
      ,[UpdatedDate] = @UpdatedDate
	  WHERE ID = @Id
END
