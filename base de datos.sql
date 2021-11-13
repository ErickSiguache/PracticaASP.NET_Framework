create table Productos(
id_producto int identity(1,1) not null,
FechaProduc varchar(100),
Categoria varchar(100),
Talla varchar(100),
Color varchar(100),
Descripcion varchar(200),
Cantidad int,
primary key (id_producto));