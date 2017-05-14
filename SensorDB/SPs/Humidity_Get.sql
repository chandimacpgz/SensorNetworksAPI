CREATE PROCEDURE [dbo].[Humidity_Get]
AS
BEGIN
	SELECT	[Id],
			[Value],
			[TimeStamp],
			[Location],
			[IsDeleted]  
	FROM	[Humidity]
	WHERE	[IsDeleted] = 0
END
