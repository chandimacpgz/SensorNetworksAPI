CREATE PROCEDURE [dbo].[Distance_Get]
AS
BEGIN
	SELECT	[Id],
			[Value],
			[TimeStamp],
			[Location],
			[IsDeleted]  
	FROM	[Distance]
	WHERE	[IsDeleted] = 0
END