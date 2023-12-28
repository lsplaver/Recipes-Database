USE [C:\MSSQL\MSSQL16.SQLSERVER\MSSQL\DATA\RECIPES.MDF]
GO

/****** Object: Table [dbo].[Ingrediants] Script Date: 12/27/2023 1:07:41 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/*DROP TABLE [dbo].[Ingrediants];*/
/*GO*/

/*DROP TABLE [dbo].[IngrediantSubstitutes];*/
/*GO*/

/*DROP TABLE [dbo].[IngrediantTypes];*/
/*GO*/

/*CREATE TABLE [dbo].[Ingrediants] (*/
/*    [IngrediantName] VARCHAR (MAX) NOT NULL,*/
/*    [IngrediantType] VARCHAR (MAX) NOT NULL,*/
/*    PRIMARY KEY CLUSTERED ([IngrediantName] ASC),*/
/*    CONSTRAINT [FK_Ingrediants_IngrediantTypes] FOREIGN KEY ([IngrediantType]) REFERENCES [dbo].[IngrediantTypes] ([Type])*/
/*);*/

/*USE [C:\MSSQL\MSSQL16.SQLSERVER\MSSQL\DATA\RECIPES.MDF]*/
/*GO*/

/****** Object: Table [dbo].[IngrediantSubstitutes] Script Date: 12/27/2023 1:08:24 PM ******/
/*SET ANSI_NULLS ON*/
/*GO*/

/*SET QUOTED_IDENTIFIER ON*/
/*GO*/

/*CREATE TABLE [dbo].[IngrediantSubstitutes] (*/
/*    [ID]                      INT           NOT NULL,*/
/*    [IngrediantSubstitutedBy] VARCHAR (MAX)   NOT NULL,*/
/*    [IngrediantName]          VARCHAR (MAX) NULL,*/
/*    PRIMARY KEY CLUSTERED ([ID] ASC),*/
/*    FOREIGN KEY ([IngrediantSubstitutedBy]) REFERENCES [dbo].[Ingrediants] ([IngrediantName])*/
/*);*/

/*USE [C:\MSSQL\MSSQL16.SQLSERVER\MSSQL\DATA\RECIPES.MDF]*/
/*GO*/

/****** Object: Table [dbo].[IngrediantTypes] Script Date: 12/27/2023 1:08:45 PM ******/
/*SET ANSI_NULLS ON*/
/*GO*/

/*SET QUOTED_IDENTIFIER ON*/
/*GO*/

CREATE TABLE [dbo].[IngrediantTypes] (
    [ID]   INT         IDENTITY (1, 1) NOT NULL,
    [Type] VARCHAR (MAX) NOT NULL /*UNIQUE*/,
    CONSTRAINT PK_IngrediantTypes_Types PRIMARY KEY CLUSTERED ([Type] ASC)
);

