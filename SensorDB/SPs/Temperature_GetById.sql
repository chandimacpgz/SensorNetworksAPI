CREATE PROCEDURE [dbo].[Temperature_GetById]
	@Id INT
AS
BEGIN
	SELECT	[Id],
			[Value],
			[TimeStamp],
			[Location],
			[IsDeleted]  
	FROM	[Temperature]
	WHERE	[Id] = @Id AND [IsDeleted] = 0
END