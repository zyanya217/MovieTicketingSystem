CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Event] VARCHAR(50) NOT NULL, 
    [Place] NCHAR(10) NULL, 
    [Date] DATE NOT NULL, 
    [Time] DATETIME NULL
)
