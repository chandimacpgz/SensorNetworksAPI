CREATE PROCEDURE [dbo].[Temperature_Get]
AS
BEGIN
	SELECT	[Id],
			[Value],
			[TimeStamp],
			[Location],
			[IsDeleted]  
	FROM	[Temperature]
	WHERE	[IsDeleted] = 0
END