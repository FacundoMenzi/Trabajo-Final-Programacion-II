// hola

create database UTN_TECNICATURAS
use UTN_TECNICATURAS

create table Contactos(
id_contacto int identity(1,1),
email varchar(130),
telefono varchar(25)

constraint pk_contactos primary key (id_contacto)
)

create table Estados_Civiles(
id_est_civil int identity(1,1),
estado_civ varchar(60)

constraint pk_estados_civ primary key (id_est_civil)
)

create table Sit_Habitacionales(
id_habitacional int identity(1,1),
descripcion varchar(60)
constraint pk_sit_habitacional primary key (id_habitacional)
)

create table Sit_Laborales(
id_laboral int identity(1,1),
descripcion varchar(60)
constraint pk_sit_laboral primary key (id_laboral)
)

create table Barrios(
id_barrio int identity(1,1),
barrio varchar(70)
constraint pk_barrios primary key (id_barrio)
)

create table Personas(
id_persona int identity(1,1),
nombre varchar(100),
apellido varchar(100),
id_contacto int,
fecha_nac date,
id_est_civil int,
id_habitacional int,
id_barrio int

constraint pk_persona primary key (id_persona),
constraint fk_contactos foreign key (id_contacto) references Contactos (id_contacto),
constraint fk_est_civiles foreign key (id_est_civil) references Estados_Civiles (id_est_civil),
constraint fk_habitacionales foreign key (id_habitacional) references Sit_Habitacionales (id_habitacional),
constraint fk_barrios foreign key (id_barrio) references Barrios (id_barrio)
)

create table Profesores (
id_profesor int identity (1,1),
id_persona int
constraint pk_profesor primary key (id_profesor)
constraint fk_profesor_persona foreign key (id_persona) references Personas (id_persona)

)

create table Alumnos(
legajo int,
id_persona int,
id_laboral int
constraint pk_alumno primary key (legajo),
constraint fk_persona foreign key (id_persona) references Personas (id_persona),
constraint fk_sit_laboral foreign key (id_laboral) references Sit_laborales (id_laboral)
)

create table Turnos(
id_turno int identity(1,1),
turno varchar(50),
constraint pk_turno primary key (id_turno)
)

create table Estado_Materias(
id_Estado int identity(1,1),
estado varchar(60)
constraint pk_estadoMateria primary key (id_estado)
)


create table Materias(
id_materia int identity(1,1),
nombre varchar(80),
id_profesor int,
id_turno int
constraint pk_materia primary key (id_materia),
constraint fk_profesor foreign key (id_profesor) references Profesores (id_profesor),
constraint fk_turno foreign key (id_turno) references Turnos (id_turno)
)


create table Materias_Alumnos(
id_materia int,
legajo int,
id_estado int
constraint pk_matAlu primary key (id_materia,legajo),
constraint fk_estado foreign key (id_estado) references Estado_Materias (id_estado),
constraint fk_alumno foreign key (legajo) references Alumnos (legajo),
constraint fk_id_materia foreign key (id_materia) references Materias (id_materia)
)
create table Tecnicaturas(
id_Tecnicatura int identity(1,1),
nombre varchar(100),
titulo varchar(100)
constraint pk_tecnicatura primary key (id_tecnicatura)
)
create table Detalle_Tecnicaturas(
id_detalle_tec int identity(1,1),
id_tecnicatura int,
id_materia int,
cuatrimestre tinyint,
anio_cursado smallint

constraint pk_detalleTec primary key (id_detalle_Tec),
constraint fk_materia foreign key (id_materia) references Materias (id_materia),
constraint fk_tecnicatura foreign key (id_tecnicatura) references Tecnicaturas (id_tecnicatura)

)

create table Tecnicaturas_Alumnos(
id_tecnicatura int,
legajo int,
id_turno int
constraint pk_tecAlu primary key (id_tecnicatura,legajo),
constraint fk_tecAlu_turno foreign key (id_turno) references Turnos (id_turno),
constraint fk_tecAlu_alumno foreign key (legajo) references Alumnos (legajo),
constraint fk_tecAlu_idtec foreign key (id_tecnicatura) references Tecnicaturas (id_tecnicatura)
)

create table Tipos_Examenes(
id_tipo_examen tinyint identity(1,1),
tipo varchar(60),

constraint pk_tipo_Examen primary key (id_tipo_examen)
)

create table Examenes(
id_examen int identity(1,1),
descripcion varchar(110),
id_materia int,
id_profesor int,
fecha date,
id_tipo_examen tinyint
constraint pk_examen primary key (id_examen),
constraint fk_examen_materia foreign key (id_materia) references Materias (id_materia),
constraint fk_examen_profesor foreign key (id_profesor) references Profesores (id_profesor),
constraint fk_tipo_examen foreign key (id_tipo_examen) references Tipos_Examenes (id_tipo_examen)
)

create table Detalle_Examenes(
id_detalle int identity(1,1),
id_examen int,
legajo int,
nota int
constraint fk_detalle_Examen primary key (id_detalle),
constraint fk_examen foreign key (id_examen) references Examenes (id_examen),
constraint fk_detEx_legajo foreign key (legajo) references Alumnos (legajo)
)

--Tabla Contactos 
insert into Contactos values ('cande2@gmail.com', '3516367311')
insert into Contactos values ('tomi112@gmail.com', '3516345787')
insert into Contactos values ('tomas78@gmail.com', '3513589477')
insert into Contactos values ('facu@gmail.com', '3514695311')
insert into Contactos values ('kunda@gmail.com', '3518965744')
insert into Contactos values ('botta@gmail.com', '3517589644')
insert into Contactos values ('santoro@gmail.com', '3511245988')
insert into Contactos values ('Olmedo@gmail.com', '3512563587')
insert into Contactos values ('sergio@gmail.com', '3513696855')
insert into Contactos values ('walter@gmail.com', '3517896521')
insert into Contactos values ('estefanich74@gmail.com', '3518695744')
insert into Contactos values ('pedrojose@gmail.com', '3515464232')
insert into Contactos values ('catalina@gmail.com', '3516567867')
insert into Contactos values ('marissapo@gmail.com', '3517648976')
insert into Contactos values ('Pollioto@gmail.com', '3517659870')
insert into Contactos values ('Roger@gmail.com', '3516785436')
insert into Contactos values ('Arietti@gmail.com', '3517895678')
insert into Contactos values ('Florencia@gmail.com', '3515768987')
insert into Contactos values ('Freudenreich@gmail.com', '3513456787')

insert into Contactos values ('Gonzalez@gmail.com', '3514567680')
insert into Contactos values ('Juan@gmail.com', '3514657364')
insert into Contactos values ('carlos@gmail.com', '3517876567')
insert into Contactos values ('alberto@gmail.com', '35134526377')
insert into Contactos values ('lopez@gmail.com', '3518787878')
insert into Contactos values ('martinez@gmail.com', '35190987656')
insert into Contactos values ('sofia@gmail.com', '35176789098')
insert into Contactos values ('maria@gmail.com', '3513456546')
insert into Contactos values ('lucia@gmail.com', '3517678987')
insert into Contactos values ('martina@gmail.com', '3519890987')
insert into Contactos values ('catalina@gmail.com', '3511234256')
insert into Contactos values ('elena@gmail.com', '3516790562')


--Tabla Estados Civiles 
insert into Estados_Civiles values ('Casado/a')
insert into Estados_Civiles values ('Soltero/a')
insert into Estados_Civiles values ('Viudo/a')
insert into Estados_Civiles values ('Divorciado/a')

--Tabla Situacion Habitacional 
insert into Sit_Habitacionales values('Precariedad Grave')
insert into Sit_Habitacionales values('Precariedad Moderada')
insert into Sit_Habitacionales values('Sin Precariedad')

--Situacion Laboral
insert into Sit_Laborales values ('Desempleado')
insert into Sit_Laborales values ('Empleado')

--Tabla Barrios
insert into Barrios values ('Alto Alberdi')
insert into Barrios values ('Los Naranjos')
insert into Barrios values ('Parque Capital')
insert into Barrios values ('Cofico')
insert into Barrios values ('Bella Vista')
insert into Barrios values ('Paso de los Andes')
insert into Barrios values ('Obrero')
insert into Barrios values ('Smata')
insert into Barrios values ('Jardin Espinosa')
insert into Barrios values ('Las Palmas')
insert into Barrios values ('Manantiales')
set dateformat dmy
--Tabla Personas
insert into Personas values ('Candelaria', 'Mello',1,'04/08/2003',2, 3, 1)
insert into Personas values ('Tomas', 'Ortega',2,'17/12/2003',2, 3, 11)
insert into Personas values ('Beatriz', 'Kunda',5, '05/07/1975',1, 3, 9)
insert into Personas values ('Pedro José', 'Crespo',12, '05/07/1975',1, 3, 9)
insert into Personas values ('Oscar', 'Botta',6, '25/08/1977',1, 3, 4)
insert into Personas values ('Ezequiel', 'Santoro',7, '04/09/1984',2, 3, 3)
insert into Personas values ('Daniel', 'Olmedo',8, '15/11/1978',1, 3, 9)
insert into Personas values ('Clarissa', 'Stefanich',11, '24/03/1970',1, 3, 2)
insert into Personas values ('Walter', 'Pereyra',10, '11/05/1981',1, 3, 5)
insert into Personas values ('Catalina', 'Murature',13, '15/12/1989',1, 3, 7)
insert into Personas values ('Marisa', 'Possetto',14, '27/06/1973',1, 3, 5)
insert into Personas values ('Graciela', 'Freudenreich',19, '15/12/1989',3, 3, 7)
insert into Personas values ('Martin', 'Pollioto',15, '06/02/1986',2, 3, 1)
insert into Personas values ('Roger', 'Martinez',16, '13/07/1987',2, 3, 5)
insert into Personas values ('Adrian', 'Arietti',17, '06/08/1983',1, 3, 7)
insert into Personas values ('Molla', 'Florencia',18, '18/09/1988',1, 3, 9)

insert into Personas values ('González', 'Miguel ',20, '15/07/1999',2, 3, 5)
insert into Personas values ('Rodríguez ', 'Juan',21, '12/09/2003',2, 3, 7)
insert into Personas values ('Gómez', 'Carlos',22, '04/06/2001',2, 3, 3)
insert into Personas values ('Fernández', 'Alberto',23, '18/11/2003',1, 3, 2)
insert into Personas values ('López', 'José ',24, '06/06/2002',1, 3, 11)
insert into Personas values ('Martínez', 'Luis',25, '17/07/2002',2, 3, 8)
insert into Personas values ('Sánchez ', 'Sofía',26, '06/09/1999',2, 3, 9)
insert into Personas values ('Romero ', 'María',27, '18/10/2002',2, 3, 7)
insert into Personas values ('Sánchez ', 'Lucía',28, '06/12/2002',2, 3, 1)
insert into Personas values ('González  ', 'Martina',29, '19/08/2003',1, 3, 2)
insert into Personas values ('Recio ', 'Catalina',30, '06/09/2002',1, 3, 7)
insert into Personas values ('Giambo ', 'Elena',31, '18/02/1999',2, 1, 10)

--Tabla Profesores
insert into Profesores values (3)
insert into Profesores values (4)
insert into Profesores values (5)
insert into Profesores values (6)
insert into Profesores values (7)
insert into Profesores values (8)
insert into Profesores values (9)
insert into Profesores values (10)
insert into Profesores values (11)
insert into Profesores values (12)
insert into Profesores values (13)
insert into Profesores values (14)
insert into Profesores values (15)
insert into Profesores values (16)

--Tabla Alumnos
insert into Alumnos values ( 113905,1,2)
insert into Alumnos values ( 114120,2,2)

insert into Alumnos values ( 114123,17,2)
insert into Alumnos values ( 114124,18,1)
insert into Alumnos values ( 114125,19,1)
insert into Alumnos values ( 114126,20,2)
insert into Alumnos values ( 114127,21,1)
insert into Alumnos values ( 114128,22,1)
insert into Alumnos values ( 114118,23,2)
insert into Alumnos values ( 114129,24,2)
insert into Alumnos values ( 114111,25,1)
insert into Alumnos values ( 114112,26,1)
insert into Alumnos values ( 114113,27,1)
insert into Alumnos values ( 114114,28,1)

--Tabla Turnos
insert into Turnos values ('Mañana')
insert into Turnos values ('Tarde')
insert into Turnos values ('Noche')

--Tabla Materias TURNO TARDE
insert into Materias values ('Laboratorio en Computación I', 1, 2)
insert into Materias values ('Laboratorio en Computación II', 1, 2)
insert into Materias values ('Programacion II', 3, 2)
insert into Materias values ('Programacion I', 3, 2)
insert into Materias values ('Metodologia de la Investigacion', 7, 2)
insert into Materias values ('Estadistica', 6, 2)
insert into Materias values ('Matematica', 6, 2)
insert into Materias values ('Ingles I', 8, 2)
insert into Materias values ('Ingles II', 8, 2)
insert into Materias values ('Arquitectura de Sistemas Operativos', 5, 2)
insert into Materias values ('Sistema de Procesamiento de Datos', 5, 2)

--TURNO NOCHE
insert into Materias values ('Laboratorio en Computación I', 2, 3)
insert into Materias values ('Laboratorio en Computación II', 4, 3)
insert into Materias values ('Programacion II', 12, 3)
insert into Materias values ('Programacion I', 13, 3)
insert into Materias values ('Metodologia de la Investigacion', 7, 3)
insert into Materias values ('Estadistica', 9, 3)
insert into Materias values ('Matematica', 9, 3)
insert into Materias values ('Ingles I', 14, 3)
insert into Materias values ('Ingles II', 14, 3)
insert into Materias values ('Arquitectura de Sistemas Operativos', 5, 3)
insert into Materias values ('Sistema de Procesamiento de Datos', 5, 3)

--Tabla Estado Materias
insert into Estado_Materias values ('Promocionado')
insert into Estado_Materias values ('Regular')
insert into Estado_Materias values ('Libre')
insert into Estado_Materias values ('Aprobado')

--Tabla Materias_Alumnos
insert into Materias_Alumnos values (1,113905,1)
insert into Materias_Alumnos values (2,113905,1)
insert into Materias_Alumnos values (4,113905,2)
insert into Materias_Alumnos values (3,113905,4)
insert into Materias_Alumnos values (5,113905,1)
insert into Materias_Alumnos values (6,113905,1)
insert into Materias_Alumnos values (7,113905,1)
insert into Materias_Alumnos values (8,113905,1)
insert into Materias_Alumnos values (9,113905,4)
insert into Materias_Alumnos values (10,113905,1)
insert into Materias_Alumnos values (11,113905,1)

insert into Materias_Alumnos values (1,114120,2)
insert into Materias_Alumnos values (2,114120,1)
insert into Materias_Alumnos values (4,114120,3)
insert into Materias_Alumnos values (3,114120,4)
insert into Materias_Alumnos values (5,114120,1)
insert into Materias_Alumnos values (6,114120,2)
insert into Materias_Alumnos values (7,114120,2)
insert into Materias_Alumnos values (8,114120,1)
insert into Materias_Alumnos values (9,114120,4)
insert into Materias_Alumnos values (10,114120,4)
insert into Materias_Alumnos values (11,114120,4)

insert into Materias_Alumnos values (1,114129,2)
insert into Materias_Alumnos values (2,114129,3)
insert into Materias_Alumnos values (4,114129,3)
insert into Materias_Alumnos values (3,114129,4)
insert into Materias_Alumnos values (5,114129,3)
insert into Materias_Alumnos values (6,114129,3)
insert into Materias_Alumnos values (7,114129,2)
insert into Materias_Alumnos values (8,114129,1)
insert into Materias_Alumnos values (9,114129,3)
insert into Materias_Alumnos values (10,114129,3)
insert into Materias_Alumnos values (11,114129,3)


--Tabla Tecnicaturas
insert into Tecnicaturas values ('Programación', 'Técnico Universitario en Programación')
insert into Tecnicaturas values ('Industrias Alimentarias', 'Tecnico Universitario en Industrias Alimentarias')
insert into Tecnicaturas values ('Mecatrónica', 'Tecnico Universitario en Mecatrónica')
insert into Tecnicaturas values ('Mantenimiento Industrial', 'Tecnico Universitario en Mantenimiento Industrial')
insert into Tecnicaturas values ('Telecomunicaciones', 'Tecnico Universitario en Telecomunicaciones')


--Tabla Detalle_Tecnicatura
insert into Detalle_Tecnicaturas values (1, 1, 1, 1)
insert into Detalle_Tecnicaturas values (1, 2, 2, 1)
insert into Detalle_Tecnicaturas values (1, 3, 2, 1)
insert into Detalle_Tecnicaturas values (1, 4, 1, 1)
insert into Detalle_Tecnicaturas values (1, 5, 2, 1)
insert into Detalle_Tecnicaturas values (1, 6, 2, 1)
insert into Detalle_Tecnicaturas values (1, 7, 1, 1)
insert into Detalle_Tecnicaturas values (1, 8, 1, 1)
insert into Detalle_Tecnicaturas values (1, 9, 2, 1)
insert into Detalle_Tecnicaturas values (1, 10, 2, 1)
Insert into Detalle_Tecnicaturas values (1, 11, 1, 1)

insert into Detalle_Tecnicaturas values (1, 12, 1, 1)
insert into Detalle_Tecnicaturas values (1, 13, 2, 1)
insert into Detalle_Tecnicaturas values (1, 14, 2, 1)
insert into Detalle_Tecnicaturas values (1, 15, 1, 1)
insert into Detalle_Tecnicaturas values (1, 16, 2, 1)
insert into Detalle_Tecnicaturas values (1, 17, 2, 1)
insert into Detalle_Tecnicaturas values (1, 18, 1, 1)
insert into Detalle_Tecnicaturas values (1, 19, 1, 1)
insert into Detalle_Tecnicaturas values (1, 20, 2, 1)
insert into Detalle_Tecnicaturas values (1, 21, 2, 1)
Insert into Detalle_Tecnicaturas values (1, 22, 1, 1)


--Tabla Tipos Examenes
insert into Tipos_Examenes values ('Parcial')
insert into Tipos_Examenes values ('Final')
insert into Tipos_Examenes values ('Recuperatorio')

select * from Examenes e join Detalle_Examenes de on de.id_examen=e.id_examen
--Tabla Examenes 
--lab
insert into Examenes values ('Unidad 1 y 2', 1, 1, '06/04/2022', 1) 
insert into Examenes values ('Unidad 3 y 4', 1, 1, '16/06/2022', 1) 
insert into Examenes values ('Integrador', 1, 1, '20/07/2022', 2) 
insert into Examenes values ('Recuperatorio Integrador',1,1,'16/07/2022',3)

insert into Examenes values ('Unidad 1 y 2', 2, 1, '22/09/2022', 1) 
insert into Examenes values ('Unidad 3 y 4', 2, 1, '27/10/2022', 1) 
insert into Examenes values ('Integrador', 2, 1, '24/11/2022', 2)
insert into Examenes values ('Recuperatorio Integrador',2,1,'19/11/2022',3)

--prog
insert into Examenes values ('Unidad 1 y 2', 4, 3, '08/04/2022', 1) 
insert into Examenes values ('Unidad 3 y 4', 4, 3, '20/06/2022', 1) 
insert into Examenes values ('Integrador', 4, 3, '24/07/2022', 2) 

insert into Examenes values ('Unidad 1 y 2', 3, 11, '01/10/2022', 1) 
insert into Examenes values ('Unidad 3 y 4', 3, 11, '29/10/2022', 1) 
insert into Examenes values ('Integrador', 3, 11, '20/11/2022', 2) 

--metodologia
insert into Examenes values ('Unidad 1 y 2', 5, 7, '08/04/2022', 1) 
insert into Examenes values ('Unidad 3 y 4', 5, 7, '20/06/2022', 1) 
insert into Examenes values ('Integrador', 5, 7, '24/07/2022', 2) 

--estadistica
insert into Examenes values ('Unidad 1 y 2', 6, 6, '01/10/2022', 1) 
insert into Examenes values ('Unidad 3 y 4', 6, 6, '29/10/2022', 1) 
insert into Examenes values ('Integrador', 6, 6, '20/11/2022', 2)
--mat
insert into Examenes values ('Unidad 1 y 2', 7, 6, '01/10/2022', 1) 
insert into Examenes values ('Unidad 3 y 4', 7, 6, '29/10/2022', 1) 
insert into Examenes values ('Integrador', 7, 6, '20/11/2022', 2)
--ingles 1
insert into Examenes values ('Unidad 1 y 2', 8, 8, '01/10/2022', 1) 
insert into Examenes values ('Unidad 3 y 4', 8, 8, '29/10/2022', 1) 
insert into Examenes values ('Integrador', 8, 8, '20/11/2022', 2)
--ingles 2
insert into Examenes values ('Unidad 1 y 2', 9, 8, '01/10/2022', 1) 
insert into Examenes values ('Unidad 3 y 4', 9, 8, '29/10/2022', 1) 
insert into Examenes values ('Integrador', 9, 8, '20/11/2022', 2)
--aso
insert into Examenes values ('Unidad 1 y 2', 10, 5, '01/10/2022', 1) 
insert into Examenes values ('Unidad 3 y 4', 10, 5, '29/10/2022', 1) 
insert into Examenes values ('Integrador', 10, 5, '20/11/2022', 2)
--spd
insert into Examenes values ('Unidad 1 y 2', 11, 5, '01/10/2022', 1) 
insert into Examenes values ('Unidad 3 y 4', 11, 5, '29/10/2022', 1) 
insert into Examenes values ('Integrador', 11, 5, '20/11/2022', 2)

--Tabla Detalle_Examenes
--lab 1
insert into Detalle_Examenes values(1,113905, 9)
insert into Detalle_Examenes values(2,113905, 8)

insert into Detalle_Examenes values(1,114120, 7)
insert into Detalle_Examenes values(2,114120, 6)
insert into Detalle_Examenes values(3,114120, 7)


insert into Detalle_Examenes values(1,114123, 10)
insert into Detalle_Examenes values(2,114123, 9)

insert into Detalle_Examenes values(1,114124, 6)
insert into Detalle_Examenes values(2,114124, 2)
insert into Detalle_Examenes values(3,114124, 6)
insert into Detalle_Examenes values(4,114124, 8)
--prog 1
insert into Detalle_Examenes values(9,113905, 9)
insert into Detalle_Examenes values(10,113905, 8)

insert into Detalle_Examenes values(9,114120, 7)
insert into Detalle_Examenes values(10,114120, 6)
insert into Detalle_Examenes values(11,114120, 7)


insert into Detalle_Examenes values(9,114123, 10)
insert into Detalle_Examenes values(10,114123, 9)

insert into Detalle_Examenes values(9,114124, 6)
insert into Detalle_Examenes values(10,114124, 2)

--lab 2
insert into Detalle_Examenes values(5,113905, 8)
insert into Detalle_Examenes values(6,113905, 8)

insert into Detalle_Examenes values(5,114120, 6)
insert into Detalle_Examenes values(6,114120, 6)
insert into Detalle_Examenes values(7,114120, 8)


insert into Detalle_Examenes values(5,114123, 8)
insert into Detalle_Examenes values(6,114123, 8)

insert into Detalle_Examenes values(5,114124, 2)
insert into Detalle_Examenes values(6,114124, 2)
insert into Detalle_Examenes values(7,114124, 6)
insert into Detalle_Examenes values(8,114124, 6)



--CONSULTAS:
--Mostrar en una misma tabla, la cantidad de regulares y libres, por materia, curso, carrera, año de cursado
--X
select count(distinct legajo) 'Cantidad','Regular' Estado,m.nombre 'Materia',t.turno 'Turno',
tec.nombre 'Tecnicatura',year(e.fecha) 'Año cursado'
from Materias_Alumnos ma join Materias m on m.id_materia=ma.id_materia
	 join turnos t on m.id_turno=t.id_turno
	 join detalle_Tecnicaturas dt on dt.id_materia=m.id_materia
	 join Tecnicaturas tec on tec.id_Tecnicatura=dt.id_tecnicatura
	 join examenes e on e.id_materia=m.id_materia
where ma.id_estado=2
group by m.nombre,t.turno,tec.nombre,year(e.fecha)

UNION
select count(distinct legajo),'Libre',m.nombre,t.turno,tec.nombre ,year(e.fecha) 
from Materias_Alumnos ma join Materias m on m.id_materia=ma.id_materia
	 join turnos t on m.id_turno=t.id_turno
	 join detalle_Tecnicaturas dt on dt.id_materia=m.id_materia
	 join Tecnicaturas tec on tec.id_Tecnicatura=dt.id_tecnicatura
	 join examenes e on e.id_materia=m.id_materia
where ma.id_estado=3
group by m.nombre,t.turno,tec.nombre,year(e.fecha)

order by estado asc


--Promedio de notas por alumno, materia, año, turno
--X
select avg(de.nota) 'Promedio de Notas', de.legajo 'Legajo Alumno',m.nombre 'Materia',year(e.fecha) 'Año',t.turno 'Turno'
from Detalle_Examenes de join examenes e on e.id_examen=de.id_examen
	 join materias m on e.id_materia=m.id_materia
	 join turnos t on m.id_turno=t.id_turno

group by de.legajo,m.nombre,year(e.fecha),t.turno

--Listar los examenes parciales de este año cuya nota superó el promedio general de notas de parciales del año pasado
--X

select e.id_examen 'ID Examen',de.nota 'Nota',de.legajo 'Legajo del alumno'
from Examenes e join Detalle_Examenes de on de.id_examen=e.id_examen
where e.id_tipo_examen=1 and year(e.fecha)=year(getdate())
and de.nota > (select avg(de2.nota)
			   from Detalle_Examenes de2 join examenes e2 on e2.id_examen=de2.id_examen
			   where datediff(year,e2.fecha,getdate())=1
			   and e2.id_tipo_examen=1
			   )



--Mostrar cual fue el promedio de notas por alumno en este año,cual fue su nota mas baja y cual la mas alta
--Siempre y cuando el promedio sea mayor al promedio del año pasado
--X
select legajo 'Legajo',avg(nota) 'Promedio de notas', year(fecha)Año,min(nota) 'Nota mas baja',max(nota) 'Nota mas alta'
from Detalle_Examenes de join Examenes e on e.id_examen=de.id_examen
group by legajo, year(fecha)
having avg(nota) > (select avg(nota) from Detalle_Examenes 
                    where year(fecha)=year(getdate())-1 
					)
order by Año,legajo

--Mostrar la cantidad de examenes tomados por cada profesor, para los casos en que 
--el nombre del profesor no comience con B ni con E, y que las notas de dichos examenes oscilen entre 5 y 8,
--siempre y cuando la cantidad de examenes tomados por el profesor supere el promedio general de los tomados el año
--anterior
--X
select count(e.id_examen) 'Cant. Examenes', pe.nombre+', '+upper(pe.apellido) 'Profesor'
from Examenes e join Detalle_Examenes de on e.id_examen=de.id_examen
	 join profesores p on p.id_profesor=e.id_profesor
	 join personas pe on pe.id_persona=p.id_persona
where pe.nombre not like '[B,E]%' 
and de.nota between 5 and 8
group by pe.nombre+', '+upper(pe.apellido)
having count(e.id_examen) > (select avg(e2.id_examen)
							 from Examenes e2
							 where datediff(year,e2.fecha,getdate())=1
							 )

--Mostrar en una misma tabla de consultas los alumnos que no rindieron ningun final este año 
--y los que rindieron mas de 2 finales este año ordenados en forma alfabetica por apellido del alumno
--X
select distinct a.legajo 'Legajo' , p.apellido 'Apellido' , 'No Rindieron' Tipo 
from examenes e join Detalle_Examenes de on de.id_examen=e.id_examen
    right join Alumnos a on de.legajo= a.legajo
    left join Personas p on p.id_persona=a.id_persona

where a.legajo not in (select legajo
					   from Detalle_Examenes de2 join Examenes e2 on e2.id_examen=de2.id_examen
					   where e2.id_tipo_examen =2 and
					   datediff(year,e2.fecha,getdate())=0)
UNION
select a.legajo, p.apellido,'Rindieron mas de 2 veces' 
from examenes e join Detalle_Examenes de on de.id_examen=e.id_examen
    join Alumnos a on de.legajo= a.legajo
    join Personas p on p.id_persona=a.id_persona
where e.id_tipo_examen =2 and year(fecha)=year(getdate())
group by p.apellido , a.legajo
having count (e.id_examen)>2

order by tipo, p.apellido asc


--Mostrar el promedio de notas, cantidad de examenes parciales rendidos de cada
--alumno, siempre y cuando el alumno tenga entre 18 y 22 años 
--y el promedio general de notas del alumno sea superior al promedio general del año pasado
--X
select a.legajo 'Legajo',datediff(year,p.fecha_nac,getdate())'Edad' ,
avg(de.nota) 'Nota promedio',count(e.id_examen) 'Cantidad de parciales rendidos'

from Examenes e join Detalle_Examenes de on e.id_examen=de.id_examen
	 join Alumnos a on a.legajo=de.legajo
	 join Personas p on p.id_persona=a.id_persona
where e.id_tipo_examen=1 and datediff(year,p.fecha_nac,getdate()) between 18 and 22

group by a.legajo,datediff(year,p.fecha_nac,getdate())
having avg(nota) > (select avg(de2.nota)
					from Detalle_Examenes de2 join Examenes e2 on e2.id_examen=de2.id_examen
					where datediff(year,fecha,getdate())=1
					)

--Alumnos que no han cursado materias este año. 
select legajo 'Legajo', p.apellido + ', '+p.nombre 'Alumno'
from Alumnos a join Personas p on p.id_persona=a.id_persona
where legajo not in (select distinct legajo 
                     from Materias_Alumnos ma join materias m on m.id_materia=ma.id_materia
					                          join Examenes e on e.id_materia=m.id_materia
					 where year(fecha)=year(getdate()))

--Listar los profesores que no han tomado examenes este año
select pr.id_profesor 'ID', p.apellido + ', '+p.nombre 'Profesor'
from Profesores pr join Personas p on p.id_persona=pr.id_persona
where pr.id_profesor not in (select distinct e.id_profesor 
							 from Examenes e 
							 where year(fecha)=year(getdate()))
order by 'Profesor'

--Listar promedio de notas por materia del primer cuatrimestre, de alumnos cuyo nombre comience con C 
--y el promedio de las notas sea mayor a 6
select p.nombre+ ', '+p.apellido 'Alumno',avg(nota) 'Promedio', m.nombre 'Materia'
from Detalle_Examenes de join Examenes e on e.id_examen=de.id_examen
                         join Alumnos a on a.legajo=de.legajo
                         join Personas p on p.id_persona=a.id_persona
                         join Materias m on e.id_materia=m.id_materia
                         join Detalle_Tecnicaturas dt on dt.id_materia=m.id_materia
where cuatrimestre=1 and p.nombre like 'C%'
group by m.nombre, p.nombre+ ', '+p.apellido
having 6 < avg(nota)
order by 'Alumno'

--Emitir un listado de los alumnos incluyendo el nombre del barrio, mail de contacto,situacion habitacional 
-- y estado civil, de los cuales se sacaron alguna vez una nota mayor a 8 en lo que va del año

select a.legajo 'Legajo', nombre+', '+apellido 'Alumno', 
barrio 'Barrio', email 'E-mail', sh.descripcion 'Situacion Habitacional', estado_civ 'Estado Civil'
from Alumnos a join Personas p on p.id_persona=a.id_persona
               join Barrios b on b.id_barrio=p.id_barrio
			   join Contactos c on c.id_contacto=p.id_contacto
			   join Sit_Habitacionales sh on sh.id_habitacional=p.id_habitacional
			   join Estados_Civiles ec on ec.id_est_civil=p.id_est_civil
where 8 < any (select nota
			   from Detalle_Examenes de2 join Examenes e2 on e2.id_examen=de2.id_examen
			   where year(fecha)=year(getdate()) and a.legajo=de2.legajo)

group by a.legajo, nombre, apellido, barrio, email,sh.descripcion , estado_civ
order by 'Legajo'
