CREATE PROCEDURE [dbo].[Motion_Add]
	@Value INT,
	@Location NVARCHAR(200)
AS
BEGIN
	INSERT INTO [Motion] ([Value],[TimeStamp],[Location]) 
	VALUES(@Value,GETDATE(),@Location);
END