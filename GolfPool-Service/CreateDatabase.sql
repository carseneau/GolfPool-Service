/****** Object:  ForeignKey [FK_winnings_golfers]    Script Date: 01/18/2012 13:01:18 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_winnings_golfers]') AND parent_object_id = OBJECT_ID(N'[winnings]'))
ALTER TABLE [winnings] DROP CONSTRAINT [FK_winnings_golfers]
GO
/****** Object:  ForeignKey [FK_winnings_tournaments]    Script Date: 01/18/2012 13:01:18 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_winnings_tournaments]') AND parent_object_id = OBJECT_ID(N'[winnings]'))
ALTER TABLE [winnings] DROP CONSTRAINT [FK_winnings_tournaments]
GO
/****** Object:  ForeignKey [FK_picks_entrants]    Script Date: 01/18/2012 13:01:20 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_picks_entrants]') AND parent_object_id = OBJECT_ID(N'[picks]'))
ALTER TABLE [picks] DROP CONSTRAINT [FK_picks_entrants]
GO
/****** Object:  ForeignKey [FK_picks_golfers]    Script Date: 01/18/2012 13:01:20 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_picks_golfers]') AND parent_object_id = OBJECT_ID(N'[picks]'))
ALTER TABLE [picks] DROP CONSTRAINT [FK_picks_golfers]
GO
/****** Object:  StoredProcedure [dbo].[addgolfer]    Script Date: 01/18/2012 13:01:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[addgolfer]') AND type in (N'P', N'PC'))
DROP PROCEDURE [addgolfer]
GO
/****** Object:  Table [dbo].[picks]    Script Date: 01/18/2012 13:01:20 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_picks_entrants]') AND parent_object_id = OBJECT_ID(N'[picks]'))
ALTER TABLE [picks] DROP CONSTRAINT [FK_picks_entrants]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_picks_golfers]') AND parent_object_id = OBJECT_ID(N'[picks]'))
ALTER TABLE [picks] DROP CONSTRAINT [FK_picks_golfers]
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_picks_inserttime]') AND type = 'D')
BEGIN
ALTER TABLE [picks] DROP CONSTRAINT [DF_picks_inserttime]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[picks]') AND type in (N'U'))
DROP TABLE [picks]
GO
/****** Object:  Table [dbo].[winnings]    Script Date: 01/18/2012 13:01:18 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_winnings_golfers]') AND parent_object_id = OBJECT_ID(N'[winnings]'))
ALTER TABLE [winnings] DROP CONSTRAINT [FK_winnings_golfers]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_winnings_tournaments]') AND parent_object_id = OBJECT_ID(N'[winnings]'))
ALTER TABLE [winnings] DROP CONSTRAINT [FK_winnings_tournaments]
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_winnings_inserttime]') AND type = 'D')
BEGIN
ALTER TABLE [winnings] DROP CONSTRAINT [DF_winnings_inserttime]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[winnings]') AND type in (N'U'))
DROP TABLE [winnings]
GO
/****** Object:  Table [dbo].[tournaments]    Script Date: 01/18/2012 13:01:16 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_tournaments_inserttime]') AND type = 'D')
BEGIN
ALTER TABLE [tournaments] DROP CONSTRAINT [DF_tournaments_inserttime]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[tournaments]') AND type in (N'U'))
DROP TABLE [tournaments]
GO
/****** Object:  Table [dbo].[entrants]    Script Date: 01/18/2012 13:01:13 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_entrants_inserttime]') AND type = 'D')
BEGIN
ALTER TABLE [entrants] DROP CONSTRAINT [DF_entrants_inserttime]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[entrants]') AND type in (N'U'))
DROP TABLE [entrants]
GO
/****** Object:  Table [dbo].[golfers]    Script Date: 01/18/2012 13:01:11 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_golfers_inserttime]') AND type = 'D')
BEGIN
ALTER TABLE [golfers] DROP CONSTRAINT [DF_golfers_inserttime]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[golfers]') AND type in (N'U'))
DROP TABLE [golfers]
GO
/****** Object:  Table [dbo].[golfers]    Script Date: 01/18/2012 13:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[golfers]') AND type in (N'U'))
BEGIN
CREATE TABLE [golfers](
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
/****** Object:  Table [dbo].[entrants]    Script Date: 01/18/2012 13:01:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[entrants]') AND type in (N'U'))
BEGIN
CREATE TABLE [entrants](
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
/****** Object:  Table [dbo].[tournaments]    Script Date: 01/18/2012 13:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[tournaments]') AND type in (N'U'))
BEGIN
CREATE TABLE [tournaments](
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
/****** Object:  Table [dbo].[winnings]    Script Date: 01/18/2012 13:01:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[winnings]') AND type in (N'U'))
BEGIN
CREATE TABLE [winnings](
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
/****** Object:  Table [dbo].[picks]    Script Date: 01/18/2012 13:01:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[picks]') AND type in (N'U'))
BEGIN
CREATE TABLE [picks](
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
/****** Object:  StoredProcedure [dbo].[addgolfer]    Script Date: 01/18/2012 13:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[addgolfer]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [addgolfer]
	-- Add the parameters for the stored procedure here
	@golferid int,
	@golfername nvarchar(50)
	
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF EXISTS (SELECT golferid FROM golfers WHERE golfername = @golfername)
		BEGIN
			UPDATE golfers SET golfername = @golfername, lastchange = GETDATE() WHERE golfername = @golfername
			SELECT golferid FROM golfers WHERE golfername = @golfername
		END
	ELSE
		BEGIN
			INSERT INTO golfers (golfername, lastchange) VALUES (@golfername, GETDATE())
			SELECT golferid FROM golfers WHERE golfername = @golfername
		END
END
' 
END
GO
/****** Object:  ForeignKey [FK_winnings_golfers]    Script Date: 01/18/2012 13:01:18 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_winnings_golfers]') AND parent_object_id = OBJECT_ID(N'[winnings]'))
ALTER TABLE [winnings]  WITH CHECK ADD  CONSTRAINT [FK_winnings_golfers] FOREIGN KEY([winningsid])
REFERENCES [golfers] ([golferid])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_winnings_golfers]') AND parent_object_id = OBJECT_ID(N'[winnings]'))
ALTER TABLE [winnings] CHECK CONSTRAINT [FK_winnings_golfers]
GO
/****** Object:  ForeignKey [FK_winnings_tournaments]    Script Date: 01/18/2012 13:01:18 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_winnings_tournaments]') AND parent_object_id = OBJECT_ID(N'[winnings]'))
ALTER TABLE [winnings]  WITH CHECK ADD  CONSTRAINT [FK_winnings_tournaments] FOREIGN KEY([tournamentid])
REFERENCES [tournaments] ([tournamentid])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_winnings_tournaments]') AND parent_object_id = OBJECT_ID(N'[winnings]'))
ALTER TABLE [winnings] CHECK CONSTRAINT [FK_winnings_tournaments]
GO
/****** Object:  ForeignKey [FK_picks_entrants]    Script Date: 01/18/2012 13:01:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_picks_entrants]') AND parent_object_id = OBJECT_ID(N'[picks]'))
ALTER TABLE [picks]  WITH CHECK ADD  CONSTRAINT [FK_picks_entrants] FOREIGN KEY([entrantid])
REFERENCES [entrants] ([entrantid])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_picks_entrants]') AND parent_object_id = OBJECT_ID(N'[picks]'))
ALTER TABLE [picks] CHECK CONSTRAINT [FK_picks_entrants]
GO
/****** Object:  ForeignKey [FK_picks_golfers]    Script Date: 01/18/2012 13:01:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_picks_golfers]') AND parent_object_id = OBJECT_ID(N'[picks]'))
ALTER TABLE [picks]  WITH CHECK ADD  CONSTRAINT [FK_picks_golfers] FOREIGN KEY([golferid])
REFERENCES [golfers] ([golferid])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_picks_golfers]') AND parent_object_id = OBJECT_ID(N'[picks]'))
ALTER TABLE [picks] CHECK CONSTRAINT [FK_picks_golfers]
GO
