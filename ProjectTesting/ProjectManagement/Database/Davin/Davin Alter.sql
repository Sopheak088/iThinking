CREATE TABLE MEMBERSHIP
(
	ID  UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
	MembershipType NVARCHAR(MAX) COLLATE KHMER_100_BIN NULL,
	DiscountValue INT,
	DiscountText VARCHAR(MAX),
	Other NVARCHAR(MAX) COLLATE KHMER_100_BIN NULL,
	CreateBy NVARCHAR(MAX) COLLATE KHMER_100_BIN NULL,
	CreateDate DATETIME NULL,
	UpdateBy NVARCHAR(MAX) COLLATE KHMER_100_BIN NULL,
	UpdateDate DATETIME NULL
	)
GO
if exists (select * from dbo.sysobjects where ID = object_id(N'[dbo].[INSERT_MEMBERSHIP]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
drop procedure [dbo].INSERT_MEMBERSHIP
GO
CREATE PROCEDURE INSERT_MEMBERSHIP(
								@ID UNIQUEIDENTIFIER,
								@MembershipType NVARCHAR(MAX),
								@DiscountValue INT,
								@DiscountText VARCHAR(MAX),
								@Other NVARCHAR(MAX),
								@CreateBy NVARCHAR(MAX),
								@CreateDate DATETIME

)
AS
BEGIN
INSERT INTO MEMBERSHIP(
[ID]
,[MembershipType]
,[DiscountValue]
,[DiscountText]
,[Other]
,[CreateBy]
,[CreateDate])
VALUES(@ID ,@MembershipType,@DiscountValue,@DiscountText,@Other,@CreateBy,@CreateDate)
END
GO
if exists (select * from dbo.sysobjects where ID = object_id(N'[dbo].[UPDATE_MEMBERSHIP]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
drop procedure [dbo].UPDATE_MEMBERSHIP
GO
CREATE PROCEDURE UPDATE_MEMBERSHIP(
								
								@ID UNIQUEIDENTIFIER,
								@MembershipType NVARCHAR(MAX),
								@DiscountValue INT,
								@DiscountText VARCHAR(MAX),
								@Other NVARCHAR(MAX),				
								@UpdateBy NVARCHAR(MAX),
								@UpdateDate DATETIME)

AS 
BEGIN
		UPDATE MEMBERSHIP SET
		[MembershipType] = @MembershipType
      ,[DiscountValue] = @DiscountValue
      ,[DiscountText] = @DiscountText
      ,[Other] = @Other      
	,[UpdateBy] = @UpdateBy
      ,[UpdateDate] = @UpdateDate
	  WHERE ID = @ID
END
GO
CREATE TABLE [dbo].[CUSTOMER](
	[ID] [uniqueidentifier] NOT NULL DEFAULT (newid()),
	[CustomerName] [nvarchar](max) NULL,
	[Gender] [varchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[Photo] [varbinary](max) NULL,
	[Active] [bit] NULL,
	[OtherContact] [varchar](max) NULL,
	[MemberShipID] [uniqueidentifier] NULL,
	[CreateBy] [nvarchar](max) NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [nvarchar](max) NULL,
	[UpdateDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
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
CREATE PROCEDURE [dbo].[UPDATE_CUSTOMER](
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
GO
CREATE TABLE INVOICE
(
	ID  UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
	InvoiceNo  VARCHAR(MAX) ,
	InvoiceDate DATETIME ,
	DiscountText VARCHAR(MAX),
	Other NVARCHAR(MAX) COLLATE KHMER_100_BIN NULL,
	Total Money,
	CustomerID UNIQUEIDENTIFIER,
	CONSTRAINT CUTOMER_PK_INVOICE_FK FOREIGN KEY(CustomerID) REFERENCES CUSTOMER(ID),
	CreateBy NVARCHAR(MAX) COLLATE KHMER_100_BIN NULL,
	CreateDate DATETIME NULL,
	UpdateBy NVARCHAR(MAX) COLLATE KHMER_100_BIN NULL,
	UpdateDate DATETIME NULL
	)
	GO
	if exists (select * from dbo.sysobjects where ID = object_id(N'[dbo].[INSERT_INVOICE]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
drop procedure [dbo].INSERT_INVOICE

GO
CREATE PROCEDURE INSERT_INVOICE(
								@ID UNIQUEIDENTIFIER,
								@InvoiceNO VARCHAR(MAX),
								@InvoiceDate DATETIME,
								@Other NVARCHAR(MAX),
								@Total MONEY,
								@CustomerID UNIQUEIDENTIFIER,
								@CreateBy NVARCHAR(MAX),
								@CreatedDate DATETIME)
								
AS
BEGIN
INSERT INTO INVOICE(
[ID]
,[InvoiceNo]
,[InvoiceDate]
,[Other]
,[Total]
,[CustomerID]
,[CreateBy]
,[CreateDate]
)
VALUES(@ID ,@InvoiceNO,@InvoiceDate,@Total,@Other,@CustomerID,@CreateBy,@CreatedDate)
END
GO
if exists (select * from dbo.sysobjects where ID = object_id(N'[dbo].[UPDATE_INVOICE]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
drop procedure [dbo].UPDATE_INVOICE

GO
CREATE PROCEDURE UPDATE_INVOICE(
								@ID UNIQUEIDENTIFIER,
								@InvoiceNO VARCHAR(MAX),
								@InvoiceDate DATETIME,
								@Other NVARCHAR(MAX),
								@Total MONEY,
								@CustomerID UNIQUEIDENTIFIER,
								@UpdateBy NVARCHAR(MAX),
								@UpdatedDate DATETIME)
AS 
BEGIN
		UPDATE INVOICE SET
		[InvoiceNO] = @InvoiceNO
      ,[InvoiceDate] = @InvoiceDate
      ,[Other] = @Other  
	  ,[Total]=@Total
	  ,[CustomerID]= @CustomerID    
	  ,[UpdateBy] = @UpdateBy
      ,[UpdateDate] = @UpdatedDate
	  WHERE ID = @ID
END
GO
