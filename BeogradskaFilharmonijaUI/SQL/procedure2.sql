CREATE PROCEDURE SelectBrClanova @Max float
AS
SELECT * FROM orkestarSet WHERE orkestarSet.brclan > @Max;
GO

EXEC SelectBrClanova @Max = 668;
