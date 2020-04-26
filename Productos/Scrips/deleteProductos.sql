USE [Taller]
IF OBJECT_ID ('deleteProductos','P') IS NOT NULL 
DROP PROCEDURE deleteProductos;
GO
CREATE PROCEDURE deleteProductos
(
	@id int
)
AS
BEGIN
	DELETE FROM dbo.productos
	WHERE IDProducto = @id
END