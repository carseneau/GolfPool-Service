/****** Object:  ForeignKey [FK_winnings_golfers]    Script Date: 01/17/2012 23:21:26 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_winnings_golfers]') AND parent_object_id = OBJECT_ID(N'[dbo].[winnings]'))
ALTER TABLE [dbo].[winnings] DROP CONSTRAINT [FK_winnings_golfers]
GO
/****** Object:  ForeignKey [FK_winnings_tournaments]    Script Date: 01/17/2012 23:21:26 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_winnings_tournaments]') AND parent_object_id = OBJECT_ID(N'[dbo].[winnings]'))
ALTER TABLE [dbo].[winnings] DROP CONSTRAINT [FK_winnings_tournaments]
GO
/****** Object:  ForeignKey [FK_picks_entrants]    Script Date: 01/17/2012 23:21:29 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_picks_entrants]') AND parent_object_id = OBJECT_ID(N'[dbo].[picks]'))
ALTER TABLE [dbo].[picks] DROP CONSTRAINT [FK_picks_entrants]
GO
/****** Object:  ForeignKey [FK_picks_golfers]    Script Date: 01/17/2012 23:21:29 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_picks_golfers]') AND parent_object_id = OBJECT_ID(N'[dbo].[picks]'))
ALTER TABLE [dbo].[picks] DROP CONSTRAINT [FK_picks_golfers]
GO
/****** Object:  Table [dbo].[picks]    Script Date: 01/17/2012 23:21:29 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_picks_entrants]') AND parent_object_id = OBJECT_ID(N'[dbo].[picks]'))
ALTER TABLE [dbo].[picks] DROP CONSTRAINT [FK_picks_entrants]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_picks_golfers]') AND parent_object_id = OBJECT_ID(N'[dbo].[picks]'))
ALTER TABLE [dbo].[picks] DROP CONSTRAINT [FK_picks_golfers]
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_picks_inserttime]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[picks] DROP CONSTRAINT [DF_picks_inserttime]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[picks]') AND type in (N'U'))
DROP TABLE [dbo].[picks]
GO
/****** Object:  Table [dbo].[winnings]    Script Date: 01/17/2012 23:21:26 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_winnings_golfers]') AND parent_object_id = OBJECT_ID(N'[dbo].[winnings]'))
ALTER TABLE [dbo].[winnings] DROP CONSTRAINT [FK_winnings_golfers]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_winnings_tournaments]') AND parent_object_id = OBJECT_ID(N'[dbo].[winnings]'))
ALTER TABLE [dbo].[winnings] DROP CONSTRAINT [FK_winnings_tournaments]
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_winnings_inserttime]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[winnings] DROP CONSTRAINT [DF_winnings_inserttime]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[winnings]') AND type in (N'U'))
DROP TABLE [dbo].[winnings]
GO
/****** Object:  Table [dbo].[tournaments]    Script Date: 01/17/2012 23:21:23 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_tournaments_inserttime]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tournaments] DROP CONSTRAINT [DF_tournaments_inserttime]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tournaments]') AND type in (N'U'))
DROP TABLE [dbo].[tournaments]
GO
/****** Object:  Table [dbo].[entrants]    Script Date: 01/17/2012 23:21:21 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_entrants_inserttime]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[entrants] DROP CONSTRAINT [DF_entrants_inserttime]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[entrants]') AND type in (N'U'))
DROP TABLE [dbo].[entrants]
GO
/****** Object:  Table [dbo].[golfers]    Script Date: 01/17/2012 23:21:18 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_golfers_inserttime]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[golfers] DROP CONSTRAINT [DF_golfers_inserttime]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[golfers]') AND type in (N'U'))
DROP TABLE [dbo].[golfers]
GO
/****** Object:  Table [dbo].[golfers]    Script Date: 01/17/2012 23:21:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[golfers]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[golfers](
	[golferid] [int] IDENTITY(1,1) NOT NULL,
	[golfername] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[lastchange] [datetime] NOT NULL,
	[inserttime] [datetime] NOT NULL CONSTRAINT [DF_golfers_inserttime]  DEFAULT (getdate()),
 CONSTRAINT [PK_golfers] PRIMARY KEY CLUSTERED 
(
	[golferid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[entrants]    Script Date: 01/17/2012 23:21:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[entrants]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[entrants](
	[entrantid] [int] IDENTITY(1,1) NOT NULL,
	[entrantname] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[entrantemail] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[lastchange] [datetime] NOT NULL,
	[inserttime] [datetime] NOT NULL CONSTRAINT [DF_entrants_inserttime]  DEFAULT (getdate()),
 CONSTRAINT [PK_entrants] PRIMARY KEY CLUSTERED 
(
	[entrantid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[tournaments]    Script Date: 01/17/2012 23:21:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tournaments]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tournaments](
	[tournamentid] [int] IDENTITY(1,1) NOT NULL,
	[tournamentname] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[lastchange] [datetime] NOT NULL,
	[inserttime] [datetime] NOT NULL CONSTRAINT [DF_tournaments_inserttime]  DEFAULT (getdate()),
 CONSTRAINT [PK_tournaments] PRIMARY KEY CLUSTERED 
(
	[tournamentid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[winnings]    Script Date: 01/17/2012 23:21:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[winnings]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[winnings](
	[winningsid] [int] IDENTITY(1,1) NOT NULL,
	[tournamentid] [int] NOT NULL,
	[golferid] [int] NOT NULL,
	[winnings] [decimal](18, 0) NOT NULL,
	[lastchange] [datetime] NOT NULL,
	[inserttime] [datetime] NOT NULL CONSTRAINT [DF_winnings_inserttime]  DEFAULT (getdate()),
 CONSTRAINT [PK_winnings] PRIMARY KEY CLUSTERED 
(
	[winningsid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[picks]    Script Date: 01/17/2012 23:21:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[picks]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[picks](
	[pickid] [int] IDENTITY(1,1) NOT NULL,
	[entrantid] [int] NOT NULL,
	[golferid] [int] NOT NULL,
	[lastchange] [datetime] NOT NULL,
	[inserttime] [datetime] NOT NULL CONSTRAINT [DF_picks_inserttime]  DEFAULT (getdate()),
 CONSTRAINT [PK_picks] PRIMARY KEY CLUSTERED 
(
	[pickid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  ForeignKey [FK_winnings_golfers]    Script Date: 01/17/2012 23:21:26 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_winnings_golfers]') AND parent_object_id = OBJECT_ID(N'[dbo].[winnings]'))
ALTER TABLE [dbo].[winnings]  WITH CHECK ADD  CONSTRAINT [FK_winnings_golfers] FOREIGN KEY([winningsid])
REFERENCES [dbo].[golfers] ([golferid])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_winnings_golfers]') AND parent_object_id = OBJECT_ID(N'[dbo].[winnings]'))
ALTER TABLE [dbo].[winnings] CHECK CONSTRAINT [FK_winnings_golfers]
GO
/****** Object:  ForeignKey [FK_winnings_tournaments]    Script Date: 01/17/2012 23:21:26 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_winnings_tournaments]') AND parent_object_id = OBJECT_ID(N'[dbo].[winnings]'))
ALTER TABLE [dbo].[winnings]  WITH CHECK ADD  CONSTRAINT [FK_winnings_tournaments] FOREIGN KEY([tournamentid])
REFERENCES [dbo].[tournaments] ([tournamentid])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_winnings_tournaments]') AND parent_object_id = OBJECT_ID(N'[dbo].[winnings]'))
ALTER TABLE [dbo].[winnings] CHECK CONSTRAINT [FK_winnings_tournaments]
GO
/****** Object:  ForeignKey [FK_picks_entrants]    Script Date: 01/17/2012 23:21:29 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_picks_entrants]') AND parent_object_id = OBJECT_ID(N'[dbo].[picks]'))
ALTER TABLE [dbo].[picks]  WITH CHECK ADD  CONSTRAINT [FK_picks_entrants] FOREIGN KEY([entrantid])
REFERENCES [dbo].[entrants] ([entrantid])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_picks_entrants]') AND parent_object_id = OBJECT_ID(N'[dbo].[picks]'))
ALTER TABLE [dbo].[picks] CHECK CONSTRAINT [FK_picks_entrants]
GO
/****** Object:  ForeignKey [FK_picks_golfers]    Script Date: 01/17/2012 23:21:29 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_picks_golfers]') AND parent_object_id = OBJECT_ID(N'[dbo].[picks]'))
ALTER TABLE [dbo].[picks]  WITH CHECK ADD  CONSTRAINT [FK_picks_golfers] FOREIGN KEY([golferid])
REFERENCES [dbo].[golfers] ([golferid])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_picks_golfers]') AND parent_object_id = OBJECT_ID(N'[dbo].[picks]'))
ALTER TABLE [dbo].[picks] CHECK CONSTRAINT [FK_picks_golfers]
GO
