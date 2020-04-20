
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/16/2020 21:33:16
-- Generated from EDMX file: C:\Users\manue\source\repos\WindowsFormsMyPhotos\MyPhotosModel\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [EfCore2020];
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

-- Creating table 'Imagini'
CREATE TABLE [dbo].[Imagini] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DateMemory] datetime  NOT NULL,
    [PathFoto] varbinary(max)  NOT NULL,
    [Search_Id] int  NOT NULL
);
GO

-- Creating table 'DetaliiComenzi'
CREATE TABLE [dbo].[DetaliiComenzi] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] int  NOT NULL,
    [Date] datetime  NOT NULL,
    [People] nvarchar(max)  NOT NULL,
    [Location] nvarchar(max)  NOT NULL,
    [Event] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Clienti'
CREATE TABLE [dbo].[Clienti] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nume] nvarchar(15)  NOT NULL,
    [Prenume] nvarchar(15)  NOT NULL,
    [Adresa] nvarchar(50)  NOT NULL,
    [Localitate] nvarchar(10)  NOT NULL,
    [Judet] nvarchar(10)  NOT NULL,
    [Telefon] nvarchar(13)  NOT NULL,
    [Email] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Searches'
CREATE TABLE [dbo].[Searches] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NOT NULL,
    [User_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Imagini'
ALTER TABLE [dbo].[Imagini]
ADD CONSTRAINT [PK_Imagini]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DetaliiComenzi'
ALTER TABLE [dbo].[DetaliiComenzi]
ADD CONSTRAINT [PK_DetaliiComenzi]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Clienti'
ALTER TABLE [dbo].[Clienti]
ADD CONSTRAINT [PK_Clienti]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Searches'
ALTER TABLE [dbo].[Searches]
ADD CONSTRAINT [PK_Searches]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Id] in table 'DetaliiComenzi'
ALTER TABLE [dbo].[DetaliiComenzi]
ADD CONSTRAINT [FK_PhotosDetaliiPhoto]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Imagini]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [User_Id] in table 'Searches'
ALTER TABLE [dbo].[Searches]
ADD CONSTRAINT [FK_UserSearch]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[Clienti]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserSearch'
CREATE INDEX [IX_FK_UserSearch]
ON [dbo].[Searches]
    ([User_Id]);
GO

-- Creating foreign key on [Search_Id] in table 'Imagini'
ALTER TABLE [dbo].[Imagini]
ADD CONSTRAINT [FK_SearchPhotos]
    FOREIGN KEY ([Search_Id])
    REFERENCES [dbo].[Searches]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SearchPhotos'
CREATE INDEX [IX_FK_SearchPhotos]
ON [dbo].[Imagini]
    ([Search_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------