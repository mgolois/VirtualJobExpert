CREATE TABLE [dbo].[JobStatus]
(
	[Id] INT NOT NULL PRIMARY KEY Identity(1,1), 
    [Status] VARCHAR(MAX) NOT NULL, 
    [Active] BIT NULL DEFAULT 1
)
