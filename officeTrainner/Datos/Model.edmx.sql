
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/04/2018 11:25:10
-- Generated from EDMX file: C:\OfficeTrainner\officeTrainer\officeTrainner\Datos\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [OfficeTrainner];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AlumnoExamen]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Examenes] DROP CONSTRAINT [FK_AlumnoExamen];
GO
IF OBJECT_ID(N'[dbo].[FK_ExamenArrayOrdenPreguntas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ArrayOrdenPreguntas] DROP CONSTRAINT [FK_ExamenArrayOrdenPreguntas];
GO
IF OBJECT_ID(N'[dbo].[FK_PuntajePreguntaExamen]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PuntajePreguntas] DROP CONSTRAINT [FK_PuntajePreguntaExamen];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Alumnos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Alumnos];
GO
IF OBJECT_ID(N'[dbo].[Examenes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Examenes];
GO
IF OBJECT_ID(N'[dbo].[ArrayOrdenPreguntas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ArrayOrdenPreguntas];
GO
IF OBJECT_ID(N'[dbo].[PuntajePreguntas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PuntajePreguntas];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Alumnos'
CREATE TABLE [dbo].[Alumnos] (
    [IdAlumno] int IDENTITY(1,1) NOT NULL,
    [nombres] nvarchar(max)  NOT NULL,
    [apellidos] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Examenes'
CREATE TABLE [dbo].[Examenes] (
    [IdExamen] int IDENTITY(1,1) NOT NULL,
    [nombreExamen] nvarchar(max)  NOT NULL,
    [fecha] datetime  NOT NULL,
    [preguntasResueltas] int  NOT NULL,
    [avance] int  NOT NULL,
    [alumnoIdAlumno] int  NOT NULL,
    [numeroDePreguntas] int  NOT NULL,
    [banderaAleatorio] bit  NOT NULL,
    [banderaCronometro] bit  NOT NULL,
    [banderaGuardar] bit  NOT NULL,
    [banderaReanudar] bit  NOT NULL
);
GO

-- Creating table 'ArrayOrdenPreguntas'
CREATE TABLE [dbo].[ArrayOrdenPreguntas] (
    [IdArrayOrdenPreguntas] int IDENTITY(1,1) NOT NULL,
    [p01] int  NOT NULL,
    [p02] int  NOT NULL,
    [p03] int  NOT NULL,
    [p04] int  NOT NULL,
    [p05] int  NOT NULL,
    [p06] int  NOT NULL,
    [p07] int  NOT NULL,
    [p08] int  NOT NULL,
    [p09] int  NOT NULL,
    [p10] int  NOT NULL,
    [p11] int  NOT NULL,
    [p12] int  NOT NULL,
    [p13] int  NOT NULL,
    [p14] int  NOT NULL,
    [p15] int  NOT NULL,
    [p16] int  NOT NULL,
    [p17] int  NOT NULL,
    [p18] int  NOT NULL,
    [p19] int  NOT NULL,
    [p20] int  NOT NULL,
    [p21] int  NOT NULL,
    [p22] int  NOT NULL,
    [p23] int  NOT NULL,
    [p24] int  NOT NULL,
    [p25] int  NOT NULL,
    [p26] int  NOT NULL,
    [p27] int  NOT NULL,
    [p28] int  NOT NULL,
    [p29] int  NOT NULL,
    [p30] int  NOT NULL,
    [p31] int  NOT NULL,
    [p32] int  NOT NULL,
    [p33] int  NOT NULL,
    [p34] int  NOT NULL,
    [p35] int  NOT NULL,
    [p36] int  NOT NULL,
    [p37] int  NOT NULL,
    [p38] int  NOT NULL,
    [p39] int  NOT NULL,
    [p40] int  NOT NULL,
    [p41] int  NOT NULL,
    [p42] int  NOT NULL,
    [p43] int  NOT NULL,
    [p44] int  NOT NULL,
    [p45] int  NOT NULL,
    [p46] int  NOT NULL,
    [p47] int  NOT NULL,
    [p48] int  NOT NULL,
    [p49] int  NOT NULL,
    [p50] int  NOT NULL,
    [ExamenIdExamen] int  NOT NULL
);
GO

-- Creating table 'PuntajePreguntas'
CREATE TABLE [dbo].[PuntajePreguntas] (
    [IdPuntajePreguntas] int IDENTITY(1,1) NOT NULL,
    [ExamenIdExamen] int  NOT NULL,
    [sp1] nvarchar(max)  NOT NULL,
    [sp2] nvarchar(max)  NOT NULL,
    [sp3] nvarchar(max)  NOT NULL,
    [sp4] nvarchar(max)  NOT NULL,
    [sp5] nvarchar(max)  NOT NULL,
    [numeroDePregunta] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdAlumno] in table 'Alumnos'
ALTER TABLE [dbo].[Alumnos]
ADD CONSTRAINT [PK_Alumnos]
    PRIMARY KEY CLUSTERED ([IdAlumno] ASC);
GO

-- Creating primary key on [IdExamen] in table 'Examenes'
ALTER TABLE [dbo].[Examenes]
ADD CONSTRAINT [PK_Examenes]
    PRIMARY KEY CLUSTERED ([IdExamen] ASC);
GO

-- Creating primary key on [IdArrayOrdenPreguntas] in table 'ArrayOrdenPreguntas'
ALTER TABLE [dbo].[ArrayOrdenPreguntas]
ADD CONSTRAINT [PK_ArrayOrdenPreguntas]
    PRIMARY KEY CLUSTERED ([IdArrayOrdenPreguntas] ASC);
GO

-- Creating primary key on [IdPuntajePreguntas] in table 'PuntajePreguntas'
ALTER TABLE [dbo].[PuntajePreguntas]
ADD CONSTRAINT [PK_PuntajePreguntas]
    PRIMARY KEY CLUSTERED ([IdPuntajePreguntas] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [alumnoIdAlumno] in table 'Examenes'
ALTER TABLE [dbo].[Examenes]
ADD CONSTRAINT [FK_AlumnoExamen]
    FOREIGN KEY ([alumnoIdAlumno])
    REFERENCES [dbo].[Alumnos]
        ([IdAlumno])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AlumnoExamen'
CREATE INDEX [IX_FK_AlumnoExamen]
ON [dbo].[Examenes]
    ([alumnoIdAlumno]);
GO

-- Creating foreign key on [ExamenIdExamen] in table 'ArrayOrdenPreguntas'
ALTER TABLE [dbo].[ArrayOrdenPreguntas]
ADD CONSTRAINT [FK_ExamenArrayOrdenPreguntas]
    FOREIGN KEY ([ExamenIdExamen])
    REFERENCES [dbo].[Examenes]
        ([IdExamen])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExamenArrayOrdenPreguntas'
CREATE INDEX [IX_FK_ExamenArrayOrdenPreguntas]
ON [dbo].[ArrayOrdenPreguntas]
    ([ExamenIdExamen]);
GO

-- Creating foreign key on [ExamenIdExamen] in table 'PuntajePreguntas'
ALTER TABLE [dbo].[PuntajePreguntas]
ADD CONSTRAINT [FK_PuntajePreguntaExamen]
    FOREIGN KEY ([ExamenIdExamen])
    REFERENCES [dbo].[Examenes]
        ([IdExamen])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PuntajePreguntaExamen'
CREATE INDEX [IX_FK_PuntajePreguntaExamen]
ON [dbo].[PuntajePreguntas]
    ([ExamenIdExamen]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------