USE [BP2Bolnica]
GO
/****** Object:  Trigger [dbo].[DodajZaposlenog]    Script Date: 06/12/2022 18:11:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[DodajZaposlenog]
ON [dbo].[Zaposleni]
FOR INSERT
AS
DECLARE @idZaposlenog INT;
DECLARE @tipZaposlenog VARCHAR(255);

SELECT @idZaposlenog = i.idZaposlenog FROM INSERTED i;
SELECT @tipZaposlenog = i.tipZaposlenog FROM INSERTED i;

IF @tipZaposlenog = 'ZdravstveniRadnik'
	INSERT INTO ZdravstveniRadnik VALUES(@idZaposlenog, @idZaposlenog * 111, '');

IF @tipZaposlenog = 'Obezbedjenje'
	INSERT INTO Obezbedjenje VALUES (@idZaposlenog, 0);

IF @tipZaposlenog = 'Spremacica'
	INSERT INTO Spremacica VALUES (@idZaposlenog, 1);

PRINT 'AFTER INSERT INTO Zaposleni TRIGGER ACTIVATED';
GO