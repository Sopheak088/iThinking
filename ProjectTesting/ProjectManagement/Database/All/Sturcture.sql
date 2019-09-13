CREATE DATABASE CAFE
 CONTAINMENT = NONE
 ON  PRIMARY
( NAME = N'CAFE', FILENAME = N'D:\Database\CAFE.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON
( NAME = N'CAFE_log', FILENAME = N'D:\Database\CAFE_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)

GO
CREATE TABLE COMPANY
(
	ID UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),			
	NameInKhmer NVARCHAR(255) COLLATE Khmer_100_BIN NOT NULL,
	NameInEnglish NVARCHAR(255) COLLATE Khmer_100_BIN NOT NULL,
	Email NVARCHAR(255) COLLATE Khmer_100_BIN NOT NULL,
	Phone NVARCHAR(255) COLLATE Khmer_100_BIN NOT NULL,
	Location NVARCHAR(255) COLLATE Khmer_100_BIN NOT NULL,
	Active BIT NOT NULL DEFAULT 1,
	Logo VARBINARY(MAX) NOT NULL,

	CreatedBy NVARCHAR(255) COLLATE Khmer_100_BIN NOT NULL,
	CreatedDate DATETIME NULL,
	UpdatedBy NVARCHAR(255) COLLATE Khmer_100_BIN NULL,
	UpdatedDate DATETIME NULL
)