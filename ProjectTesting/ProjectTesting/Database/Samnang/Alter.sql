CREATE TABLE STAFF(
	ID UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	Name NVARCHAR(MAX) COLLATE Khmer_100_BIN,
	Salary MONEY,
	HireDate DATE,
	StopDate DATE,
	Photo VARBINARY(MAX)
	)
GO
CREATE PROCEDURE InsertStaff(
								@Id UNIQUEIDENTIFIER,
								@Name nvarchar(max),
								@Salary MONEY,
								@HireDate DATE,
								@StopDate DATE,
								@Photo VARBINARY(MAX)
							  )
AS 
BEGIN
	INSERT INTO STAFF 
	VALUES(@Id,@Name,@Salary,@HireDate,@StopDate,@Photo)
END
GO
CREATE PROCEDURE UpdateStaff(
								@Id UNIQUEIDENTIFIER,
								@Name nvarchar(max),
								@Salary MONEY,
								@HireDate DATE,
								@StopDate DATE,
								@Photo VARBINARY(MAX)
							  )
AS 
BEGIN
	UPDATE STAFF 
	SET
	Name = @Name,
	Salary = @Salary,
	HireDate = @HireDate,
	StopDate = @StopDate,
	Photo = @Photo
	WHERE ID = @Id
END
GO
CREATE PROCEDURE ListAllStaff 
AS 
BEGIN
	SELECT * FROM STAFF
END
GO
CREATE TABLE COMPANY(
	ID UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	Name VARCHAR(50) COLLATE Khmer_100_BIN,
	Location VARCHAR(50),
	Email VARCHAR(50),
	Telephone VARCHAR(15),
	Fax VARCHAR(50),
	Logo VARBINARY(MAX),
	Branch INT
)
GO
CREATE PROCEDURE InsertCompany(
								@Id UNIQUEIDENTIFIEr,
								@Name VARCHAR(50),
								@Location VARCHAR(50),
								@Email VARCHAR(50),
								@Telephone VARCHAR(15),
								@Fax VARCHAR(50),
								@Logo VARBINARY(MAX),
								@Branch INT
							  )
AS 
BEGIN
	INSERT INTO COMPANY 
	VALUES(@Id,@Name,@Location,@Email,@Telephone,@Fax,@Logo,@Branch)
END
GO
CREATE PROCEDURE UpdateCompany(
								@Id UNIQUEIDENTIFIEr,
								@Name VARCHAR(50),
								@Location VARCHAR(50),
								@Email VARCHAR(50),
								@Telephone VARCHAR(15),
								@Fax VARCHAR(50),
								@Logo VARBINARY(MAX),
								@Branch INT
							  )
AS 
BEGIN
	UPDATE COMPANY 
	SET
	Name = @Name,
	Location = @Location,
	Email = @Email,
	Telephone = @Telephone,
	Fax = @Fax,
	Logo = @Logo,
	Branch = @Branch
	WHERE ID = @Id
END
GO
CREATE PROCEDURE ListAllCompany
AS 
BEGIN
	SELECT * FROM COMPANY
END
GO
CREATE PROCEDURE SearchCompany(
								@Id UNIQUEIDENTIFIEr,
								@Name VARCHAR(50),
								@Location VARCHAR(50),
								@Email VARCHAR(50),
								@Telephone VARCHAR(15),
								@Fax VARCHAR(50),
								@Logo VARBINARY(MAX),
								@Branch INT
)
AS
BEGIN
		SELECT 
		Name 
		FROM COMPANY
		WHERE 
		Name
		LIKE '[A-Z]%'
