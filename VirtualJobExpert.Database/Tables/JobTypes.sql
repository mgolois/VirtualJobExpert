CREATE TABLE [dbo].[JobTypes]
(
	[Id] INT NOT NULL PRIMARY KEY Identity(1,1), 
    [Type] VARCHAR(MAX) NOT NULL, 
    [Active] BIT NULL DEFAULT 1
)
