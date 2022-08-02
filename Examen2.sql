create database Examens2db

create table Clientes
(
	
	Cedula varchar(20) primary key,
	Nombre varchar(50) not null,
	Telefono varchar(15) not null,
	Direccion varchar(50) not null,
	Monto money,
	Descuento money,
	Subtotal money,
	Iva money,
	Total money,

)


create proc sp_guardar

@nombre varchar(50),
@cedula varchar(20),
@telefono varchar(15),
@direccion varchar(50),
@monto money,
@descuento money,
@iva money,
@subtotal money,
@total money
	as
		begin 
		insert into Clientes (Nombre,Cedula,Telefono,Direccion,Monto,Descuento,Iva,Subtotal,Total)
		values(@nombre, @cedula, @telefono, @direccion,@monto,@descuento,@iva,@subtotal,@total)
		end

select * from Clientes
