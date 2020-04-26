USE TALLER 
drop table Productos
create table Productos 
				( IDProducto int , 
				Nombre varchar(50),
				Descripcion varchar(50),
				Precio int ,
				Stock int,
				primary key (IDProducto)
				);