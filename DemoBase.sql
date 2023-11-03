use master
create database Prueba_1
use Prueba_1

--------------------------Creacion de tablas de la base---------------------------
create table pacientes
(
	codPaciente char(7) not null,
	primerNombre varchar(20) not null,
	segundoNombre varchar(20) null,
	primerApellido varchar(20) not null,
	segundoApellido varchar(20) null,
	direccion varchar(200),
	telefono char(9),
	sexo char(1) not null,
	fechaNacimiento date not null,
	dui char(10),
	nit char(17),

)

create table recetas
(
	codReceta char(7) not null,
	--codMedico char(7) not null,
	--codPaciente char(7) not null,
	fechaEmitida date,
	codReporte char(7) not null
)

create table medicos
(
	codMedico char(7) not null,
	primerNombre varchar(20) not null,
	primerApellido varchar(20) not null,
	telefono char(9) not null,
	especialidad varchar(50) not null
)

create table medicamentos
(
	--codMedicamento char(7) not null,
	codReceta char(7) not null,
	nombreMedicamento varchar(20) not null,
	indicaciones varchar(200) not null
)

create table citasMedicas
(
	codCita char(7) not null,
	codPaciente char(7) not null,
	codMedico char(7) not null,
	fechaHora datetime
)

create table reportes
(
	codReporte char(7) not null,
	codCita char(7) not null,
	motivo varchar(500) not null,
	diagnostico varchar(1000) not null
)

create table signosVitales
(
	codReporte char(7) not null,
	peso numeric(5,2),
	talla numeric (5,2),
	temperatura numeric(3,1),
	presionArterial varchar(8)
)

-------------------------------------Fin de la creación de tablas-------------------------------------


-------------------------------------Primary keys-------------------------------------

--Tabla paciente
alter table pacientes
add constraint pk_codPaciente
primary key (codPaciente)

--Tabla Medico
alter table medicos
add constraint pk_codMedico
primary key (codMedico)

--Tabla receta
alter table recetas
add constraint pk_codReceta
primary key (codReceta)

--tabla citaMedica
alter table citasMedicas
add constraint pk_codCita
primary key (codCita)

--Tabla reporte
alter table reportes
add constraint pk_codReporte
primary key (codReporte)

-------------------------------------Fin de las primary keys-------------------------------------


-------------------------------------Foreign keys-------------------------------------

--Tabla receta
alter table recetas
add constraint fk_codReporetR
foreign key (codReporte)
references  reportes(codReporte)

--Tabla medicamento
alter table medicamentos
add constraint fk_codRecetaM
foreign key (codReceta)
references  recetas(codReceta)
on delete cascade
on update cascade

--Tabla cita
alter table citasMedicas
add constraint fk_codPacienteC
foreign key (codPaciente)
references  pacientes(codPaciente)
on delete cascade
on update cascade

--Tabla
alter table citasMedicas
add constraint fk_codMedicoC
foreign key (codMedico)
references  medicos(codMedico)

--Tabla reporte
alter table reportes
add constraint fk_codCitaR
foreign key (codCita)
references  citasMedicas(codCita)
on delete cascade
on update cascade

--Tabla signosVitales
alter table signosVitales
add constraint fk_codReporteSV
foreign key (codReporte)
references  reportes(codReporte)
on delete cascade
on update cascade

-------------------------------------Fin de las foreign keys-------------------------------------


-------------------------------------Restricciones-------------------------------------

alter table recetas
add constraint df_fechaEmitida
default getdate() for fechaEmitida

alter table citasMedicas
add constraint ch_fechaHora
check (fechaHora >= getdate())

alter table signosVitales
add constraint ch_peso
check (peso >=0 and peso<=999)

alter table signosVitales
add constraint ch_talla
check (talla >=0 and talla <=3)

alter table signosVitales
add constraint ch_temperatura
check (talla >=0 and talla <= 45)

-------------------------------------Fin de las resticciones-------------------------------------


-------------------------------------Extras necesarios-------------------------------------

--Edad calculada tabla paciente
ALTER TABLE pacientes
ADD edad
    AS (CONVERT(INT,CONVERT(CHAR(8),GETDATE(),112))-CONVERT(CHAR(8),fechaNacimiento,112))/10000;

--Hora calculada tabla cita medica

ALTER TABLE citasMedicas
ADD hora
    AS RIGHT( CONVERT(DATETIME, fechahora, 108),8) 

-------------------------------------Fin de los extras-------------------------------------


-------------------------------------Procedimientos almacenados-------------------------------------


---------Procedimiento almacenado pacientes---------

create procedure InscribirPaciente(
--Datos que van a entrar
@pnom varchar(20),
@snom varchar(20), 
@pape varchar(20), 
@sape varchar(20), 
@dir varchar(200),
@tel char(9),
@sex char(1),
@fecha date,
@dui char(10),
@nit char(17))
as
--Armando el codigo
declare @l1 char(1)
declare @l2 char(1)
declare @n1 int
declare @l3 char(4)
declare @cod char(7)

set @n1 = (select count(codPaciente) from pacientes) +1

if (@n1 < 10)

begin
set @l3 = '000'+trim(str(@n1))
end

else if (@n1 >=10 and @n1 < 100)
begin
set @l3 = '00'+trim(str(@n1))
end

else if (@n1 >=100 and @n1 <1000)
begin
set @l3 = '0'+trim(str(@n1))
end

else if (@n1 >=1000)
begin
set @l3 = trim(str(@n1))
end

set @l1 = SUBSTRING(@pape,1,1)
set @l2 = SUBSTRING(@pnom,1,1)

set @cod = 'P'+@l1+@l2+@l3

insert into pacientes (codPaciente,primerNombre,segundoNombre,primerApellido,segundoApellido,direccion,telefono,sexo,fechaNacimiento,dui,nit)
values (@cod,@pnom,@snom,@pape,@sape,@dir,@tel,@sex,@fecha,@dui,@nit)

---------fin del Procedimiento Almacenado---------


---------Procedimiento almacenado médico---------
create procedure InscribirMedico
(
@pnom varchar(20),
@pape varchar(20),
@tel char(9),
@esp varchar(50)
)
as
declare @l1 char(1)
declare @l2 char(1)
declare @n1 int
declare @l3 char(4)
declare @cod char(7)

set @n1 = (select count(codMedico) from medicos) +1

if (@n1 < 10)

begin
set @l3 = '000'+trim(str(@n1))
end

else if (@n1 >=10 and @n1 < 100)
begin
set @l3 = '00'+trim(str(@n1))
end

else if (@n1 >=100 and @n1 <1000)
begin
set @l3 = '0'+trim(str(@n1))
end

else if (@n1 >=1000)
begin
set @l3 = trim(str(@n1))
end

set @l1 = SUBSTRING(@pape,1,1)
set @l2 = SUBSTRING(@pnom,1,1)

set @cod = 'M'+@l1+@l2+@l3

insert into medicos(codMedico,primerNombre,primerApellido,telefono,especialidad) values
(@cod,@pnom,@pape,@tel,@esp)

---------fin del Procedimiento Almacenado---------


---------Procedimiento almacenado cita médica---------
create procedure IngresarCita
(
@codP char(7),
@codM char(7),
@fechaH datetime
)
as
declare @l1 char(1)
declare @l2 char(1)
declare @n1 int
declare @l3 char(4)
declare @cod char(7)

set @l1 = substring((select primerApellido from pacientes  where codPaciente like @codP),1,1)
set @l2 = substring((select primerNombre from pacientes  where codPaciente like @codP),1,1)

set @n1 = (select count(codCita) from citasMedicas where codPaciente like @codP) +1

if (@n1 < 10)
begin
set @l3 = '000'+trim(str(@n1))
end

else if (@n1 >=10 and @n1 < 100)
begin
set @l3 = '00'+trim(str(@n1))
end

else if (@n1 >=100 and @n1 <1000)
begin
set @l3 = '0'+trim(str(@n1))
end

else if (@n1 >=1000)
begin
set @l3 = trim(str(@n1))
end

set @cod = 'C'+@l1+@l2+@l3

insert into citasMedicas(codCita,codPaciente,codMedico,fechaHora) values
(@cod,@codP,@codM,@fechaH)

---------fin del Procedimiento Almacenado---------


---------Procedimiento almacenado reporte---------

create procedure CrearReporte
(
	@codcita char(7),
	@mot varchar(500),
	@diag varchar(1000),
	@peso numeric(5,2),
	@tal numeric (5,2),
	@temp numeric(3,1),
	@presi varchar(8)
)
as

declare @cod char(7)
set @cod = 'R'+SUBSTRING(@codcita,2,6)

insert into reportes(codReporte,codCita,motivo,diagnostico) values
(@cod,@codcita,@mot,@diag)

insert into signosVitales(codReporte,peso,talla,temperatura,presionArterial) values
(@cod,@peso,@tal,@temp,@presi)

---------fin del Procedimiento Almacenado---------


---------Procedimiento almacenado receta---------
create procedure CrearReceta
(
	@codRe char(7),
	@fecha date
)
as
declare @cod char(7)
set @cod = 'E'+SUBSTRING(@codRE,2,6)

insert into recetas(codReceta,codReporte,fechaEmitida) values
(@cod,@codRe,@fecha)

---------fin del Procedimiento Almacenado---------


---------Procedimiento almacenado medicamento---------
create procedure AgregarMedicamento
(
	@codR char(7),
	@nom varchar(20),
	@indi varchar(200)
)
as

insert into medicamentos(codReceta,nombreMedicamento,indicaciones) values
(@codR,@nom,@indi)
---------fin del Procedimiento Almacenado---------


-------------------------------------Valores de prueba-------------------------------------


--Pacientes--

--Asi se usan los procedimientos almacenados, solo los mandas a llamar y le pasas el dato
--Es más sencillo para conectarlo con el programa, y es la única forma de que se creen los códigos
--Es IMPORTANTE que se usen

exec InscribirPaciente 'Rodrigo','Alexis','Mejia','Rivas','Colonia quien sabe donde','7070-6060','M','2005/04/25','00000000-0','0000-000000-000-0'

--Como en las consultas, se les puede pasar valores nulos y no pasa nada, siempre y cuando no exista una restriccion not null en el campo
exec InscribirPaciente 'Valeria','Lizeth','Paredes','Lara','Casa tal de la colonia tal en tal lugar','7070-6060','F','2004/06/24',null,'0000-000000-000-0'


--Medicos--
exec InscribirMedico 'Agustin','Laje','7070-9090','Medicina General'

exec InscribirMedico 'Donald','Trump','7070-9090','Ginecologia'

--Citas medicas--
exec IngresarCita 'PMR0001','MLA0001','2023-11-03 07:30:00'

exec IngresarCita 'PMR0001','MLA0001','2023-12-05 08:15:00'

exec IngresarCita 'PPV0002','MLA0001','2023-12-10 10:30:00'

exec IngresarCita 'PPV0002','MLA0001','2023-12-13 10:30:00'


--Reporte--
--En cuanto al reporte, se tienen que pasar los datos del reporte, y los datos de los signos vitales juntos
--Se ha hecho así porque no pueden tomarse signos vitales si no hay un reporte
--Y no puede haber un reporte que no tenga signos vitales
exec CrearReporte 'CMR0001','Fiebre alta, gripe y tos','Parece tener el mal del puerco','60.5','1.65','30.5','60/30'


--Receta--
exec CrearReceta 'RMR0001','2023-12-03'


--Medicinas pertenecen a una receta, asi se identifica cada receta, por su codigo
exec AgregarMedicamento 'EMR0001','Paracetamol','1 tableta cada 8 horas por 2 semanas'
exec AgregarMedicamento 'EMR0001','Acetaminofen','2 tableta cada 6 horas por 1 mes'
exec AgregarMedicamento 'EMR0001','Palagrip','2 tableta cada 12 horas por 3 dias'


--Aqui un ejemplo de como hacer consultas en toda la base, la base está pensada para ser fácil de relacionar
--Todo sigue una jerarquia, y todo dato puede ser obtenido de manera sencilla si lo píensas un poco
--En este caso quiero ver los medicamentos que se le han recetado a los pacientes, basta con un 'where' para poder filtrar entre los registros
select p.primerNombre as [Nombre], p.primerApellido as [Apellido], fechaEmitida as [Fecha de receta], nombreMedicamento as [Medicamento recetado], indicaciones as [Dosis], mm.primerNombre as [Medico], mm.especialidad as [Especialidad]
from pacientes p
inner join citasMedicas c
on p.codPaciente = c.codPaciente
inner join reportes r
on c.codCita = r.codCita
inner join recetas rr
on r.codReporte = rr.codReporte
inner join medicamentos m
on rr.codReceta = m.codReceta
inner join medicos mm
on mm.codMedico = c.codMedico

use Prueba_1

Select primerNombre+ ' ' + segundoNombre as Nombres, primerApellido + ' ' +segundoApellido as Apellidos
from pacientes

select * from pacientes
select * from medicos
select * from citasMedicas c
inner join pacientes p
on c.codPaciente = p.codPaciente
where p.primerNombre = 'Hazel'


exec IngresarCita 'PRD0003','MTD0002','2023-12-06 13:30:00'
exec IngresarCita 'PRD0003','MTD0002','2023-11-03 14:00:00'


delete from pacientes where codPaciente = 'Phh0006'
delete from medicos where primerNombre = ''

exec IngresarCita 'PRD0003','MLA0001','2023-11-13 13:30:00'

update medicos set especialidad = 'Ginecología' where especialidad = 'Ginecologia'