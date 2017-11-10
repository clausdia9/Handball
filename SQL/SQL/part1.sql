
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
CONSTRAINT [PK_News] PRIMARY KEY ([ArticleID]));

CREATE TABLE [Photos](
	[PhotoID] uniqueidentifier NOT NULL,
	[PhotoVarbinary] varbinary(max) NOT NULL,
CONSTRAINT [PK_Photos] PRIMARY KEY ([PhotoID]));

CREATE TABLE [ArticlesPhotos](
	[ArticleID] uniqueidentifier NOT NULL,
	[PhotoID] uniqueidentifier NOT NULL,
CONSTRAINT [PK_ArticlesPhotos] PRIMARY KEY ([ArticleID], [PhotoID]),
CONSTRAINT [FK_ArticlesPhotos_Articles] FOREIGN KEY ([ArticleID])
    REFERENCES [Articles]([ArticleID]),
CONSTRAINT [FK_ArticlesPhotos_Photo] FOREIGN KEY ([PhotoID])
    REFERENCES [Photos]([PhotoID]));

CREATE TABLE [Players](
	[PlayerID] uniqueidentifier NOT NULL,
	[PlayerName] nvarchar (200) NOT NULL,
	[Position] nvarchar (50) NOT NULL,
	[Goals] int ,
	[BirthDay] date,
	[PlayerPhoto] varbinary(max),
CONSTRAINT [PK_PlayerID] PRIMARY KEY ([PlayerID]),
);

CREATE TABLE [Events](
	[EventID] uniqueidentifier NOT NULL,
	[EventName] nvarchar (50) NOT NULL,
	[Location] nvarchar (50) NOT NULL,
	[Date] date,
CONSTRAINT [PK_EventID] PRIMARY KEY ([EventID]));