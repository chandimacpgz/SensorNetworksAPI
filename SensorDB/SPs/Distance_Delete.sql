CREATE PROCEDURE [dbo].[Distance_Delete]
	@Id INT
AS
BEGIN
	DECLARE @DeletedDate DATETIME

	SELECT	@DeletedDate = GETDATE()

	UPDATE	[Distance]
	SET		[IsDeleted] = 1,[TimeStamp] = @DeletedDate
	WHERE	[Id] = @Id
END