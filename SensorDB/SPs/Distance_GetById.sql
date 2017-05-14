CREATE PROCEDURE [dbo].[Distance_GetById]
	@Id INT
AS
BEGIN
	SELECT	[Id],
			[Value],
			[TimeStamp],
			[Location],
			[IsDeleted]  
	FROM	[Distance]
	WHERE	[Id] = @Id AND [IsDeleted] = 0
END