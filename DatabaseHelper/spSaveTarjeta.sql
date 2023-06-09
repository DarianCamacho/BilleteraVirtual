USE [BilleteraVirtual]
GO
/****** Object:  StoredProcedure [dbo].[spSaveTarjeta]    Script Date: 6/5/2023 07:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spSaveTarjeta]
(
		@Foto				NVARCHAR(MAX),
		@Banco				NVARCHAR(50),
		@Emisor				NVARCHAR(50),
		@Dueno				NVARCHAR(100),
		@NumeroTarjeta		NVARCHAR(16),
		@CodigoCVV			NVARCHAR(3),
		@FechaExpiracion	DATETIME
)
AS
BEGIN
	INSERT INTO Tarjetas
		(Foto,
      Banco,
      Emisor,
      Dueno,
      NumeroTarjeta,
      CodigoCVV,
      FechaExpiracion)

	VALUES (@Foto,
      @Banco,
      @Emisor,
      @Dueno,
      @NumeroTarjeta,
      @CodigoCVV,
      @FechaExpiracion)
END