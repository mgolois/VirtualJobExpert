CREATE TABLE [dbo].[JobCategories]
(
	[Id] INT NOT NULL PRIMARY KEY Identity(1,1), 
    [Category] VARCHAR(MAX) NOT NULL, 
    [Active] BIT NULL DEFAULT 1
)
