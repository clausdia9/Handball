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
INSERT INTO Articles([ArticleID], [Title], [Author], [Description]) VALUES (@ArticleID, 'Debutul echipei acasa', 'Alexandru Marin',NULL);


DECLARE @PhotoID uniqueidentifier
SET @PhotoID=NEWID();



INSERT INTO Photos([PhotoID],[PhotoVarbinary]) --VALUES (@PhotoID	,NULL)
SELECT @PhotoID, BulkColumn 
FROM OPENROWSET( BULK 'D:\UMT\image1.jpg', SINGLE_BLOB) AS IMAGE

INSERT INTO ArticlesPhotos([ArticleID],[PhotoID]) VALUES (@ArticleID,@PhotoID);

SET @ArticleID=NEWID();
INSERT INTO Articles([ArticleID], [Title], [Author], [Description]) VALUES (@ArticleID, 'Victorie clara in fata Bucurestiului', 'Ioana Achim',NULL);

INSERT INTO ArticlesPhotos([ArticleID],[PhotoID]) VALUES (@ArticleID,@PhotoID);


SET @ArticleID=NEWID();
INSERT INTO Articles([ArticleID], [Title], [Author],[Description]) VALUES (@ArticleID, 'Lupta acerba pentru campionat in deplasare', NULL,NULL);

INSERT INTO ArticlesPhotos([ArticleID],[PhotoID]) VALUES (@ArticleID,@PhotoID);

SET @ArticleID=NEWID();
INSERT INTO Articles([ArticleID], [Title], [Author],[Description]) VALUES (@ArticleID, 'Infrangere in ultima secunda', 'Alexandru Marin',NULL);

SET @ArticleID=NEWID();
INSERT INTO Articles([ArticleID], [Title], [Author],[Description]) VALUES (@ArticleID, 'Victorie la limita', 'Ioana Achim',NULL);

SET @ArticleID=NEWID();
INSERT INTO Articles([ArticleID], [Title], [Author],[Description]) VALUES (@ArticleID, 'Noul sponsor al echipei este QQQ', 'Ioana Achim',NULL);

SET @ArticleID=NEWID();
INSERT INTO Articles([ArticleID], [Title], [Author],[Description]) VALUES (@ArticleID, 'Egalitate ce aduce un punct important', NULL,NULL);

SET @ArticleID=NEWID();
INSERT INTO Articles([ArticleID], [Title], [Author],[Description]) VALUES (@ArticleID, 'Noile echipamente au sosit', 'Alexandru Marin',NULL);

SET @PhotoID=NEWID();
INSERT INTO Photos([PhotoID],[PhotoVarbinary]) --VALUES (@PhotoID,NULL)
SELECT @PhotoID, BulkColumn 
FROM OPENROWSET( BULK 'D:\UMT\image2.jpg', SINGLE_BLOB) AS IMAGE

INSERT INTO ArticlesPhotos([ArticleID],[PhotoID]) VALUES (@ArticleID,@PhotoID);

SET @ArticleID=NEWID();
INSERT INTO Articles([ArticleID], [Title], [Author],[Description]) VALUES (@ArticleID, 'Echipa castiga clar in deplasare la Podgorica', 'Ioana Achim',NULL);

SET @PhotoID=NEWID();
INSERT INTO Photos([PhotoID],[PhotoVarbinary]) --VALUES (@PhotoID,NULL)
SELECT @PhotoID, BulkColumn 
FROM OPENROWSET( BULK 'D:\UMT\image3.jpg', SINGLE_BLOB) AS IMAGE


INSERT INTO ArticlesPhotos([ArticleID],[PhotoID]) VALUES (@ArticleID,@PhotoID);



SET @PhotoID=NEWID();
INSERT INTO Photos([PhotoID],[PhotoVarbinary]) --VALUES (@PhotoID,NULL)
SELECT @PhotoID, BulkColumn 
FROM OPENROWSET( BULK 'D:\UMT\image4.jpg', SINGLE_BLOB) AS IMAGE

SET @PhotoID=NEWID();
INSERT INTO Photos([PhotoID],[PhotoVarbinary]) --VALUES (@PhotoID,NULL)
SELECT @PhotoID, BulkColumn 
FROM OPENROWSET( BULK 'D:\UMT\image5.jpg', SINGLE_BLOB) AS IMAGE

INSERT INTO ArticlesPhotos([ArticleID],[PhotoID]) VALUES (@ArticleID,@PhotoID);


SET @PhotoID=NEWID();
INSERT INTO Photos([PhotoID],[PhotoVarbinary]) --VALUES (@PhotoID,NULL)
SELECT @PhotoID, BulkColumn 
FROM OPENROWSET( BULK 'D:\UMT\image6.jpg', SINGLE_BLOB) AS IMAGE


INSERT INTO ArticlesPhotos([ArticleID],[PhotoID]) VALUES (@ArticleID,@PhotoID);


SET @PhotoID=NEWID();
INSERT INTO Photos([PhotoID],[PhotoVarbinary]) --VALUES (@PhotoID,NULL)
SELECT @PhotoID, BulkColumn 
FROM OPENROWSET( BULK 'D:\UMT\image7.jpg', SINGLE_BLOB) AS IMAGE

SET @PhotoID=NEWID();
INSERT INTO Photos([PhotoID],[PhotoVarbinary]) --VALUES (@PhotoID,NULL)
SELECT @PhotoID, BulkColumn 
FROM OPENROWSET( BULK 'D:\UMT\image8.jpg', SINGLE_BLOB) AS IMAGE

SET @PhotoID=NEWID();
INSERT INTO Photos([PhotoID],[PhotoVarbinary]) --VALUES (@PhotoID,NULL)
SELECT @PhotoID, BulkColumn 
FROM OPENROWSET( Bulk 'D:\UMT\image9.jpg', SINGLE_BLOB) AS IMAGE

SET @PhotoID=NEWID();
INSERT INTO Photos([PhotoID],[PhotoVarbinary]) --VALUES (@PhotoID,NULL)
SELECT @PhotoID, BulkColumn 
FROM OPENROWSET( BULK 'D:\UMT\image10.jpg', SINGLE_BLOB) AS IMAGE


DECLARE @PlayerID uniqueidentifier


DECLARE @PositionID uniqueidentifier

SET @PhotoID=NEWID();
INSERT INTO Photos([PhotoID],[PhotoVarbinary]) --VALUES (@PhotoID,NULL)
SELECT @PhotoID, BulkColumn 
FROM OPENROWSET( BULK 'D:\UMT\neagu.jpg', SINGLE_BLOB) AS IMAGE


SET @PlayerID=NEWID();
INSERT INTO Players ([PlayerID], [PlayerName], [Goals], [BirthDay]) VALUES ( @PlayerID, 'Cristina Neagu', 25, '1988-08-26')



SET @PositionID=NEWID();
INSERT INTO Positions([PositionID],[PositionName]) VALUES (@PositionID,'Left Back');

INSERT INTO PlayersPhotos ([PlayerID],[PhotoID])  VALUES (@PlayerID,@PhotoID);

INSERT INTO PlayersPositions([PlayerID],[PositionID]) VALUES (@PlayerID,@PositionID);


SET @PhotoID=NEWID();
INSERT INTO Photos([PhotoID],[PhotoVarbinary]) --VALUES (@PhotoID,NULL)
SELECT @PhotoID, BulkColumn 
FROM OPENROWSET( BULK 'D:\UMT\mork.jpg', SINGLE_BLOB) AS IMAGE


SET @PlayerID=NEWID();
INSERT INTO Players ([PlayerID], [PlayerName], [Goals], [BirthDay]) VALUES ( @PlayerID, 'Nora Morke', 20, '1989-03-02')

SET @PositionID=NEWID();
INSERT INTO Positions([PositionID],[PositionName]) VALUES (@PositionID,'Right Back');

INSERT INTO PlayersPhotos ([PlayerID],[PhotoID])  VALUES (@PlayerID,@PhotoID);

INSERT INTO PlayersPositions([PlayerID],[PositionID]) VALUES (@PlayerID,@PositionID);


SET @PhotoID=NEWID();
INSERT INTO Photos([PhotoID],[PhotoVarbinary]) --VALUES (@PhotoID,NULL)
SELECT @PhotoID, BulkColumn 
FROM OPENROWSET( BULK 'D:\UMT\loke.jpg', SINGLE_BLOB) AS IMAGE


SET @PlayerID=NEWID();
INSERT INTO Players ([PlayerID], [PlayerName], [Goals], [BirthDay]) VALUES(@PlayerID, 'Heidi Loke', 25, '1983-10-03')


SET @PositionID=NEWID();
INSERT INTO Positions([PositionID],[PositionName]) VALUES (@PositionID,'Pivot');

INSERT INTO PlayersPhotos ([PlayerID],[PhotoID])  VALUES (@PlayerID,@PhotoID);

INSERT INTO PlayersPositions([PlayerID],[PositionID]) VALUES (@PlayerID,@PositionID);


SET @PhotoID=NEWID();
INSERT INTO Photos([PhotoID],[PhotoVarbinary]) --VALUES (@PhotoID,NULL)
SELECT @PhotoID, BulkColumn 
FROM OPENROWSET( BULK 'D:\UMT\ardean.jpg', SINGLE_BLOB) AS IMAGE


SET @PlayerID=NEWID();
INSERT INTO Players ([PlayerID], [PlayerName], [Goals], [BirthDay]) VALUES (@PlayerID, 'Valentina Ardean', 18, '1980-10-21')


SET @PositionID=NEWID();
INSERT INTO Positions([PositionID],[PositionName]) VALUES (@PositionID,'Far Left');

INSERT INTO PlayersPhotos ([PlayerID],[PhotoID])  VALUES (@PlayerID,@PhotoID);

INSERT INTO PlayersPositions([PlayerID],[PositionID]) VALUES (@PlayerID,@PositionID);



SET @PhotoID=NEWID();
INSERT INTO Photos([PhotoID],[PhotoVarbinary]) --VALUES (@PhotoID,NULL)
SELECT @PhotoID, BulkColumn 
FROM OPENROWSET( BULK 'D:\UMT\varzaru.jpg', SINGLE_BLOB) AS IMAGE

SET @PlayerID=NEWID();
INSERT INTO Players ([PlayerID], [PlayerName], [Goals], [BirthDay]) VALUES ( @PlayerID, 'Cristina Varzaru', 16, '1980-06-26')

INSERT INTO PlayersPhotos ([PlayerID],[PhotoID])  VALUES (@PlayerID,@PhotoID);


SET @PhotoID=NEWID();
INSERT INTO Photos([PhotoID],[PhotoVarbinary]) --VALUES (@PhotoID,NULL)
SELECT @PhotoID, BulkColumn 
FROM OPENROWSET( BULK 'D:\UMT\gullden.jpg', SINGLE_BLOB) AS IMAGE


SET @PlayerID=NEWID();
INSERT INTO Players ([PlayerID], [PlayerName], [Goals], [BirthDay]) VALUES (@PlayerID, 'Isabelle Gullden', 25, '1988-11-09')


INSERT INTO PlayersPhotos ([PlayerID],[PhotoID])  VALUES (@PlayerID,@PhotoID);


SET @PhotoID=NEWID();
INSERT INTO Photos([PhotoID],[PhotoVarbinary]) --VALUES (@PhotoID,NULL)
SELECT @PhotoID, BulkColumn 
FROM OPENROWSET( BULK 'D:\UMT\dumanska.jpg', SINGLE_BLOB) AS IMAGE

SET @PlayerID=NEWID();
INSERT INTO Players ([PlayerID], [PlayerName], [Goals], [BirthDay]) VALUES( @PlayerID, 'Iulia Dumanska', 1, '1996-05-05')



SET @PositionID=NEWID();
INSERT INTO Positions([PositionID],[PositionName]) VALUES (@PositionID,'Goalkeeper');

INSERT INTO PlayersPhotos ([PlayerID],[PhotoID])  VALUES (@PlayerID,@PhotoID);

INSERT INTO PlayersPositions([PlayerID],[PositionID]) VALUES (@PlayerID,@PositionID);

SET @PositionID=NEWID();
INSERT INTO Positions([PositionID],[PositionName]) VALUES (@PositionID,'Far Right');

SET @PositionID=NEWID();
INSERT INTO Positions([PositionID],[PositionName]) VALUES (@PositionID,'Centre');




INSERT INTO NextEvents ([EventID], [EventName], [Location], [Date]) VALUES (NEWID(),'Blue Ravens - CSM Oradea', 'Sala Sporturilor Horia Demian','2017-11-11');
INSERT INTO NextEvents ([EventID], [EventName], [Location], [Date]) VALUES (NEWID(),'Blue Ravens - CSM Bucuresti', 'Sala Sporturilor Horia Demian','2017-11-19');
INSERT INTO NextEvents ([EventID], [EventName], [Location], [Date]) VALUES (NEWID(),'Viborg FDK- Blue Ravens', 'Blue Arena','2017-11-20');
INSERT INTO NextEvents ([EventID], [EventName], [Location], [Date]) VALUES (NEWID(),'SCM Craiova- Blue Ravens', 'Sala Polivalenta Craiova','2017-11-25');
INSERT INTO NextEvents ([EventID], [EventName], [Location], [Date]) VALUES (NEWID(),'Blue Ravens - Buducnost Podgorica', 'Sala Sporturilor Horia Demian','2017-11-28');
INSERT INTO NextEvents ([EventID], [EventName], [Location], [Date]) VALUES (NEWID(),'Corona Brasov - Blue Ravens', 'Sala Sporturilor Brasov','2018-01-20');
INSERT INTO NextEvents ([EventID], [EventName], [Location], [Date]) VALUES (NEWID(),'Blue Ravens - Gyor Audi ETO', 'Sala Sporturilor Horia Demian','2018-02-15');
INSERT INTO NextEvents ([EventID], [EventName], [Location], [Date]) VALUES (NEWID(),'CSM Slatina - Blue Ravens', 'Sala Sporturilor Slatina','2018-03-13');
INSERT INTO NextEvents ([EventID], [EventName], [Location], [Date]) VALUES (NEWID(),'Blue Ravens - Krim Lublijana', 'Sala Sporturilor Horia Demian','2018-03-20');
INSERT INTO NextEvents ([EventID], [EventName], [Location], [Date]) VALUES (NEWID(),'Blue Ravens - HC Zalau', 'Sala Sporturilor Horia Demian','2018-03-29');
INSERT INTO NextEvents ([EventID], [EventName], [Location], [Date]) VALUES (NEWID(),'Blue Ravens - Ferencvaros', 'Sala Sporturilor Horia Demian','2018-04-01');
INSERT INTO NextEvents ([EventID], [EventName], [Location], [Date]) VALUES (NEWID(),'Vardar Skopje- Blue Ravens', 'Dobreva Arena','2018-04-13');




	