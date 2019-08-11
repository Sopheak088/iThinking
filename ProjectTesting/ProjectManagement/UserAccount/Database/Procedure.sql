if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ListAllUser]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].ListAllUser
GO
CREATE PROCEDURE ListAllUser
AS 
BEGIN
	SELECT * FROM [USER] WHERE Active = 1
END

GO