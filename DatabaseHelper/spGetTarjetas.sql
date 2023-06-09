USE [BilleteraVirtual]
GO
/****** Object:  StoredProcedure [dbo].[GetTarjetas]    Script Date: 4/5/2023 21:25:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[GetTarjetas]
AS
BEGIN
    SELECT Id, Foto, Banco, Emisor, Dueno, RIGHT(NumeroTarjeta, 4) AS UltimosDigitos, FechaExpiracion
    FROM Tarjetas
END