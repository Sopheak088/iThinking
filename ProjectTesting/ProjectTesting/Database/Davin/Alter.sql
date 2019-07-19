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