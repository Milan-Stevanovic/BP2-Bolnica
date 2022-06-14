CREATE PROCEDURE ProracunProsecnePlate
@PlataProsek decimal(10, 3) OUTPUT
AS
SELECT @PlataProsek = AVG(plataZ) FROM Zaposleni;
GO
DECLARE @Rezultat decimal(10, 3);
EXEC ProracunProsecnePlate @PlataProsek = @Rezultat OUTPUT;
PRINT 'Prosecna plata svih zaposlenih je: ' + CAST(@Rezultat AS VARCHAR(10));
GO