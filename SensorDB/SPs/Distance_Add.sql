CREATE PROCEDURE [dbo].[Distance_Add]
	@Value INT,
	@Location NVARCHAR(200)
AS
BEGIN
	INSERT INTO [Distance] ([Value],[TimeStamp],[Location]) 
	VALUES(@Value,GETDATE(),@Location);
END