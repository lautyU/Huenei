USE [Taller]
IF OBJECT_ID ('selectProductos','P') IS NOT NULL 
DROP PROCEDURE selectProductos;
GO
CREATE PROCEDURE selectProductos
AS
BEGIN
	SELECT * FROM dbo.productos 
	ORDER BY IDProducto DESC
END




