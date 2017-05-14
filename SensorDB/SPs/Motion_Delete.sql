CREATE PROCEDURE [dbo].[Motion_Delete]
	@Id INT
AS
BEGIN
	DECLARE @DeletedDate DATETIME

	SELECT	@DeletedDate = GETDATE()

	UPDATE	[Motion]
	SET		[IsDeleted] = 1,[TimeStamp] = @DeletedDate
	WHERE	[Id] = @Id
END