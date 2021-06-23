
USE [BeogradskaFilharmonijaModel]
GO
/****** Object:  Trigger [dbo].[Update_Statistics]    Script Date: 22.6.2021. 20:41:06 ******/
SET ANSI_NULLS ON
GO

CREATE TRIGGER NegativnaaVrednost ON [dbo].[kartaSet]
FOR INSERT 
NOT FOR REPLICATION 
AS
 
BEGIN
  INSERT INTO [BeogradskaFilharmonijaModel].[dbo].[Statistic]
  SELECT AVG(cen)
    ,getdate()
  FROM kartaSet
END;