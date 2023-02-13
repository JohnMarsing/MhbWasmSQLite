CREATE PROCEDURE dbo.stpScripturePortToSQLite
/*
DECLARE @RC int
EXECUTE @RC = dbo.stpScripturePortToSQLite

GRANT EXECUTE ON dbo.stpScripturePortToSQLite TO [USER NAME]
*/

AS

BEGIN TRY

DROP TABLE IF EXISTS dbo.ScripturePortToSQLite;

	CREATE TABLE dbo.ScripturePortToSQLite(
		ID						[int] NOT NULL, 
		BCV            nvarchar(11) NOT NULl ,
		BookID         int NOT NULl,
		Chapter        int NOT NULl, 
		Verse          int NOT NULl, 
		KJV						nvarchar(550),
		VerseOffset	  nvarchar(10),
		DescH nvarchar(255) NULL, 
		DescD nvarchar(255) NULL,
		DescHSlug nvarchar(255) NULL,
		)

	INSERT INTO dbo.ScripturePortToSQLite
	SELECT ID, BCV, BookID, Chapter, Verse, KJV, VerseOffset, DescH, DescD, DescHSlug
	FROM vwScripturePortToSQLite
	ORDER BY ID


END TRY

BEGIN CATCH
	EXECUTE dbo.stpPrintError 
 	IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION; 
	EXECUTE dbo.stpLogError 
END CATCH;