
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/24/2020 12:58:37
-- Generated from EDMX file: C:\Users\Public\TSNET\L3_ModelDesignFirst\ModelManyToMany.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TestPerson];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Albums'
CREATE TABLE [dbo].[Albums] (
    [AlbumId] int IDENTITY(1,1) NOT NULL,
    [AlbumName] nvarchar(20)  NOT NULL
);
GO

-- Creating table 'Artists'
CREATE TABLE [dbo].[Artists] (
    [ArtistId] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(10)  NOT NULL,
    [LastName] nvarchar(10)  NOT NULL
);
GO

-- Creating table 'AlbumArtist'
CREATE TABLE [dbo].[AlbumArtist] (
    [Albums_AlbumId] int  NOT NULL,
    [Artists_ArtistId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [AlbumId] in table 'Albums'
ALTER TABLE [dbo].[Albums]
ADD CONSTRAINT [PK_Albums]
    PRIMARY KEY CLUSTERED ([AlbumId] ASC);
GO

-- Creating primary key on [ArtistId] in table 'Artists'
ALTER TABLE [dbo].[Artists]
ADD CONSTRAINT [PK_Artists]
    PRIMARY KEY CLUSTERED ([ArtistId] ASC);
GO

-- Creating primary key on [Albums_AlbumId], [Artists_ArtistId] in table 'AlbumArtist'
ALTER TABLE [dbo].[AlbumArtist]
ADD CONSTRAINT [PK_AlbumArtist]
    PRIMARY KEY CLUSTERED ([Albums_AlbumId], [Artists_ArtistId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Albums_AlbumId] in table 'AlbumArtist'
ALTER TABLE [dbo].[AlbumArtist]
ADD CONSTRAINT [FK_AlbumArtist_Album]
    FOREIGN KEY ([Albums_AlbumId])
    REFERENCES [dbo].[Albums]
        ([AlbumId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Artists_ArtistId] in table 'AlbumArtist'
ALTER TABLE [dbo].[AlbumArtist]
ADD CONSTRAINT [FK_AlbumArtist_Artist]
    FOREIGN KEY ([Artists_ArtistId])
    REFERENCES [dbo].[Artists]
        ([ArtistId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AlbumArtist_Artist'
CREATE INDEX [IX_FK_AlbumArtist_Artist]
ON [dbo].[AlbumArtist]
    ([Artists_ArtistId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------