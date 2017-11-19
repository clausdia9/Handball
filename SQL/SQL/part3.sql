------------------------------------------------CREATE-----------------------------------------------------------------
CREATE PROCEDURE [dbo].[CreateArticles]
(
@ArticleID uniqueidentifier,
@Title nvarchar(100),
@Author nvarchar(100),
@Description nvarchar(max)
)
	AS
	 BEGIN
		INSERT INTO Articles([ArticleID],[Title],[Author]) VALUES(@ArticleID, @Title, @Author)
	END
GO
DECLARE @ArticleID uniqueidentifier  ='5D2C2C4B-A03F-447B-B459-6E3481869111B'
DECLARE @Title nvarchar(100)  ='NEW WIN FOR THE TEAM'
DECLARE @Author nvarchar(100)  ='Ioana Ion'
DECLARE @Description nvarchar(max) =NULL
EXECUTE [dbo].[CreateArticles] @ArticleID , @Title , @Author, @Description
GO

CREATE PROCEDURE [dbo].[CreateEvents]
(
@EventID uniqueidentifier,
@EventName nvarchar(50),
@Location nvarchar(50),
@Date date
)
	AS
	 BEGIN
		INSERT INTO Events([EventID],[EventName],[Location],[Date]) VALUES (@EventID,@EventName,@Location,@Date)
	 END
GO

DECLARE @EventID uniqueidentifier ='5D2C2C4C-A03F-447B-B459-6E3481869111B'
DECLARE @EventName nvarchar(50) ='CSM BUCURESTI-Blue Ravens '
DECLARE @Location nvarchar(50) ='Polyvalent Hall'
DECLARE @Date date ='2018-01-02'
EXECUTE [dbo].[CreateEvents] @EventID,@EventName,@Location,@Date
GO

CREATE PROCEDURE [dbo].[CreatePhotos]
(
@PhotoID uniqueidentifier,
@PhotoVarbinary varbinary(max)
)
	AS
	 BEGIN
		INSERT INTO Photos([PhotoID],[PhotoVarbinary]) VALUES (@PhotoID,@PhotoVarbinary)
	END
GO

DECLARE @PhotoID uniqueidentifier ='5D2C2C4D-A03F-447B-B459-6E3481869111B'
DECLARE @PhotoVarbinary varbinary(max) =NULL
EXECUTE [dbo].[CreatePhotos] @PhotoID,@PhotoVarbinary
GO


CREATE PROCEDURE [dbo].[CreateArticlesPhotos]
(
@ArticleID uniqueidentifier,
@PhotoID uniqueidentifier
)
	AS
	 BEGIN
		INSERT INTO ArticlesPhotos ([ArticleID],[PhotoID]) VALUES (@ArticleID,@PhotoID) 
	 END
GO

DECLARE @ArticleID uniqueidentifier ='5D2C2C4B-A03F-447B-B459-6E3481869111B'
DECLARE @PhotoID uniqueidentifier ='5D2C2C4D-A03F-447B-B459-6E3481869111B'
EXECUTE [dbo].[CreateArticlesPhotos] @ArticleID,@PhotoID
GO

CREATE PROCEDURE [dbo].[CreatePlayers]
(
@PlayerID uniqueidentifier,
@PlayerName nvarchar(200),
@Goals int,
@BirthDay date
)
	AS
	 BEGIN
		INSERT INTO Players ([PlayerID],[PlayerName],[Goals],[Birthday]) VALUES (@PlayerID,@PlayerName,@Goals,@BirthDay)
	 END
GO

DECLARE @PlayerID uniqueidentifier ='5D2C2C4E-A03F-447B-B459-6E3481869111B'
DECLARE @PlayerName nvarchar(200) ='Cristina Laslo'
DECLARE @Goals int =15
DECLARE @BirthDay date ='1996-04-24'
EXECUTE [dbo].[CreatePlayers] @PlayerID,@PlayerName,@Goals,@BirthDay
GO


CREATE PROCEDURE [dbo].[CreatePlayersPhotos]
(
@PlayerID uniqueidentifier,
@PhotoID uniqueidentifier
)	
	AS
	 BEGIN
		INSERT INTO PlayersPhotos([PlayerID],[PhotoID]) VALUES (@PlayerID,@PhotoID)
	 END
GO

DECLARE @PlayerID uniqueidentifier ='5D2C2C4E-A03F-447B-B459-6E3481869111B'
DECLARE @PhotoID uniqueidentifier ='5D2C2C4D-A03F-447B-B459-6E3481869111B'
EXECUTE[dbo].[CreatePlayersPhotos] @PlayerID,@PhotoID
GO

CREATE PROCEDURE [dbo].[CreatePositions]
(
@PositionID uniqueidentifier,
@PositionName nvarchar(50)
)
	AS
	 BEGIN
		INSERT INTO Positions ([PositionID],[PositionName]) VALUES (@PositionID,@PositionName)
	 END
GO

DECLARE @PositionID uniqueidentifier ='5D2C2C4F-A03F-447B-B459-6E3481869111B'
DECLARE @PositionName nvarchar(50) ='SOMETHING NEW'
EXECUTE [dbo].[CreatePositions] @PositionID,@PositionName
GO


CREATE PROCEDURE [dbo].[CreatePlayersPositions]
(
@PlayerID uniqueidentifier,
@PositionID uniqueidentifier
)
	AS
	 BEGIN
		INSERT INTO PlayersPositions([PlayerID],[PositionID]) VALUES (@PlayerID,@PositionID) 
	 END
GO

DECLARE @PlayerID uniqueidentifier ='5D2C2C4E-A03F-447B-B459-6E3481869111B'
DECLARE @PositionID uniqueidentifier ='5D2C2C4F-A03F-447B-B459-6E3481869111B'
EXECUTE [dbo].[CreatePlayersPositions] @PlayerID,@PositionID
GO

CREATE PROCEDURE [dbo].[CreateUsers]
(
@UserID uniqueidentifier,
@UserName nvarchar(50),
@Password nvarchar(50),
@UserType nvarchar(50)
)
	AS
	 BEGIN
		INSERT INTO Users([UserID],[UserName],[Password],[UserType]) VALUES (@UserID,@UserName,@Password,@UserType)
	 END
GO

DECLARE @UserID uniqueidentifier ='5D2C2C4F-A03F-447B-B459-6E3481869111C'
DECLARE @UserName nvarchar(50) ='lateuj'
DECLARE @Password nvarchar(50) ='11123'
DECLARE @UserType nvarchar(50) ='STANDARD'
EXECUTE [dbo].[CreateUsers] @UserID,@UserName,@Password,@UserType
GO

---------------------------------------------------UPDATE----------------------------------------------------------------------------

CREATE PROCEDURE [dbo].[UpdateArticles]
(
@ArticleID uniqueidentifier,
@Title nvarchar(100),
@Author nvarchar(100),
@Description nvarchar(max)
)
	AS
	 BEGIN
		UPDATE Articles
			SET Title=@Title,
				Author=@Author
			WHERE ArticleID=@ArticleID
	 END
GO

DECLARE @ArticleID uniqueidentifier  ='5D2C2C4B-A03F-447B-B459-6E3481869111B'
DECLARE @Title nvarchar(50) = 'FIRST WIN HOME'
DECLARE @Author nvarchar(50) = 'Ioana Ion' 
DECLARE @Description nvarchar(max)= NULL
EXECUTE [dbo].[UpdateArticles] @ArticleID,@Title,@Author,@Description
GO

CREATE PROCEDURE [dbo].[UpdateEvents]
(
@EventID uniqueidentifier,
@EventName nvarchar(50),
@Location nvarchar(50),
@Date date
)
	AS
	 BEGIN
		UPDATE Events
			SET EventName=@EventName,
				Location=@Location,
				Date=@Date
			WHERE EventID=@EventID
	 END
GO


DECLARE @EventID uniqueidentifier ='5D2C2C4C-A03F-447B-B459-6E3481869111B'
DECLARE @EventName nvarchar(50) = 'Blue Ravens - HC ZALAU'
DECLARE @Location nvarchar(50) ='Sala Sporturilor Horia DEMIAN'
DECLARE @Date date ='2018-03-21'
EXECUTE [dbo].[UpdateEvents] @EventID, @EventName, @Location, @Date
GO

CREATE PROCEDURE [dbo].[UpdatePhotos]
(
@PhotoID uniqueidentifier,
@PhotoVarbinary varbinary(max)
)
	AS
	 BEGIN
		UPDATE Photos
			SET PhotoVarbinary=@PhotoVarbinary
			WHERE PhotoID=@PhotoID
	 END
GO

DECLARE @PhotoID uniqueidentifier ='5D2C2C4D-A03F-447B-B459-6E3481869111B'
DECLARE @PhotoVarbinary varbinary(max) = NULL
EXECUTE [dbo].[UpdatePhotos] @PhotoID,@PhotoVarbinary
GO

CREATE PROCEDURE [dbo].[UpdatePlayers]
(
@PlayerID uniqueidentifier,
@PlayerName nvarchar(200),
@Goals int,
@BirthDay date
)
	AS
	 BEGIN
		UPDATE Players
			SET PlayerName=@PlayerName,
			Goals=@Goals,
			BirthDay=@BirthDay
			WHERE PlayerID=@PlayerID
	END
GO

DECLARE @PlayerID uniqueidentifier ='5D2C2C4E-A03F-447B-B459-6E3481869111B'
DECLARE @PlayerName nvarchar(200) = 'Heidi LOKE'
DECLARE @Goals int = 19
DECLARE @BirthDay date ='1980-05-09'
EXECUTE [dbo].[UpdatePlayers] @PlayerID,@PlayerName,@Goals,@BirthDay
GO

CREATE PROCEDURE [dbo].[UpdatePositions]
(
@PositionID uniqueidentifier,
@PositionName nvarchar(50)
)
	AS
	 BEGIN
		UPDATE Positions
			SET PositionName=@PositionName
			WHERE PositionID=@PositionID
	 END
GO

DECLARE @PositionID uniqueidentifier ='5D2C2C4F-A03F-447B-B459-6E3481869111B'
DECLARE @PositionName nvarchar(50) ='FAR LEFT'
EXECUTE [dbo].[UpdatePositions] @PositionID, @PositionName
GO

CREATE PROCEDURE [dbo].[UpdateUsers]
(
@UserID uniqueidentifier,
@UserName nvarchar(50),
@Password nvarchar(50),
@UserType nvarchar(50)
)
	AS
	 BEGIN
		UPDATE Users
			SET UserName=@UserName,
			Password=@Password,
			UserType=@UserType
			WHERE UserID=@UserID
		END
GO

DECLARE @UserID uniqueidentifier ='5D2C2C4F-A03F-447B-B459-6E3481869111C'
DECLARE @UserName nvarchar(50) ='kyaira21'
DECLARE @Password nvarchar(50) ='23era21'
DECLARE @UserType nvarchar(50) ='STANDARD'
EXECUTE [dbo].[UpdateUsers] @UserID,@UserName,@Password,@UserType
GO

----------------------------------------------------ReadByID-----------------------------------------------------------------------------

CREATE PROCEDURE [dbo].[UsersReadById]
(
@UserID uniqueidentifier
)
	AS
	 BEGIN
		SELECT u.UserID,
			   u.Username,
			   u.UserType
		FROM Users u
		WHERE UserID=@UserID
	 END
GO

DECLARE @UserID uniqueidentifier ='5D2C2C4F-A03F-447B-B459-6E3481869111C'
EXECUTE [dbo].[UsersReadById] @UserID
GO

CREATE PROCEDURE [dbo].[EventsReadById]
(
@EventID uniqueidentifier
)
	AS
	 BEGIN
		SELECT e.EventID,
			   e.EventName,
			   e.Location
		FROM Events e
		WHERE EventID=@EventID
	 END
GO

DECLARE @EventID uniqueidentifier ='5D2C2C4C-A03F-447B-B459-6E3481869111B'
EXECUTE [dbo].[EventsReadById] @EventID
GO

CREATE PROCEDURE [dbo].[ArticlesReadById]
(
@ArticleID uniqueidentifier
)
	AS
	 BEGIN
		SELECT a.ArticleID,
			   a.Title,
			   COUNT(p.PhotoID) as NoOfPhotos
		FROM Articles a
			LEFT JOIN ArticlesPhotos ap ON a.ArticleID=ap.ArticleID
			LEFT JOIN Photos p ON p.PhotoID=ap.PhotoID
		WHERE a.ArticleID=@ArticleID
		GROUP BY a.ArticleID,a.Title
	 END
GO

DECLARE @ArticleID uniqueidentifier  ='5D2C2C4B-A03F-447B-B459-6E3481869111B'
EXECUTE [dbo].[ArticlesReadById] @ArticleID
GO

CREATE PROCEDURE [dbo].[PhotosReadById]
(
@PhotoID uniqueidentifier
)
	AS
	 BEGIN
		SELECT p.PhotoID,
			   p.PhotoVarbinary
		FROM Photos p
			INNER JOIN ArticlesPhotos ap ON p.PhotoID=ap.PhotoID
		WHERE p.PhotoID=@PhotoID
	 END
GO

DECLARE @PhotoID uniqueidentifier ='5D2C2C4D-A03F-447B-B459-6E3481869111B'
EXECUTE [dbo].[PhotosReadById] @PhotoID
GO

CREATE PROCEDURE [dbo].[PlayersReadById]
(
@PlayerID uniqueidentifier
)
	AS
	 BEGIN
		SELECT p.PlayerID,
			   p.PlayerName,
			   p.Goals,
			   COUNT(ph.PhotoID) AS NoOfPhotos
		FROM Players p
			LEFT JOIN PlayersPhotos pp ON p.PlayerID=pp.PlayerID
			LEFT JOIN Photos ph ON ph.PhotoID=pp.PhotoID
		WHERE p.PlayerID=@PlayerID
		GROUP BY p.PlayerID,p.PlayerName,p.Goals
	 END
GO

DECLARE @PlayerID uniqueidentifier ='5D2C2C4E-A03F-447B-B459-6E3481869111B'
EXECUTE [dbo].[PlayersReadById] @PlayerID
GO

CREATE PROCEDURE [dbo].[PositionsReadById]
(
@PositionID uniqueidentifier
)
	AS
	 BEGIN
		SELECT p.PositionID,
			   p.PositionName,
			   COUNT(pl.PlayerID) AS NoOfPlayers
		FROM Positions p
			 LEFT JOIN PlayersPositions pp ON p.PositionID=pp.PositionID
			 LEFT JOIN Players pl ON pl.PlayerID=pp.PlayerID
		WHERE p.PositionID=@PositionID
		GROUP BY p.PositionID, p.PositionName 
	 END
GO

DECLARE @PositionID uniqueidentifier ='5D2C2C4F-A03F-447B-B459-6E3481869111B'
EXECUTE [dbo].[PositionsReadById] @PositionID
GO


CREATE VIEW NoOfPlayers
AS
SELECT p.PositionID,
			   p.PositionName,
			   COUNT(pl.PlayerID) AS NoOfPlayers
		FROM Positions p
			 LEFT JOIN PlayersPositions pp ON p.PositionID=pp.PositionID
			 LEFT JOIN Players pl ON pl.PlayerID=pp.PlayerID
		GROUP BY p.PositionID, p.PositionName 
GO

SELECT * FROM NoOfPlayers
GO

------------------------------------------------------------DELETE-----------------------------------------------------------------------------


CREATE PROCEDURE [dbo].[DeleteArticlesPhotos]
(
@ArticleID uniqueidentifier,
@PhotoID uniqueidentifier
)
	AS
	 BEGIN
		DELETE FROM ArticlesPhotos 
		WHERE ArticleID=@ArticleID AND PhotoID=@PhotoID
	 END
GO

DECLARE @ArticleID uniqueidentifier ='5D2C2C4B-A03F-447B-B459-6E3481869111B'
DECLARE @PhotoID uniqueidentifier ='5D2C2C4D-A03F-447B-B459-6E3481869111B'
EXECUTE [dbo].[DeleteArticlesPhotos] @ArticleID,@PhotoID
GO

CREATE PROCEDURE [dbo].[DeletePlayersPhotos]
(
@PlayerID uniqueidentifier,
@PhotoID uniqueidentifier
)
	AS
	 BEGIN
		DELETE FROM PlayersPhotos
		WHERE PlayerID=@PlayerID AND PhotoID=@PhotoID
	 END
GO

DECLARE @PlayerID uniqueidentifier ='5D2C2C4E-A03F-447B-B459-6E3481869111B'
DECLARE @PhotoID uniqueidentifier ='5D2C2C4D-A03F-447B-B459-6E3481869111B'
EXECUTE[dbo].[DeletePlayersPhotos] @PlayerID,@PhotoID
GO

CREATE PROCEDURE [dbo].[DeletePlayersPositions]
(
@PlayerID uniqueidentifier,
@PositionID uniqueidentifier
)
	AS
	 BEGIN
		DELETE FROM PlayersPositions 
		WHERE PlayerID=@PlayerID AND PositionID=@PositionID
	 END
GO

DECLARE @PlayerID uniqueidentifier ='5D2C2C4E-A03F-447B-B459-6E3481869111B'
DECLARE @PositionID uniqueidentifier ='5D2C2C4F-A03F-447B-B459-6E3481869111B'
EXECUTE [dbo].[DeletePlayersPositions] @PlayerID,@PositionID
GO

CREATE PROCEDURE [dbo].[DeleteArticles]
(
@ArticleID uniqueidentifier
)
	AS
	 BEGIN
		DELETE FROM Articles
		WHERE ArticleID=@ArticleID
	 END
GO

DECLARE @ArticleID uniqueidentifier  ='5D2C2C4B-A03F-447B-B459-6E3481869111B'
EXECUTE [dbo].[DeleteArticles] @ArticleID
GO

CREATE PROCEDURE [dbo].[DeleteEvents]
(
@EventID uniqueidentifier
)
	AS
	 BEGIN
		DELETE FROM Events
		WHERE EventID=@EventID
	 END
GO


DECLARE @EventID uniqueidentifier ='5D2C2C4C-A03F-447B-B459-6E3481869111B'
EXECUTE [dbo].[DeleteEvents] @EventID
GO

CREATE PROCEDURE [dbo].[DeletePhotos]
(
@PhotoID uniqueidentifier
)
	AS
	 BEGIN
		DELETE FROM Photos
		WHERE PhotoID=@PhotoID
	 END
GO

DECLARE @PhotoID uniqueidentifier ='5D2C2C4D-A03F-447B-B459-6E3481869111B'
EXECUTE [dbo].[DeletePhotos] @PhotoID
GO

CREATE PROCEDURE [dbo].[DeletePlayers]
(
@PlayerID uniqueidentifier
)
	AS
	 BEGIN
		DELETE FROM Players
		WHERE PlayerID=@PlayerID
	 END
GO

DECLARE @PlayerID uniqueidentifier ='5D2C2C4E-A03F-447B-B459-6E3481869111B'
EXECUTE [dbo].[DeletePlayers] @PlayerID
GO

CREATE PROCEDURE [dbo].[DeletePositions]
(
@PositionID uniqueidentifier
)
	AS
	 BEGIN
		DELETE FROM Positions
		WHERE PositionID=@PositionID
	 END
GO

DECLARE @PositionID uniqueidentifier ='5D2C2C4F-A03F-447B-B459-6E3481869111B'
EXECUTE [dbo].[DeletePositions] @PositionID
GO

CREATE PROCEDURE [dbo].[DeleteUsers]
(
@UserID uniqueidentifier
)
	AS
	 BEGIN
		DELETE FROM Users
		WHERE UserID=@UserID
	 END
GO

DECLARE @UserID uniqueidentifier ='5D2C2C4F-A03F-447B-B459-6E3481869111C'
EXECUTE [dbo].[DeleteUsers] @UserID
GO


-------------NON-CLUSTERED-INDEXES---------------
USE [Team]
GO
CREATE NONCLUSTERED INDEX [NonClusteredIndex-PhotoID] ON [dbo].[Photos]
(
	[PhotoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
GO




USE [Team]
GO
CREATE NONCLUSTERED INDEX [NonClusteredIndex-PositionID] ON [dbo].[Positions]
(
	[PositionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
GO
