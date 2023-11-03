--database proyecto integrador SportsWorlds 


CREATE TABLE Tipo_usuario
(
  id_tipo_usuario INT PRIMARY KEY NOT NULL IDENTITY (0,1),
  descripcion VARCHAR(30) NOT NULL,

);
go

select * from Tipo_usuario

INSERT INTO Tipo_usuario (descripcion) VALUES ('VENDEDOR')
INSERT INTO Tipo_usuario (descripcion) VALUES ('ADMINISTRADOR')
INSERT INTO Tipo_usuario (descripcion) VALUES ('GERENTE')



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

INSERT INTO Tipo_pago (desc_tipo_pago) values ('EFECTIVO')
INSERT INTO Tipo_pago (desc_tipo_pago) values ('MERCADO PAGO')
select * from Tipo_pago

CREATE TABLE Proveedor
(
  id_proveedor INT NOT NULL PRIMARY KEY IDENTITY (0,1),
  nombre VARCHAR(30) NOT NULL,
  apellido VARCHAR(30) NOT NULL,
  razonsocial VARCHAR(30) NOT NULL,
  direccion VARCHAR(30) NOT NULL,
  correo VARCHAR(30) NOT NULL,
  nro_telefono INT NOT NULL,
  dni int

  CONSTRAINT UQ_DNI UNIQUE (dni)

);

select * from Proveedor

INSERT INTO Proveedor (nombre, apellido, razonsocial,direccion,correo,nro_telefono,dni) values ('jose','fernandez','josesito','independecia1234','user@gmail.com',1234,2508201)
INSERT INTO Proveedor (nombre, apellido, razonsocial,direccion,correo,nro_telefono,dni) values ('jose','fernandez','josesito','independecia1234','user@gmail.com',1234,2508202)
INSERT INTO Proveedor (nombre, apellido, razonsocial,direccion,correo,nro_telefono,dni) values ('jose','fernandez','josesito','independecia1234','user@gmail.com',1234,2508203)

SELECT * FROM Venta_detalle
CREATE TABLE Categoria
	(
	  id_categoria INT PRIMARY KEY NOT NULL IDENTITY (0,1),
	  descripcion VARCHAR(20) NOT NULL,

	);
	go

	INSERT INTO Categoria(descripcion) values ('REMERAS')
	INSERT INTO Categoria(descripcion) values ('SHORTS')
	INSERT INTO Categoria(descripcion) values ('PANTALONES')
	select * from Categoria


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
  estado_usuario NUMERIC NOT NULL,
  id_tipo_usuario INT NOT NULL,
  FOREIGN KEY (id_tipo_usuario) REFERENCES Tipo_usuario(id_tipo_usuario),
  CONSTRAINT UQ_USERNAME  UNIQUE (username),
  CONSTRAINT UQ_EMAIL  UNIQUE (email_usuario),
);
go
 INSERT INTO Usuario (nombre_usuario,apellido_usuario,username,dni_usuario,email_usuario,domicilio_usuario,celular_usuario,pass,fecha_creacion,estado_usuario,id_tipo_usuario) VALUES ('Augusto','Almiron','augusto01',1234,'user@gmail.com','laprida1234',37771923,'1234',getdate(),1,0)
 INSERT INTO Usuario (nombre_usuario,apellido_usuario,username,dni_usuario,email_usuario,domicilio_usuario,celular_usuario,pass,fecha_creacion,estado_usuario,id_tipo_usuario) VALUES ('Jose','Blanco','josesito1',1234,'user1@gmail.com','laprida1234',37771923,'1234',getdate(),1,1)
 INSERT INTO Usuario (nombre_usuario,apellido_usuario,username,dni_usuario,email_usuario,domicilio_usuario,celular_usuario,pass,fecha_creacion,estado_usuario,id_tipo_usuario) VALUES ('Micaela','Giovino','mica1',1234,'user2@gmail.com','laprida1234',37771923,'1234',getdate(),1,2)

 select * from Usuario
 drop table Venta_cabecera

CREATE TABLE Venta_cabecera
(
  id_cabecera INT NOT NULL,
  id_usuario INT NOT NULL,
  id_cliente INT NOT NULL,
  id_tipo_pago INT NOT NULL,
  fecha_Venta date not null, 
  PRIMARY KEY (id_cabecera),
  FOREIGN KEY (id_usuario) REFERENCES Usuario(id_usuario),
  FOREIGN KEY (id_cliente) REFERENCES Cliente(id_cliente),
  FOREIGN KEY (id_tipo_pago) REFERENCES Tipo_pago(id_tipo_pago)
);
go

CREATE TABLE Talle(
id_talle int primary key identity (0,1)not null,
descripcion varchar (20) not null
)
go

CREATE TABLE Producto
(
  id_talle int not null,
  id_producto int not null primary key identity (0,1),
  descripcion INT NOT NULL,
  precio_unitario FLOAT NOT NULL,
  stock INT NOT NULL,
  fecha_alta INT NOT NULL,
  id_categoria INT NOT NULL,
  id_proveedor INT NOT NULL,
  FOREIGN KEY (id_talle) REFERENCES  Talle (id_talle),
  FOREIGN KEY (id_categoria) REFERENCES Categoria(id_categoria),
  FOREIGN KEY (id_proveedor) REFERENCES Proveedor(id_proveedor)
);

select * from Producto
go

CREATE TABLE Venta_detalle
(

id_detalle int not null primary key identity (0,1),
id_cabecera int,
  cantidad_producto INT NOT NULL,
  nombre_producto varchar(100),
  id_producto INT NOT NULL,
  FOREIGN KEY (id_producto) REFERENCES Producto(id_producto),
  FOREIGN KEY (id_cabecera) REFERENCES Venta_cabecera(id_cabecera)
);

drop table Venta_detalle

go


SELECT * FROM Venta_Detalle

---PROCEDIMIENTOS ALMACENADOS PARA LOS ABM


create proc sp_listar_usuarios As
select * from Usuario
order by id_usuario
go
select * from Tipo_pago
create proc sp_buscar_usuarios
@dni_usuario int
As
select * from Usuario where @dni_usuario like @dni_usuario +'%'
go

create proc sp_mantenimiento_usuario
@id_usuario int,
@nombre_usuario char (100),
@apellido_usuario char (100),
@username varchar (100),
@dni_usuario int,
@email_usuario varchar (100),
@domicilio_usuario varchar (100),
@celular_usuario int,
@pass varchar (100),
@fecha_creacion date,
@estado_usuario numeric,
@id_tipo_usuario int,
@accion varchar (50) output
as
if(@accion = '1')
begin
	declare @id_nuevo int, @id_max int
	set @id_max = (select max(@id_usuario)from Usuario)
	set @id_max = isnull(@id_usuario,0)
	set @id_nuevo = @id_max + 1
	insert into Usuario (nombre_usuario,apellido_usuario,username,dni_usuario,email_usuario,domicilio_usuario,celular_usuario,pass,fecha_creacion,estado_usuario,id_tipo_usuario) values 
						(@nombre_usuario,@apellido_usuario,@username,@dni_usuario,@email_usuario,@domicilio_usuario,@celular_usuario,@pass,@fecha_creacion,@estado_usuario,@id_tipo_usuario)
	set @accion = 'se agrego el usuario'+@nombre_usuario 
end
else if (@accion = '2')
begin
	update Usuario  set nombre_usuario = @nombre_usuario, apellido_usuario = @apellido_usuario, username=@username, dni_usuario=@dni_usuario,email_usuario=@email_usuario,domicilio_usuario=@domicilio_usuario,celular_usuario=@celular_usuario,pass=@pass,estado_usuario=@estado_usuario,id_tipo_usuario=@id_tipo_usuario where dni_usuario = @dni_usuario
	set @accion = 'se modifico el usuario con el dni: '+@dni_usuario
end
else if (@accion = '3')
begin

	update Usuario set estado_usuario = 0 where @dni_usuario like @dni_usuario +'%'
	set @accion = 'Se elimino el usuario '+@username

end












/*
select* from Usuario
--listar clientes
Create proc sp_mostrar
as
select nombre_usuario,apellido_usuario,username,dni_usuario,email_usuario,domicilio_usuario,celular_usuario,fecha_creacion,estado_usuario,id_tipo_usuario from Usuario order by id_usuario
go


--buscar clientes
Create proc sp_buscar_usuarios
@nombre char (20)
as
select nombre_usuario,apellido_usuario,username,dni_usuario,email_usuario,domicilio_usuario,celular_usuario,fecha_creacion,estado_usuario,id_tipo_usuario from Usuario where nombre_usuario like @nombre +'%' 
go
 drop proc sp_listar_usuarios
--abm clientes


Create proc sp_abm_usuarios
@id_usuario  int,
@nombre_usuario char (20),
@apellido_usuario char(20),
@username varchar (100),
@dni_usuario int,
@email_usuario varchar (100),
@domicilio_usuario varchar (100),
@celular_usuario int,
@pass varchar (100),
@fecha_creacion date,
@estado_usuario numeric,
@id_tipo_usuario int,
@accion varchar (50)
as
if(@accion = '1')
begin
	declare @codnuevo int, @codmax int
	set @codnuevo = (select max (id_usuario) from Usuario)
	set @codmax = isnull(@codmax,0)
	set @codnuevo = @codmax + 1
	INSERT INTO Usuario (nombre_usuario,apellido_usuario,username,dni_usuario,email_usuario,domicilio_usuario,celular_usuario,pass,fecha_creacion,estado_usuario,id_tipo_usuario) 
	VALUES				(@nombre_usuario,@apellido_usuario,@username,@dni_usuario,@email_usuario,@domicilio_usuario,@celular_usuario,@pass,@fecha_creacion,@estado_usuario,@id_tipo_usuario)
	set @accion ='El Usuario: '+ @nombre_usuario+' '+@apellido_usuario+' se inserto correctamente!'
end
else if (@accion = '2')
begin
	update Usuario set nombre_usuario = @nombre_usuario, apellido_usuario =@apellido_usuario, dni_usuario =@dni_usuario, email_usuario =@email_usuario,domicilio_usuario=@domicilio_usuario,celular_usuario=@celular_usuario,id_tipo_usuario=@id_tipo_usuario where id_usuario = @id_usuario
	set @accion = 'Se modificio el usuario'+@nombre_usuario
end
else if (@accion ='3')
begin
update Usuario set estado_usuario = 0 where id_usuario=@id_usuario
set @accion = 'Se elimino el usuario '+@nombre_usuario+' '+@apellido_usuario
end*/
