CREATE TABLE [dbo].[Shop] (
    [Id]      INT            NOT NULL,
    [Name]    NVARCHAR (150) NOT NULL,
    [Address] NCHAR (500)    NULL,
    [ContactNo] NUMERIC NOT NULL, 
    [Email] VARCHAR(50) NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

