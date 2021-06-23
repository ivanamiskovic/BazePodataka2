CREATE PROCEDURE Selectvelsce @Min float
AS
SELECT * FROM salaSet WHERE salaSet.velsce > @Min;
GO

EXEC Selectvelsce @Min = 70;
