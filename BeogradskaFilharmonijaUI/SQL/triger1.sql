CREATE TRIGGER Update_Statistics ON kartaSet
FOR INSERT 
NOT FOR REPLICATION 
AS
 
BEGIN
  INSERT INTO [BeogradskaFilharmonijaModel].[dbo].[Statistic]
  SELECT sum(cen)
    ,getdate()
  FROM kartaSet
END