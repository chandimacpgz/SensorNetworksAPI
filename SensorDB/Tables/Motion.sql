CREATE TABLE [dbo].[Motion]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Value] INT NULL, 
    [TimeStamp] DATETIME NULL, 
    [Location] NVARCHAR(200) NULL, 
    [IsDeleted] BIT NOT NULL DEFAULT 0
)
