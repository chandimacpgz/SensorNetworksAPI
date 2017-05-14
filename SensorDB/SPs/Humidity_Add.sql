CREATE PROCEDURE [dbo].[Humidity_Add]
	@Value INT,
	@Location NVARCHAR(200)
AS
BEGIN
	INSERT INTO [Humidity] ([Value],[TimeStamp],[Location]) 
	VALUES(@Value,GETDATE(),@Location);
END
