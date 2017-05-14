CREATE PROCEDURE [dbo].[Humidity_GetById]
	@Id INT
AS
BEGIN
	SELECT	[Id],
			[Value],
			[TimeStamp],
			[Location],
			[IsDeleted]  
	FROM	[Humidity]
	WHERE	[Id] = @Id AND [IsDeleted] = 0
END