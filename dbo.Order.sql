CREATE TABLE [dbo].[Order] (
    [訂單編號]      INT           NOT NULL,
    [日期]        DATE          NOT NULL,
    [電影名稱]      NVARCHAR (50) NOT NULL,
    [票數]        INT           NOT NULL,
    [影廳]        NVARCHAR (50) NOT NULL,
    [場次]        NVARCHAR (50) NOT NULL,
    [距離觀影日還有幾天] AS            (datediff(day,getdate(),[日期])),
    [電話] NVARCHAR(10) NOT NULL, 
    PRIMARY KEY CLUSTERED ([訂單編號] ASC)
);

