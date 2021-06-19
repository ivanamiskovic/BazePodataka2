CREATE PROCEDURE SelectKartaCena @Limit float
AS
SELECT * FROM kartaSet WHERE kartaSet.cen > @Limit;
GO

EXEC SelectKartaCena @Limit = 54