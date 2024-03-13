CREATE TABLE [dbo].[Formation] (
    [CodeFor]               INT          NOT NULL,
    [Mois]             VARCHAR(50)          NULL,
    [Date]                 INT NULL,
    [Jour]                  VARCHAR (50) NULL,
    [NumDomaine]                  INT         NULL,
    [NumProjet]              INT NULL,
    [Domaine] VARCHAR (50) NULL,
    [Sujet]              VARCHAR (50) NULL,
    [CategorieBeneficiaire]    VARCHAR(50)          NULL,
    [NembreBeneficiaire]                 INT NULL,
    [ForConfi] VARCHAR(50) NULL, 
    [Lieu] VARCHAR(50) NULL, 
    [Heure] INT NULL, 
    CONSTRAINT [PK_Formation] PRIMARY KEY CLUSTERED ([CodeFor] ASC)
);

