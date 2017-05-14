CREATE PROCEDURE [dbo].[Temperature_Update]
	@Id INT,
	@Location NVARCHAR(200),
	@Value INT
AS
BEGIN
	DECLARE @UpdatedDate DATETIME

	SELECT	@UpdatedDate = GETDATE()

	UPDATE	[Temperature]
	SET		[Location] = @Location, [Value] = @Value, [TimeStamp] = @UpdatedDate
	WHERE	[Id]=@Id
END