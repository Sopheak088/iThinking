
CREATE TABLE CATEGORY(
	ID UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID() not null,
	CategoryName NVARCHAR(255) COLLATE Khmer_100_BIN not null,
	Other NVARCHAR(255) COLLATE Khmer_100_BIN null,
	CreatedBy NVARCHAR(255) COLLATE Khmer_100_BIN null,
	CreatedDate DATETIME null,
	UpdatedBy NVARCHAR(255) COLLATE Khmer_100_BIN null,
	UpdatedDate DATETIME null
	)
GO
CREATE TABLE PRODUCT(
	ID UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
	CategoryID UNIQUEIDENTIFIER, 
	CONSTRAINT CATEGORY_PK_PRODUCT_FK FOREIGN KEY (CategoryID) REFERENCES CATEGORY(ID),
	ProductName NVARCHAR(MAX) COLLATE Khmer_100_BIN NOT NULL,
	Price MONEY NOT NULL,
	MadeDate DATETIME NOT NULL,
	[ExpireDate] DATETIME NOT NULL,
	Photo VARBINARY(MAX) NOT NULL,
	Barcode VARCHAR(15) NOT NULL,
	Active BIT NOT NULL,
	CreatedBy NVARCHAR(255) COLLATE Khmer_100_BIN NULL,
	CreatedDate DATETIME NULL,
	UpdatedBy NVARCHAR(255) COLLATE Khmer_100_BIN NULL,
	UpdatedDate DATETIME NULL
	)
GO
CREATE PROCEDURE INSERT_CATEGORY(
			@Id UNIQUEIDENTIFIER,
			@CategoryName NVARCHAR(255),
			@Other NVARCHAR(255),
			@CreatedBy NVARCHAR(255),
			@CreatedDate DATETIME
			)
AS
BEGIN
INSERT INTO CATEGORY(
			ID,
			CategoryName,
			Other,
			CreatedBy,
			CreatedDate
			)
VALUES(@Id, @CategoryName, @Other, @CreatedBy, @CreatedDate)
END
GO
CREATE PROC UPDATE_CATEGORY(
			@Id UNIQUEIDENTIFIER,
			@CategoryName NVARCHAR(255),
			@Other NVARCHAR(255),
			@UpdatedBy NVARCHAR(255),
			@UpdatedDate DATETIME
			)
AS
BEGIN
	UPDATE CATEGORY SET
	CategoryName = @CategoryName,
	Other = @Other,
	UpdatedBy = @UpdatedBy,
	UpdatedDate = @UpdatedDate
	WHERE ID = @Id
END
GO


CREATE PROCEDURE [dbo].[INSERT_PRODUCT](
	@Id UNIQUEIDENTIFIER,
	@CategoryID UNIQUEIDENTIFIER,
	@ProductName NVARCHAR(MAX),
	@Price MONEY,
	@MadeDate DATETIME,
	@ExpireDate DATETIME,
	@Photo VARBINARY(MAX),
	@BarCode VARCHAR(15),
	@Active BIT,
	@CreatedBy NVARCHAR(255),
	@CreatedDate DATETIME
	)
AS 
BEGIN
INSERT INTO PRODUCT(
			ID,
			CategoryID,
			ProductName,
			Price,
			MadeDate,
			[ExpireDate],
			Photo,
			Barcode,
			Active,
			CreatedBy,
			CreatedDate
			)
VALUES(@Id, @CategoryID,@ProductName,@Price, @MadeDate,@ExpireDate,@Photo,@BarCode,@Active, @CreatedBy,@CreatedDate)
END
GO

CREATE PROCEDURE UPDATE_PRODUCT(
								@Id UNIQUEIDENTIFIER,
								@CategoryId UNIQUEIDENTIFIER,
								@ProductName NVARCHAR(MAX),
								@Price MONEY,
								@MadeDate DATETIME,
								@ExpireDate DATETIME,
								@Photo VARBINARY(MAX),
								@Barcode VARCHAR(15),
								@Active BIT,								
								@UpdatedBy NVARCHAR(255),
								@UpdatedDate DATETIME
							  )
AS 
BEGIN
	UPDATE PRODUCT SET
	CategoryID = @CategoryId,
	ProductName = @ProductName,
	Price = @Price,
	MadeDate = @MadeDate,
	[ExpireDate] = @ExpireDate,
	Photo=@Photo,
	Barcode=@Barcode,
	Active=@Active,
	UpdatedBy=@UpdatedBy,
	UpdatedDate=@UpdatedDate
	WHERE ID = @Id
END
GO