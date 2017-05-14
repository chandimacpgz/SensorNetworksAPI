CREATE PROCEDURE [dbo].[Distance_Update]
	@Id INT,
	@Location NVARCHAR(200),
	@Value INT
AS
BEGIN
	DECLARE @UpdatedDate DATETIME

	SELECT	@UpdatedDate = GETDATE()

	UPDATE	[Distance]
	SET		[Location] = @Location, [Value] = @Value, [TimeStamp] = @UpdatedDate
	WHERE	[Id]=@Id
END