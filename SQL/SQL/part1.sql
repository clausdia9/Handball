
CREATE TABLE [Users](
	[UserID] uniqueidentifier NOT NULL,
	[UserName] nvarchar (50) NOT NULL,
	[Password] nvarchar (50) NOT NULL,
	[UserType] nvarchar (50) NOT NULL,  --ADMINISTRATOR or STANDARD
CONSTRAINT [PK_UserID] PRIMARY KEY ([UserID]));

CREATE TABLE [Articles](
	[ArticleID] uniqueidentifier NOT NULL,
	[Title] nvarchar(100) NOT NULL,
	[Author] nvarchar (100),
	[Description] nvarchar(max)
CONSTRAINT [PK_News] PRIMARY KEY ([ArticleID]));

CREATE TABLE [Photos](
	[PhotoID] uniqueidentifier NOT NULL,
	[PhotoVarbinary] varbinary(max),
CONSTRAINT [PK_Photos] PRIMARY KEY ([PhotoID]));

CREATE TABLE [ArticlesPhotos](
	[ArticleID] uniqueidentifier NOT NULL,
	[PhotoID] uniqueidentifier NOT NULL,
CONSTRAINT [PK_ArticlesPhotos] PRIMARY KEY ([ArticleID], [PhotoID]),
CONSTRAINT [FK_ArticlesPhotos_Articles] FOREIGN KEY ([ArticleID])
    REFERENCES [Articles]([ArticleID]),
CONSTRAINT [FK_ArticlesPhotos_Photos] FOREIGN KEY ([PhotoID])
    REFERENCES [Photos]([PhotoID]));

CREATE TABLE [Players](
	[PlayerID] uniqueidentifier NOT NULL,
	[PlayerName] nvarchar (200) NOT NULL,
	[Goals] int ,
	[BirthDay] date,
CONSTRAINT [PK_PlayerID] PRIMARY KEY ([PlayerID]),	
);

CREATE TABLE [PlayersPhotos](
	[PlayerID] uniqueidentifier NOT NULL,
	[PhotoID] uniqueidentifier NOT NULL,
	CONSTRAINT [PK_PlayersPhotos] PRIMARY KEY ([PlayerID], [PhotoID]),
CONSTRAINT [FK_PlayersPhotos_Players] FOREIGN KEY ([PlayerID])
    REFERENCES [Players]([PlayerID]),
CONSTRAINT [FK_PlayersPhotos_Photos] FOREIGN KEY ([PhotoID])
    REFERENCES [Photos]([PhotoID])
);


CREATE TABLE [Positions](
	[PositionID] uniqueidentifier NOT NULL,
	[PositionName] nvarchar(50),
CONSTRAINT [PK_PositionID] PRIMARY KEY ([PositionID]),
);

CREATE TABLE [PlayersPositions](
	[PlayerID] uniqueidentifier NOT NULL,
	[PositionID] uniqueidentifier NOT NULL,
CONSTRAINT [PK_PlayersPositions] PRIMARY KEY ([PlayerID],[PositionID]),
CONSTRAINT [FK_PlayersPositions_Players] FOREIGN KEY ([PlayerID])
	REFERENCES [Players]([PlayerID]),
CONSTRAINT [FK_PlayersPositions_Positions] FOREIGN KEY ([PositionID])
	REFERENCES [Positions]([PositionID])
);



CREATE TABLE [Events](
	[EventID] uniqueidentifier NOT NULL,
	[EventName] nvarchar (50) NOT NULL,
	[Location] nvarchar (50) NOT NULL,
	[Date] date,
CONSTRAINT [PK_EventID] PRIMARY KEY ([EventID]));
