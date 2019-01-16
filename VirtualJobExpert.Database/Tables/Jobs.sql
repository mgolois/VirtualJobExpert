CREATE TABLE [dbo].[Jobs]
(
	[Id] INT NOT NULL PRIMARY KEY Identity(1,1), 
    [Title] VARCHAR(MAX) NULL, 
    [StatusId] INT NULL, 
    [CategoryId] INT NULL, 
    [TypeId] INT NULL, 
    [CityState] VARCHAR(MAX) NULL, 
    [Zipcode] VARCHAR(10) NULL, 
    [PostedDate] DATETIME NULL, 
    [Salary] VARCHAR(MAX) NULL, 
    [Link] VARCHAR(1024) NULL, 
    [WeeklyHours] VARCHAR(50) NULL, 
    [Description] VARCHAR(MAX) NULL, 
    [UpdatedOn] DATETIME NOT NULL, 
    [CompanyName] VARCHAR(MAX) NULL, 
    [CareerLevel] VARCHAR(MAX) NULL, 
    CONSTRAINT [FK_Jobs_ToJobStatus] FOREIGN KEY ([StatusId]) REFERENCES [JobStatus]([Id]),
    CONSTRAINT [FK_Jobs_ToJobCategories] FOREIGN KEY ([CategoryId]) REFERENCES [JobCategories]([Id]),
    CONSTRAINT [FK_Jobs_ToJobTypes] FOREIGN KEY ([TypeId]) REFERENCES [JobTypes]([Id]),

)
