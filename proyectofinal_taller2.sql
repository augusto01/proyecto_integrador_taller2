--database proyecto integrador SportsWorlds 

CREATE DATABASE proyectotaller2_final
use proyectotaller2_final
CREATE TABLE Tipo_usuario
(
  id_tipo_usuario INT PRIMARY KEY NOT NULL IDENTITY (0,1),
  descripcion VARCHAR(30) NOT NULL,

);
go

CREATE TABLE Cliente
(
  id_cliente INT PRIMARY KEY NOT NULL IDENTITY (0,1),
  nombre_cliente CHAR(20) ,
  apellido_cliente CHAR(20) ,
  dni_cliente INT,
  email_cliente VARCHAR(50),
  domicilio_cliente VARCHAR(50),
  celular_cliente INT ,
);
go


CREATE TABLE Tipo_pago
(
  id_tipo_pago INT PRIMARY KEY NOT NULL IDENTITY (0,1),
  desc_tipo_pago VARCHAR(100) NOT NULL,
);
go

CREATE TABLE Talle(
id_talle int primary key not null IDENTITY (0,1),
descripcion varchar (30)


)


CREATE TABLE Proveedor
(
  id_proveedor INT NOT NULL PRIMARY KEY IDENTITY (0,1),
  nombre VARCHAR(30) NOT NULL,
  apellido varchar (30) not null ,
  razonsocial VARCHAR(30) NOT NULL,
  direccion VARCHAR(30) NOT NULL,
  correo VARCHAR(30) NOT NULL,
  nro_telefono INT NOT NULL,
  dni int not null,
  estado bit not null

);
go



CREATE TABLE Categoria
	(
	  id_categoria INT PRIMARY KEY NOT NULL IDENTITY (0,1),
	  descripcion VARCHAR(20) NOT NULL,

	);
	go




CREATE TABLE Usuario
(
  id_usuario INT NOT NULL PRIMARY KEY IDENTITY (0,1),
  nombre_usuario CHAR(20) NOT NULL,
  apellido_usuario CHAR(20) NOT NULL,
  username varchar (100) not null,
  dni_usuario INT NOT NULL,
  email_usuario VARCHAR (100)NOT NULL,
  domicilio_usuario VARCHAR(100) NOT NULL,
  celular_usuario INT,
  pass VARCHAR (100)NOT NULL,
  fecha_creacion DATE NOT NULL,
  estado_usuario bit NOT NULL,
  id_tipo_usuario INT NOT NULL,
  FOREIGN KEY (id_tipo_usuario) REFERENCES Tipo_usuario(id_tipo_usuario),
  CONSTRAINT UQ_USERNAME  UNIQUE (username),
  CONSTRAINT UQ_EMAIL  UNIQUE (email_usuario),
);


CREATE TABLE Venta_cabecera
(
  id_cabecera INT NOT NULL identity (0,1),
  id_usuario INT NOT NULL,
  id_cliente INT NOT NULL,
  id_tipo_pago INT NOT NULL,
  fecha_venta date,
  PRIMARY KEY (id_cabecera),
  FOREIGN KEY (id_usuario) REFERENCES Usuario(id_usuario),
  FOREIGN KEY (id_cliente) REFERENCES Cliente(id_cliente),
  FOREIGN KEY (id_tipo_pago) REFERENCES Tipo_pago(id_tipo_pago)
);

go
CREATE TABLE Producto
(
  id_producto int not null primary key identity (0,1),
  descripcion varchar (50) NOT NULL,
  precio_unitario FLOAT NOT NULL,
  stock INT NOT NULL,
  fecha_alta date NOT NULL,
  id_categoria INT NOT NULL,
  id_proveedor INT NOT NULL,
  id_talle int not null
  FOREIGN KEY (id_categoria) REFERENCES Categoria(id_categoria),
  FOREIGN KEY (id_proveedor) REFERENCES Proveedor(id_proveedor),
  estado bit not null
);


Create table Compra(

id_compra int not null primary key identity (0,1),
id_producto int not null,
id_usuario int not null

 FOREIGN KEY (id_producto)REFERENCES Producto(id_producto),
  FOREIGN KEY (id_usuario)REFERENCES Usuario(id_usuario),

)


CREATE TABLE Venta_detalle
(
id_detalle int not null primary key identity (0,1),
id_cabecera int not null,
 cantidad_producto INT NOT NULL,
 id_producto INT NOT NULL,
   subtotal float not null,
   total float not null,
  FOREIGN KEY (id_producto) REFERENCES Producto(id_producto),
  FOREIGN KEY (id_cabecera) REFERENCES Venta_cabecera(id_cabecera)
);
go

SELECT * FROM Tipo_usuario
--LOTE DE DATOS 

--TIPO DE USUARIO
INSERT INTO Tipo_usuario (descripcion) VALUES ('EMPLEADO')
INSERT INTO Tipo_usuario (descripcion) VALUES ('ADMINISTRADOR')
INSERT INTO Tipo_usuario (descripcion) VALUES ('GERENTE')

select * from Usuario


--USUARIO
INSERT INTO Usuario (nombre_usuario,apellido_usuario,username,dni_usuario,email_usuario,domicilio_usuario,celular_usuario,pass,fecha_creacion,estado_usuario,id_tipo_usuario) VALUES ('Augusto','Almiron','augusto01',1234,'user@gmail.com','laprida1234',37771923,'03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4',getdate(),1,0)
INSERT INTO Usuario (nombre_usuario,apellido_usuario,username,dni_usuario,email_usuario,domicilio_usuario,celular_usuario,pass,fecha_creacion,estado_usuario,id_tipo_usuario) VALUES ('Jose','Blanco','josesito1',12345,'user1@gmail.com','laprida1234',37771923,'03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4',getdate(),1,1)
INSERT INTO Usuario (nombre_usuario,apellido_usuario,username,dni_usuario,email_usuario,domicilio_usuario,celular_usuario,pass,fecha_creacion,estado_usuario,id_tipo_usuario) VALUES ('Micaela','Giovino','mica1',123456,'user2@gmail.com','laprida1234',37771923,'03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4',getdate(),1,2)
 --TIPO PAGO
INSERT INTO Tipo_pago (desc_tipo_pago) values ('EFECTIVO')
INSERT INTO Tipo_pago (desc_tipo_pago) values ('MERCADO PAGO')


--CLIENTE
insert into Cliente (nombre_cliente) VALUES ('CONSUMIDOR FINAL')
alter table Cliente add estado bit

--PROVEEDOR
select * from Proveedor

INSERT INTO Proveedor(nombre,apellido,razonsocial,direccion,correo,nro_telefono,dni) VALUES ('Jose' , 'Perez', 'La chiquita', 'Laprida1234', 'proveedor1@gmail.com',12345,1234)
INSERT INTO Proveedor(nombre,apellido,razonsocial,direccion,correo,nro_telefono,dni) VALUES ('Martina' , 'Disalvo', 'productora SRL', 'INDEPENDENCIA 123', 'proveedor2@gmail.com',12345,1235)
INSERT INTO Proveedor(nombre,apellido,razonsocial,direccion,correo,nro_telefono,dni) VALUES ('Gerardo' , 'Martines', 'El macanudo SRL', 'Chacabuco 333', 'proveedor3@gmail.com',12345,1236)

--TALLE
insert into Talle (descripcion) values ('42')
insert into Talle (descripcion) values ('41')
insert into Talle (descripcion) values ('40')
insert into Talle (descripcion) values ('42')
insert into Talle (descripcion) values ('S')
insert into Talle (descripcion) values ('M')
insert into Talle (descripcion) values ('L')
insert into Talle (descripcion) values ('XL')

--CATEGORIA

INSERT Categoria (descripcion) VALUES ('REMERAS')
INSERT Categoria (descripcion) VALUES ('MEDIAS')
INSERT Categoria (descripcion) VALUES ('ZAPATILLAS')
--PRODUCTO

INSERT INTO Producto (descripcion,precio_unitario,stock,fecha_alta,id_categoria,id_proveedor,id_talle,estado) VALUES ('REMERA NIKE',1500,1000,GETDATE(),0,1,2,1)
INSERT INTO Producto (descripcion,precio_unitario,stock,fecha_alta,id_categoria,id_proveedor,id_talle,estado) VALUES ('ZAPATILLA PUMA',1500,1000,GETDATE(),2,2,3,1)
INSERT INTO Producto (descripcion,precio_unitario,stock,fecha_alta,id_categoria,id_proveedor,id_talle,estado) VALUES ('MEDIA SEELE',1500,1000,GETDATE(),1,0,1,1)




--PROCEDIMIENTOS ALMACENADOS PARA INFORMES 



create proc DashboardDatos 
@totVentas decimal out,
@nprod int out,
@ncliente int out,
@nprov int out,
@ncantidadventas int out,
@nempleado int out
as
SET @totVentas = (select SUM(total) as TotalVentas from Venta_detalle)
set @nprod = (select count (id_producto) from Producto)
set @nempleado = (select count (id_usuario) from Usuario)
set @ncliente = (select count (id_cliente) from Cliente)
set @nprov = (select count (id_proveedor) from Proveedor)
set @ncantidadventas = (select count (id_cabecera) from Venta_cabecera)
go


create proc productos_preferidos 
as
	SELECT top 5 pro.id_producto, count (vd.id_producto) as 'Veces Vendidas',pro.descripcion 'Producto' from Venta_detalle as vd

	INNER JOIN Producto pro on  pro.id_producto = vd.id_producto
	group by pro.id_producto, pro.descripcion
	order by count (2)desc

	
go

select * from Usuario


productos_preferidos

--PRODUCTOS POR CATEGORIA
create proc productos_por_categoria 
as
	select cat.descripcion as 'Descripcion', count (Producto.id_categoria) as Cant from Producto
	INNER JOIN Categoria cat on   cat.id_categoria = Producto.id_categoria
	group by  cat.descripcion
	order by  count (Producto.id_categoria) DESC
go


select * from Usuario