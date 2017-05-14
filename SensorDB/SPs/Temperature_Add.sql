CREATE PROCEDURE [dbo].[Temperature_Add]
	@Value INT,
	@Location NVARCHAR(200)
AS
BEGIN
	INSERT INTO [Temperature] ([Value],[TimeStamp],[Location]) 
	VALUES(@Value,GETDATE(),@Location);
END