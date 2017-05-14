CREATE PROCEDURE [dbo].[Temperature_Delete]
	@Id INT
AS
BEGIN
	DECLARE @DeletedDate DATETIME

	SELECT	@DeletedDate = GETDATE()

	UPDATE	[Temperature]
	SET		[IsDeleted] = 1,[TimeStamp] = @DeletedDate
	WHERE	[Id] = @Id
END