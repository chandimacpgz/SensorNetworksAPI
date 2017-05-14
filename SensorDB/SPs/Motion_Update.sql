CREATE PROCEDURE [dbo].[Motion_Update]
	@Id INT,
	@Location NVARCHAR(200),
	@Value INT
AS
BEGIN
	DECLARE @UpdatedDate DATETIME

	SELECT	@UpdatedDate = GETDATE()

	UPDATE	[Motion]
	SET		[Location] = @Location, [Value] = @Value, [TimeStamp] = @UpdatedDate
	WHERE	[Id]=@Id
END