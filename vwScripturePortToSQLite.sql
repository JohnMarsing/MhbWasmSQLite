ALTER VIEW dbo.vwScripturePortToSQLite
/*
SELECT * FROM vwScripturePortToSQLite ORDER BY Id

SELECT ID, BCV, BookID, Chapter, Verse, KJV, VerseOffset, DescH, DescD, DescHSlug
FROM vwScripturePortToSQLite 
ORDER BY Id


SELECT * FROM vwScripturePortToSQLite 
WHERE BookID=1 AND Chapter=1
ORDER BY Id

SELECT ID, BCV, BookID, Chapter, Verse, KJV, VerseOffset
FROM vwScripturePortToSQLite 
ORDER BY ID

GRANT SELECT ON dbo.vwScripturePortToSQLite TO [USER NAME]


*/

AS

SELECT s.ID
, s.BCV
, s.BookID, s.Chapter, s.Verse
, ki.KJV
, s.VerseOffset
, o.DescH, o.DescD, o.DescHSlug
--, s.BCV, s.Verse
FROM Scripture s
	INNER JOIN			vwKjvItalics ki ON ki.Id = s.Id
	LEFT OUTER JOIN OutlineFlat   o	ON s.ID  = ScriptureID_Beg

