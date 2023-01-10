CREATE TABLE [dbo].[Order] (
    [訂單編號]      INT        IDENTITY (1, 1) NOT NULL,
    [日期]        DATE       NOT NULL,
    [電影名稱]      NCHAR (10) NOT NULL,
    [票數]        INT NOT NULL,
    [影廳]        NCHAR (10) NULL,
    [場次]        NCHAR (10) NULL,
    [距離觀影日還有幾天] NCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([訂單編號] ASC)
);

