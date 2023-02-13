

https://localhost:7127/api/scripture
https://localhost:7070/api/scripture/1
https://localhost:7070/api/scripture/3



select ID, replace(KJV, '^', ',') from Scripture


- [Part 2: A Beginners' Guide to Blazor WebAssembly - An Introduction & Getting Started](https://www.youtube.com/watch?v=oHsfe2Ndo1g&t=1s)

- [Part 4: A Beginners' Guide to Blazor WebAssembly - Adding SQLite & Dapper](https://www.youtube.com/watch?v=_9XOgs3LeNs)

https://stackoverflow.com/questions/67966259/how-to-use-sqlite-in-blazor-webassembly

[Route("[CountryId]")] instead of [Route("{CountryId}")]


C:\Users\JohnM\source\repos\MhbWasmSQLite\MhbWasmSQLite\Server\Data\

https://www.mssqltips.com/sqlservertip/3087/creating-a-sql-server-linked-server-to-sqlite-to-import-data/#:~:text=Creating%20a%20SQL%20Server%20Linked%20Server%20to%20SQLite,it%20into%20a%20SQL%20Server%20database%20table.%20


```
		public static List<ScriptureVM> scriptures = new()
		{
			new ScriptureVM {ID=1, BookID=1, Chapter=1, Verse=1, KJV="In the beginning God created the heaven and the earth.", DescH="God creates heaven, earth, plants, animals a man named Adom", DescD="God creates heaven and earth;"},
			new ScriptureVM {ID=2, BookID=1, Chapter=1, Verse=2, KJV="And the earth was without form, and void; and darkness was upon the face of the deep. And the Spirit of God moved upon the face of the waters.", DescH=null, DescD=null}
		};
		
var scripture = scriptures.FirstOrDefault(s => s.ID == ScriptureId);

SELECT * FROM Scripture ORDER BY Id LIMIT 5

```

vwScripturePortToSQLite

INSERT INTO Scripture (Id, BCV, BookID, Chapter, Verse, KJV, VerseOffset, DescH, DescD, DescHSlug) 
VALUES (1, 'Gen 1:1', 1, 1, 1, 'In the beginning God created the heaven and the earth.', NULL, 'God creates heaven, earth, plants, animals a man named Adom', 'God creates heaven and earth;', 'god-creates-heaven-earth-plants-animals-a-man-named-adom')



-- vwScripturePortToAzure

SELECT s.ID
/*
 ,  LEFT(s.BCV,3) 
 + LEFT(REPLICATE('0', 3-LEN(s.Chapter) ) + CONVERT(VARCHAR(10), s.Chapter), 3) AS PartitionKey -- BookAbrv + Chapter
, LEFT(REPLICATE('0', 3-LEN(s.Verse) ) + CONVERT(VARCHAR(10), s.Verse), 3) AS RowKey
*/
, s.BCV
, s.BookID, s.Chapter, s.Verse
, ki.KJV
, s.VerseOffset
, o.DescH, o.DescD, o.DescHSlug
--, s.BCV, s.Verse
FROM Scripture s
	INNER JOIN			vwKjvItalics ki ON ki.Id = s.Id
	LEFT OUTER JOIN OutlineFlat   o	ON s.ID  = ScriptureID_Beg












USE [OsisXmlToSql]
GO

/****** Object:  Table [dbo].[Scripture]    Script Date: 2/12/2023 1:31:52 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Scripture](
	[ID] [int] NOT NULL,
	[BCV] [nvarchar](11) NOT NULL,
	[BookID] [tinyint] NOT NULL,
	[Chapter] [tinyint] NOT NULL,
	[Verse] [tinyint] NOT NULL,
	[KJV] [nvarchar](550) NOT NULL,
	[KJVPlus] [nvarchar](850) NOT NULL,
	[Hebrew1] [nvarchar](max) NULL,
	[Hebrew2] [nvarchar](max) NULL,
	[Interlinear] [nvarchar](max) NULL,
	[InterlinearKjv] [nvarchar](max) NULL,
	[VerseOffset] [nvarchar](10) NULL,
 CONSTRAINT [PK_Scripture] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

