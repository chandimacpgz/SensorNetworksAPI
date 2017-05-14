CREATE PROCEDURE [dbo].[Motion_Get]
AS
BEGIN
	SELECT	[Id],
			[Value],
			[TimeStamp],
			[Location],
			[IsDeleted]  
	FROM	[Motion]
	WHERE	[IsDeleted] = 0
END