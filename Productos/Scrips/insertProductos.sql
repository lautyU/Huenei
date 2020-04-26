USE [Taller]
IF OBJECT_ID ('insertProductos','P') IS NOT NULL 
DROP PROCEDURE insertProductos;
GO
CREATE PROCEDURE insertProductos
(
	@nombre VARCHAR(50),
	@descrip VARCHAR(50),
	@precio int,
	@stock int
)
AS
BEGIN
	INSERT INTO dbo.productos (Nombre,Descripcion,Precio,Stock) 
	VALUES(@nombre,@descrip,@precio,@stock)
END