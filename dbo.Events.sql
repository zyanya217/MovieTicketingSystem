CREATE TABLE [dbo].[Events] (
    [活動編號] INT           NOT NULL,
    [活動名稱] NCHAR(10) NOT NULL,
    [活動資訊] NCHAR(10) NOT NULL,
    [開始日期] DATE          NOT NULL,
    [結束日期] DATE          NULL,
    [開始時段] TIME (7)      NULL,
    [結束時段] TIME (7)      NULL,
    [地點名稱] NCHAR(10) NULL,
    PRIMARY KEY CLUSTERED ([活動編號] ASC)
);

