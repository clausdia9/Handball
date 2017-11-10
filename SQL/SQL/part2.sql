INSERT INTO Users ([UserID], [UserName], [Password],[UserType]) VALUES (NEWID(),'trinam','alabala','ADMINISTRATOR');
INSERT INTO Users([UserID], [UserName], [Password], [UserType]) VALUES (NEWID(), 'juza','ghiamin','STANDARD');
INSERT INTO Users([UserID], [UserName], [Password], [UserType]) VALUES (NEWID(), 'adamR','salutare','STANDARD');
INSERT INTO Users([UserID], [UserName], [Password], [UserType]) VALUES (NEWID(), 'Wexq','1234','STANDARD');
INSERT INTO Users([UserID], [UserName], [Password], [UserType]) VALUES (NEWID(), 'akila','SALUT78','ADMINISTRATOR');
INSERT INTO Users([UserID], [UserName], [Password], [UserType]) VALUES (NEWID(), 'WERT','wert2','STANDARD');
INSERT INTO Users([UserID], [UserName], [Password], [UserType]) VALUES (NEWID(), 'qww','errder','STANDARD');
INSERT INTO Users([UserID], [UserName], [Password], [UserType]) VALUES (NEWID(), 'olaf','elsa23','STANDARD');
INSERT INTO Users([UserID], [UserName], [Password], [UserType]) VALUES (NEWID(), 'abumeyang','0040','STANDARD');
INSERT INTO Users([UserID], [UserName], [Password], [UserType]) VALUES (NEWID(), '2stocks','joke4','STANDARD');
INSERT INTO Users([UserID], [UserName], [Password], [UserType]) VALUES (NEWID(), 'murray12','ambroseQA','STANDARD');
INSERT INTO Users([UserID], [UserName], [Password], [UserType]) VALUES (NEWID(), 'marciano','hibernian222','STANDARD');
INSERT INTO Users([UserID], [UserName], [Password], [UserType]) VALUES (NEWID(), 'dandi','rose87','STANDARD');
INSERT INTO Users([UserID], [UserName], [Password], [UserType]) VALUES (NEWID(), 'borrusia09','goetze','STANDARD');
INSERT INTO Users([UserID], [UserName], [Password], [UserType]) VALUES (NEWID(), 'caylor32Navas','county533','STANDARD');	
INSERT INTO Users([UserID], [UserName], [Password], [UserType]) VALUES (NEWID(), 'wedd','HEllOworld','STANDARD');
INSERT INTO Users([UserID], [UserName], [Password], [UserType]) VALUES (NEWID(), 'raulK','minutul90','STANDARD');
INSERT INTO Users([UserID], [UserName], [Password], [UserType]) VALUES (NEWID(), 'dejaVU','aberli','STANDARD');
INSERT INTO Users([UserID], [UserName], [Password], [UserType]) VALUES (NEWID(), 'Quza','0009','STANDARD');
INSERT INTO Users([UserID], [UserName], [Password], [UserType]) VALUES (NEWID(), '1martyn1','rangers','STANDARD');
INSERT INTO Users([UserID], [UserName], [Password], [UserType]) VALUES (NEWID(), 'chicago2','fire','STANDARD');
INSERT INTO Users([UserID], [UserName], [Password], [UserType]) VALUES (NEWID(), 'chicago3','med54','STANDARD');
INSERT INTO Users([UserID], [UserName], [Password], [UserType]) VALUES (NEWID(), 'chicago4','PD210','STANDARD');
INSERT INTO Users([UserID], [UserName], [Password], [UserType]) VALUES (NEWID(), 'morelos','troty','STANDARD');
INSERT INTO Users([UserID], [UserName], [Password], [UserType]) VALUES (NEWID(), 'kevin2','1111','STANDARD');
INSERT INTO Users([UserID], [UserName], [Password], [UserType]) VALUES (NEWID(), 'joao','buicean','STANDARD');
INSERT INTO Users([UserID], [UserName], [Password], [UserType]) VALUES (NEWID(), 'ikercas','porto65','STANDARD');
INSERT INTO Users([UserID], [UserName], [Password], [UserType]) VALUES (NEWID(), 'candeias','olala2','STANDARD');
INSERT INTO Users([UserID], [UserName], [Password], [UserType]) VALUES (NEWID(), 'ezra','myun','STANDARD');

DECLARE @ArticleID uniqueidentifier
SET @ArticleID=NEWID();
INSERT INTO Articles([ArticleID], [Title], [Author]) VALUES (@ArticleID, 'Debutul echipei acasa', 'Alexandru Marin');


DECLARE @PhotoID uniqueidentifier
SET @PhotoID=NEWID();

INSERT INTO Photos([PhotoID],[PhotoVarbinary])
SELECT @PhotoID, BulkColumn 
FROM OPENROWSET( BULK 'D:\UMT\image1.jpg', SINGLE_BLOB) AS IMAGE

INSERT INTO ArticlesPhotos([ArticleID],[PhotoID]) VALUES (@ArticleID,@PhotoID);

SET @ArticleID=NEWID();
INSERT INTO Articles([ArticleID], [Title], [Author]) VALUES (@ArticleID, 'Victorie clara in fata Bucurestiului', 'Ioana Achim');

INSERT INTO ArticlesPhotos([ArticleID],[PhotoID]) VALUES (@ArticleID,@PhotoID);


SET @ArticleID=NEWID();
INSERT INTO Articles([ArticleID], [Title], [Author]) VALUES (@ArticleID, 'Lupta acerba pentru campionat in deplasare', NULL);

INSERT INTO ArticlesPhotos([ArticleID],[PhotoID]) VALUES (@ArticleID,@PhotoID);

SET @ArticleID=NEWID();
INSERT INTO Articles([ArticleID], [Title], [Author]) VALUES (@ArticleID, 'Infrangere in ultima secunda', 'Alexandru Marin');

SET @ArticleID=NEWID();
INSERT INTO Articles([ArticleID], [Title], [Author]) VALUES (@ArticleID, 'Victorie la limita', 'Ioana Achim');

SET @ArticleID=NEWID();
INSERT INTO Articles([ArticleID], [Title], [Author]) VALUES (@ArticleID, 'Noul sponsor al echipei este QQQ', 'Ioana Achim');

SET @ArticleID=NEWID();
INSERT INTO Articles([ArticleID], [Title], [Author]) VALUES (@ArticleID, 'Egalitate ce aduce un punct important', NULL);

SET @ArticleID=NEWID();
INSERT INTO Articles([ArticleID], [Title], [Author]) VALUES (@ArticleID, 'Noile echipamente au sosit', 'Alexandru Marin');

SET @PhotoID=NEWID();
INSERT INTO Photos([PhotoID],[PhotoVarbinary])
SELECT @PhotoID, BulkColumn 
FROM OPENROWSET( BULK 'D:\UMT\image2.jpg', SINGLE_BLOB) AS IMAGE

INSERT INTO ArticlesPhotos([ArticleID],[PhotoID]) VALUES (@ArticleID,@PhotoID);

SET @ArticleID=NEWID();
INSERT INTO Articles([ArticleID], [Title], [Author]) VALUES (@ArticleID, 'Echipa castiga clar in deplasare la Podgorica', 'Ioana Achim');

SET @PhotoID=NEWID();
INSERT INTO Photos([PhotoID],[PhotoVarbinary])
SELECT @PhotoID, BulkColumn 
FROM OPENROWSET( BULK 'D:\UMT\image3.jpg', SINGLE_BLOB) AS IMAGE


INSERT INTO ArticlesPhotos([ArticleID],[PhotoID]) VALUES (@ArticleID,@PhotoID);



SET @PhotoID=NEWID();
INSERT INTO Photos([PhotoID],[PhotoVarbinary])
SELECT @PhotoID, BulkColumn 
FROM OPENROWSET( BULK 'D:\UMT\image4.jpg', SINGLE_BLOB) AS IMAGE

SET @PhotoID=NEWID();
INSERT INTO Photos([PhotoID],[PhotoVarbinary])
SELECT @PhotoID, BulkColumn 
FROM OPENROWSET( BULK 'D:\UMT\image5.jpg', SINGLE_BLOB) AS IMAGE

INSERT INTO ArticlesPhotos([ArticleID],[PhotoID]) VALUES (@ArticleID,@PhotoID);


SET @PhotoID=NEWID();
INSERT INTO Photos([PhotoID],[PhotoVarbinary])
SELECT @PhotoID, BulkColumn 
FROM OPENROWSET( BULK 'D:\UMT\image6.jpg', SINGLE_BLOB) AS IMAGE


INSERT INTO ArticlesPhotos([ArticleID],[PhotoID]) VALUES (@ArticleID,@PhotoID);


SET @PhotoID=NEWID();
INSERT INTO Photos([PhotoID],[PhotoVarbinary])
SELECT @PhotoID, BulkColumn 
FROM OPENROWSET( BULK 'D:\UMT\image7.jpg', SINGLE_BLOB) AS IMAGE

SET @PhotoID=NEWID();
INSERT INTO Photos([PhotoID],[PhotoVarbinary])
SELECT @PhotoID, BulkColumn 
FROM OPENROWSET( BULK 'D:\UMT\image8.jpg', SINGLE_BLOB) AS IMAGE

SET @PhotoID=NEWID();
INSERT INTO Photos([PhotoID],[PhotoVarbinary])
SELECT @PhotoID, BulkColumn 
FROM OPENROWSET( Bulk 'D:\UMT\image9.jpg', SINGLE_BLOB) AS IMAGE

SET @PhotoID=NEWID();
INSERT INTO Photos([PhotoID],[PhotoVarbinary])
SELECT @PhotoID, BulkColumn 
FROM OPENROWSET( BULK 'D:\UMT\image10.jpg', SINGLE_BLOB) AS IMAGE

INSERT INTO Events ([EventID], [EventName], [Location], [Date]) VALUES (NEWID(),'Blue Ravens - CSM Oradea', 'Sala Sporturilor Horia Demian','2017-11-11');
INSERT INTO Events ([EventID], [EventName], [Location], [Date]) VALUES (NEWID(),'Blue Ravens - CSM Bucuresti', 'Sala Sporturilor Horia Demian','2017-11-19');
INSERT INTO Events ([EventID], [EventName], [Location], [Date]) VALUES (NEWID(),'Viborg FDK- Blue Ravens', 'Blue Arena','2017-11-20');
INSERT INTO Events ([EventID], [EventName], [Location], [Date]) VALUES (NEWID(),'SCM Craiova- Blue Ravens', 'Sala Polivalenta Craiova','2017-11-25');
INSERT INTO Events ([EventID], [EventName], [Location], [Date]) VALUES (NEWID(),'Blue Ravens - Buducnost Podgorica', 'Sala Sporturilor Horia Demian','2017-11-28');
INSERT INTO Events ([EventID], [EventName], [Location], [Date]) VALUES (NEWID(),'Corona Brasov - Blue Ravens', 'Sala Sporturilor Brasov','2018-01-20');
INSERT INTO Events ([EventID], [EventName], [Location], [Date]) VALUES (NEWID(),'Blue Ravens - Gyor Audi ETO', 'Sala Sporturilor Horia Demian','2018-02-15');
INSERT INTO Events ([EventID], [EventName], [Location], [Date]) VALUES (NEWID(),'CSM Slatina - Blue Ravens', 'Sala Sporturilor Slatina','2018-03-13');
INSERT INTO Events ([EventID], [EventName], [Location], [Date]) VALUES (NEWID(),'Blue Ravens - Krim Lublijana', 'Sala Sporturilor Horia Demian','2018-03-20');
INSERT INTO Events ([EventID], [EventName], [Location], [Date]) VALUES (NEWID(),'Blue Ravens - HC Zalau', 'Sala Sporturilor Horia Demian','2018-03-29');
INSERT INTO Events ([EventID], [EventName], [Location], [Date]) VALUES (NEWID(),'Blue Ravens - Ferencvaros', 'Sala Sporturilor Horia Demian','2018-04-01');
INSERT INTO Events ([EventID], [EventName], [Location], [Date]) VALUES (NEWID(),'Vardar Skopje- Blue Ravens', 'Dobreva Arena','2018-04-13');

INSERT INTO Players ([PlayerID], [PlayerName], [Position], [Goals], [BirthDay])
SELECT NEWID(), 'Nora Morke', 'Right Back', 20, '1989-03-02'
FROM OPENROWSET (BULK 'D:\UMT\mork.jpg', SINGLE_BLOB) AS IMAGE

INSERT INTO Players ([PlayerID], [PlayerName], [Position], [Goals], [BirthDay])
SELECT NEWID(), 'Cristina Neagu', 'Left Back', 25, '1988-08-26'
FROM OPENROWSET (BULK 'D:\UMT\neagu.jpg', SINGLE_BLOB) AS IMAGE

INSERT INTO Players ([PlayerID], [PlayerName], [Position], [Goals], [BirthDay])
SELECT NEWID(), 'Valentina Ardean', 'Far Left', 18, '1980-10-21'
FROM OPENROWSET (BULK 'D:\UMT\ardean.jpg', SINGLE_BLOB) AS IMAGE

INSERT INTO Players ([PlayerID], [PlayerName], [Position], [Goals], [BirthDay])
SELECT NEWID(), 'Iulia Dumanska', 'Goalkeeper', 1, '1996-05-05'
FROM OPENROWSET (BULK 'D:\UMT\dumanska.jpg', SINGLE_BLOB) AS IMAGE

INSERT INTO Players ([PlayerID], [PlayerName], [Position], [Goals], [BirthDay])
SELECT NEWID(), 'Heidi Loke', 'Pivot', 25, '1983-10-03'
FROM OPENROWSET (BULK 'D:\UMT\loke.jpg', SINGLE_BLOB) AS IMAGE

INSERT INTO Players ([PlayerID], [PlayerName], [Position], [Goals], [BirthDay])
SELECT NEWID(), 'Cristina Varzaru', 'Far Right', 16, '1980-06-26'
FROM OPENROWSET (BULK 'D:\UMT\varzaru.jpg', SINGLE_BLOB) AS IMAGE

INSERT INTO Players ([PlayerID], [PlayerName], [Position], [Goals], [BirthDay])
SELECT NEWID(), 'Isabelle Gullden', 'Centre', 25, '1988-11-09'
FROM OPENROWSET (BULK 'D:\UMT\gullden.jpg', SINGLE_BLOB) AS IMAGE


--the number of articles with authors
SELECT COUNT(Author) AS NoOfSignedArticles
FROM Articles 

--players ordered desc by number of scored goals
SELECT PlayerName, Goals 
FROM Players
ORDER BY Goals DESC

--players which have the letter 'u' in their names
SELECT PlayerName, Position
FROM Players
WHERE PlayerName LIKE '%u%'

--players that scored more than 10 goals 
SELECT PlayerName, Goals
FROM Players
WHERE Goals>10

--select photos which are used in an article at least
SELECT DISTINCT p.PhotoID
FROM Photos p
	INNER JOIN ArticlesPhotos a ON p.PhotoID=a.PhotoID

--select articles that have at least one photo
SELECT DISTINCT a.ArticleID
FROM Articles a
	INNER JOIN ArticlesPhotos p ON p.ArticleID=a.ArticleID

--number of photos for each article with photos
SELECT a.ArticleID, COUNT(a.ArticleID) AS NoOfPhotos
FROM Articles a
	INNER JOIN ArticlesPhotos p ON a.ArticleID= p.ArticleID
GROUP BY a.ArticleID

--photos that have been used in more than 2 articles
SELECT p.PhotoID, COUNT(p.PhotoID) AS NoOfArticles
FROM Photos p
	INNER JOIN ArticlesPhotos a ON a.PhotoID= p.PhotoID
GROUP BY p.PhotoID
HAVING COUNT(p.PhotoID) >2

--select all the photos, even the ones without one or more articles
SELECT DISTINCT p.PhotoID
FROM Photos p
	LEFT JOIN ArticlesPhotos a ON p.PhotoID=a.PhotoID

--select only the photos who are used in at least one article
SELECT DISTINCT p.PhotoID
FROM Photos p
	RIGHT JOIN ArticlesPhotos a ON p.PhotoID=a.PhotoID

--select all articles (the ones with photos as well as the ones without photos)
SELECT DISTINCT a.ArticleID,a.Title
FROM Articles a
	FULL  OUTER JOIN ArticlesPhotos p ON a.ArticleID=p.ArticleID

--first 3 events from 2018
SELECT TOP 3 EventName
FROM Events E 
WHERE E.Date>'2018-01-01'
GO

--number of each type of users
CREATE VIEW NoOfUsersForEachType
AS
		SELECT  u.UserType,COUNT(u.UserType) AS NoType
		FROM Users u
		GROUP BY u.UserType
		HAVING COUNT(u.UserType) >1
GO



SELECT * from NoOfUsersForEachType
GO

--returns the number of future events announced
CREATE FUNCTION [GetEventsCount] ()
RETURNS int
AS
BEGIN
	RETURN(
		SELECT COUNT(EventName)
		FROM Events)
END
GO


SELECT [dbo].[GetEventsCount] () AS NoOfFutureEvents
GO

--this procedure selects only the articles that have a number of photos greater than a given value

CREATE PROCEDURE [GetArticlesCountInArticlesPhotos]
(
	@Count nvarchar(MAX)
)
AS
BEGIN
	SELECT a.Title, COUNT(a.ArticleID) AS ArticlesWithNPhotos
	FROM Articles a
		LEFT JOIN ArticlesPhotos p ON a.ArticleID= p.ArticleID
	GROUP BY a.Title
	HAVING COUNT(a.ArticleID) > @Count
END
GO
EXEC [GetArticlesCountInArticlesPhotos] @Count = 1
