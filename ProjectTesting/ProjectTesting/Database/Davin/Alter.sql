CREATE TABLE PRODUCT(
	ID UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	Name NVARCHAR(MAX) COLLATE Khmer_100_BIN,
	Price MONEY,
	MadeDate DATE,
	ExpiredDate DATE,
	Photo VARBINARY(MAX),
	Active BIT
)
GO
CREATE PROCEDURE InsertProduct(
								@Id UNIQUEIDENTIFIER,
								@Name nvarchar(max),
								@Price MONEY,
								@MadeDate DATE,
								@ExpiredDate DATE,
								@Photo VARBINARY(MAX),
								@Active BIT
							  )
AS 
BEGIN
	INSERT INTO PRODUCT
	VALUES(@Id,@Name,@Price,@MadeDate,@ExpiredDate,@Photo,@Active)
END
GO
CREATE PROCEDURE UpdateProduct(
								@Id UNIQUEIDENTIFIER,
								@Name nvarchar(max),
								@Price MONEY,
								@MadeDate DATE,
								@ExpiredDate DATE,
								@Photo VARBINARY(MAX),
								@Active BIT
							  )
AS 
BEGIN
	UPDATE PRODUCT 
	SET
	Name = @Name,
	Price = @Price,
	MadeDate = @MadeDate,
	ExpiredDate = @ExpiredDate,
	Photo = @Photo,
	Active = @Active
	WHERE ID = @Id
END
GO
CREATE PROCEDURE ListAllProduct 
AS 
BEGIN
	SELECT * FROM PRODUCT
END
GO
CREATE TABLE CUSTOMER (
ID UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
Name NVARCHAR(MAX) COLLATE Khmer_100_BIN,
Phone VARCHAR(13),
Photo VARBINARY(MAX)
)
GO


CREATE PROCEDURE InsertCustomer(
				@ID UNIQUEIDENTIFIER,
				@Name NVARCHAR(MAX),
				@Phone VARCHAR(13),
				@Photo VARBINARY(MAX)


)
AS
BEGIN
INSERT INTO CUSTOMER
VALUES (@ID,@Name,@Phone,@Photo)

END

Go


CREATE PROCEDURE UpdateCustomer(
				@ID UNIQUEIDENTIFIER,
				@Name NVARCHAR(MAX),
				@Phone VARCHAR(13),
				@Photo VARBINARY(MAX)


)
AS
BEGIN
UPDATE CUSTOMER
SET
	Name=@Name,
	Phone=@Phone,
	Photo=@Photo
	WHERE ID=@ID

END
GO
CREATE PROCEDURE ListAllCustomer
AS
BEGIN
SELECT * FROM CUSTOMER
END
GO

CREATE TABLE SUPPLIER(
	ID UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	Name NVARCHAR(MAX) COLLATE Khmer_100_BIN,
	Phone VARCHAR(13),
	Descript NVARCHAR(MAX) COLLATE khmer_100_BIN, 
	Photo VARBINARY(MAX))
	GO
	CREATE PROCEDURE InsertSupplier(
								@ID UNIQUEIDENTIFIER,
								@Name NVARCHAR(max),
								@Phone VARCHAR(13),
								@Descript NVARCHAR(MAX),
								@Photo VARBINARY(MAX)								
							  )
AS 
BEGIN
	INSERT INTO SUPPLIER
	VALUES(@ID,@Name,@phone,@Descript,@Photo)
END
Go
CREATE PROCEDURE UpdateSupplier(
				@ID UNIQUEIDENTIFIER,
				@Name NVARCHAR(MAX),
				@Descript NVARCHAR(MAX),
				@Phone VARCHAR(13),
				@Photo VARBINARY(MAX)


)
AS
BEGIN
UPDATE SUPPLIER
SET
	Name=@Name,
	Phone=@Phone,
	Descript=@Descritp,
	Photo=@Photo
	WHERE ID=@ID
	END
	GO
	CREATE PROCEDURE ListAllSupplier
AS
BEGIN
SELECT * FROM SUPPLIER
END
GO
CREATE TABLE [USER](
		
	ID UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	UserName VARCHAR(MAX),
	UserPassword  VARCHAR(MAX),
	Position VARCHAR(MAX)
	
)
Go
CREATE PROCEDURE InsertUser(
								@ID UNIQUEIDENTIFIER,
								@UserName VARCHAR(max),
								@UserPassword VARCHAR(MAX),
								@Position VARCHAR(MAX)
											
							  )
AS 
BEGIN
	INSERT INTO [USER]
	VALUES(@ID,@UserName,@UserPassword,@Position)
END
Go
CREATE PROCEDURE UpdateUser(
				@ID UNIQUEIDENTIFIER,
				@UserName VARCHAR(MAX),
				@UserPassword VARCHAR(MAX),
				@Position VARCHAR(MAX)


)
AS
BEGIN
UPDATE [USER]
SET
	UserName=@UserName,
	UserPassword=@UserPassword,
	Position=@Position
	WHERE ID=@ID

END
Go
--CREATE PROCEDURE ListAllUser
--AS
--BEGIN
--SELECT * FROM [USER]
--END
--GO
--CREATE PROCEDURE UserLogin(
--						@uid VARCHAR(MAX),
--						@pwd VARCHAR(MAX)
--						)
--AS
--BEGIN
--SELECT * FROM [USER]
--WHERE LOWER(UserName)=LOWER(@uid)
--AND UserPassword=@pwd
--END
GO
create procedure UserLogin(@uid varchar(max),@pwd varchar(max))
as
begin
	select * from [USER]
	where [UserName] = @uid and [UserPassword] =@pwd
end
GO

CREATE TABLE CATEGORY(
	ID UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	Category NVARCHAR(MAX) COLLATE Khmer_100_BIN,
	[Des]   NVARCHAR(MAX)
	
)
GO
CREATE PROCEDURE InsertCategory(
				@ID UNIQUEIDENTIFIER,
				@Category NVARCHAR(MAX),
				@Des NVARCHAR(MAX)
				


)
AS
BEGIN
INSERT INTO CATEGORY
VALUES (@ID,@Category,@Des)

END
Go
CREATE PROCEDURE UpdateCategory(
				@ID UNIQUEIDENTIFIER,
				@Category NVARCHAR(MAX),
				@Des NVARCHAR(MAX)			


)
AS
BEGIN
UPDATE CATEGORY
SET
	Category=@Category,
	[Des]=@Des
	
	WHERE ID=@ID

END
Go
CREATE PROCEDURE ListAllCategory
AS
BEGIN
SELECT * FROM CATEGORY
END
Go
CREATE PROCEDURE SearchCustomerByName @name nvarchar(30)
AS
SELECT * FROM [CUSTOMER] WHERE Lower(Name) LIKE '%'+ LOWER(@name) +'%'
GO
CREATE PROCEDURE SearchProductByName @name nvarchar(30)
AS
SELECT * FROM PRODUCT
 WHERE Lower(Name) LIKE '%'+ LOWER(@name) +'%'