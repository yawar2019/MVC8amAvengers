
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/24/2022 09:05:50
-- Generated from EDMX file: D:\MedicoRx7StarsBatch\MVC8amAvengers\ModelFirstApproach\Models\EmployeeModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TestSharangModelDb];
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

-- Creating table 'Employees'
CREATE TABLE [dbo].[Employees] (
    [EmpId] int IDENTITY(1,1) NOT NULL,
    [EmpName] nvarchar(max)  NOT NULL,
    [EmpSalary] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [EmpId] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [PK_Employees]
    PRIMARY KEY CLUSTERED ([EmpId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------