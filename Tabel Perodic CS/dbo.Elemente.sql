CREATE TABLE [dbo].[Elemente] (
    [Id]            INT            NOT NULL,
    [Symbol]        NCHAR (10)     NOT NULL,
    [Denumire]      NVARCHAR (MAX) NOT NULL,
    [MasaMolec]     FLOAT (53)     NOT NULL,
    [WikiLink]      NVARCHAR (MAX) NULL,
    [PunctFierbere] FLOAT (53)     NULL,
    [PunctTopire]   FLOAT (53)     NULL,
    [SerieChimica]  NVARCHAR (MAX) NULL,
    [Densitate]     FLOAT (53)     NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

