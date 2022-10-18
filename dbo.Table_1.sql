CREATE TABLE [dbo].[Kategooria]
(
	[Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL, 
    [Kategooria_nimetus] VARCHAR(50) NOT NULL, 
    [Kirjeldus] VARCHAR(50) NULL
)
