--------------------------------------------------TABLES-----------------
CREATE TABLE [Users](
	[UserID] uniqueidentifier NOT NULL,
	[UserName] nvarchar (50) NOT NULL,
	[Password] nvarchar (50) NOT NULL,
	[UserType] nvarchar (50) NOT NULL,  --ADMINISTRATOR or STANDARD
CONSTRAINT [PK_UserID] PRIMARY KEY ([UserID]));
GO

CREATE TABLE [Articles](
	[ArticleID] uniqueidentifier NOT NULL,
	[Title] nvarchar(100) NOT NULL,
	[Author] nvarchar (100),
	[Description] nvarchar(max)
CONSTRAINT [PK_News] PRIMARY KEY ([ArticleID]));
GO

CREATE TABLE [Photos](
	[PhotoID] uniqueidentifier NOT NULL,
	[PhotoVarbinary] varbinary(max),
CONSTRAINT [PK_Photos] PRIMARY KEY ([PhotoID]));
GO

CREATE TABLE [ArticlesPhotos](
	[ArticleID] uniqueidentifier NOT NULL,
	[PhotoID] uniqueidentifier NOT NULL,
CONSTRAINT [PK_ArticlesPhotos] PRIMARY KEY ([ArticleID], [PhotoID]),
CONSTRAINT [FK_ArticlesPhotos_Articles] FOREIGN KEY ([ArticleID])
    REFERENCES [Articles]([ArticleID]),
CONSTRAINT [FK_ArticlesPhotos_Photos] FOREIGN KEY ([PhotoID])
    REFERENCES [Photos]([PhotoID]));
GO

CREATE TABLE [Players](
	[PlayerID] uniqueidentifier NOT NULL,
	[PlayerName] nvarchar (200) NOT NULL,
	[Goals] int ,
	[BirthDay] date,
CONSTRAINT [PK_PlayerID] PRIMARY KEY ([PlayerID]),	
);
GO

CREATE TABLE [PlayersPhotos](
	[PlayerID] uniqueidentifier NOT NULL,
	[PhotoID] uniqueidentifier NOT NULL,
	CONSTRAINT [PK_PlayersPhotos] PRIMARY KEY ([PlayerID], [PhotoID]),
CONSTRAINT [FK_PlayersPhotos_Players] FOREIGN KEY ([PlayerID])
    REFERENCES [Players]([PlayerID]),
CONSTRAINT [FK_PlayersPhotos_Photos] FOREIGN KEY ([PhotoID])
    REFERENCES [Photos]([PhotoID])
);
GO

CREATE TABLE [Positions](
	[PositionID] uniqueidentifier NOT NULL,
	[PositionName] nvarchar(50),
CONSTRAINT [PK_PositionID] PRIMARY KEY ([PositionID]),
);
GO

CREATE TABLE [PlayersPositions](
	[PlayerID] uniqueidentifier NOT NULL,
	[PositionID] uniqueidentifier NOT NULL,
CONSTRAINT [PK_PlayersPositions] PRIMARY KEY ([PlayerID],[PositionID]),
CONSTRAINT [FK_PlayersPositions_Players] FOREIGN KEY ([PlayerID])
	REFERENCES [Players]([PlayerID]),
CONSTRAINT [FK_PlayersPositions_Positions] FOREIGN KEY ([PositionID])
	REFERENCES [Positions]([PositionID])
);
GO


CREATE TABLE [NextEvents] (
	[EventID] uniqueidentifier NOT NULL,
	[EventName] nvarchar (50) NOT NULL,
	[Location] nvarchar (50) NOT NULL,
	[Date] date,
CONSTRAINT [PK_EventID] PRIMARY KEY ([EventID]));
GO

------------------------------------------------CREATE-----------------------------------------------------------------
CREATE PROCEDURE [dbo].[Articles_Create]
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


CREATE PROCEDURE [dbo].[NextEvents_Create]
(
@EventID uniqueidentifier,
@EventName nvarchar(50),
@Location nvarchar(50),
@Date date
)
	AS
	 BEGIN
		INSERT INTO NextEvents([EventID],[EventName],[Location],[Date]) VALUES (@EventID,@EventName,@Location,@Date)
	 END
GO



CREATE PROCEDURE [dbo].[Photos_Create]
(
@PhotoID uniqueidentifier,
@PhotoVarbinary varbinary(max)
)
	AS
	 BEGIN
		INSERT INTO Photos([PhotoID],[PhotoVarbinary]) VALUES (@PhotoID,@PhotoVarbinary)
	END
GO



CREATE PROCEDURE [dbo].[ArticlesPhotos_Create]
(
@ArticleID uniqueidentifier,
@PhotoID uniqueidentifier
)
	AS
	 BEGIN
		INSERT INTO ArticlesPhotos ([ArticleID],[PhotoID]) VALUES (@ArticleID,@PhotoID) 
	 END
GO



CREATE PROCEDURE [dbo].[Players_Create]
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




CREATE PROCEDURE [dbo].[PlayersPhotos_Create]
(
@PlayerID uniqueidentifier,
@PhotoID uniqueidentifier
)	
	AS
	 BEGIN
		INSERT INTO PlayersPhotos([PlayerID],[PhotoID]) VALUES (@PlayerID,@PhotoID)
	 END
GO



CREATE PROCEDURE [dbo].[Positions_Create]
(
@PositionID uniqueidentifier,
@PositionName nvarchar(50)
)
	AS
	 BEGIN
		INSERT INTO Positions ([PositionID],[PositionName]) VALUES (@PositionID,@PositionName)
	 END
GO




CREATE PROCEDURE [dbo].[PlayersPositions_Create]
(
@PlayerID uniqueidentifier,
@PositionID uniqueidentifier
)
	AS
	 BEGIN
		INSERT INTO PlayersPositions([PlayerID],[PositionID]) VALUES (@PlayerID,@PositionID) 
	 END
GO



CREATE PROCEDURE [dbo].[Users_Create]
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



---------------------------------------------------UPDATE----------------------------------------------------------------------------

CREATE PROCEDURE [dbo].[Articles_Update]
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



CREATE PROCEDURE [dbo].[NextEvents_Update]
(
@EventID uniqueidentifier,
@EventName nvarchar(50),
@Location nvarchar(50),
@Date date
)
	AS
	 BEGIN
		UPDATE NextEvents
			SET EventName=@EventName,
				Location=@Location,
				Date=@Date
			WHERE EventID=@EventID
	 END
GO




CREATE PROCEDURE [dbo].[Photos_Update]
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



CREATE PROCEDURE [dbo].[Players_Update]
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


CREATE PROCEDURE [dbo].[Positions_Update]
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



CREATE PROCEDURE [dbo].[Users_Update]
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



----------------------------------------------------ReadById-----------------------------------------------------------------------------

CREATE PROCEDURE [dbo].[Users_ReadById]
(
@UserID uniqueidentifier
)
	AS
	 BEGIN
		SELECT u.UserID,
			   u.Username,
			   u.Password,
			   u.UserType
		FROM Users u
		WHERE UserID=@UserID
	 END
GO



CREATE PROCEDURE [dbo].[NextEvents_ReadById]
(
@EventID uniqueidentifier
)
	AS
	 BEGIN
		SELECT e.EventID,
			   e.EventName,
			   e.Location,
			   e.Date
		FROM NextEvents e
		WHERE EventID=@EventID
	 END
GO



CREATE PROCEDURE [dbo].[Articles_ReadById]
(
@ArticleID uniqueidentifier
)
	AS
	 BEGIN
		SELECT a.ArticleID,
			   a.Title,
			   a.Author,
			   a.Description
		FROM Articles a
		WHERE a.ArticleID=@ArticleID
	 END
GO



CREATE PROCEDURE [dbo].[Photos_ReadById]
(
@PhotoID uniqueidentifier
)
	AS
	 BEGIN
		SELECT p.PhotoID,
			   p.PhotoVarbinary
		FROM Photos p
		WHERE p.PhotoID=@PhotoID
	 END
GO



CREATE PROCEDURE [dbo].[Players_ReadById]
(
@PlayerID uniqueidentifier
)
	AS
	 BEGIN
		SELECT p.PlayerID,
			   p.PlayerName,
			   p.Goals,
			   p.BirthDay
		FROM Players p
		WHERE p.PlayerID=@PlayerID
	 END
GO



CREATE PROCEDURE [dbo].[Positions_ReadById]
(
@PositionID uniqueidentifier
)
	AS
	 BEGIN
		SELECT p.PositionID,
			   p.PositionName
		FROM Positions p
		WHERE p.PositionID=@PositionID
	 END
GO


------------------------------------------------------------DELETE-----------------------------------------------------------------------------


CREATE PROCEDURE [dbo].[ArticlesPhotos_Delete]
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



CREATE PROCEDURE [dbo].[PlayersPhotos_Delete]
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



CREATE PROCEDURE [dbo].[PlayersPositions_Delete]
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


CREATE PROCEDURE [dbo].[Articles_Delete]
(
@ArticleID uniqueidentifier
)
	AS
	 BEGIN
		DELETE FROM Articles
		WHERE ArticleID=@ArticleID
	 END
GO



CREATE PROCEDURE [dbo].[NextEvents_Delete]
(
@EventID uniqueidentifier
)
	AS
	 BEGIN
		DELETE FROM NextEvents
		WHERE EventID=@EventID
	 END
GO



CREATE PROCEDURE [dbo].[Photos_Delete]
(
@PhotoID uniqueidentifier
)
	AS
	 BEGIN
		DELETE FROM Photos
		WHERE PhotoID=@PhotoID
	 END
GO


CREATE PROCEDURE [dbo].[Players_Delete]
(
@PlayerID uniqueidentifier
)
	AS
	 BEGIN
		DELETE FROM Players
		WHERE PlayerID=@PlayerID
	 END
GO



CREATE PROCEDURE [dbo].[Positions_Delete]
(
@PositionID uniqueidentifier
)
	AS
	 BEGIN
		DELETE FROM Positions
		WHERE PositionID=@PositionID
	 END
GO



CREATE PROCEDURE [dbo].[Users_Delete]
(
@UserID uniqueidentifier
)
	AS
	 BEGIN
		DELETE FROM Users
		WHERE UserID=@UserID
	 END
GO

--------------------------------------------------------------ReadAll----------------------------
CREATE PROCEDURE [dbo].[Articles_ReadAll]
AS
BEGIN
	SELECT ArticleID,
	       Title,
	       Author,
	       Description
	FROM Articles
END
GO

CREATE PROCEDURE [dbo].[Photos_ReadAll]
AS
BEGIN
	SELECT PhotoID,
	       PhotoVarbinary
	FROM Photos
END
GO

CREATE PROCEDURE [dbo].[Players_ReadAll]
AS
BEGIN
	SELECT PlayerID,
		   PlayerName,
		   Goals,
		   BirthDay
	FROM Players
END
GO

CREATE PROCEDURE [dbo].[Positions_ReadAll]
AS
BEGIN
	SELECT PositionID,
		   PositionName
	FROM Positions
END
GO

CREATE PROCEDURE [dbo].[NextEvents_ReadAll]
AS
BEGIN
	SELECT EventID,
		   EventName,
		   Location,
		   Date
	FROM NextEvents
END
GO

CREATE PROCEDURE [dbo].[Users_ReadAll]
AS
BEGIN
	SELECT UserID,
		   UserName,
		   Password,
		   UserType
	FROM Users
END
GO


