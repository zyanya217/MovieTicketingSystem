CREATE TABLE [dbo].[Orders] (
    [訂單編號]      INT           NOT NULL,
    [日期]        DATE          NULL,
    [電影名稱]      NVARCHAR (MAX) NULL,
    [票數]        INT           NULL,
    [影廳]        NVARCHAR (50) NULL,
    [場次]        NVARCHAR (50) NULL,
    [距離觀影日還有幾天] AS            (datediff(day,getdate(),[日期])),
    [電話]        NCHAR (10)    NULL,
    PRIMARY KEY CLUSTERED ([訂單編號] ASC)
);

