
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/20/2016 17:17:22
-- Generated from EDMX file: \\mac\Google Drive\JansStuff\SwimWithJan\SwimWithJanMVC\SwimWithJanMVC\Models\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SwimLessons];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[fk_Kids]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Lessons] DROP CONSTRAINT [fk_Kids];
GO
IF OBJECT_ID(N'[dbo].[fk_KidsCustomLogin]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Kids] DROP CONSTRAINT [fk_KidsCustomLogin];
GO
IF OBJECT_ID(N'[dbo].[fk_LessonDates]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Lessons] DROP CONSTRAINT [fk_LessonDates];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Customers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customers];
GO
IF OBJECT_ID(N'[dbo].[Kids]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Kids];
GO
IF OBJECT_ID(N'[dbo].[LessonDates]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LessonDates];
GO
IF OBJECT_ID(N'[dbo].[Lessons]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Lessons];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [CustomerLogin] nvarchar(50)  NOT NULL,
    [FirstName] nvarchar(50)  NULL,
    [LastName] nvarchar(50)  NULL,
    [Address] nvarchar(50)  NULL,
    [City] nvarchar(50)  NULL,
    [State] nvarchar(50)  NULL,
    [Zip] nvarchar(50)  NULL,
    [CellPhone] nvarchar(50)  NULL,
    [HomePhone] nvarchar(50)  NULL,
    [Comments] nvarchar(50)  NULL,
    [Password] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Kids'
CREATE TABLE [dbo].[Kids] (
    [CustomerLogin] nvarchar(50)  NOT NULL,
    [FirstName] nvarchar(50)  NOT NULL,
    [LastName] nvarchar(50)  NULL,
    [Age] nvarchar(50)  NULL,
    [CurrentLevel] nvarchar(50)  NULL,
    [StartLevel] nvarchar(50)  NULL
);
GO

-- Creating table 'LessonDates'
CREATE TABLE [dbo].[LessonDates] (
    [Date] datetime  NOT NULL,
    [Hour] varchar(50)  NOT NULL
);
GO

-- Creating table 'Lessons'
CREATE TABLE [dbo].[Lessons] (
    [CustomerLogin] nvarchar(50)  NOT NULL,
    [FirstName] nvarchar(50)  NOT NULL,
    [Date] datetime  NOT NULL,
    [Hour] varchar(50)  NOT NULL,
    [description] nvarchar(4000)  NULL,
    [Duration] nvarchar(50)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CustomerLogin] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([CustomerLogin] ASC);
GO

-- Creating primary key on [CustomerLogin], [FirstName] in table 'Kids'
ALTER TABLE [dbo].[Kids]
ADD CONSTRAINT [PK_Kids]
    PRIMARY KEY CLUSTERED ([CustomerLogin], [FirstName] ASC);
GO

-- Creating primary key on [Date], [Hour] in table 'LessonDates'
ALTER TABLE [dbo].[LessonDates]
ADD CONSTRAINT [PK_LessonDates]
    PRIMARY KEY CLUSTERED ([Date], [Hour] ASC);
GO

-- Creating primary key on [CustomerLogin], [FirstName], [Date], [Hour] in table 'Lessons'
ALTER TABLE [dbo].[Lessons]
ADD CONSTRAINT [PK_Lessons]
    PRIMARY KEY CLUSTERED ([CustomerLogin], [FirstName], [Date], [Hour] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CustomerLogin] in table 'Kids'
ALTER TABLE [dbo].[Kids]
ADD CONSTRAINT [fk_KidsCustomLogin]
    FOREIGN KEY ([CustomerLogin])
    REFERENCES [dbo].[Customers]
        ([CustomerLogin])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [CustomerLogin], [FirstName] in table 'Lessons'
ALTER TABLE [dbo].[Lessons]
ADD CONSTRAINT [fk_Kids]
    FOREIGN KEY ([CustomerLogin], [FirstName])
    REFERENCES [dbo].[Kids]
        ([CustomerLogin], [FirstName])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Date], [Hour] in table 'Lessons'
ALTER TABLE [dbo].[Lessons]
ADD CONSTRAINT [fk_LessonDates]
    FOREIGN KEY ([Date], [Hour])
    REFERENCES [dbo].[LessonDates]
        ([Date], [Hour])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_LessonDates'
CREATE INDEX [IX_fk_LessonDates]
ON [dbo].[Lessons]
    ([Date], [Hour]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------