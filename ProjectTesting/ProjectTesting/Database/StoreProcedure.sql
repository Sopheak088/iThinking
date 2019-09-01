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

CREATE PROCEDURE InsertSupplier(
								@ID UNIQUEIDENTIFIER,
								@Name NVARCHAR(max),
								@Phone VARCHAR(13),
								@Descritp NVARCHAR(MAX),
								@Photo VARBINARY(MAX)								
							  )
AS 
BEGIN
	INSERT INTO SUPPLIER
	VALUES(@ID,@Name,@phone,@Descritp,@Photo)
END
Go
CREATE PROCEDURE UpdateSupplier(
				@ID UNIQUEIDENTIFIER,
				@Name NVARCHAR(MAX),
				@Descritp NVARCHAR(MAX),
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
CREATE PROCEDURE ListAllUser
AS
BEGIN
SELECT * FROM [USER]
END
GO
