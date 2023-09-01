use proyecto_taller2
create table Rol(
	id_rol int primary key identity,
	descripcion varchar (50),
	fecha_creacion datetime default getdate()
)

create table Permiso(
	id_permiso int primary key identity not null,
	id_rol int references Rol(id_rol),
	nombre_menu varchar (100),
	fechacreacion datetime default getdate()
)

create table Proveedor (
	id_proveedor int primary key identity,
	nombre varchar (100),
	razon_social varchar (50),
	correo varchar (50),
	estado bit,
	fecha_creacion datetime default getdate(),
)

create table Usuario (
	id_usuario int primary key identity,
	id_rol int references Rol(id_rol),
	nombre varchar (100),
	apellido varchar (50),
	correo varchar (50),
	password varchar (50),	
	estado bit,
	fecha_creacion datetime default getdate(),
)

create table Compra (
	id_compra int primary key identity,
	id_usuario int references Usuario(id_usuario),
	id_proveedor int references Proveedor(id_proveedor),
	descripcion varchar (100),
	estado bit,
	fecha_creacion datetime default getdate(),
)
create table Categoria (
	id_categoria int primary key identity,
	descripcion varchar (100),
	estado bit,
)

create table Producto (
	id_producto int primary key identity,
	id_categoria int references Categoria(id_categoria),
	precio_unitario int references usuario(id_usuario)not null,
	
	descripcion varchar (100),
	estado bit,
	fecha_creacion datetime default getdate(),
)

create table Venta (
	id_producto int primary key identity,
	id_usuario int references Usuario (id_usuario),

	
	descripcion varchar (100),
	estado bit,
	fecha_creacion datetime default getdate(),
)
