
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/02/2021 08:21:18
-- Generated from EDMX file: C:\Users\Ivana\Desktop\NE BRISI\BeogradskaFilharmonija\BeogradskaFilharmonija\BeogradskaFilharmonijaModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BeogradskaFilharmonijaModel];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_clan_klubadjak]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[djakSet] DROP CONSTRAINT [FK_clan_klubadjak];
GO
IF OBJECT_ID(N'[dbo].[FK_clan_klubapenzioner]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[penzionerSet] DROP CONSTRAINT [FK_clan_klubapenzioner];
GO
IF OBJECT_ID(N'[dbo].[FK_clan_klubastudent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[studentSet] DROP CONSTRAINT [FK_clan_klubastudent];
GO
IF OBJECT_ID(N'[dbo].[FK_posetilacclan_kluba]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[clan_klubaSet] DROP CONSTRAINT [FK_posetilacclan_kluba];
GO
IF OBJECT_ID(N'[dbo].[FK_saladvorana]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[salaSet] DROP CONSTRAINT [FK_saladvorana];
GO
IF OBJECT_ID(N'[dbo].[FK_izvodjenjesala]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[izvodjenjeSet] DROP CONSTRAINT [FK_izvodjenjesala];
GO
IF OBJECT_ID(N'[dbo].[FK_kartaizvodjenje]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[kartaSet] DROP CONSTRAINT [FK_kartaizvodjenje];
GO
IF OBJECT_ID(N'[dbo].[FK_koncertizvodjenje]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[izvodjenjeSet] DROP CONSTRAINT [FK_koncertizvodjenje];
GO
IF OBJECT_ID(N'[dbo].[FK_posetilackarta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[kartaSet] DROP CONSTRAINT [FK_posetilackarta];
GO
IF OBJECT_ID(N'[dbo].[FK_koncertorkestar_koncertSet]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[koncertorkestar] DROP CONSTRAINT [FK_koncertorkestar_koncertSet];
GO
IF OBJECT_ID(N'[dbo].[FK_koncertorkestar_orkestarSet]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[koncertorkestar] DROP CONSTRAINT [FK_koncertorkestar_orkestarSet];
GO
IF OBJECT_ID(N'[dbo].[FK_koncertsef_dirigent_koncertSet]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[koncertsef_dirigent] DROP CONSTRAINT [FK_koncertsef_dirigent_koncertSet];
GO
IF OBJECT_ID(N'[dbo].[FK_koncertsef_dirigent_sef_dirigentSet]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[koncertsef_dirigent] DROP CONSTRAINT [FK_koncertsef_dirigent_sef_dirigentSet];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[clan_klubaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[clan_klubaSet];
GO
IF OBJECT_ID(N'[dbo].[djakSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[djakSet];
GO
IF OBJECT_ID(N'[dbo].[dvoranaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[dvoranaSet];
GO
IF OBJECT_ID(N'[dbo].[izvodjenjeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[izvodjenjeSet];
GO
IF OBJECT_ID(N'[dbo].[kartaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[kartaSet];
GO
IF OBJECT_ID(N'[dbo].[koncertSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[koncertSet];
GO
IF OBJECT_ID(N'[dbo].[orkestarSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[orkestarSet];
GO
IF OBJECT_ID(N'[dbo].[penzionerSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[penzionerSet];
GO
IF OBJECT_ID(N'[dbo].[posetilacSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[posetilacSet];
GO
IF OBJECT_ID(N'[dbo].[salaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[salaSet];
GO
IF OBJECT_ID(N'[dbo].[sef_dirigentSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sef_dirigentSet];
GO
IF OBJECT_ID(N'[dbo].[studentSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[studentSet];
GO
IF OBJECT_ID(N'[dbo].[koncertorkestar]', 'U') IS NOT NULL
    DROP TABLE [dbo].[koncertorkestar];
GO
IF OBJECT_ID(N'[dbo].[koncertsef_dirigent]', 'U') IS NOT NULL
    DROP TABLE [dbo].[koncertsef_dirigent];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'clan_klubaSet'
CREATE TABLE [dbo].[clan_klubaSet] (
    [sfr] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [jmbg] nvarchar(max)  NOT NULL,
    [korime] nvarchar(max)  NOT NULL,
    [datrodj] nvarchar(max)  NOT NULL,
    [imeck] nvarchar(max)  NOT NULL,
    [prezck] nvarchar(max)  NOT NULL,
    [posetilac_brckar_clan_kluba] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'djakSet'
CREATE TABLE [dbo].[djakSet] (
    [popdjak] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [sfr] decimal(18,0)  NOT NULL,
    [brckar] decimal(18,0)  NOT NULL,
    [clan_kluba_sfr] decimal(18,0)  NOT NULL,
    [clan_kluba_posetilac_brckar_clan_kluba] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'dvoranaSet'
CREATE TABLE [dbo].[dvoranaSet] (
    [iddvor] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [ul] nvarchar(max)  NOT NULL,
    [br] decimal(18,0)  NOT NULL,
    [mest] nvarchar(max)  NOT NULL,
    [nazdv] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'izvodjenjeSet'
CREATE TABLE [dbo].[izvodjenjeSet] (
    [sala_dvorana_iddvor_izvodjenje] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [sala_idsal_izvodjenje] decimal(18,0)  NOT NULL,
    [koncert_idkon_izvodjenje] decimal(18,0)  NOT NULL,
    [sala_idsal] decimal(18,0)  NOT NULL,
    [sala_dvorana_iddvor_sala] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'kartaSet'
CREATE TABLE [dbo].[kartaSet] (
    [br] int IDENTITY(1,1) NOT NULL,
    [red] decimal(18,0)  NOT NULL,
    [sed] decimal(18,0)  NOT NULL,
    [cen] float  NOT NULL,
    [satiz] nvarchar(max)  NOT NULL,
    [daniz] nvarchar(max)  NOT NULL,
    [izvodjenje_koncert_idkon_karta] decimal(18,0)  NOT NULL,
    [izvodjenje_sala_idsal_karta] decimal(18,0)  NOT NULL,
    [izvodjenje_sala_dvorana_iddvor_karta] decimal(18,0)  NOT NULL,
    [posetilac_brckar_karta] decimal(18,0)  NULL,
    [izvodjenje_sala_dvorana_iddvor_izvodjenje] decimal(18,0)  NOT NULL,
    [izvodjenje_sala_idsal_izvodjenje] decimal(18,0)  NOT NULL,
    [izvodjenje_koncert_idkon_izvodjenje] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'koncertSet'
CREATE TABLE [dbo].[koncertSet] (
    [idkon] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [nazkon] nvarchar(max)  NOT NULL,
    [znrmuzik] nvarchar(max)  NOT NULL,
    [traj] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'orkestarSet'
CREATE TABLE [dbo].[orkestarSet] (
    [id] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [imeork] nvarchar(max)  NOT NULL,
    [brclan] int  NOT NULL
);
GO

-- Creating table 'penzionerSet'
CREATE TABLE [dbo].[penzionerSet] (
    [osigur] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [sfr] decimal(18,0)  NOT NULL,
    [brckar] decimal(18,0)  NOT NULL,
    [clan_kluba_sfr] decimal(18,0)  NOT NULL,
    [clan_kluba_posetilac_brckar_clan_kluba] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'posetilacSet'
CREATE TABLE [dbo].[posetilacSet] (
    [brckar] decimal(18,0) IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'salaSet'
CREATE TABLE [dbo].[salaSet] (
    [idsal] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [brsed] decimal(18,0)  NOT NULL,
    [velsce] nvarchar(max)  NOT NULL,
    [dvorana_iddvor_sala] decimal(18,0)  NOT NULL,
    [dvorana_iddvor] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'sef_dirigentSet'
CREATE TABLE [dbo].[sef_dirigentSet] (
    [iddir] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [imed] nvarchar(max)  NOT NULL,
    [prezdir] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'studentSet'
CREATE TABLE [dbo].[studentSet] (
    [popstud] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [sfr] decimal(18,0)  NOT NULL,
    [brckar] decimal(18,0)  NOT NULL,
    [clan_kluba_sfr] decimal(18,0)  NOT NULL,
    [clan_kluba_posetilac_brckar_clan_kluba] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'koncertorkestar'
CREATE TABLE [dbo].[koncertorkestar] (
    [koncertSet_idkon] decimal(18,0)  NOT NULL,
    [orkestarSet_id] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'koncertsef_dirigent'
CREATE TABLE [dbo].[koncertsef_dirigent] (
    [koncertSet_idkon] decimal(18,0)  NOT NULL,
    [sef_dirigentSet_iddir] decimal(18,0)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [sfr], [posetilac_brckar_clan_kluba] in table 'clan_klubaSet'
ALTER TABLE [dbo].[clan_klubaSet]
ADD CONSTRAINT [PK_clan_klubaSet]
    PRIMARY KEY CLUSTERED ([sfr], [posetilac_brckar_clan_kluba] ASC);
GO

-- Creating primary key on [popdjak], [sfr], [brckar] in table 'djakSet'
ALTER TABLE [dbo].[djakSet]
ADD CONSTRAINT [PK_djakSet]
    PRIMARY KEY CLUSTERED ([popdjak], [sfr], [brckar] ASC);
GO

-- Creating primary key on [iddvor] in table 'dvoranaSet'
ALTER TABLE [dbo].[dvoranaSet]
ADD CONSTRAINT [PK_dvoranaSet]
    PRIMARY KEY CLUSTERED ([iddvor] ASC);
GO

-- Creating primary key on [sala_dvorana_iddvor_izvodjenje], [sala_idsal_izvodjenje], [koncert_idkon_izvodjenje] in table 'izvodjenjeSet'
ALTER TABLE [dbo].[izvodjenjeSet]
ADD CONSTRAINT [PK_izvodjenjeSet]
    PRIMARY KEY CLUSTERED ([sala_dvorana_iddvor_izvodjenje], [sala_idsal_izvodjenje], [koncert_idkon_izvodjenje] ASC);
GO

-- Creating primary key on [br], [izvodjenje_koncert_idkon_karta], [izvodjenje_sala_idsal_karta], [izvodjenje_sala_dvorana_iddvor_karta] in table 'kartaSet'
ALTER TABLE [dbo].[kartaSet]
ADD CONSTRAINT [PK_kartaSet]
    PRIMARY KEY CLUSTERED ([br], [izvodjenje_koncert_idkon_karta], [izvodjenje_sala_idsal_karta], [izvodjenje_sala_dvorana_iddvor_karta] ASC);
GO

-- Creating primary key on [idkon] in table 'koncertSet'
ALTER TABLE [dbo].[koncertSet]
ADD CONSTRAINT [PK_koncertSet]
    PRIMARY KEY CLUSTERED ([idkon] ASC);
GO

-- Creating primary key on [id] in table 'orkestarSet'
ALTER TABLE [dbo].[orkestarSet]
ADD CONSTRAINT [PK_orkestarSet]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [osigur], [sfr], [brckar] in table 'penzionerSet'
ALTER TABLE [dbo].[penzionerSet]
ADD CONSTRAINT [PK_penzionerSet]
    PRIMARY KEY CLUSTERED ([osigur], [sfr], [brckar] ASC);
GO

-- Creating primary key on [brckar] in table 'posetilacSet'
ALTER TABLE [dbo].[posetilacSet]
ADD CONSTRAINT [PK_posetilacSet]
    PRIMARY KEY CLUSTERED ([brckar] ASC);
GO

-- Creating primary key on [idsal], [dvorana_iddvor_sala] in table 'salaSet'
ALTER TABLE [dbo].[salaSet]
ADD CONSTRAINT [PK_salaSet]
    PRIMARY KEY CLUSTERED ([idsal], [dvorana_iddvor_sala] ASC);
GO

-- Creating primary key on [iddir] in table 'sef_dirigentSet'
ALTER TABLE [dbo].[sef_dirigentSet]
ADD CONSTRAINT [PK_sef_dirigentSet]
    PRIMARY KEY CLUSTERED ([iddir] ASC);
GO

-- Creating primary key on [popstud], [sfr], [brckar] in table 'studentSet'
ALTER TABLE [dbo].[studentSet]
ADD CONSTRAINT [PK_studentSet]
    PRIMARY KEY CLUSTERED ([popstud], [sfr], [brckar] ASC);
GO

-- Creating primary key on [koncertSet_idkon], [orkestarSet_id] in table 'koncertorkestar'
ALTER TABLE [dbo].[koncertorkestar]
ADD CONSTRAINT [PK_koncertorkestar]
    PRIMARY KEY CLUSTERED ([koncertSet_idkon], [orkestarSet_id] ASC);
GO

-- Creating primary key on [koncertSet_idkon], [sef_dirigentSet_iddir] in table 'koncertsef_dirigent'
ALTER TABLE [dbo].[koncertsef_dirigent]
ADD CONSTRAINT [PK_koncertsef_dirigent]
    PRIMARY KEY CLUSTERED ([koncertSet_idkon], [sef_dirigentSet_iddir] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [clan_kluba_sfr], [clan_kluba_posetilac_brckar_clan_kluba] in table 'djakSet'
ALTER TABLE [dbo].[djakSet]
ADD CONSTRAINT [FK_clan_klubadjak]
    FOREIGN KEY ([clan_kluba_sfr], [clan_kluba_posetilac_brckar_clan_kluba])
    REFERENCES [dbo].[clan_klubaSet]
        ([sfr], [posetilac_brckar_clan_kluba])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_clan_klubadjak'
CREATE INDEX [IX_FK_clan_klubadjak]
ON [dbo].[djakSet]
    ([clan_kluba_sfr], [clan_kluba_posetilac_brckar_clan_kluba]);
GO

-- Creating foreign key on [clan_kluba_sfr], [clan_kluba_posetilac_brckar_clan_kluba] in table 'penzionerSet'
ALTER TABLE [dbo].[penzionerSet]
ADD CONSTRAINT [FK_clan_klubapenzioner]
    FOREIGN KEY ([clan_kluba_sfr], [clan_kluba_posetilac_brckar_clan_kluba])
    REFERENCES [dbo].[clan_klubaSet]
        ([sfr], [posetilac_brckar_clan_kluba])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_clan_klubapenzioner'
CREATE INDEX [IX_FK_clan_klubapenzioner]
ON [dbo].[penzionerSet]
    ([clan_kluba_sfr], [clan_kluba_posetilac_brckar_clan_kluba]);
GO

-- Creating foreign key on [clan_kluba_sfr], [clan_kluba_posetilac_brckar_clan_kluba] in table 'studentSet'
ALTER TABLE [dbo].[studentSet]
ADD CONSTRAINT [FK_clan_klubastudent]
    FOREIGN KEY ([clan_kluba_sfr], [clan_kluba_posetilac_brckar_clan_kluba])
    REFERENCES [dbo].[clan_klubaSet]
        ([sfr], [posetilac_brckar_clan_kluba])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_clan_klubastudent'
CREATE INDEX [IX_FK_clan_klubastudent]
ON [dbo].[studentSet]
    ([clan_kluba_sfr], [clan_kluba_posetilac_brckar_clan_kluba]);
GO

-- Creating foreign key on [posetilac_brckar_clan_kluba] in table 'clan_klubaSet'
ALTER TABLE [dbo].[clan_klubaSet]
ADD CONSTRAINT [FK_posetilacclan_kluba]
    FOREIGN KEY ([posetilac_brckar_clan_kluba])
    REFERENCES [dbo].[posetilacSet]
        ([brckar])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_posetilacclan_kluba'
CREATE INDEX [IX_FK_posetilacclan_kluba]
ON [dbo].[clan_klubaSet]
    ([posetilac_brckar_clan_kluba]);
GO

-- Creating foreign key on [dvorana_iddvor] in table 'salaSet'
ALTER TABLE [dbo].[salaSet]
ADD CONSTRAINT [FK_saladvorana]
    FOREIGN KEY ([dvorana_iddvor])
    REFERENCES [dbo].[dvoranaSet]
        ([iddvor])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_saladvorana'
CREATE INDEX [IX_FK_saladvorana]
ON [dbo].[salaSet]
    ([dvorana_iddvor]);
GO

-- Creating foreign key on [sala_idsal], [sala_dvorana_iddvor_sala] in table 'izvodjenjeSet'
ALTER TABLE [dbo].[izvodjenjeSet]
ADD CONSTRAINT [FK_izvodjenjesala]
    FOREIGN KEY ([sala_idsal], [sala_dvorana_iddvor_sala])
    REFERENCES [dbo].[salaSet]
        ([idsal], [dvorana_iddvor_sala])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_izvodjenjesala'
CREATE INDEX [IX_FK_izvodjenjesala]
ON [dbo].[izvodjenjeSet]
    ([sala_idsal], [sala_dvorana_iddvor_sala]);
GO

-- Creating foreign key on [izvodjenje_sala_dvorana_iddvor_izvodjenje], [izvodjenje_sala_idsal_izvodjenje], [izvodjenje_koncert_idkon_izvodjenje] in table 'kartaSet'
ALTER TABLE [dbo].[kartaSet]
ADD CONSTRAINT [FK_kartaizvodjenje]
    FOREIGN KEY ([izvodjenje_sala_dvorana_iddvor_izvodjenje], [izvodjenje_sala_idsal_izvodjenje], [izvodjenje_koncert_idkon_izvodjenje])
    REFERENCES [dbo].[izvodjenjeSet]
        ([sala_dvorana_iddvor_izvodjenje], [sala_idsal_izvodjenje], [koncert_idkon_izvodjenje])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_kartaizvodjenje'
CREATE INDEX [IX_FK_kartaizvodjenje]
ON [dbo].[kartaSet]
    ([izvodjenje_sala_dvorana_iddvor_izvodjenje], [izvodjenje_sala_idsal_izvodjenje], [izvodjenje_koncert_idkon_izvodjenje]);
GO

-- Creating foreign key on [koncert_idkon_izvodjenje] in table 'izvodjenjeSet'
ALTER TABLE [dbo].[izvodjenjeSet]
ADD CONSTRAINT [FK_koncertizvodjenje]
    FOREIGN KEY ([koncert_idkon_izvodjenje])
    REFERENCES [dbo].[koncertSet]
        ([idkon])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_koncertizvodjenje'
CREATE INDEX [IX_FK_koncertizvodjenje]
ON [dbo].[izvodjenjeSet]
    ([koncert_idkon_izvodjenje]);
GO

-- Creating foreign key on [posetilac_brckar_karta] in table 'kartaSet'
ALTER TABLE [dbo].[kartaSet]
ADD CONSTRAINT [FK_posetilackarta]
    FOREIGN KEY ([posetilac_brckar_karta])
    REFERENCES [dbo].[posetilacSet]
        ([brckar])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_posetilackarta'
CREATE INDEX [IX_FK_posetilackarta]
ON [dbo].[kartaSet]
    ([posetilac_brckar_karta]);
GO

-- Creating foreign key on [koncertSet_idkon] in table 'koncertorkestar'
ALTER TABLE [dbo].[koncertorkestar]
ADD CONSTRAINT [FK_koncertorkestar_koncertSet]
    FOREIGN KEY ([koncertSet_idkon])
    REFERENCES [dbo].[koncertSet]
        ([idkon])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [orkestarSet_id] in table 'koncertorkestar'
ALTER TABLE [dbo].[koncertorkestar]
ADD CONSTRAINT [FK_koncertorkestar_orkestarSet]
    FOREIGN KEY ([orkestarSet_id])
    REFERENCES [dbo].[orkestarSet]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_koncertorkestar_orkestarSet'
CREATE INDEX [IX_FK_koncertorkestar_orkestarSet]
ON [dbo].[koncertorkestar]
    ([orkestarSet_id]);
GO

-- Creating foreign key on [koncertSet_idkon] in table 'koncertsef_dirigent'
ALTER TABLE [dbo].[koncertsef_dirigent]
ADD CONSTRAINT [FK_koncertsef_dirigent_koncertSet]
    FOREIGN KEY ([koncertSet_idkon])
    REFERENCES [dbo].[koncertSet]
        ([idkon])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [sef_dirigentSet_iddir] in table 'koncertsef_dirigent'
ALTER TABLE [dbo].[koncertsef_dirigent]
ADD CONSTRAINT [FK_koncertsef_dirigent_sef_dirigentSet]
    FOREIGN KEY ([sef_dirigentSet_iddir])
    REFERENCES [dbo].[sef_dirigentSet]
        ([iddir])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_koncertsef_dirigent_sef_dirigentSet'
CREATE INDEX [IX_FK_koncertsef_dirigent_sef_dirigentSet]
ON [dbo].[koncertsef_dirigent]
    ([sef_dirigentSet_iddir]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------