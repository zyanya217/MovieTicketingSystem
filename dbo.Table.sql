CREATE TABLE [dbo].[Table]
(
	[訂單編號] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [日期] TIME NOT NULL, 
    [電影名稱] NCHAR(10) NOT NULL, 
    [票種] NCHAR(10) NOT NULL, 
    [座位] NCHAR(5) NOT NULL, 
    [影廳] NCHAR(10) NULL, 
    [場次] NCHAR(10) NULL, 
    [距離觀影日還有幾天] NCHAR(10) NULL
)
