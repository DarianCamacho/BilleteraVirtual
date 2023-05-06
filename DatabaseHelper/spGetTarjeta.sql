USE [BilleteraVirtual]
GO
/****** Object:  StoredProcedure [dbo].[GetTarjeta]    Script Date: 5/5/2023 20:34:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[GetTarjeta]
AS
BEGIN
	SELECT Foto, Banco, Emisor, Dueno, NumeroTarjeta, FechaExpiracion
	FROM Tarjetas
END