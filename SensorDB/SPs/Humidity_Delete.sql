CREATE PROCEDURE [dbo].[Humidity_Delete]
	@Id INT
AS
BEGIN
	DECLARE @DeletedDate DATETIME

	SELECT	@DeletedDate = GETDATE()

	UPDATE	[Humidity]
	SET		[IsDeleted] = 1,[TimeStamp] = @DeletedDate
	WHERE	[Id] = @Id
END
