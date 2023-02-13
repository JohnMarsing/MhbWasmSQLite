SELECT 
--TOP 5
ID AS Id, BCV, BookID, Chapter, Verse
, REPLACE(KJV, ',', '^') AS KJV
, VerseOffset
, REPLACE(DescH, ',', '^') AS DescH
, REPLACE(DescD, ',', '^') AS DescD
, DescHSlug
FROM vwScripturePortToSQLite 
--WHERE KJV LIKE '%,%'
ORDER BY Id