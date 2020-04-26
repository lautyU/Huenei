USE [Taller]
IF OBJECT_ID ('updateProductos','P') IS NOT NULL 
DROP PROCEDURE updateProductos;
GO
CREATE PROCEDURE updateProductos
(
	@id int,
	@nombre VARCHAR(50),
	@descrip VARCHAR(50),
	@precio int,
	@stock int
)
AS
BEGIN
	UPDATE dbo.productos 
	SET Nombre= @nombre,Descripcion=@descrip,Precio=@precio,Stock=@stock
	WHERE IDProducto = @id
END