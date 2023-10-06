use proyecto_taller2
CREATE TABLE Tipo_usuario(
	id_tipo_usuario int primary key  identity(0,1) not null CHECK (id_tipo_usuario >=0 AND id_tipo_usuario <=2),
	descripcion varchar (100) not null,

)
create table Proveedor (
	id_proveedor int primary key identity,
	nombre varchar (100),
	razon_social varchar (50),
	correo varchar (50),
	estado bit,
	fecha_creacion datetime default getdate(),
)



create table Compra (
	id_compra int primary key identity not null,
	id_proveedor int references Proveedor(id_proveedor) not null,
	descripcion varchar (100),
	fecha_alta_compra datetime default getdate(),
)
create table Categoria (
	id_categoria int primary key identity not null,
	descripcion varchar (100),
	estado bit,
)
create table Producto (
	id_producto int primary key identity,
	id_categoria int references Categoria(id_categoria),
	precio_unitario float not null,
	stock int not null CHECK (stock >= 0),
	descripcion varchar (100),
	estado bit,
	fecha_creacion datetime default getdate(),
)
CREATE TABLE Venta_detalle(
	id_venta int primary key identity not null,
	id_producto int references Producto(id_producto),	
	descripcion varchar (100),
)


create table Usuario (
	id_usuario int primary key identity,
	id_tipo_usuario int references Tipo_usuario(id_tipo_usuario),
	id_venta int references Venta_detalle(id_venta),
	id_compra int references Compra(id_compra),
	nombre varchar (100) not null,
	apellido varchar (50)not null,
	correo varchar (50)not null,
	password varchar (50) not null,	
	estado bit  not null,
	fecha_creacion datetime default getdate(),
)





CREATE TABLE Cliente (
	id_cliente int primary key identity,
	nombre_cliente varchar (100) not null,
	apellido_cliente varchar (50) not null,
	correo_cliente varchar (50),
	estado_cliente bit,
	fecha_creacion datetime default getdate(),
)




CREATE TABLE Venta_cabecera(
	id_cabecera int primary key identity NOT NULL,
	id_usuario int references Usuario(id_usuario),	
	id_cliente int references Cliente (id_cliente),
	fecha_venta datetime default getdate(),
)


drop table Tipo_usuario

select * from Usuario 

INSERT INTO Usuario(id_tipo_usuario,id_venta,id_compra,nombre,apellido,correo,pass,estado,fecha_creacion,dni,username)VALUES(2,null,null,'augusto','almiron','user@gmial.com','1234',1,getdate(),42791957,'augusto01')
INSERT INTO Usuario(id_tipo_usuario,id_venta,id_compra,nombre,apellido,correo,pass,estado,fecha_creacion,dni,username)VALUES(null,null,null,'jose','almiron','user@gmial.com','1234',1,getdate(),12345,'josesito1')
INSERT INTO Usuario(id_tipo_usuario,id_venta,id_compra,nombre,apellido,correo,pass,estado,fecha_creacion,dni,username)VALUES(null,null,null,'Micaela','disalvo','user@gmial.com','1234',1,getdate(),1234567,'mica01')
INSERT INTO Usuario(id_tipo_usuario,id_venta,id_compra,nombre,apellido,correo,pass,estado,fecha_creacion,dni,username)VALUES(null,null,null,'Agostina','perez','user@gmial.com','1234',1,getdate(),8998,'agos01')
INSERT INTO Usuario(id_tipo_usuario,id_venta,id_compra,nombre,apellido,correo,pass,estado,fecha_creacion,dni,username)VALUES(null,null,null,'Raul','almiron','user@gmial.com','1234',1,getdate(),12312,'raulito01')
select * from Usuario

DELETE from Usuario where id_usuario =2 

INSERT INTO Tipo_Usuario (descripcion)  VALUES ('Administrador')
INSERT INTO Tipo_Usuario (descripcion)  VALUES ('Empleado')
INSERT INTO Tipo_Usuario (descripcion)  VALUES ('Gerente')

select * from Usuario


INSERT INTO Usuario(id_tipo_usuario,nombre,apellido,correo,pass,estado,fecha_creacion,dni,username)VALUES(2,'augusto','almiron','user@gmial.com','1234',1,getdate(),42791957,'augusto01')

INSERT INTO Usuario (id_tipo_usuario,nombre,apellido,correo,estado,fecha_creacion,dni,username,pass,cel) values(2,'nombre','apellido','correo',1,getdate(),1234,'user01','pass')

alter table Usuario add cel int

delete from Usuario  where (id_usuario < 20)
            
			select * from Usuario
			select * from tipo_usuario


			select * from tipo