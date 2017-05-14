CREATE PROCEDURE [dbo].[Motion_GetById]
	@Id INT
AS
BEGIN
	SELECT	[Id],
			[Value],
			[TimeStamp],
			[Location],
			[IsDeleted]  
	FROM	[Motion]
	WHERE	[Id] = @Id AND [IsDeleted] = 0
END