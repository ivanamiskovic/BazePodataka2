DROP TRIGGER IF EXISTS koncertSet_insert;
GO
CREATE TRIGGER koncertSet_insert ON koncertSet INSTEAD OF INSERT
AS BEGIN
    DECLARE @nazkon nvarchar(max);
    DECLARE @znrmuzik nvarchar(max);
    DECLARE @traj  decimal(18,0);
    SELECT @nazkon = nazkon, @znrmuzik = znrmuzik, @traj = traj FROM INSERTED;
    IF @nazkon IS NULL SET @nazkon = @znrmuzik;
    IF @znrmuzik IS NULL SET @znrmuzik= @nazkon;
    INSERT INTO koncertSet (nazkon, znrmuzik, traj) VALUES (@nazkon, @znrmuzik, @traj);
END;

SELECT * FROM koncertSet;
INSERT INTO koncertSet(znrmuzik, traj) VALUES ('Pop', '33');
SELECT * FROM koncertSet;